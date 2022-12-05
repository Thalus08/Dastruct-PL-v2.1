
namespace Project1
{
    partial class LoginTab
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
            this.components = new System.ComponentModel.Container();
            this.TxtBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TxtBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonExit = new Guna.UI2.WinForms.Guna2Button();
            this.LinkLabelGuest = new System.Windows.Forms.LinkLabel();
            this.ButtonLogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // TxtBoxUsername
            // 
            this.TxtBoxUsername.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtBoxUsername.BorderColor = System.Drawing.Color.Black;
            this.TxtBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBoxUsername.DefaultText = "";
            this.TxtBoxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBoxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBoxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBoxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBoxUsername.FillColor = System.Drawing.Color.Black;
            this.TxtBoxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBoxUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBoxUsername.ForeColor = System.Drawing.Color.White;
            this.TxtBoxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBoxUsername.Location = new System.Drawing.Point(98, 133);
            this.TxtBoxUsername.Name = "TxtBoxUsername";
            this.TxtBoxUsername.PasswordChar = '\0';
            this.TxtBoxUsername.PlaceholderText = "Enter Username";
            this.TxtBoxUsername.SelectedText = "";
            this.TxtBoxUsername.Size = new System.Drawing.Size(200, 36);
            this.TxtBoxUsername.TabIndex = 0;
            this.TxtBoxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBoxUsername_KeyDown);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this.TxtBoxUsername;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 12;
            this.guna2Elipse2.TargetControl = this.TxtBoxPassword;
            // 
            // TxtBoxPassword
            // 
            this.TxtBoxPassword.BorderColor = System.Drawing.Color.Black;
            this.TxtBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBoxPassword.DefaultText = "";
            this.TxtBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBoxPassword.FillColor = System.Drawing.Color.Black;
            this.TxtBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBoxPassword.ForeColor = System.Drawing.Color.White;
            this.TxtBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBoxPassword.Location = new System.Drawing.Point(98, 195);
            this.TxtBoxPassword.Name = "TxtBoxPassword";
            this.TxtBoxPassword.PasswordChar = '*';
            this.TxtBoxPassword.PlaceholderText = "Enter Password";
            this.TxtBoxPassword.SelectedText = "";
            this.TxtBoxPassword.Size = new System.Drawing.Size(200, 36);
            this.TxtBoxPassword.TabIndex = 1;
            this.TxtBoxPassword.TextChanged += new System.EventHandler(this.TxtBoxPassword_TextChanged);
            this.TxtBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBoxPassword_KeyDown);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.Transparent;
            this.ButtonExit.BorderRadius = 5;
            this.ButtonExit.CheckedState.FillColor = System.Drawing.Color.White;
            this.ButtonExit.FillColor = System.Drawing.Color.Black;
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonExit.ForeColor = System.Drawing.Color.Gray;
            this.ButtonExit.Location = new System.Drawing.Point(360, 12);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.PressedColor = System.Drawing.Color.White;
            this.ButtonExit.Size = new System.Drawing.Size(28, 30);
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.Text = "X";
            this.ButtonExit.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // LinkLabelGuest
            // 
            this.LinkLabelGuest.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(55)))), ((int)(((byte)(107)))));
            this.LinkLabelGuest.AutoSize = true;
            this.LinkLabelGuest.BackColor = System.Drawing.Color.Transparent;
            this.LinkLabelGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelGuest.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.LinkLabelGuest.Location = new System.Drawing.Point(140, 556);
            this.LinkLabelGuest.Name = "LinkLabelGuest";
            this.LinkLabelGuest.Size = new System.Drawing.Size(123, 18);
            this.LinkLabelGuest.TabIndex = 3;
            this.LinkLabelGuest.TabStop = true;
            this.LinkLabelGuest.Text = "Login As Guest";
            this.LinkLabelGuest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelGuest_LinkClicked);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLogin.BorderRadius = 5;
            this.ButtonLogin.CheckedState.BorderColor = System.Drawing.Color.White;
            this.ButtonLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.ButtonLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.Location = new System.Drawing.Point(108, 486);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(180, 45);
            this.ButtonLogin.TabIndex = 4;
            this.ButtonLogin.Text = "Login League";
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 12;
            this.guna2Elipse3.TargetControl = this;
            // 
            // LoginTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project1.Properties.Resources.Untitled_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 615);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.LinkLabelGuest);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.TxtBoxPassword);
            this.Controls.Add(this.TxtBoxUsername);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginTab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginTab_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox TxtBoxUsername;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2TextBox TxtBoxPassword;
        private Guna.UI2.WinForms.Guna2Button ButtonExit;
        private System.Windows.Forms.LinkLabel LinkLabelGuest;
        private Guna.UI2.WinForms.Guna2Button ButtonLogin;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
    }
}

