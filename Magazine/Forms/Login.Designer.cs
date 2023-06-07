namespace Magizine_project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblAlt = new System.Windows.Forms.Label();
            this.Lgin_hello = new System.Windows.Forms.Label();
            this.lgin_signup = new System.Windows.Forms.Label();
            this.lgin_forgot = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rjToggleButton2 = new CustomControls.RJControls.RJToggleButton();
            this.Signin_btn = new CustomControls.RJControls.RJButton();
            this.login_usrname = new CustomControls.RJControls.RJTextBox();
            this.login_pass = new CustomControls.RJControls.RJTextBox();
            this.hoverButton1 = new HoverButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlt
            // 
            this.lblAlt.BackColor = System.Drawing.Color.Transparent;
            this.lblAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAlt.ForeColor = System.Drawing.Color.Gray;
            this.lblAlt.Location = new System.Drawing.Point(63, 285);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(343, 58);
            this.lblAlt.TabIndex = 45;
            this.lblAlt.Text = "Please enter your email address and password to get sign in to your account";
            this.lblAlt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lgin_hello
            // 
            this.Lgin_hello.BackColor = System.Drawing.Color.Transparent;
            this.Lgin_hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lgin_hello.Location = new System.Drawing.Point(41, 74);
            this.Lgin_hello.Name = "Lgin_hello";
            this.Lgin_hello.Size = new System.Drawing.Size(206, 78);
            this.Lgin_hello.TabIndex = 44;
            this.Lgin_hello.Text = "Hello!";
            this.Lgin_hello.UseMnemonic = false;
            // 
            // lgin_signup
            // 
            this.lgin_signup.AutoSize = true;
            this.lgin_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lgin_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgin_signup.Location = new System.Drawing.Point(98, 579);
            this.lgin_signup.Name = "lgin_signup";
            this.lgin_signup.Size = new System.Drawing.Size(263, 20);
            this.lgin_signup.TabIndex = 42;
            this.lgin_signup.Text = "Don\'t have an account yet? Sign Up";
            this.lgin_signup.Click += new System.EventHandler(this.label7_Click);
            // 
            // lgin_forgot
            // 
            this.lgin_forgot.AutoSize = true;
            this.lgin_forgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lgin_forgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgin_forgot.Location = new System.Drawing.Point(268, 480);
            this.lgin_forgot.Name = "lgin_forgot";
            this.lgin_forgot.Size = new System.Drawing.Size(138, 20);
            this.lgin_forgot.TabIndex = 41;
            this.lgin_forgot.Text = "Forgot Password?";
            this.lgin_forgot.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(251, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // rjToggleButton2
            // 
            this.rjToggleButton2.AutoSize = true;
            this.rjToggleButton2.BackColor = System.Drawing.Color.Transparent;
            this.rjToggleButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjToggleButton2.ForeColor = System.Drawing.Color.Transparent;
            this.rjToggleButton2.Location = new System.Drawing.Point(350, 432);
            this.rjToggleButton2.MinimumSize = new System.Drawing.Size(35, 20);
            this.rjToggleButton2.Name = "rjToggleButton2";
            this.rjToggleButton2.OffBackColor = System.Drawing.Color.Gray;
            this.rjToggleButton2.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rjToggleButton2.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjToggleButton2.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rjToggleButton2.Size = new System.Drawing.Size(35, 20);
            this.rjToggleButton2.TabIndex = 46;
            this.rjToggleButton2.UseVisualStyleBackColor = false;
            this.rjToggleButton2.CheckedChanged += new System.EventHandler(this.rjToggleButton2_CheckedChanged);
            // 
            // Signin_btn
            // 
            this.Signin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Signin_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Signin_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Signin_btn.BorderRadius = 15;
            this.Signin_btn.BorderSize = 0;
            this.Signin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signin_btn.FlatAppearance.BorderSize = 0;
            this.Signin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signin_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signin_btn.ForeColor = System.Drawing.Color.White;
            this.Signin_btn.Location = new System.Drawing.Point(64, 513);
            this.Signin_btn.Name = "Signin_btn";
            this.Signin_btn.Size = new System.Drawing.Size(342, 54);
            this.Signin_btn.TabIndex = 40;
            this.Signin_btn.Text = "Sign In";
            this.Signin_btn.TextColor = System.Drawing.Color.White;
            this.Signin_btn.UseVisualStyleBackColor = false;
            this.Signin_btn.Click += new System.EventHandler(this.Signinbtn_Click);
            // 
            // login_usrname
            // 
            this.login_usrname.BackColor = System.Drawing.Color.White;
            this.login_usrname.BorderColor = System.Drawing.Color.Black;
            this.login_usrname.BorderFocusColor = System.Drawing.Color.BlueViolet;
            this.login_usrname.BorderRadius = 12;
            this.login_usrname.BorderSize = 1;
            this.login_usrname.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_usrname.ForeColor = System.Drawing.Color.DimGray;
            this.login_usrname.Location = new System.Drawing.Point(67, 347);
            this.login_usrname.Margin = new System.Windows.Forms.Padding(4);
            this.login_usrname.MinimumSize = new System.Drawing.Size(0, 50);
            this.login_usrname.Multiline = false;
            this.login_usrname.Name = "login_usrname";
            this.login_usrname.Padding = new System.Windows.Forms.Padding(12, 12, 7, 7);
            this.login_usrname.PasswordChar = false;
            this.login_usrname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.login_usrname.PlaceholderText = "Enter Username";
            this.login_usrname.Size = new System.Drawing.Size(331, 50);
            this.login_usrname.TabIndex = 34;
            this.login_usrname.Texts = "";
            this.login_usrname.UnderlinedStyle = false;
            // 
            // login_pass
            // 
            this.login_pass.BackColor = System.Drawing.Color.White;
            this.login_pass.BorderColor = System.Drawing.Color.Black;
            this.login_pass.BorderFocusColor = System.Drawing.Color.BlueViolet;
            this.login_pass.BorderRadius = 12;
            this.login_pass.BorderSize = 1;
            this.login_pass.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_pass.ForeColor = System.Drawing.Color.DimGray;
            this.login_pass.Location = new System.Drawing.Point(67, 416);
            this.login_pass.Margin = new System.Windows.Forms.Padding(4);
            this.login_pass.MinimumSize = new System.Drawing.Size(0, 50);
            this.login_pass.Multiline = false;
            this.login_pass.Name = "login_pass";
            this.login_pass.Padding = new System.Windows.Forms.Padding(12, 12, 7, 7);
            this.login_pass.PasswordChar = true;
            this.login_pass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.login_pass.PlaceholderText = "Password";
            this.login_pass.Size = new System.Drawing.Size(331, 50);
            this.login_pass.TabIndex = 33;
            this.login_pass.Texts = "";
            this.login_pass.UnderlinedStyle = false;
            // 
            // hoverButton1
            // 
            this.hoverButton1.FlatAppearance.BorderSize = 0;
            this.hoverButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hoverButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hoverButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hoverButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoverButton1.HoverColor = System.Drawing.Color.Chocolate;
            this.hoverButton1.Location = new System.Drawing.Point(452, 7);
            this.hoverButton1.Name = "hoverButton1";
            this.hoverButton1.Size = new System.Drawing.Size(28, 30);
            this.hoverButton1.TabIndex = 47;
            this.hoverButton1.Text = "▶";
            this.hoverButton1.UseVisualStyleBackColor = true;
            this.hoverButton1.Click += new System.EventHandler(this.hoverButton1_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.Signin_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(481, 685);
            this.Controls.Add(this.hoverButton1);
            this.Controls.Add(this.rjToggleButton2);
            this.Controls.Add(this.lblAlt);
            this.Controls.Add(this.Lgin_hello);
            this.Controls.Add(this.lgin_signup);
            this.Controls.Add(this.lgin_forgot);
            this.Controls.Add(this.Signin_btn);
            this.Controls.Add(this.login_usrname);
            this.Controls.Add(this.login_pass);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RJControls.RJTextBox login_pass;
        private CustomControls.RJControls.RJTextBox login_usrname;
        private CustomControls.RJControls.RJButton Signin_btn;
        private CustomControls.RJControls.RJToggleButton rjToggleButton2;
        private System.Windows.Forms.Label lblAlt;
        private System.Windows.Forms.Label Lgin_hello;
        private System.Windows.Forms.Label lgin_signup;
        private System.Windows.Forms.Label lgin_forgot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private HoverButton hoverButton1;
    }
}