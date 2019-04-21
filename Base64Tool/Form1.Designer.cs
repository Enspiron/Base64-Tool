namespace Base64Tool
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.OG = new System.Windows.Forms.RichTextBox();
            this.v = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Encode = new MaterialSkin.Controls.MaterialRaisedButton();
            this.NEW = new System.Windows.Forms.RichTextBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.copyOutput = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pDC = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pEC = new MaterialSkin.Controls.MaterialRaisedButton();
            this.clearOG = new MaterialSkin.Controls.MaterialRaisedButton();
            this.clearNEW = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // OG
            // 
            this.OG.Location = new System.Drawing.Point(44, 158);
            this.OG.Name = "OG";
            this.OG.Size = new System.Drawing.Size(411, 96);
            this.OG.TabIndex = 0;
            this.OG.Text = "";
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.v.Depth = 0;
            this.v.Icon = null;
            this.v.Location = new System.Drawing.Point(100, 277);
            this.v.MouseState = MaterialSkin.MouseState.HOVER;
            this.v.Name = "v";
            this.v.Primary = true;
            this.v.Size = new System.Drawing.Size(73, 36);
            this.v.TabIndex = 1;
            this.v.Text = "Decode";
            this.v.UseVisualStyleBackColor = true;
            this.v.Click += new System.EventHandler(this.V_Click);
            // 
            // Encode
            // 
            this.Encode.AutoSize = true;
            this.Encode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Encode.Depth = 0;
            this.Encode.Icon = null;
            this.Encode.Location = new System.Drawing.Point(317, 277);
            this.Encode.MouseState = MaterialSkin.MouseState.HOVER;
            this.Encode.Name = "Encode";
            this.Encode.Primary = true;
            this.Encode.Size = new System.Drawing.Size(74, 36);
            this.Encode.TabIndex = 2;
            this.Encode.Text = "Encode";
            this.Encode.UseVisualStyleBackColor = true;
            this.Encode.Click += new System.EventHandler(this.Encode_Click);
            // 
            // NEW
            // 
            this.NEW.Location = new System.Drawing.Point(44, 339);
            this.NEW.Name = "NEW";
            this.NEW.Size = new System.Drawing.Size(411, 96);
            this.NEW.TabIndex = 3;
            this.NEW.Text = "";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(232, 277);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(35, 36);
            this.materialRaisedButton1.TabIndex = 4;
            this.materialRaisedButton1.Text = "↑↓";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.MaterialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(83, 453);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(90, 36);
            this.materialRaisedButton2.TabIndex = 5;
            this.materialRaisedButton2.Text = "Open Link";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.MaterialRaisedButton2_Click);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Icon = null;
            this.materialRaisedButton3.Location = new System.Drawing.Point(335, 453);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(78, 36);
            this.materialRaisedButton3.TabIndex = 6;
            this.materialRaisedButton3.Text = "History";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.MaterialRaisedButton3_Click);
            // 
            // copyOutput
            // 
            this.copyOutput.AutoSize = true;
            this.copyOutput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.copyOutput.Depth = 0;
            this.copyOutput.Icon = null;
            this.copyOutput.Location = new System.Drawing.Point(196, 453);
            this.copyOutput.MouseState = MaterialSkin.MouseState.HOVER;
            this.copyOutput.Name = "copyOutput";
            this.copyOutput.Primary = true;
            this.copyOutput.Size = new System.Drawing.Size(113, 36);
            this.copyOutput.TabIndex = 7;
            this.copyOutput.Text = "Copy Output";
            this.copyOutput.UseVisualStyleBackColor = true;
            this.copyOutput.Click += new System.EventHandler(this.CopyOutput_Click);
            // 
            // pDC
            // 
            this.pDC.AutoSize = true;
            this.pDC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pDC.Depth = 0;
            this.pDC.Icon = null;
            this.pDC.Location = new System.Drawing.Point(44, 106);
            this.pDC.MouseState = MaterialSkin.MouseState.HOVER;
            this.pDC.Name = "pDC";
            this.pDC.Primary = true;
            this.pDC.Size = new System.Drawing.Size(174, 36);
            this.pDC.TabIndex = 8;
            this.pDC.Text = "Paste->Decode->Copy";
            this.pDC.UseVisualStyleBackColor = true;
            this.pDC.Click += new System.EventHandler(this.PDC_Click);
            // 
            // pEC
            // 
            this.pEC.AutoSize = true;
            this.pEC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pEC.Depth = 0;
            this.pEC.Icon = null;
            this.pEC.Location = new System.Drawing.Point(281, 106);
            this.pEC.MouseState = MaterialSkin.MouseState.HOVER;
            this.pEC.Name = "pEC";
            this.pEC.Primary = true;
            this.pEC.Size = new System.Drawing.Size(175, 36);
            this.pEC.TabIndex = 9;
            this.pEC.Text = "Paste->Encode->Copy";
            this.pEC.UseVisualStyleBackColor = true;
            this.pEC.Click += new System.EventHandler(this.PEC_Click);
            // 
            // clearOG
            // 
            this.clearOG.AutoSize = true;
            this.clearOG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearOG.Depth = 0;
            this.clearOG.Icon = null;
            this.clearOG.Location = new System.Drawing.Point(481, 188);
            this.clearOG.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearOG.Name = "clearOG";
            this.clearOG.Primary = true;
            this.clearOG.Size = new System.Drawing.Size(30, 36);
            this.clearOG.TabIndex = 10;
            this.clearOG.Text = "X  ";
            this.clearOG.UseVisualStyleBackColor = true;
            this.clearOG.Click += new System.EventHandler(this.ClearOG_Click);
            // 
            // clearNEW
            // 
            this.clearNEW.AutoSize = true;
            this.clearNEW.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearNEW.Depth = 0;
            this.clearNEW.Icon = null;
            this.clearNEW.Location = new System.Drawing.Point(481, 371);
            this.clearNEW.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearNEW.Name = "clearNEW";
            this.clearNEW.Primary = true;
            this.clearNEW.Size = new System.Drawing.Size(30, 36);
            this.clearNEW.TabIndex = 11;
            this.clearNEW.Text = "X  ";
            this.clearNEW.UseVisualStyleBackColor = true;
            this.clearNEW.Click += new System.EventHandler(this.ClearNEW_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(539, 522);
            this.Controls.Add(this.clearNEW);
            this.Controls.Add(this.clearOG);
            this.Controls.Add(this.pEC);
            this.Controls.Add(this.pDC);
            this.Controls.Add(this.copyOutput);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.NEW);
            this.Controls.Add(this.Encode);
            this.Controls.Add(this.v);
            this.Controls.Add(this.OG);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Base64 Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox OG;
        private MaterialSkin.Controls.MaterialRaisedButton v;
        private MaterialSkin.Controls.MaterialRaisedButton Encode;
        private System.Windows.Forms.RichTextBox NEW;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton copyOutput;
        private MaterialSkin.Controls.MaterialRaisedButton pDC;
        private MaterialSkin.Controls.MaterialRaisedButton pEC;
        private MaterialSkin.Controls.MaterialRaisedButton clearOG;
        private MaterialSkin.Controls.MaterialRaisedButton clearNEW;
    }
}

