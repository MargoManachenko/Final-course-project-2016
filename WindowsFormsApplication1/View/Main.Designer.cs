namespace DoctorsHandBook
{
    partial class Form1
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
            this.Main = new System.Windows.Forms.TabControl();
            this.tabMedications = new System.Windows.Forms.TabPage();
            this.tabDiseases = new System.Windows.Forms.TabPage();
            this.tabPrescriptions = new System.Windows.Forms.TabPage();
            this.Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.Controls.Add(this.tabMedications);
            this.Main.Controls.Add(this.tabDiseases);
            this.Main.Controls.Add(this.tabPrescriptions);
            this.Main.Location = new System.Drawing.Point(0, -1);
            this.Main.Name = "Main";
            this.Main.SelectedIndex = 0;
            this.Main.Size = new System.Drawing.Size(819, 546);
            this.Main.TabIndex = 3;
            // 
            // tabMedications
            // 
            this.tabMedications.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabMedications.Location = new System.Drawing.Point(4, 25);
            this.tabMedications.Name = "tabMedications";
            this.tabMedications.Padding = new System.Windows.Forms.Padding(3);
            this.tabMedications.Size = new System.Drawing.Size(811, 517);
            this.tabMedications.TabIndex = 0;
            this.tabMedications.Text = "Medications";
            // 
            // tabDiseases
            // 
            this.tabDiseases.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabDiseases.Location = new System.Drawing.Point(4, 25);
            this.tabDiseases.Name = "tabDiseases";
            this.tabDiseases.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiseases.Size = new System.Drawing.Size(811, 517);
            this.tabDiseases.TabIndex = 1;
            this.tabDiseases.Text = "Diseases";
            // 
            // tabPrescriptions
            // 
            this.tabPrescriptions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPrescriptions.Location = new System.Drawing.Point(4, 25);
            this.tabPrescriptions.Name = "tabPrescriptions";
            this.tabPrescriptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrescriptions.Size = new System.Drawing.Size(811, 517);
            this.tabPrescriptions.TabIndex = 2;
            this.tabPrescriptions.Text = "Prescription";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 544);
            this.Controls.Add(this.Main);
            this.Name = "Form1";
            this.Text = "Doctor\'s Hand-Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl Main;
        private System.Windows.Forms.TabPage tabMedications;
        private System.Windows.Forms.TabPage tabDiseases;
        private System.Windows.Forms.TabPage tabPrescriptions;
    }
}

