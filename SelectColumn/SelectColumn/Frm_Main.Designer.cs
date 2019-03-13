namespace SelectColumn
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
            this.dgv_Message = new System.Windows.Forms.DataGridView();
            this.学生编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学生姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.年龄DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.家庭住址DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newDataSet1 = new SelectColumn.NewDataSet1();
            this.sheet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sheet1_TableAdapter1 = new SelectColumn.NewDataSet1TableAdapters.Sheet1_TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Message)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheet1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Message
            // 
            this.dgv_Message.AutoGenerateColumns = false;
            this.dgv_Message.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Message.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学生编号DataGridViewTextBoxColumn,
            this.学生姓名DataGridViewTextBoxColumn,
            this.性别DataGridViewTextBoxColumn,
            this.年龄DataGridViewTextBoxColumn,
            this.家庭住址DataGridViewTextBoxColumn});
            this.dgv_Message.DataSource = this.sheet1BindingSource1;
            this.dgv_Message.Location = new System.Drawing.Point(-1, 2);
            this.dgv_Message.Name = "dgv_Message";
            this.dgv_Message.RowTemplate.Height = 23;
            this.dgv_Message.Size = new System.Drawing.Size(539, 258);
            this.dgv_Message.TabIndex = 0;
            // 
            // 学生编号DataGridViewTextBoxColumn
            // 
            this.学生编号DataGridViewTextBoxColumn.DataPropertyName = "学生编号";
            this.学生编号DataGridViewTextBoxColumn.HeaderText = "学生编号";
            this.学生编号DataGridViewTextBoxColumn.Name = "学生编号DataGridViewTextBoxColumn";
            // 
            // 学生姓名DataGridViewTextBoxColumn
            // 
            this.学生姓名DataGridViewTextBoxColumn.DataPropertyName = "学生姓名";
            this.学生姓名DataGridViewTextBoxColumn.HeaderText = "学生姓名";
            this.学生姓名DataGridViewTextBoxColumn.Name = "学生姓名DataGridViewTextBoxColumn";
            // 
            // 性别DataGridViewTextBoxColumn
            // 
            this.性别DataGridViewTextBoxColumn.DataPropertyName = "性别";
            this.性别DataGridViewTextBoxColumn.HeaderText = "性别";
            this.性别DataGridViewTextBoxColumn.Name = "性别DataGridViewTextBoxColumn";
            // 
            // 年龄DataGridViewTextBoxColumn
            // 
            this.年龄DataGridViewTextBoxColumn.DataPropertyName = "年龄";
            this.年龄DataGridViewTextBoxColumn.HeaderText = "年龄";
            this.年龄DataGridViewTextBoxColumn.Name = "年龄DataGridViewTextBoxColumn";
            // 
            // 家庭住址DataGridViewTextBoxColumn
            // 
            this.家庭住址DataGridViewTextBoxColumn.DataPropertyName = "家庭住址";
            this.家庭住址DataGridViewTextBoxColumn.HeaderText = "家庭住址";
            this.家庭住址DataGridViewTextBoxColumn.Name = "家庭住址DataGridViewTextBoxColumn";
            // 
            // newDataSet1
            // 
            this.newDataSet1.DataSetName = "NewDataSet1";
            this.newDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sheet1BindingSource1
            // 
            this.sheet1BindingSource1.DataMember = "Sheet1$";
            this.sheet1BindingSource1.DataSource = this.newDataSet1;
            // 
            // sheet1_TableAdapter1
            // 
            this.sheet1_TableAdapter1.ClearBeforeFill = true;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 261);
            this.Controls.Add(this.dgv_Message);
            this.Name = "Frm_Main";
            this.Text = "查询特定列数据";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Message)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheet1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学生编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学生姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年龄DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 家庭住址DataGridViewTextBoxColumn;
        private NewDataSet1 newDataSet1;
        private System.Windows.Forms.BindingSource sheet1BindingSource1;
        private NewDataSet1TableAdapters.Sheet1_TableAdapter sheet1_TableAdapter1;
    }
}

