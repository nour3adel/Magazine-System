namespace Magizine_project
{
    partial class CategoryLists
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.hoverButton4 = new HoverButton();
            this.hoverButton3 = new HoverButton();
            this.hoverButton1 = new HoverButton();
            this.hoverButton2 = new HoverButton();
            this.rjComboBox1 = new CustomControls.RJControls.RJComboBox();
            this.roundedButton1 = new RoundedButton();
            this.roundedButton4 = new RoundedButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Location = new System.Drawing.Point(0, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(43, 43);
            this.BtnCerrar.TabIndex = 22;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(1224, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(39, 39);
            this.exit.TabIndex = 25;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(720, 66);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(520, 448);
            this.dataGridView1.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LCDMono2", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 29);
            this.label1.TabIndex = 101;
            this.label1.Text = "0";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("LCDMono2", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(351, 181);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(330, 29);
            this.numericUpDown1.TabIndex = 103;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(708, 53);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(544, 479);
            this.rjButton1.TabIndex = 99;
            this.rjButton1.Text = "rjButton1";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // hoverButton4
            // 
            this.hoverButton4.BackColor = System.Drawing.Color.Transparent;
            this.hoverButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hoverButton4.FlatAppearance.BorderSize = 0;
            this.hoverButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hoverButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hoverButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hoverButton4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoverButton4.ForeColor = System.Drawing.Color.Black;
            this.hoverButton4.HoverColor = System.Drawing.Color.LightCoral;
            this.hoverButton4.Location = new System.Drawing.Point(26, 66);
            this.hoverButton4.Name = "hoverButton4";
            this.hoverButton4.Size = new System.Drawing.Size(289, 73);
            this.hoverButton4.TabIndex = 98;
            this.hoverButton4.Text = "Magazine Name:";
            this.hoverButton4.UseVisualStyleBackColor = false;
            // 
            // hoverButton3
            // 
            this.hoverButton3.BackColor = System.Drawing.Color.Transparent;
            this.hoverButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hoverButton3.FlatAppearance.BorderSize = 0;
            this.hoverButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hoverButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hoverButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hoverButton3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoverButton3.ForeColor = System.Drawing.Color.Black;
            this.hoverButton3.HoverColor = System.Drawing.Color.LightCoral;
            this.hoverButton3.Location = new System.Drawing.Point(-39, 158);
            this.hoverButton3.Name = "hoverButton3";
            this.hoverButton3.Size = new System.Drawing.Size(343, 73);
            this.hoverButton3.TabIndex = 97;
            this.hoverButton3.Text = "Quantity:";
            this.hoverButton3.UseVisualStyleBackColor = false;
            // 
            // hoverButton1
            // 
            this.hoverButton1.BackColor = System.Drawing.Color.Transparent;
            this.hoverButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hoverButton1.FlatAppearance.BorderSize = 0;
            this.hoverButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hoverButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hoverButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hoverButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoverButton1.ForeColor = System.Drawing.Color.Black;
            this.hoverButton1.HoverColor = System.Drawing.Color.LightCoral;
            this.hoverButton1.Location = new System.Drawing.Point(50, 253);
            this.hoverButton1.Name = "hoverButton1";
            this.hoverButton1.Size = new System.Drawing.Size(265, 73);
            this.hoverButton1.TabIndex = 96;
            this.hoverButton1.Text = "Total price of items:";
            this.hoverButton1.UseVisualStyleBackColor = false;
            // 
            // hoverButton2
            // 
            this.hoverButton2.BackColor = System.Drawing.Color.Transparent;
            this.hoverButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hoverButton2.FlatAppearance.BorderSize = 0;
            this.hoverButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hoverButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hoverButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hoverButton2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoverButton2.ForeColor = System.Drawing.Color.Black;
            this.hoverButton2.HoverColor = System.Drawing.Color.LightCoral;
            this.hoverButton2.Location = new System.Drawing.Point(26, 376);
            this.hoverButton2.Name = "hoverButton2";
            this.hoverButton2.Size = new System.Drawing.Size(303, 73);
            this.hoverButton2.TabIndex = 95;
            this.hoverButton2.Text = "Total price of order:";
            this.hoverButton2.UseVisualStyleBackColor = false;
            // 
            // rjComboBox1
            // 
            this.rjComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.rjComboBox1.BorderColor = System.Drawing.Color.Transparent;
            this.rjComboBox1.BorderSize = 1;
            this.rjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rjComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjComboBox1.ForeColor = System.Drawing.Color.White;
            this.rjComboBox1.IconColor = System.Drawing.Color.White;
            this.rjComboBox1.ListBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox1.ListTextColor = System.Drawing.Color.White;
            this.rjComboBox1.Location = new System.Drawing.Point(350, 84);
            this.rjComboBox1.MinimumSize = new System.Drawing.Size(205, 30);
            this.rjComboBox1.Name = "rjComboBox1";
            this.rjComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox1.Size = new System.Drawing.Size(331, 35);
            this.rjComboBox1.TabIndex = 94;
            this.rjComboBox1.Texts = "Select";
            this.rjComboBox1.OnSelectedIndexChanged += new System.EventHandler(this.rjComboBox1_OnSelectedIndexChanged);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.roundedButton1.CornerRadius = 25;
            this.roundedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(158)))));
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(131, 515);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(366, 75);
            this.roundedButton1.TabIndex = 27;
            this.roundedButton1.Text = "Make Order";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // roundedButton4
            // 
            this.roundedButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.roundedButton4.CornerRadius = 25;
            this.roundedButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton4.FlatAppearance.BorderSize = 0;
            this.roundedButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(158)))));
            this.roundedButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton4.ForeColor = System.Drawing.Color.White;
            this.roundedButton4.Location = new System.Drawing.Point(805, 600);
            this.roundedButton4.Name = "roundedButton4";
            this.roundedButton4.Size = new System.Drawing.Size(335, 62);
            this.roundedButton4.TabIndex = 26;
            this.roundedButton4.Text = "Add items";
            this.roundedButton4.UseVisualStyleBackColor = false;
            this.roundedButton4.Click += new System.EventHandler(this.roundedButton4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LCDMono2", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 29);
            this.label2.TabIndex = 104;
            this.label2.Text = "0";
            // 
            // CategoryLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.hoverButton4);
            this.Controls.Add(this.hoverButton3);
            this.Controls.Add(this.hoverButton1);
            this.Controls.Add(this.hoverButton2);
            this.Controls.Add(this.rjComboBox1);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.roundedButton4);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.BtnCerrar);
            this.Name = "CategoryLists";
            this.Text = "FormMembresia";
            this.Load += new System.EventHandler(this.CategoryLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button exit;
        private RoundedButton roundedButton4;
        private RoundedButton roundedButton1;
        private HoverButton hoverButton2;
        private HoverButton hoverButton1;
        private HoverButton hoverButton3;
        private HoverButton hoverButton4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private CustomControls.RJControls.RJComboBox rjComboBox1;
        private System.Windows.Forms.Label label2;
    }
}