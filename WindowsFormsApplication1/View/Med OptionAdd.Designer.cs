namespace DoctorsHandBook.View
{
    partial class MedOptionAdd
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
            this.btnMedCancel = new System.Windows.Forms.Button();
            this.btnMedSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numUDPeriod = new System.Windows.Forms.NumericUpDown();
            this.R = new System.Windows.Forms.Label();
            this.rtBoxMedDescription = new System.Windows.Forms.RichTextBox();
            this.numUDPortion = new System.Windows.Forms.NumericUpDown();
            this.tBoxMedTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numUDUnit = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numUDinStock = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPortion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDinStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMedCancel
            // 
            this.btnMedCancel.Location = new System.Drawing.Point(12, 311);
            this.btnMedCancel.Name = "btnMedCancel";
            this.btnMedCancel.Size = new System.Drawing.Size(97, 39);
            this.btnMedCancel.TabIndex = 37;
            this.btnMedCancel.Text = "Cancel";
            this.btnMedCancel.UseVisualStyleBackColor = true;
            this.btnMedCancel.Click += new System.EventHandler(this.btnMedCancel_Click);
            // 
            // btnMedSave
            // 
            this.btnMedSave.Location = new System.Drawing.Point(417, 311);
            this.btnMedSave.Name = "btnMedSave";
            this.btnMedSave.Size = new System.Drawing.Size(97, 39);
            this.btnMedSave.TabIndex = 36;
            this.btnMedSave.Text = "Save";
            this.btnMedSave.UseVisualStyleBackColor = true;
            this.btnMedSave.Click += new System.EventHandler(this.buttonMedSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 34);
            this.label6.TabIndex = 35;
            this.label6.Text = "Time\r\nperiod";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Description";
            // 
            // numUDPeriod
            // 
            this.numUDPeriod.Location = new System.Drawing.Point(384, 188);
            this.numUDPeriod.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUDPeriod.Name = "numUDPeriod";
            this.numUDPeriod.Size = new System.Drawing.Size(54, 22);
            this.numUDPeriod.TabIndex = 34;
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Location = new System.Drawing.Point(198, 176);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(56, 34);
            this.R.TabIndex = 33;
            this.R.Text = "Portion\r\nper day";
            // 
            // rtBoxMedDescription
            // 
            this.rtBoxMedDescription.Location = new System.Drawing.Point(142, 66);
            this.rtBoxMedDescription.Name = "rtBoxMedDescription";
            this.rtBoxMedDescription.Size = new System.Drawing.Size(296, 71);
            this.rtBoxMedDescription.TabIndex = 26;
            this.rtBoxMedDescription.Text = "";
            this.rtBoxMedDescription.TextChanged += new System.EventHandler(this.rtBoxMedDescription_TextChanged);
            // 
            // numUDPortion
            // 
            this.numUDPortion.Location = new System.Drawing.Point(260, 188);
            this.numUDPortion.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUDPortion.Name = "numUDPortion";
            this.numUDPortion.Size = new System.Drawing.Size(54, 22);
            this.numUDPortion.TabIndex = 32;
            // 
            // tBoxMedTitle
            // 
            this.tBoxMedTitle.Location = new System.Drawing.Point(142, 28);
            this.tBoxMedTitle.Name = "tBoxMedTitle";
            this.tBoxMedTitle.Size = new System.Drawing.Size(296, 22);
            this.tBoxMedTitle.TabIndex = 23;
            this.tBoxMedTitle.TextChanged += new System.EventHandler(this.textBoxMedTitle_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 34);
            this.label4.TabIndex = 31;
            this.label4.Text = "Quantity\r\n(unit)";
            // 
            // numUDUnit
            // 
            this.numUDUnit.Location = new System.Drawing.Point(121, 188);
            this.numUDUnit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUDUnit.Name = "numUDUnit";
            this.numUDUnit.Size = new System.Drawing.Size(54, 22);
            this.numUDUnit.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Dosage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 34);
            this.label5.TabIndex = 38;
            this.label5.Text = "Units\r\nin stock";
            // 
            // numUDinStock
            // 
            this.numUDinStock.Location = new System.Drawing.Point(121, 245);
            this.numUDinStock.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUDinStock.Name = "numUDinStock";
            this.numUDinStock.Size = new System.Drawing.Size(54, 22);
            this.numUDinStock.TabIndex = 39;
            // 
            // MedOptionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 362);
            this.Controls.Add(this.numUDinStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMedCancel);
            this.Controls.Add(this.btnMedSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numUDPeriod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.R);
            this.Controls.Add(this.rtBoxMedDescription);
            this.Controls.Add(this.numUDPortion);
            this.Controls.Add(this.tBoxMedTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numUDUnit);
            this.Name = "MedOptionAdd";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Med_Options_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPortion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDinStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMedCancel;
        private System.Windows.Forms.Button btnMedSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numUDPeriod;
        private System.Windows.Forms.Label R;
        private System.Windows.Forms.RichTextBox rtBoxMedDescription;
        private System.Windows.Forms.NumericUpDown numUDPortion;
        private System.Windows.Forms.TextBox tBoxMedTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numUDUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numUDinStock;
    }
}