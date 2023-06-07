namespace Magizine_project
{
    partial class Recover
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recover));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hoverButton4 = new HoverButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.recoverbtn = new CustomControls.RJControls.RJButton();
            this.email = new CustomControls.RJControls.RJTextBox();
            this.OTPrec = new CustomControls.RJControls.RJTextBox();
            this.rjToggleButton2 = new CustomControls.RJControls.RJToggleButton();
            this.pass_confirm = new CustomControls.RJControls.RJTextBox();
            this.pass = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(16)))));
            this.label1.Location = new System.Drawing.Point(34, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 126);
            this.label1.TabIndex = 63;
            this.label1.Text = "Account \r\nRecovery";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(312, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
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
            this.hoverButton4.TabIndex = 66;
            this.hoverButton4.Text = "▶";
            this.hoverButton4.UseVisualStyleBackColor = true;
            this.hoverButton4.Click += new System.EventHandler(this.hoverButton4_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(292, 308);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(136, 54);
            this.rjButton1.TabIndex = 64;
            this.rjButton1.Text = "Send OTP";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // recoverbtn
            // 
            this.recoverbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.recoverbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.recoverbtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.recoverbtn.BorderRadius = 15;
            this.recoverbtn.BorderSize = 0;
            this.recoverbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recoverbtn.FlatAppearance.BorderSize = 0;
            this.recoverbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recoverbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoverbtn.ForeColor = System.Drawing.Color.White;
            this.recoverbtn.Location = new System.Drawing.Point(64, 535);
            this.recoverbtn.Name = "recoverbtn";
            this.recoverbtn.Size = new System.Drawing.Size(364, 54);
            this.recoverbtn.TabIndex = 62;
            this.recoverbtn.Text = "Recover account";
            this.recoverbtn.TextColor = System.Drawing.Color.White;
            this.recoverbtn.UseVisualStyleBackColor = false;
            this.recoverbtn.Click += new System.EventHandler(this.rjButton3_Click);
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
            this.email.Location = new System.Drawing.Point(64, 240);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.MinimumSize = new System.Drawing.Size(0, 50);
            this.email.Multiline = false;
            this.email.Name = "email";
            this.email.Padding = new System.Windows.Forms.Padding(12, 12, 7, 7);
            this.email.PasswordChar = false;
            this.email.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.email.PlaceholderText = "Enter Email";
            this.email.Size = new System.Drawing.Size(364, 50);
            this.email.TabIndex = 61;
            this.email.Texts = "";
            this.email.UnderlinedStyle = false;
            this.email._TextChanged += new System.EventHandler(this.email__TextChanged);
            // 
            // OTPrec
            // 
            this.OTPrec.BackColor = System.Drawing.Color.White;
            this.OTPrec.BorderColor = System.Drawing.Color.Black;
            this.OTPrec.BorderFocusColor = System.Drawing.Color.BlueViolet;
            this.OTPrec.BorderRadius = 12;
            this.OTPrec.BorderSize = 1;
            this.OTPrec.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTPrec.ForeColor = System.Drawing.Color.DimGray;
            this.OTPrec.Location = new System.Drawing.Point(64, 308);
            this.OTPrec.Margin = new System.Windows.Forms.Padding(4);
            this.OTPrec.MinimumSize = new System.Drawing.Size(0, 50);
            this.OTPrec.Multiline = false;
            this.OTPrec.Name = "OTPrec";
            this.OTPrec.Padding = new System.Windows.Forms.Padding(12, 12, 7, 7);
            this.OTPrec.PasswordChar = false;
            this.OTPrec.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.OTPrec.PlaceholderText = "Enter OTP";
            this.OTPrec.Size = new System.Drawing.Size(221, 50);
            this.OTPrec.TabIndex = 60;
            this.OTPrec.Texts = "";
            this.OTPrec.UnderlinedStyle = false;
            this.OTPrec._TextChanged += new System.EventHandler(this.OTP__TextChanged);
            // 
            // rjToggleButton2
            // 
            this.rjToggleButton2.AutoSize = true;
            this.rjToggleButton2.BackColor = System.Drawing.Color.Transparent;
            this.rjToggleButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjToggleButton2.ForeColor = System.Drawing.Color.Transparent;
            this.rjToggleButton2.Location = new System.Drawing.Point(382, 401);
            this.rjToggleButton2.MinimumSize = new System.Drawing.Size(35, 20);
            this.rjToggleButton2.Name = "rjToggleButton2";
            this.rjToggleButton2.OffBackColor = System.Drawing.Color.Gray;
            this.rjToggleButton2.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rjToggleButton2.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjToggleButton2.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rjToggleButton2.Size = new System.Drawing.Size(35, 20);
            this.rjToggleButton2.TabIndex = 59;
            this.rjToggleButton2.UseVisualStyleBackColor = false;
            this.rjToggleButton2.CheckedChanged += new System.EventHandler(this.rjToggleButton2_CheckedChanged);
            // 
            // pass_confirm
            // 
            this.pass_confirm.BackColor = System.Drawing.Color.White;
            this.pass_confirm.BorderColor = System.Drawing.Color.Black;
            this.pass_confirm.BorderFocusColor = System.Drawing.Color.BlueViolet;
            this.pass_confirm.BorderRadius = 12;
            this.pass_confirm.BorderSize = 1;
            this.pass_confirm.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_confirm.ForeColor = System.Drawing.Color.DimGray;
            this.pass_confirm.Location = new System.Drawing.Point(64, 457);
            this.pass_confirm.Margin = new System.Windows.Forms.Padding(4);
            this.pass_confirm.MinimumSize = new System.Drawing.Size(0, 50);
            this.pass_confirm.Multiline = false;
            this.pass_confirm.Name = "pass_confirm";
            this.pass_confirm.Padding = new System.Windows.Forms.Padding(12, 12, 7, 7);
            this.pass_confirm.PasswordChar = true;
            this.pass_confirm.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.pass_confirm.PlaceholderText = "Confirm New Password";
            this.pass_confirm.Size = new System.Drawing.Size(364, 50);
            this.pass_confirm.TabIndex = 58;
            this.pass_confirm.Texts = "";
            this.pass_confirm.UnderlinedStyle = false;
            this.pass_confirm._TextChanged += new System.EventHandler(this.pass_confirm__TextChanged);
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.White;
            this.pass.BorderColor = System.Drawing.Color.Black;
            this.pass.BorderFocusColor = System.Drawing.Color.BlueViolet;
            this.pass.BorderRadius = 12;
            this.pass.BorderSize = 1;
            this.pass.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.DimGray;
            this.pass.Location = new System.Drawing.Point(64, 386);
            this.pass.Margin = new System.Windows.Forms.Padding(4);
            this.pass.MinimumSize = new System.Drawing.Size(0, 50);
            this.pass.Multiline = false;
            this.pass.Name = "pass";
            this.pass.Padding = new System.Windows.Forms.Padding(12, 12, 7, 7);
            this.pass.PasswordChar = true;
            this.pass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.pass.PlaceholderText = "New Password";
            this.pass.Size = new System.Drawing.Size(364, 50);
            this.pass.TabIndex = 57;
            this.pass.Texts = "";
            this.pass.UnderlinedStyle = false;
            this.pass._TextChanged += new System.EventHandler(this.pass__TextChanged);
            // 
            // Recover
            // 
            this.AcceptButton = this.recoverbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(465, 646);
            this.Controls.Add(this.hoverButton4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recoverbtn);
            this.Controls.Add(this.email);
            this.Controls.Add(this.OTPrec);
            this.Controls.Add(this.rjToggleButton2);
            this.Controls.Add(this.pass_confirm);
            this.Controls.Add(this.pass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recover";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recover";
            this.Load += new System.EventHandler(this.Recover_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton recoverbtn;
        private CustomControls.RJControls.RJTextBox email;
        private CustomControls.RJControls.RJTextBox OTPrec;
        private CustomControls.RJControls.RJToggleButton rjToggleButton2;
        private CustomControls.RJControls.RJTextBox pass_confirm;
        private CustomControls.RJControls.RJTextBox pass;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private HoverButton hoverButton4;
    }
}