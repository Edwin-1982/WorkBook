namespace UseProcedure
{
    partial class Frm_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Alter = new System.Windows.Forms.Button();
            this.txt_Math = new System.Windows.Forms.TextBox();
            this.txt_English = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_Message = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Exit);
            this.groupBox1.Controls.Add(this.btn_Alter);
            this.groupBox1.Controls.Add(this.txt_Math);
            this.groupBox1.Controls.Add(this.txt_English);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据信息";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(162, 86);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(63, 23);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "退出(E)";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Alter
            // 
            this.btn_Alter.Location = new System.Drawing.Point(59, 86);
            this.btn_Alter.Name = "btn_Alter";
            this.btn_Alter.Size = new System.Drawing.Size(75, 23);
            this.btn_Alter.TabIndex = 10;
            this.btn_Alter.Text = "修改(&U)";
            this.btn_Alter.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txt_Math
            // 
            this.txt_Math.Location = new System.Drawing.Point(196, 49);
            this.txt_Math.Name = "txt_Math";
            this.txt_Math.Size = new System.Drawing.Size(74, 21);
            this.txt_Math.TabIndex = 7;
            // 
            // txt_English
            // 
            this.txt_English.Location = new System.Drawing.Point(60, 49);
            this.txt_English.Name = "txt_English";
            this.txt_English.Size = new System.Drawing.Size(74, 21);
            this.txt_English.TabIndex = 6;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(196, 17);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(74, 21);
            this.txt_Name.TabIndex = 5;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(60, 17);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(74, 21);
            this.txt_id.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "高数成绩";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "英语成绩";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "学生姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生编号";
            // 
            // lv_Message
            // 
            this.lv_Message.Location = new System.Drawing.Point(4, 137);
            this.lv_Message.Name = "lv_Message";
            this.lv_Message.Size = new System.Drawing.Size(277, 123);
            this.lv_Message.TabIndex = 2;
            this.lv_Message.UseCompatibleStateImageBehavior = false;
            this.lv_Message.Click += new System.EventHandler(this.listView1_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lv_Message);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Main";
            this.Text = "利用存储过程修改数据";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Alter;
        private System.Windows.Forms.TextBox txt_Math;
        private System.Windows.Forms.TextBox txt_English;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_Message;
    }
}

