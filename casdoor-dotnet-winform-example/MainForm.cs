using System;
using System.Windows.Forms;

namespace casdoor_dotnet_winform_example
{
    public partial class MainForm : Form
    {
        private readonly CasdoorApi _casdoorApi;
        private string? _authCode;

        public MainForm()
        {
            InitializeComponent();

            _casdoorApi = new CasdoorApi(CasdoorVariables.Domain);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var login = new LoginForm();
            login.CodeReceived += Login_CodeReceived;

            login.ShowDialog();
        }

        private async void Login_CodeReceived(object? sender, CodeReceivedEventArgs e)
        {
            _authCode = e.Code;

            userProfilePanel.Visible = true;
            loginPanel.Visible = false;
            username.Text = "Loading...";

            var token = await _casdoorApi.RequestToken(
                CasdoorVariables.ClientId,
                CasdoorVariables.ClientSecret,
                _authCode
            );

            // Assume request token and get user process is in happy path..
            var user = await _casdoorApi.GetUserInfo(token!);
            username.Text = $"Username: {user!.Name}";
            username.Location = new System.Drawing.Point((userProfilePanel.Width - username.Size.Width) / 2, 39);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            _authCode = null;
            username.Text = "No User";

            userProfilePanel.Visible = false;
            loginPanel.Visible = true;
        }
    }
}