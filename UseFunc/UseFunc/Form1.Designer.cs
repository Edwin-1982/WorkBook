﻿namespace UseFunc
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
            this.cbox_Count = new System.Windows.Forms.ComboBox();
            this.btn_Select = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Message)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Message
            // 
            this.dgv_Message.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Message.Location = new System.Drawing.Point(0, -3);
            this.dgv_Message.Name = "dgv_Message";
            this.dgv_Message.RowTemplate.Height = 23;
            this.dgv_Message.Size = new System.Drawing.Size(570, 207);
            this.dgv_Message.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "学生姓名长度：";
            // 
            // cbox_Count
            // 
            this.cbox_Count.FormattingEnabled = true;
            this.cbox_Count.Items.AddRange(new object[] {
            "2",
            "3"});
            this.cbox_Count.Location = new System.Drawing.Point(183, 225);
            this.cbox_Count.Name = "cbox_Count";
            this.cbox_Count.Size = new System.Drawing.Size(104, 20);
            this.cbox_Count.TabIndex = 2;
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(350, 223);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(85, 23);
            this.btn_Select.TabIndex = 3;
            this.btn_Select.Text = "查询";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 252);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.cbox_Count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Message);
            this.Name = "Frm_Main";
            this.Text = "使用函数设置条件";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Message)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_Count;
        private System.Windows.Forms.Button btn_Select;
    }
}
