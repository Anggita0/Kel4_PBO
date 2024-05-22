namespace Kel4_PBO.View
{
    partial class Login
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
            panelLogin = new Panel();
            panelLoginSelamatDatang = new Panel();
            showPassword = new CheckBox();
            buttonLogin = new Button();
            textBoxUsername = new TextBox();
            labelUsername = new Label();
            iconUsername = new FontAwesome.Sharp.IconPictureBox();
            labelPassword = new Label();
            iconPassword = new FontAwesome.Sharp.IconPictureBox();
            textBoxPassword = new TextBox();
            buttonhidepwd = new Button();
            panelSelamatDatang = new Panel();
            labelSelamatDatang = new Label();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            panelLogin.SuspendLayout();
            panelLoginSelamatDatang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPassword).BeginInit();
            panelSelamatDatang.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(35, 35, 35);
            panelLogin.Controls.Add(panelLoginSelamatDatang);
            panelLogin.Controls.Add(panelSelamatDatang);
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(0, 0);
            panelLogin.Margin = new Padding(4, 5, 4, 5);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(1440, 1050);
            panelLogin.TabIndex = 0;
            // 
            // panelLoginSelamatDatang
            // 
            panelLoginSelamatDatang.Controls.Add(showPassword);
            panelLoginSelamatDatang.Controls.Add(buttonLogin);
            panelLoginSelamatDatang.Controls.Add(textBoxUsername);
            panelLoginSelamatDatang.Controls.Add(labelUsername);
            panelLoginSelamatDatang.Controls.Add(iconUsername);
            panelLoginSelamatDatang.Controls.Add(labelPassword);
            panelLoginSelamatDatang.Controls.Add(iconPassword);
            panelLoginSelamatDatang.Controls.Add(textBoxPassword);
            panelLoginSelamatDatang.Controls.Add(buttonhidepwd);
            panelLoginSelamatDatang.Dock = DockStyle.Top;
            panelLoginSelamatDatang.Location = new Point(0, 500);
            panelLoginSelamatDatang.Margin = new Padding(4, 5, 4, 5);
            panelLoginSelamatDatang.Name = "panelLoginSelamatDatang";
            panelLoginSelamatDatang.Size = new Size(1440, 715);
            panelLoginSelamatDatang.TabIndex = 1;
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showPassword.ForeColor = Color.White;
            showPassword.Location = new Point(617, 320);
            showPassword.Margin = new Padding(4, 5, 4, 5);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(207, 36);
            showPassword.TabIndex = 10;
            showPassword.Text = "Show Password";
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += showPassword_CheckedChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.FlatAppearance.BorderColor = Color.FromArgb(255, 102, 36);
            buttonLogin.FlatAppearance.BorderSize = 3;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.FromArgb(255, 102, 36);
            buttonLogin.Location = new Point(507, 400);
            buttonLogin.Margin = new Padding(4, 5, 4, 5);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(421, 133);
            buttonLogin.TabIndex = 9;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxUsername.Location = new Point(617, 95);
            textBoxUsername.Margin = new Padding(4, 5, 4, 5);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(613, 55);
            textBoxUsername.TabIndex = 8;
            // 
            // labelUsername
            // 
            labelUsername.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(291, 77);
            labelUsername.Margin = new Padding(4, 0, 4, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(304, 100);
            labelUsername.TabIndex = 7;
            labelUsername.Text = "Username";
            labelUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iconUsername
            // 
            iconUsername.BackColor = Color.FromArgb(35, 35, 35);
            iconUsername.ForeColor = Color.FromArgb(255, 102, 36);
            iconUsername.IconChar = FontAwesome.Sharp.IconChar.Person;
            iconUsername.IconColor = Color.FromArgb(255, 102, 36);
            iconUsername.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconUsername.IconSize = 86;
            iconUsername.Location = new Point(213, 77);
            iconUsername.Margin = new Padding(4, 5, 4, 5);
            iconUsername.Name = "iconUsername";
            iconUsername.Size = new Size(86, 100);
            iconUsername.TabIndex = 6;
            iconUsername.TabStop = false;
            // 
            // labelPassword
            // 
            labelPassword.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(291, 202);
            labelPassword.Margin = new Padding(4, 0, 4, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(304, 100);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password";
            labelPassword.TextAlign = ContentAlignment.MiddleCenter;
            labelPassword.Click += labelPassword_Click;
            // 
            // iconPassword
            // 
            iconPassword.BackColor = Color.FromArgb(35, 35, 35);
            iconPassword.ForeColor = Color.FromArgb(255, 102, 36);
            iconPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPassword.IconColor = Color.FromArgb(255, 102, 36);
            iconPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPassword.IconSize = 86;
            iconPassword.Location = new Point(213, 202);
            iconPassword.Margin = new Padding(4, 5, 4, 5);
            iconPassword.Name = "iconPassword";
            iconPassword.Size = new Size(86, 100);
            iconPassword.TabIndex = 3;
            iconPassword.TabStop = false;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(617, 220);
            textBoxPassword.Margin = new Padding(4, 5, 4, 5);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(613, 55);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonhidepwd
            // 
            buttonhidepwd.BackColor = Color.White;
            buttonhidepwd.FlatStyle = FlatStyle.Flat;
            buttonhidepwd.Location = new Point(1169, 227);
            buttonhidepwd.Margin = new Padding(4, 5, 4, 5);
            buttonhidepwd.Name = "buttonhidepwd";
            buttonhidepwd.Size = new Size(57, 58);
            buttonhidepwd.TabIndex = 12;
            buttonhidepwd.UseVisualStyleBackColor = false;
            // 
            // panelSelamatDatang
            // 
            panelSelamatDatang.Controls.Add(labelSelamatDatang);
            panelSelamatDatang.Dock = DockStyle.Top;
            panelSelamatDatang.Location = new Point(0, 0);
            panelSelamatDatang.Margin = new Padding(4, 5, 4, 5);
            panelSelamatDatang.Name = "panelSelamatDatang";
            panelSelamatDatang.Size = new Size(1440, 500);
            panelSelamatDatang.TabIndex = 0;
            // 
            // labelSelamatDatang
            // 
            labelSelamatDatang.Dock = DockStyle.Fill;
            labelSelamatDatang.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold);
            labelSelamatDatang.ForeColor = Color.White;
            labelSelamatDatang.Location = new Point(0, 0);
            labelSelamatDatang.Margin = new Padding(4, 0, 4, 0);
            labelSelamatDatang.Name = "labelSelamatDatang";
            labelSelamatDatang.Size = new Size(1440, 500);
            labelSelamatDatang.TabIndex = 0;
            labelSelamatDatang.Text = "Selamat Datang";
            labelSelamatDatang.TextAlign = ContentAlignment.MiddleCenter;
            labelSelamatDatang.MouseDown += labelSelamatDatang_MouseDown;
            // 
            // iconDropDownButton1
            // 
            iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDropDownButton1.IconColor = Color.Black;
            iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton1.Name = "iconDropDownButton1";
            iconDropDownButton1.Size = new Size(23, 23);
            iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(1440, 1050);
            Controls.Add(panelLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Login";
            Text = "Login";
            panelLogin.ResumeLayout(false);
            panelLoginSelamatDatang.ResumeLayout(false);
            panelLoginSelamatDatang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPassword).EndInit();
            panelSelamatDatang.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Panel panelSelamatDatang;
        private Label labelSelamatDatang;
        private Panel panelLoginSelamatDatang;
        private TextBox textBoxUsername;
        private Label labelUsername;
        private FontAwesome.Sharp.IconPictureBox iconUsername;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private FontAwesome.Sharp.IconPictureBox iconPassword;
        private Button buttonLogin;
        private CheckBox showPassword;
        private Button buttonhidepwd;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
    }
}