using Microsoft.Web.WebView2.Core;

namespace casdoor_dotnet_winform_example
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.LoginWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.LoginView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginWebView)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginView
            // 
            this.LoginView.AllowExternalDrop = true;
            this.LoginView.CreationProperties = null;
            this.LoginView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.LoginView.Location = new System.Drawing.Point(2, 3);
            this.LoginView.Name = "LoginView";
            this.LoginView.Size = new System.Drawing.Size(408, 534);
            this.LoginView.TabIndex = 0;
            this.LoginView.ZoomFactor = 1D;
            // 
            // LoginWebView
            // 
            this.LoginWebView.AllowExternalDrop = true;
            this.LoginWebView.CreationProperties = null;
            this.LoginWebView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.LoginWebView.Location = new System.Drawing.Point(1, 3);
            this.LoginWebView.Name = "LoginWebView";
            this.LoginWebView.Size = new System.Drawing.Size(458, 845);
            this.LoginWebView.TabIndex = 0;
            this.LoginWebView.ZoomFactor = 1D;
            this.LoginWebView.CoreWebView2InitializationCompleted += new System.EventHandler<CoreWebView2InitializationCompletedEventArgs>(this.LoginWebView_Load);
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(460, 850);
            this.Controls.Add(this.LoginWebView);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginWebView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 LoginView;
        private Microsoft.Web.WebView2.WinForms.WebView2 LoginWebView;
    }
}