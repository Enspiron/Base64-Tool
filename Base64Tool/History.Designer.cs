namespace Base64Tool
{
    partial class History
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.copySelected = new MaterialSkin.Controls.MaterialRaisedButton();
            this.clearHistory = new MaterialSkin.Controls.MaterialRaisedButton();
            this.getTitle = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(33, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(268, 433);
            this.listBox1.TabIndex = 0;
            // 
            // copySelected
            // 
            this.copySelected.AutoSize = true;
            this.copySelected.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.copySelected.Depth = 0;
            this.copySelected.Icon = null;
            this.copySelected.Location = new System.Drawing.Point(33, 71);
            this.copySelected.MouseState = MaterialSkin.MouseState.HOVER;
            this.copySelected.Name = "copySelected";
            this.copySelected.Primary = true;
            this.copySelected.Size = new System.Drawing.Size(125, 36);
            this.copySelected.TabIndex = 1;
            this.copySelected.Text = "Copy Selected";
            this.copySelected.UseVisualStyleBackColor = true;
            this.copySelected.Click += new System.EventHandler(this.MaterialRaisedButton1_Click);
            // 
            // clearHistory
            // 
            this.clearHistory.AutoSize = true;
            this.clearHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearHistory.Depth = 0;
            this.clearHistory.Icon = null;
            this.clearHistory.Location = new System.Drawing.Point(176, 71);
            this.clearHistory.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearHistory.Name = "clearHistory";
            this.clearHistory.Primary = true;
            this.clearHistory.Size = new System.Drawing.Size(123, 36);
            this.clearHistory.TabIndex = 2;
            this.clearHistory.Text = "Clear History";
            this.clearHistory.UseVisualStyleBackColor = true;
            this.clearHistory.Click += new System.EventHandler(this.ClearHistory_Click);
            // 
            // getTitle
            // 
            this.getTitle.AutoSize = true;
            this.getTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.getTitle.Depth = 0;
            this.getTitle.Icon = null;
            this.getTitle.Location = new System.Drawing.Point(97, 565);
            this.getTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.getTitle.Name = "getTitle";
            this.getTitle.Primary = true;
            this.getTitle.Size = new System.Drawing.Size(139, 36);
            this.getTitle.TabIndex = 3;
            this.getTitle.Text = "Get Title of Link";
            this.getTitle.UseVisualStyleBackColor = true;
            this.getTitle.Click += new System.EventHandler(this.GetTitle_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 623);
            this.Controls.Add(this.getTitle);
            this.Controls.Add(this.clearHistory);
            this.Controls.Add(this.copySelected);
            this.Controls.Add(this.listBox1);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private MaterialSkin.Controls.MaterialRaisedButton copySelected;
        private MaterialSkin.Controls.MaterialRaisedButton clearHistory;
        private MaterialSkin.Controls.MaterialRaisedButton getTitle;
    }
}