namespace Subtrans
{
    partial class AutoTranslateFRM
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
            this.components = new System.ComponentModel.Container();
            this.Translate_listView = new System.Windows.Forms.ListView();
            this.Source_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Trans_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartTranslate = new System.Windows.Forms.Button();
            this._comboFrom = new System.Windows.Forms.ComboBox();
            this._comboTo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AT_progressBar = new System.Windows.Forms.ProgressBar();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.AddToList_btn = new System.Windows.Forms.Button();
            this.Translate_timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Translate_listView
            // 
            this.Translate_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Source_columnHeader,
            this.Trans_columnHeader});
            this.Translate_listView.FullRowSelect = true;
            this.Translate_listView.GridLines = true;
            this.Translate_listView.Location = new System.Drawing.Point(12, 98);
            this.Translate_listView.Name = "Translate_listView";
            this.Translate_listView.Size = new System.Drawing.Size(693, 306);
            this.Translate_listView.TabIndex = 0;
            this.Translate_listView.UseCompatibleStateImageBehavior = false;
            this.Translate_listView.View = System.Windows.Forms.View.Details;
            // 
            // Source_columnHeader
            // 
            this.Source_columnHeader.Text = "Source";
            this.Source_columnHeader.Width = 300;
            // 
            // Trans_columnHeader
            // 
            this.Trans_columnHeader.Text = "Translation";
            this.Trans_columnHeader.Width = 300;
            // 
            // StartTranslate
            // 
            this.StartTranslate.Location = new System.Drawing.Point(336, 46);
            this.StartTranslate.Name = "StartTranslate";
            this.StartTranslate.Size = new System.Drawing.Size(88, 23);
            this.StartTranslate.TabIndex = 1;
            this.StartTranslate.Text = "Start";
            this.StartTranslate.UseVisualStyleBackColor = true;
            this.StartTranslate.Click += new System.EventHandler(this.StartTranslate_Click);
            // 
            // _comboFrom
            // 
            this._comboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboFrom.FormattingEnabled = true;
            this._comboFrom.Items.AddRange(new object[] {
            "Afrikaans",
            "Albanian",
            "Arabic",
            "Belarusian",
            "Bulgarian",
            "Catalan",
            "Chinese",
            "Croatian",
            "Czech",
            "Danish",
            "Dutch",
            "English",
            "Estonian",
            "Filipino",
            "Finnish",
            "French",
            "Galician",
            "German",
            "Greek",
            "Haitian Creole",
            "Hebrew",
            "Hindi",
            "Hungarian",
            "Icelandic",
            "Indonesian",
            "Irish",
            "Italian",
            "Japanese",
            "Korean",
            "Latvian",
            "Lithuanian",
            "Macedonian",
            "Malay",
            "Maltese",
            "Norwegian",
            "Persian",
            "Polish",
            "Portuguese",
            "Romanian",
            "Russian",
            "Serbian",
            "Slovak",
            "Slovenian",
            "Spanish",
            "Swahili",
            "Swedish",
            "Thai",
            "Turkish",
            "Ukrainian",
            "Vietnamese",
            "Welsh",
            "Yiddish"});
            this._comboFrom.Location = new System.Drawing.Point(12, 40);
            this._comboFrom.Name = "_comboFrom";
            this._comboFrom.Size = new System.Drawing.Size(94, 21);
            this._comboFrom.TabIndex = 216;
            // 
            // _comboTo
            // 
            this._comboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboTo.FormattingEnabled = true;
            this._comboTo.Items.AddRange(new object[] {
            "Afrikaans",
            "Albanian",
            "Arabic",
            "Belarusian",
            "Bulgarian",
            "Catalan",
            "Chinese",
            "Croatian",
            "Czech",
            "Danish",
            "Dutch",
            "English",
            "Estonian",
            "Filipino",
            "Finnish",
            "French",
            "Galician",
            "German",
            "Greek",
            "Haitian Creole",
            "Hindi",
            "Hungarian",
            "Icelandic",
            "Indonesian",
            "Irish",
            "Italian",
            "Japanese",
            "Korean",
            "Latvian",
            "Lithuanian",
            "Macedonian",
            "Malay",
            "Maltese",
            "Norwegian",
            "Persian",
            "Polish",
            "Portuguese",
            "Romanian",
            "Russian",
            "Serbian",
            "Slovak",
            "Slovenian",
            "Spanish",
            "Swahili",
            "Swedish",
            "Thai",
            "Turkish",
            "Ukrainian",
            "Vietnamese",
            "Welsh",
            "Yiddish"});
            this._comboTo.Location = new System.Drawing.Point(123, 40);
            this._comboTo.Name = "_comboTo";
            this._comboTo.Size = new System.Drawing.Size(94, 21);
            this._comboTo.TabIndex = 215;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._comboTo);
            this.groupBox1.Controls.Add(this._comboFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 79);
            this.groupBox1.TabIndex = 219;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Translate Setting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Target Language";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Language";
            // 
            // AT_progressBar
            // 
            this.AT_progressBar.Location = new System.Drawing.Point(6, 19);
            this.AT_progressBar.Name = "AT_progressBar";
            this.AT_progressBar.Size = new System.Drawing.Size(418, 21);
            this.AT_progressBar.TabIndex = 217;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(8, 411);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(101, 13);
            this.linkLabel1.TabIndex = 217;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Powered By Google";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AT_progressBar);
            this.groupBox2.Controls.Add(this.Cancel_btn);
            this.groupBox2.Controls.Add(this.StartTranslate);
            this.groupBox2.Location = new System.Drawing.Point(275, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 79);
            this.groupBox2.TabIndex = 220;
            this.groupBox2.TabStop = false;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Enabled = false;
            this.Cancel_btn.Location = new System.Drawing.Point(5, 46);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(88, 23);
            this.Cancel_btn.TabIndex = 1;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // AddToList_btn
            // 
            this.AddToList_btn.Enabled = false;
            this.AddToList_btn.Location = new System.Drawing.Point(617, 407);
            this.AddToList_btn.Name = "AddToList_btn";
            this.AddToList_btn.Size = new System.Drawing.Size(88, 23);
            this.AddToList_btn.TabIndex = 221;
            this.AddToList_btn.Text = "Add";
            this.AddToList_btn.UseVisualStyleBackColor = true;
            this.AddToList_btn.Click += new System.EventHandler(this.AddToList_btn_Click);
            // 
            // Translate_timer
            // 
            this.Translate_timer.Tick += new System.EventHandler(this.Translate_timer_Tick);
            // 
            // AutoTranslateFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 432);
            this.Controls.Add(this.AddToList_btn);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Translate_listView);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AutoTranslateFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Translate";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutoTranslateFRM_FormClosing);
            this.Load += new System.EventHandler(this.AutoTranslateFRM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Translate_listView;
        private System.Windows.Forms.Button StartTranslate;
        private System.Windows.Forms.ComboBox _comboFrom;
        private System.Windows.Forms.ComboBox _comboTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar AT_progressBar;
        private System.Windows.Forms.ColumnHeader Source_columnHeader;
        private System.Windows.Forms.ColumnHeader Trans_columnHeader;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddToList_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Timer Translate_timer;
    }
}