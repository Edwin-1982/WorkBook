namespace Subtrans
{
    partial class HistoryFrm
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
            this.History_lstbox = new System.Windows.Forms.ListBox();
            this.apply_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // History_lstbox
            // 
            this.History_lstbox.Enabled = false;
            this.History_lstbox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.History_lstbox.FormattingEnabled = true;
            this.History_lstbox.ItemHeight = 16;
            this.History_lstbox.Location = new System.Drawing.Point(11, 12);
            this.History_lstbox.Name = "History_lstbox";
            this.History_lstbox.Size = new System.Drawing.Size(250, 180);
            this.History_lstbox.TabIndex = 3;
            // 
            // apply_btn
            // 
            this.apply_btn.Location = new System.Drawing.Point(11, 198);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(75, 23);
            this.apply_btn.TabIndex = 1;
            this.apply_btn.Text = "Rollback";
            this.apply_btn.UseVisualStyleBackColor = true;
            this.apply_btn.Click += new System.EventHandler(this.apply_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(187, 198);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 2;
            this.cancel_btn.Text = "Close";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // HistoryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 230);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.apply_btn);
            this.Controls.Add(this.History_lstbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HistoryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Undo history";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HistoryFrm_FormClosing);
            this.Load += new System.EventHandler(this.HistoryFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox History_lstbox;
        private System.Windows.Forms.Button apply_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}