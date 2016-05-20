namespace DoctorsHandBook.View
{
    partial class DiseasesControl
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
            this.buttonDiseaseDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMedEdit = new System.Windows.Forms.Button();
            this.DiseaseDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxSearch = new System.Windows.Forms.ComboBox();
            this.btnDisSearch = new System.Windows.Forms.Button();
            this.tBoxDisSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DiseaseDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDiseaseDelete
            // 
            this.buttonDiseaseDelete.Location = new System.Drawing.Point(156, 12);
            this.buttonDiseaseDelete.Name = "buttonDiseaseDelete";
            this.buttonDiseaseDelete.Size = new System.Drawing.Size(66, 33);
            this.buttonDiseaseDelete.TabIndex = 19;
            this.buttonDiseaseDelete.Text = "Delete";
            this.buttonDiseaseDelete.UseVisualStyleBackColor = true;
            this.buttonDiseaseDelete.Click += new System.EventHandler(this.buttonDiseaseDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 33);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMedEdit
            // 
            this.btnMedEdit.Location = new System.Drawing.Point(84, 12);
            this.btnMedEdit.Name = "btnMedEdit";
            this.btnMedEdit.Size = new System.Drawing.Size(66, 33);
            this.btnMedEdit.TabIndex = 40;
            this.btnMedEdit.Text = "Edit";
            this.btnMedEdit.UseVisualStyleBackColor = true;
            this.btnMedEdit.Click += new System.EventHandler(this.btnMedEdit_Click);
            // 
            // DiseaseDataGrid
            // 
            this.DiseaseDataGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.DiseaseDataGrid.AllowUserToAddRows = false;
            this.DiseaseDataGrid.AllowUserToDeleteRows = false;
            this.DiseaseDataGrid.AllowUserToOrderColumns = true;
            this.DiseaseDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DiseaseDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DiseaseDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiseaseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiseaseDataGrid.Location = new System.Drawing.Point(12, 75);
            this.DiseaseDataGrid.Name = "DiseaseDataGrid";
            this.DiseaseDataGrid.ReadOnly = true;
            this.DiseaseDataGrid.RowTemplate.Height = 24;
            this.DiseaseDataGrid.Size = new System.Drawing.Size(795, 457);
            this.DiseaseDataGrid.TabIndex = 31;
            this.DiseaseDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiseasesDataBase_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Search by:";
            // 
            // cmbBoxSearch
            // 
            this.cmbBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBoxSearch.FormattingEnabled = true;
            this.cmbBoxSearch.Items.AddRange(new object[] {
            "Title",
            "Symptoms",
            "Procedures",
            "Treatment"});
            this.cmbBoxSearch.Location = new System.Drawing.Point(395, 15);
            this.cmbBoxSearch.Name = "cmbBoxSearch";
            this.cmbBoxSearch.Size = new System.Drawing.Size(124, 24);
            this.cmbBoxSearch.TabIndex = 44;
            this.cmbBoxSearch.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSearch_SelectedIndexChanged);
            // 
            // btnDisSearch
            // 
            this.btnDisSearch.Location = new System.Drawing.Point(729, 12);
            this.btnDisSearch.Name = "btnDisSearch";
            this.btnDisSearch.Size = new System.Drawing.Size(66, 33);
            this.btnDisSearch.TabIndex = 43;
            this.btnDisSearch.Text = "Search";
            this.btnDisSearch.UseVisualStyleBackColor = true;
            this.btnDisSearch.Click += new System.EventHandler(this.btnDisSearch_Click);
            // 
            // tBoxDisSearch
            // 
            this.tBoxDisSearch.Location = new System.Drawing.Point(525, 17);
            this.tBoxDisSearch.Name = "tBoxDisSearch";
            this.tBoxDisSearch.Size = new System.Drawing.Size(198, 22);
            this.tBoxDisSearch.TabIndex = 42;
            this.tBoxDisSearch.TextChanged += new System.EventHandler(this.tBoxDisSearch_TextChanged);
            // 
            // DiseasesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxSearch);
            this.Controls.Add(this.btnDisSearch);
            this.Controls.Add(this.tBoxDisSearch);
            this.Controls.Add(this.DiseaseDataGrid);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMedEdit);
            this.Controls.Add(this.buttonDiseaseDelete);
            this.Name = "DiseasesControl";
            this.Text = "Diseases";
            this.Load += new System.EventHandler(this.Diseases_Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DiseaseDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDiseaseDelete;
        private System.Windows.Forms.DataGridView DiseaseDataGrid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMedEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxSearch;
        private System.Windows.Forms.Button btnDisSearch;
        private System.Windows.Forms.TextBox tBoxDisSearch;
    }
}