using System.Windows.Forms;

namespace casdoor_dotnet_winform_example
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.userProfilePanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            this.userProfilePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(29, 49);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(197, 29);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Casdoor Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.loginBtn);
            this.loginPanel.Location = new System.Drawing.Point(173, 87);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(250, 128);
            this.loginPanel.TabIndex = 1;
            // 
            // userProfilePanel
            // 
            this.userProfilePanel.Controls.Add(this.logoutBtn);
            this.userProfilePanel.Controls.Add(this.username);
            this.userProfilePanel.Location = new System.Drawing.Point(173, 88);
            this.userProfilePanel.Name = "userProfilePanel";
            this.userProfilePanel.Size = new System.Drawing.Size(250, 125);
            this.userProfilePanel.Visible = false;
            this.userProfilePanel.TabIndex = 2;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(74, 77);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(94, 29);
            this.logoutBtn.TabIndex = 1;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(74, 39);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(1, 20);
            this.username.TabIndex = 0;
            this.username.Text = "No User";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.userProfilePanel);
            this.Controls.Add(this.loginPanel);
            this.Name = "MainForm";
            this.Text = "Main";
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.loginPanel.ResumeLayout(false);
            this.userProfilePanel.ResumeLayout(false);
            this.userProfilePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button loginBtn;
        private Panel loginPanel;
        private Panel userProfilePanel;
        private Label username;
        private Button logoutBtn;
    }
}