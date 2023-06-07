namespace Magizine_project
{
    partial class SignUp
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
            this.pass_toggle = new CustomControls.RJControls.RJToggleButton();
            this.signup_pass2 = new CustomControls.RJControls.RJTextBox();
            this.signup_pass = new CustomControls.RJControls.RJTextBox();
            this.signup_usr = new CustomControls.RJControls.RJTextBox();
            this.email = new CustomControls.RJControls.RJTextBox();
            this.lblCreate = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.checkboxTerms = new System.Windows.Forms.CheckBox();
            this.linkSignIn = new System.Windows.Forms.LinkLabel();
            this.Createbtn = new CustomControls.RJControls.RJButton();
            this.hoverButton4 = new HoverButton();
            this.SuspendLayout();
            // 
            // pass_toggle
            // 
            this.pass_toggle.AutoSize = true;
            this.pass_toggle.BackColor = System.Drawing.Color.Transparent;
            this.pass_toggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pass_toggle.ForeColor = System.Drawing.Color.Transparent;
            this.pass_toggle.Location = new System.Drawing.Point(350, 349);
            this.pass_toggle.MinimumSize = new System.Drawing.Size(35, 20);
            this.pass_toggle.Name = "pass_toggle";
            this.pass_toggle.OffBackColor = System.Drawing.Color.Gray;
            this.pass_toggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.pass_toggle.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.pass_toggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.pass_toggle.Size = new System.Drawing.Size(35, 20);
            this.pass_toggle.TabIndex = 49;
            this.pass_toggle.UseVisualStyleBackColor = false;
            this.pass_toggle.CheckedChanged += new System.EventHandler(this.passtoggle_CheckedChanged);
            // 
            // signup_pass2
            // 
            this.signup_pass2.BackColor = System.Drawing.Color.White;
            this.signup_pass2.BorderColor = System.Drawing.Color.Black;
            this.signup_pass2.BorderFocusColor = System.Drawing.Color.BlueViolet;
            this.signup_pass2.BorderRadius = 12;
            this.signup_pass2.BorderSize = 1;
            this.signup_pass2.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_pass2.ForeColor = System.Drawing.Color.DimGray;
            this.signup_pass2.Location = new System.Drawing.Point(67, 406);
            this.signup_pass2.Margin = new System.Windows.Forms.Padding(4);
            this.signup_pass2.MinimumSize = new System.Drawing.Size(0, 50);
            this.signup_pass2.Multiline = false;
            this.signup_pass2.Name = "signup_pass2";
            this.signup_pass2.Padding = new System.Windows.Forms.Padding(12, 12, 7, 7);
            this.signup_pass2.PasswordChar = false;
            this.signup_pass2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.signup_pass2.PlaceholderText = "Confirm Password";
            this.signup_pass2.Size = new System.Drawing.Size(331, 50);
            this.signup_pass2.TabIndex = 48;
            this.signup_pass2.Texts = "";
            this.signup_pass2.UnderlinedStyle = false;
            this.signup_pass2._TextChanged += new System.EventHandler(this.signup_pass2__TextChanged);
            // 
            // signup_pass
            // 
            this.signup_pass.BackColor = System.Drawing.Color.White;
            this.signup_pass.BorderColor = System.Drawing.Color.Black;
            this.signup_pass.BorderFocusColor = System.Drawing.Color.BlueViolet;
            this.signup_pass.BorderRadius = 12;
            this.signup_pass.BorderSize = 1;
            this.signup_pass.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_pass.ForeColor = System.Drawing.Color.DimGray;
            this.signup_pass.Location = new System.Drawing.Point(67, 334);
            this.signup_pass.Margin = new System.Windows.Forms.Padding(4);
            this.signup_pass.MinimumSize = new System.Drawing.Size(0, 50);
            this.signup_pass.Multiline = false;
            this.signup_pass.Name = "signup_pass";
            this.signup_pass.Padding = new System.Windows.Forms.Padding(12, 12, 7, 7);
            this.signup_pass.PasswordChar = true;
            this.signup_pass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.signup_pass.PlaceholderText = "CreatePassword";
            this.signup_pass.Size = new System.Drawing.Size(331, 50);
            this.signup_pass.TabIndex = 47;
            this.signup_pass.Texts = "";
            this.signup_pass.UnderlinedStyle = false;
            this.signup_pass._TextChanged += new System.EventHandler(this.signup_pass__TextChanged);
            // 
            // signup_usr
            // 
            this.signup_usr.BackColor = System.Drawing.Color.White;
            this.signup_usr.BorderColor = System.Drawing.Color.Black;
            this.signup_usr.BorderFocusColor = System.Drawing.Color.BlueViolet;
            this.signup_usr.BorderRadius = 12;
            this.signup_usr.BorderSize = 1;
            this.signup_usr.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_usr.ForeColor = System.Drawing.Color.DimGray;
            this.signup_usr.Location = new System.Drawing.Point(67, 261);
            this.signup_usr.Margin = new System.Windows.Forms.Padding(4);
            this.signup_usr.MinimumSize = new System.Drawing.Size(0, 50);
            this.signup_usr.Multiline = false;
            this.signup_usr.Name = "signup_usr";
            this.signup_usr.Padding = new System.Windows.Forms.Padding(12, 12, 7, 7);
            this.signup_usr.PasswordChar = false;
            this.signup_usr.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.signup_usr.PlaceholderText = "Create Username";
            this.signup_usr.Size = new System.Drawing.Size(331, 50);
            this.signup_usr.TabIndex = 50;
            this.signup_usr.Texts = "";
            this.signup_usr.UnderlinedStyle = false;
            this.signup_usr._TextChanged += new System.EventHandler(this.signup_usr__TextChanged);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.White;
            this.email.BorderColor = System.Drawing.Color.Black;
            this.email.BorderFocusColor = System.Drawing.Color.BlueViolet;
            this.email.BorderRadius = 12;
            this.email.BorderSize = 1;
            this.email.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.DimGray;
            this.email.Location = new System.Drawing.Point(67, 189);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.MinimumSize = new System.Drawing.Size(0, 50);
            this.email.Multiline = false;
            this.email.Name = "email";
            this.email.Padding = new System.Windows.Forms.Padding(12, 12, 7, 7);
            this.email.PasswordChar = false;
            this.email.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.email.PlaceholderText = "Enter Email";
            this.email.Size = new System.Drawing.Size(331, 50);
            this.email.TabIndex = 51;
            this.email.Texts = "";
            this.email.UnderlinedStyle = false;
            this.email._TextChanged += new System.EventHandler(this.email__TextChanged);
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.lblCreate.Location = new System.Drawing.Point(61, 45);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(345, 44);
            this.lblCreate.TabIndex = 52;
            this.lblCreate.Text = "Create an account";
            // 
            // lblNote
            // 
            this.lblNote.BackColor = System.Drawing.Color.Transparent;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNote.ForeColor = System.Drawing.Color.Gray;
            this.lblNote.Location = new System.Drawing.Point(63, 107);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(343, 58);
            this.lblNote.TabIndex = 53;
            this.lblNote.Text = "Please fill up the neccessary information to create your account";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkboxTerms
            // 
            this.checkboxTerms.AutoSize = true;
            this.checkboxTerms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkboxTerms.Location = new System.Drawing.Point(69, 475);
            this.checkboxTerms.Name = "checkboxTerms";
            this.checkboxTerms.Size = new System.Drawing.Size(219, 17);
            this.checkboxTerms.TabIndex = 54;
            this.checkboxTerms.Text = "I agree to all the Term and Privacy Policy";
            this.checkboxTerms.UseVisualStyleBackColor = true;
            this.checkboxTerms.CheckedChanged += new System.EventHandler(this.checkboxTerms_CheckedChanged);
            // 
            // linkSignIn
            // 
            this.linkSignIn.AutoSize = true;
            this.linkSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSignIn.LinkColor = System.Drawing.Color.Black;
            this.linkSignIn.Location = new System.Drawing.Point(120, 587);
            this.linkSignIn.Name = "linkSignIn";
            this.linkSignIn.Size = new System.Drawing.Size(246, 20);
            this.linkSignIn.TabIndex = 55;
            this.linkSignIn.TabStop = true;
            this.linkSignIn.Text = "Already have an account? Sign In";
            this.linkSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignIn_LinkClicked);
            // 
            // Createbtn
            // 
            this.Createbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Createbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Createbtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Createbtn.BorderRadius = 15;
            this.Createbtn.BorderSize = 0;
            this.Createbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Createbtn.FlatAppearance.BorderSize = 0;
            this.Createbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Createbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Createbtn.ForeColor = System.Drawing.Color.White;
            this.Createbtn.Location = new System.Drawing.Point(64, 514);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Size = new System.Drawing.Size(342, 54);
            this.Createbtn.TabIndex = 56;
            this.Createbtn.Text = "Create account";
            this.Createbtn.TextColor = System.Drawing.Color.White;
            this.Createbtn.UseVisualStyleBackColor = false;
            this.Createbtn.Click += new System.EventHandler(this.Createbtn_Click);
            // 
            // hoverButton4
            // 
            this.hoverButton4.FlatAppearance.BorderSize = 0;
            this.hoverButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hoverButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hoverButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hoverButton4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoverButton4.HoverColor = System.Drawing.Color.Chocolate;
            this.hoverButton4.Location = new System.Drawing.Point(435, 3);
            this.hoverButton4.Name = "hoverButton4";
            this.hoverButton4.Size = new System.Drawing.Size(28, 30);
            this.hoverButton4.TabIndex = 57;
            this.hoverButton4.Text = "▶";
            this.hoverButton4.UseVisualStyleBackColor = true;
            this.hoverButton4.Click += new System.EventHandler(this.hoverButton4_Click);
            // 
            // SignUp
            // 
            this.AcceptButton = this.Createbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(465, 646);
            this.Controls.Add(this.hoverButton4);
            this.Controls.Add(this.Createbtn);
            this.Controls.Add(this.linkSignIn);
            this.Controls.Add(this.checkboxTerms);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblCreate);
            this.Controls.Add(this.email);
            this.Controls.Add(this.signup_usr);
            this.Controls.Add(this.pass_toggle);
            this.Controls.Add(this.signup_pass2);
            this.Controls.Add(this.signup_pass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJToggleButton pass_toggle;
        private CustomControls.RJControls.RJTextBox signup_pass2;
        private CustomControls.RJControls.RJTextBox signup_pass;
        private CustomControls.RJControls.RJTextBox signup_usr;
        private CustomControls.RJControls.RJTextBox email;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.CheckBox checkboxTerms;
        private System.Windows.Forms.LinkLabel linkSignIn;
        private CustomControls.RJControls.RJButton Createbtn;
        private HoverButton hoverButton4;
    }
}