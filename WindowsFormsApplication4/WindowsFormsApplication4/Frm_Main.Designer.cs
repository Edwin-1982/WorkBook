namespace WindowsFormsApplication4
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
            this.rbtn_school = new System.Windows.Forms.RadioButton();
            this.rbtn_hospital = new System.Windows.Forms.RadioButton();
            this.btn_go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtn_school
            // 
            this.rbtn_school.AutoSize = true;
            this.rbtn_school.Location = new System.Drawing.Point(51, 50);
            this.rbtn_school.Name = "rbtn_school";
            this.rbtn_school.Size = new System.Drawing.Size(60, 20);
            this.rbtn_school.TabIndex = 0;
            this.rbtn_school.TabStop = true;
            this.rbtn_school.Text = "去学校";
            this.rbtn_school.UseCompatibleTextRendering = true;
            this.rbtn_school.UseVisualStyleBackColor = true;
            // 
            // rbtn_hospital
            // 
            this.rbtn_hospital.AutoSize = true;
            this.rbtn_hospital.Location = new System.Drawing.Point(234, 50);
            this.rbtn_hospital.Name = "rbtn_hospital";
            this.rbtn_hospital.Size = new System.Drawing.Size(59, 16);
            this.rbtn_hospital.TabIndex = 1;
            this.rbtn_hospital.TabStop = true;
            this.rbtn_hospital.Text = "去医院";
            this.rbtn_hospital.UseVisualStyleBackColor = true;
            // 
            // btn_go
            // 
            this.btn_go.Location = new System.Drawing.Point(137, 127);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(75, 23);
            this.btn_go.TabIndex = 2;
            this.btn_go.Text = "出发";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 206);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.rbtn_hospital);
            this.Controls.Add(this.rbtn_school);
            this.Name = "Frm_Main";
            this.Text = "小明去医院和学校分别要走哪条路";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_school;
        private System.Windows.Forms.RadioButton rbtn_hospital;
        private System.Windows.Forms.Button btn_go;
    }
}

