namespace DoctorsHandBook
{
    partial class MedsControl
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
            this.btnMedEdit = new System.Windows.Forms.Button();
            this.btnMedDelete = new System.Windows.Forms.Button();
            this.MedsDataGrid = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tBoxMedSearch = new System.Windows.Forms.TextBox();
            this.btnMedSearch = new System.Windows.Forms.Button();
            this.cmbBoxSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MedsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMedEdit
            // 
            this.btnMedEdit.Location = new System.Drawing.Point(84, 12);
            this.btnMedEdit.Name = "btnMedEdit";
            this.btnMedEdit.Size = new System.Drawing.Size(66, 33);
            this.btnMedEdit.TabIndex = 11;
            this.btnMedEdit.Text = "Edit";
            this.btnMedEdit.UseVisualStyleBackColor = true;
            this.btnMedEdit.Click += new System.EventHandler(this.buttonMedEdit_Click);
            // 
            // btnMedDelete
            // 
            this.btnMedDelete.Location = new System.Drawing.Point(156, 12);
            this.btnMedDelete.Name = "btnMedDelete";
            this.btnMedDelete.Size = new System.Drawing.Size(66, 33);
            this.btnMedDelete.TabIndex = 10;
            this.btnMedDelete.Text = "Delete";
            this.btnMedDelete.UseVisualStyleBackColor = true;
            this.btnMedDelete.Click += new System.EventHandler(this.buttonMedDelete_Click);
            // 
            // MedsDataGrid
            // 
            this.MedsDataGrid.AllowUserToAddRows = false;
            this.MedsDataGrid.AllowUserToDeleteRows = false;
            this.MedsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MedsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.MedsDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.MedsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MedsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedsDataGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.MedsDataGrid.Location = new System.Drawing.Point(16, 51);
            this.MedsDataGrid.Name = "MedsDataGrid";
            this.MedsDataGrid.ReadOnly = true;
            this.MedsDataGrid.RowTemplate.Height = 24;
            this.MedsDataGrid.Size = new System.Drawing.Size(783, 480);
            this.MedsDataGrid.TabIndex = 9;
            this.MedsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MedsDataBase_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 33);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // tBoxMedSearch
            // 
            this.tBoxMedSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxMedSearch.Location = new System.Drawing.Point(525, 17);
            this.tBoxMedSearch.Name = "tBoxMedSearch";
            this.tBoxMedSearch.Size = new System.Drawing.Size(198, 22);
            this.tBoxMedSearch.TabIndex = 23;
            // 
            // btnMedSearch
            // 
            this.btnMedSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMedSearch.Location = new System.Drawing.Point(729, 12);
            this.btnMedSearch.Name = "btnMedSearch";
            this.btnMedSearch.Size = new System.Drawing.Size(66, 33);
            this.btnMedSearch.TabIndex = 24;
            this.btnMedSearch.Text = "Search";
            this.btnMedSearch.UseVisualStyleBackColor = true;
            this.btnMedSearch.Click += new System.EventHandler(this.btnMedSearch_Click);
            // 
            // cmbBoxSearch
            // 
            this.cmbBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBoxSearch.FormattingEnabled = true;
            this.cmbBoxSearch.Items.AddRange(new object[] {
            "Title",
            "Description"});
            this.cmbBoxSearch.Location = new System.Drawing.Point(395, 17);
            this.cmbBoxSearch.Name = "cmbBoxSearch";
            this.cmbBoxSearch.Size = new System.Drawing.Size(124, 24);
            this.cmbBoxSearch.TabIndex = 26;
            this.cmbBoxSearch.SelectedIndexChanged += new System.EventHandler(this.CmbBoxSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Search by:";
            // 
            // MedsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxSearch);
            this.Controls.Add(this.btnMedSearch);
            this.Controls.Add(this.tBoxMedSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.MedsDataGrid);
            this.Controls.Add(this.btnMedDelete);
            this.Controls.Add(this.btnMedEdit);
            this.MaximizeBox = false;
            this.Name = "MedsControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Medications";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Meds_Control_FormClosing);
            this.Load += new System.EventHandler(this.Meds_Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MedsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView MedsDataGrid;
        private System.Windows.Forms.Button btnMedEdit;
        private System.Windows.Forms.Button btnMedDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tBoxMedSearch;
        private System.Windows.Forms.Button btnMedSearch;
        private System.Windows.Forms.ComboBox cmbBoxSearch;
        private System.Windows.Forms.Label label1;
    }
}