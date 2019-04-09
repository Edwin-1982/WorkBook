namespace FindNULL
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
            this.btn_Selsect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Message)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Message
            // 
            this.dgv_Message.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Message.Location = new System.Drawing.Point(-1, -1);
            this.dgv_Message.Name = "dgv_Message";
            this.dgv_Message.RowTemplate.Height = 23;
            this.dgv_Message.Size = new System.Drawing.Size(542, 178);
            this.dgv_Message.TabIndex = 0;
            // 
            // btn_Selsect
            // 
            this.btn_Selsect.Location = new System.Drawing.Point(188, 195);
            this.btn_Selsect.Name = "btn_Selsect";
            this.btn_Selsect.Size = new System.Drawing.Size(146, 23);
            this.btn_Selsect.TabIndex = 1;
            this.btn_Selsect.Text = "查询地址为空的记录";
            this.btn_Selsect.UseVisualStyleBackColor = true;
            this.btn_Selsect.Click += new System.EventHandler(this.btn_Selsect_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 230);
            this.Controls.Add(this.btn_Selsect);
            this.Controls.Add(this.dgv_Message);
            this.Name = "Frm_Main";
            this.Text = "查询（’‘或null）空数据";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Message)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Message;
        private System.Windows.Forms.Button btn_Selsect;
    }
}

