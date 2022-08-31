using System.Web;
using Microsoft.Web.WebView2.Core;

namespace casdoor_dotnet_winform_example
{

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            //Loaded += Login_Loaded;
        }

        public event EventHandler<CodeReceivedEventArgs>? CodeReceived;

        private void LoginForm_Load(object sender, EventArgs e)
        {
            LoginWebView.CoreWebView2InitializationCompleted += WebView_CoreWebView2InitializationCompleted;

            var loginUrl = GetLoginUrl();
            LoginWebView.Source = new Uri(loginUrl);
        }

        private void LoginWebView_Load(object sender, EventArgs e)
        {
            LoginWebView.CoreWebView2InitializationCompleted += WebView_CoreWebView2InitializationCompleted;

            var loginUrl = GetLoginUrl();
            LoginWebView.Source = new Uri(loginUrl);
        }

        private void CoreWebView2_NewWindowRequested(object? sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            string GetCodeFromUrl(string url)
                => HttpUtility.ParseQueryString(new Uri(url).Query).Get("code")!;

            var deferral = e.GetDeferral();
            string? code = null;

            if (e.Uri.StartsWith("casdoor://", StringComparison.OrdinalIgnoreCase))
            {
                code = GetCodeFromUrl(e.Uri);
                CodeReceived?.Invoke(this, new CodeReceivedEventArgs(code));
            }

            deferral.Complete();
            e.Handled = true;

            if (code != null)
                Close();
        }

        private void WebView_CoreWebView2InitializationCompleted(object? sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            LoginWebView.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
        }

        private string GetLoginUrl()
            => $"{CasdoorVariables.Domain}/login/oauth/authorize?client_id={CasdoorVariables.ClientId}&response_type=code&redirect_uri={CasdoorVariables.CallbackUrl}&scope=profile&state={CasdoorVariables.AppName}&noRedirect=true";

    }

    public class CodeReceivedEventArgs : EventArgs
    {
        public CodeReceivedEventArgs(string code) => Code = code;

        public string Code { get; }
    }
}
