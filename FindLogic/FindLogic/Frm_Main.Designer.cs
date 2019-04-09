namespace FindLogic
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_Bool = new System.Windows.Forms.ComboBox();
            this.btn_Select = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Message)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Message
            // 
            this.dgv_Message.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Message.Location = new System.Drawing.Point(-1, 0);
            this.dgv_Message.Name = "dgv_Message";
            this.dgv_Message.RowTemplate.Height = 23;
            this.dgv_Message.Size = new System.Drawing.Size(627, 261);
            this.dgv_Message.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "查询是否为统招生：";
            // 
            // cbox_Bool
            // 
            this.cbox_Bool.FormattingEnabled = true;
            this.cbox_Bool.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cbox_Bool.Location = new System.Drawing.Point(213, 273);
            this.cbox_Bool.Name = "cbox_Bool";
            this.cbox_Bool.Size = new System.Drawing.Size(121, 20);
            this.cbox_Bool.TabIndex = 3;
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(372, 272);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(75, 23);
            this.btn_Select.TabIndex = 0;
            this.btn_Select.Text = "查询";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 300);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.cbox_Bool);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Message);
            this.Name = "Frm_Main";
            this.Text = "查询逻辑型数据";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Message)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_Bool;
        private System.Windows.Forms.Button btn_Select;
    }
}

