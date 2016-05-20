namespace WindowsFormsApplication1.View
{
    partial class Prescription
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
            this.lblHeaderP = new System.Windows.Forms.Label();
            this.lblHeaderO = new System.Windows.Forms.Label();
            this.lblHeaderD = new System.Windows.Forms.Label();
            this.chLBOut = new System.Windows.Forms.CheckedListBox();
            this.chLBMeds = new System.Windows.Forms.CheckedListBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.brnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrescrSearch = new System.Windows.Forms.Button();
            this.tBoxDiseaseSearch = new System.Windows.Forms.TextBox();
            this.pnlPresc = new System.Windows.Forms.Panel();
            this.lblProced = new System.Windows.Forms.Label();
            this.pnlPresc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeaderP
            // 
            this.lblHeaderP.AutoSize = true;
            this.lblHeaderP.Location = new System.Drawing.Point(492, 54);
            this.lblHeaderP.Name = "lblHeaderP";
            this.lblHeaderP.Size = new System.Drawing.Size(46, 17);
            this.lblHeaderP.TabIndex = 50;
            this.lblHeaderP.Text = "label2";
            this.lblHeaderP.Visible = false;
            // 
            // lblHeaderO
            // 
            this.lblHeaderO.AutoSize = true;
            this.lblHeaderO.Location = new System.Drawing.Point(87, 266);
            this.lblHeaderO.Name = "lblHeaderO";
            this.lblHeaderO.Size = new System.Drawing.Size(46, 17);
            this.lblHeaderO.TabIndex = 49;
            this.lblHeaderO.Text = "label2";
            this.lblHeaderO.Visible = false;
            // 
            // lblHeaderD
            // 
            this.lblHeaderD.AutoSize = true;
            this.lblHeaderD.Location = new System.Drawing.Point(80, 54);
            this.lblHeaderD.Name = "lblHeaderD";
            this.lblHeaderD.Size = new System.Drawing.Size(46, 17);
            this.lblHeaderD.TabIndex = 48;
            this.lblHeaderD.Text = "label2";
            this.lblHeaderD.Visible = false;
            // 
            // chLBOut
            // 
            this.chLBOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chLBOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chLBOut.Enabled = false;
            this.chLBOut.FormattingEnabled = true;
            this.chLBOut.Location = new System.Drawing.Point(19, 300);
            this.chLBOut.Name = "chLBOut";
            this.chLBOut.Size = new System.Drawing.Size(295, 170);
            this.chLBOut.TabIndex = 47;
            // 
            // chLBMeds
            // 
            this.chLBMeds.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chLBMeds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chLBMeds.FormattingEnabled = true;
            this.chLBMeds.Location = new System.Drawing.Point(19, 94);
            this.chLBMeds.Name = "chLBMeds";
            this.chLBMeds.Size = new System.Drawing.Size(295, 153);
            this.chLBMeds.TabIndex = 46;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(385, 8);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(66, 33);
            this.btnPreview.TabIndex = 45;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // brnClear
            // 
            this.brnClear.Location = new System.Drawing.Point(457, 8);
            this.brnClear.Name = "brnClear";
            this.brnClear.Size = new System.Drawing.Size(66, 33);
            this.brnClear.TabIndex = 43;
            this.brnClear.Text = "Clear";
            this.brnClear.UseVisualStyleBackColor = true;
            this.brnClear.Click += new System.EventHandler(this.brnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Prescribe by:";
            // 
            // btnPrescrSearch
            // 
            this.btnPrescrSearch.Location = new System.Drawing.Point(313, 8);
            this.btnPrescrSearch.Name = "btnPrescrSearch";
            this.btnPrescrSearch.Size = new System.Drawing.Size(66, 33);
            this.btnPrescrSearch.TabIndex = 41;
            this.btnPrescrSearch.Text = "Search";
            this.btnPrescrSearch.UseVisualStyleBackColor = true;
            this.btnPrescrSearch.Click += new System.EventHandler(this.btnPrescrSearch_Click);
            // 
            // tBoxDiseaseSearch
            // 
            this.tBoxDiseaseSearch.Location = new System.Drawing.Point(109, 13);
            this.tBoxDiseaseSearch.Name = "tBoxDiseaseSearch";
            this.tBoxDiseaseSearch.Size = new System.Drawing.Size(198, 22);
            this.tBoxDiseaseSearch.TabIndex = 40;
            // 
            // pnlPresc
            // 
            this.pnlPresc.Controls.Add(this.lblProced);
            this.pnlPresc.Location = new System.Drawing.Point(334, 94);
            this.pnlPresc.Name = "pnlPresc";
            this.pnlPresc.Size = new System.Drawing.Size(370, 380);
            this.pnlPresc.TabIndex = 51;
            this.pnlPresc.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblProced
            // 
            this.lblProced.AutoSize = true;
            this.lblProced.Location = new System.Drawing.Point(13, 17);
            this.lblProced.Name = "lblProced";
            this.lblProced.Size = new System.Drawing.Size(46, 17);
            this.lblProced.TabIndex = 0;
            this.lblProced.Text = "label2";
            this.lblProced.Visible = false;
            // 
            // Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 503);
            this.Controls.Add(this.pnlPresc);
            this.Controls.Add(this.lblHeaderP);
            this.Controls.Add(this.lblHeaderO);
            this.Controls.Add(this.lblHeaderD);
            this.Controls.Add(this.chLBOut);
            this.Controls.Add(this.chLBMeds);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.brnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrescrSearch);
            this.Controls.Add(this.tBoxDiseaseSearch);
            this.Name = "Prescription";
            this.Text = "Prescription";
            this.Load += new System.EventHandler(this.Prescription_Load);
            this.pnlPresc.ResumeLayout(false);
            this.pnlPresc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeaderP;
        private System.Windows.Forms.Label lblHeaderO;
        private System.Windows.Forms.Label lblHeaderD;
        private System.Windows.Forms.CheckedListBox chLBOut;
        private System.Windows.Forms.CheckedListBox chLBMeds;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button brnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrescrSearch;
        private System.Windows.Forms.TextBox tBoxDiseaseSearch;
        private System.Windows.Forms.Panel pnlPresc;
        private System.Windows.Forms.Label lblProced;
    }
}