namespace Subtrans
{
    partial class Delay
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectedrdobtn = new System.Windows.Forms.RadioButton();
            this.allrdobtn = new System.Windows.Forms.RadioButton();
            this.setbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.DurationTimetxtbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(44, 21);
            this.comboBox1.TabIndex = 203;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectedrdobtn);
            this.groupBox1.Controls.Add(this.allrdobtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 69);
            this.groupBox1.TabIndex = 204;
            this.groupBox1.TabStop = false;
            // 
            // selectedrdobtn
            // 
            this.selectedrdobtn.AutoSize = true;
            this.selectedrdobtn.Location = new System.Drawing.Point(9, 41);
            this.selectedrdobtn.Name = "selectedrdobtn";
            this.selectedrdobtn.Size = new System.Drawing.Size(67, 17);
            this.selectedrdobtn.TabIndex = 0;
            this.selectedrdobtn.Text = "Selected";
            this.selectedrdobtn.UseVisualStyleBackColor = true;
            // 
            // allrdobtn
            // 
            this.allrdobtn.AutoSize = true;
            this.allrdobtn.Checked = true;
            this.allrdobtn.Location = new System.Drawing.Point(9, 17);
            this.allrdobtn.Name = "allrdobtn";
            this.allrdobtn.Size = new System.Drawing.Size(36, 17);
            this.allrdobtn.TabIndex = 0;
            this.allrdobtn.TabStop = true;
            this.allrdobtn.Text = "All";
            this.allrdobtn.UseVisualStyleBackColor = true;
            // 
            // setbtn
            // 
            this.setbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.setbtn.Location = new System.Drawing.Point(12, 114);
            this.setbtn.Name = "setbtn";
            this.setbtn.Size = new System.Drawing.Size(62, 20);
            this.setbtn.TabIndex = 205;
            this.setbtn.Text = "Set";
            this.setbtn.UseVisualStyleBackColor = true;
            this.setbtn.Click += new System.EventHandler(this.setbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cancelbtn.Location = new System.Drawing.Point(80, 114);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(62, 20);
            this.cancelbtn.TabIndex = 205;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // DurationTimetxtbox
            // 
            this.DurationTimetxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DurationTimetxtbox.Location = new System.Drawing.Point(62, 13);
            this.DurationTimetxtbox.MaxLength = 8;
            this.DurationTimetxtbox.Name = "DurationTimetxtbox";
            this.DurationTimetxtbox.Size = new System.Drawing.Size(80, 20);
            this.DurationTimetxtbox.TabIndex = 206;
            this.DurationTimetxtbox.TabStop = false;
            this.DurationTimetxtbox.TextChanged += new System.EventHandler(this.DurationTimetxtbox_TextChanged);
            this.DurationTimetxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DurationTimetxtbox_KeyPress);
            // 
            // Delay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(151, 142);
            this.Controls.Add(this.DurationTimetxtbox);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.setbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Delay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual Shift";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Delay_FormClosing);
            this.Load += new System.EventHandler(this.Delay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton selectedrdobtn;
        private System.Windows.Forms.RadioButton allrdobtn;
        private System.Windows.Forms.Button setbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.TextBox DurationTimetxtbox;

    }
}