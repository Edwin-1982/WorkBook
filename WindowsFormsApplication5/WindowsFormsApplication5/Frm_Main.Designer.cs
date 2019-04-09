namespace WindowsFormsApplication5
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
            this.components = new System.ComponentModel.Container();
            this.rtBox_text = new System.Windows.Forms.RichTextBox();
            this.bnt_Get = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // rtBox_text
            // 
            this.rtBox_text.Location = new System.Drawing.Point(13, 13);
            this.rtBox_text.Name = "rtBox_text";
            this.rtBox_text.Size = new System.Drawing.Size(443, 216);
            this.rtBox_text.TabIndex = 0;
            this.rtBox_text.Text = "";
            // 
            // bnt_Get
            // 
            this.bnt_Get.Location = new System.Drawing.Point(196, 241);
            this.bnt_Get.Name = "bnt_Get";
            this.bnt_Get.Size = new System.Drawing.Size(75, 23);
            this.bnt_Get.TabIndex = 1;
            this.bnt_Get.Text = "获取";
            this.bnt_Get.UseVisualStyleBackColor = true;
            this.bnt_Get.Click += new System.EventHandler(this.bnt_Get_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 276);
            this.Controls.Add(this.bnt_Get);
            this.Controls.Add(this.rtBox_text);
            this.Name = "Frm_Main";
            this.Text = "使用typeof关键字获取类的内部结构";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtBox_text;
        private System.Windows.Forms.Button bnt_Get;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

