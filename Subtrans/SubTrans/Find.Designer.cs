namespace Subtrans
{
    partial class Find
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
            this.Find_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Find_btn = new System.Windows.Forms.Button();
            this.MatchCase = new System.Windows.Forms.CheckBox();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Search_up = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Find_tabPage = new System.Windows.Forms.TabPage();
            this.Replace_tabPage = new System.Windows.Forms.TabPage();
            this.ReplaceALLbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ReplaceMATCHcasechkbox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Replace_REPLACE_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReplaceFIND_txtbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Find_tabPage.SuspendLayout();
            this.Replace_tabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Find_txtbox
            // 
            this.Find_txtbox.Location = new System.Drawing.Point(9, 19);
            this.Find_txtbox.Name = "Find_txtbox";
            this.Find_txtbox.Size = new System.Drawing.Size(262, 20);
            this.Find_txtbox.TabIndex = 0;
            this.Find_txtbox.TextChanged += new System.EventHandler(this.Find_txtbox_TextChanged);
            this.Find_txtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Find_txtbox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find what:";
            // 
            // Find_btn
            // 
            this.Find_btn.Location = new System.Drawing.Point(9, 124);
            this.Find_btn.Name = "Find_btn";
            this.Find_btn.Size = new System.Drawing.Size(81, 23);
            this.Find_btn.TabIndex = 2;
            this.Find_btn.Text = "Find Next";
            this.Find_btn.UseVisualStyleBackColor = true;
            this.Find_btn.Click += new System.EventHandler(this.Find_btn_Click);
            // 
            // MatchCase
            // 
            this.MatchCase.AutoSize = true;
            this.MatchCase.Location = new System.Drawing.Point(6, 19);
            this.MatchCase.Name = "MatchCase";
            this.MatchCase.Size = new System.Drawing.Size(82, 17);
            this.MatchCase.TabIndex = 3;
            this.MatchCase.Text = "Match case";
            this.MatchCase.UseVisualStyleBackColor = true;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(192, 124);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(81, 23);
            this.Cancel_btn.TabIndex = 2;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Search_up);
            this.groupBox1.Controls.Add(this.MatchCase);
            this.groupBox1.Location = new System.Drawing.Point(9, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Option";
            // 
            // Search_up
            // 
            this.Search_up.AutoSize = true;
            this.Search_up.Location = new System.Drawing.Point(6, 42);
            this.Search_up.Name = "Search_up";
            this.Search_up.Size = new System.Drawing.Size(75, 17);
            this.Search_up.TabIndex = 3;
            this.Search_up.Text = "Search up";
            this.Search_up.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Find_tabPage);
            this.tabControl1.Controls.Add(this.Replace_tabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(287, 182);
            this.tabControl1.TabIndex = 5;
            // 
            // Find_tabPage
            // 
            this.Find_tabPage.BackColor = System.Drawing.SystemColors.Control;
            this.Find_tabPage.Controls.Add(this.Cancel_btn);
            this.Find_tabPage.Controls.Add(this.groupBox1);
            this.Find_tabPage.Controls.Add(this.Find_btn);
            this.Find_tabPage.Controls.Add(this.Find_txtbox);
            this.Find_tabPage.Controls.Add(this.label1);
            this.Find_tabPage.Location = new System.Drawing.Point(4, 22);
            this.Find_tabPage.Name = "Find_tabPage";
            this.Find_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Find_tabPage.Size = new System.Drawing.Size(279, 156);
            this.Find_tabPage.TabIndex = 0;
            this.Find_tabPage.Text = "Find";
            // 
            // Replace_tabPage
            // 
            this.Replace_tabPage.BackColor = System.Drawing.SystemColors.Control;
            this.Replace_tabPage.Controls.Add(this.ReplaceALLbtn);
            this.Replace_tabPage.Controls.Add(this.cancelbtn);
            this.Replace_tabPage.Controls.Add(this.groupBox2);
            this.Replace_tabPage.Controls.Add(this.label3);
            this.Replace_tabPage.Controls.Add(this.Replace_REPLACE_txtbox);
            this.Replace_tabPage.Controls.Add(this.label2);
            this.Replace_tabPage.Controls.Add(this.ReplaceFIND_txtbox);
            this.Replace_tabPage.Location = new System.Drawing.Point(4, 22);
            this.Replace_tabPage.Name = "Replace_tabPage";
            this.Replace_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Replace_tabPage.Size = new System.Drawing.Size(279, 156);
            this.Replace_tabPage.TabIndex = 1;
            this.Replace_tabPage.Text = "Replace";
            // 
            // ReplaceALLbtn
            // 
            this.ReplaceALLbtn.Location = new System.Drawing.Point(9, 124);
            this.ReplaceALLbtn.Name = "ReplaceALLbtn";
            this.ReplaceALLbtn.Size = new System.Drawing.Size(81, 23);
            this.ReplaceALLbtn.TabIndex = 5;
            this.ReplaceALLbtn.Text = "Replace all";
            this.ReplaceALLbtn.UseVisualStyleBackColor = true;
            this.ReplaceALLbtn.Click += new System.EventHandler(this.ReplaceALLbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(192, 124);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(81, 23);
            this.cancelbtn.TabIndex = 5;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ReplaceMATCHcasechkbox);
            this.groupBox2.Location = new System.Drawing.Point(9, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 41);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Replace Option";
            // 
            // ReplaceMATCHcasechkbox
            // 
            this.ReplaceMATCHcasechkbox.AutoSize = true;
            this.ReplaceMATCHcasechkbox.Location = new System.Drawing.Point(6, 16);
            this.ReplaceMATCHcasechkbox.Name = "ReplaceMATCHcasechkbox";
            this.ReplaceMATCHcasechkbox.Size = new System.Drawing.Size(82, 17);
            this.ReplaceMATCHcasechkbox.TabIndex = 0;
            this.ReplaceMATCHcasechkbox.Text = "Match case";
            this.ReplaceMATCHcasechkbox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Replace with:";
            // 
            // Replace_REPLACE_txtbox
            // 
            this.Replace_REPLACE_txtbox.Location = new System.Drawing.Point(9, 58);
            this.Replace_REPLACE_txtbox.Name = "Replace_REPLACE_txtbox";
            this.Replace_REPLACE_txtbox.Size = new System.Drawing.Size(262, 20);
            this.Replace_REPLACE_txtbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Find what:";
            // 
            // ReplaceFIND_txtbox
            // 
            this.ReplaceFIND_txtbox.Location = new System.Drawing.Point(9, 19);
            this.ReplaceFIND_txtbox.Name = "ReplaceFIND_txtbox";
            this.ReplaceFIND_txtbox.Size = new System.Drawing.Size(262, 20);
            this.ReplaceFIND_txtbox.TabIndex = 0;
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 182);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Find";
            this.Text = "Find and Replace";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Find_FormClosing);
            this.Load += new System.EventHandler(this.Find_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Find_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Find_tabPage.ResumeLayout(false);
            this.Find_tabPage.PerformLayout();
            this.Replace_tabPage.ResumeLayout(false);
            this.Replace_tabPage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Find_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Find_btn;
        private System.Windows.Forms.CheckBox MatchCase;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Search_up;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Find_tabPage;
        private System.Windows.Forms.TabPage Replace_tabPage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Replace_REPLACE_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ReplaceFIND_txtbox;
        private System.Windows.Forms.CheckBox ReplaceMATCHcasechkbox;
        private System.Windows.Forms.Button ReplaceALLbtn;
        private System.Windows.Forms.Button cancelbtn;
    }
}