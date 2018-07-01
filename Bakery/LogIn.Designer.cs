namespace Bakery
{
    partial class LogIn
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtNLogin = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnClose.Location = new System.Drawing.Point(23, 247);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(227, 48);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Выйти";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogIn.Location = new System.Drawing.Point(23, 193);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(227, 48);
            this.btnLogIn.TabIndex = 16;
            this.btnLogIn.Text = "Войти";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtNLogin
            // 
            // 
            // 
            // 
            this.txtNLogin.CustomButton.Image = null;
            this.txtNLogin.CustomButton.Location = new System.Drawing.Point(199, 2);
            this.txtNLogin.CustomButton.Name = "";
            this.txtNLogin.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtNLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNLogin.CustomButton.TabIndex = 1;
            this.txtNLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNLogin.CustomButton.UseSelectable = true;
            this.txtNLogin.CustomButton.Visible = false;
            this.txtNLogin.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNLogin.Lines = new string[0];
            this.txtNLogin.Location = new System.Drawing.Point(23, 98);
            this.txtNLogin.MaxLength = 32767;
            this.txtNLogin.Name = "txtNLogin";
            this.txtNLogin.PasswordChar = '\0';
            this.txtNLogin.PromptText = "Логин";
            this.txtNLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNLogin.SelectedText = "";
            this.txtNLogin.SelectionLength = 0;
            this.txtNLogin.SelectionStart = 0;
            this.txtNLogin.ShortcutsEnabled = true;
            this.txtNLogin.Size = new System.Drawing.Size(227, 30);
            this.txtNLogin.TabIndex = 18;
            this.txtNLogin.UseSelectable = true;
            this.txtNLogin.WaterMark = "Логин";
            this.txtNLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(199, 2);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(23, 134);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "Пароль";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(227, 30);
            this.txtPassword.TabIndex = 19;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Пароль";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 318);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNLogin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogIn);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogIn";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Войдите в систему";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLogIn;
        private MetroFramework.Controls.MetroTextBox txtNLogin;
        private MetroFramework.Controls.MetroTextBox txtPassword;
    }
}