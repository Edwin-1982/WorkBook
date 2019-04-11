namespace SQLDelete
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
            this.dgv_Message = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Execute = new System.Windows.Forms.Button();
            this.txt_SQL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Message)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Message
            // 
            this.dgv_Message.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Message.Location = new System.Drawing.Point(1, 3);
            this.dgv_Message.Name = "dgv_Message";
            this.dgv_Message.RowTemplate.Height = 23;
            this.dgv_Message.Size = new System.Drawing.Size(305, 150);
            this.dgv_Message.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Execute);
            this.groupBox1.Controls.Add(this.txt_SQL);
            this.groupBox1.Location = new System.Drawing.Point(1, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "在文本框总输入有效地SQL语句修改数据";
            // 
            // txt_Execute
            // 
            this.txt_Execute.Location = new System.Drawing.Point(104, 81);
            this.txt_Execute.Name = "txt_Execute";
            this.txt_Execute.Size = new System.Drawing.Size(75, 23);
            this.txt_Execute.TabIndex = 1;
            this.txt_Execute.Text = "执行";
            this.txt_Execute.UseVisualStyleBackColor = true;
            this.txt_Execute.Click += new System.EventHandler(this.txt_Execute_Click);
            // 
            // txt_SQL
            // 
            this.txt_SQL.Location = new System.Drawing.Point(7, 21);
            this.txt_SQL.Multiline = true;
            this.txt_SQL.Name = "txt_SQL";
            this.txt_SQL.Size = new System.Drawing.Size(292, 53);
            this.txt_SQL.TabIndex = 0;
            this.txt_SQL.Text = "DELETE FROM Sheet1$ WHERE 学生编号= 20074109";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 290);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_Message);
            this.Name = "Frm_Main";
            this.Text = "利用SQL语句删除数据";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Message)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Message;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txt_Execute;
        private System.Windows.Forms.TextBox txt_SQL;
    }
}

