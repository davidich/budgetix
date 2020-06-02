namespace CourseProjectOleksiyDavidich
{
    partial class Receipts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipts));
            this.receiptsDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.storesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetixDBDataSet = new CourseProjectOleksiyDavidich.BudgetixDBDataSet();
            this.TotalSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptsTableAdapter = new CourseProjectOleksiyDavidich.BudgetixDBDataSetTableAdapters.ReceiptsTableAdapter();
            this.tableAdapterManager = new CourseProjectOleksiyDavidich.BudgetixDBDataSetTableAdapters.TableAdapterManager();
            this.storesTableAdapter = new CourseProjectOleksiyDavidich.BudgetixDBDataSetTableAdapters.StoresTableAdapter();
            this.openButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetixDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // receiptsDataGridView
            // 
            this.receiptsDataGridView.AllowUserToAddRows = false;
            this.receiptsDataGridView.AllowUserToDeleteRows = false;
            this.receiptsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.receiptsDataGridView.AutoGenerateColumns = false;
            this.receiptsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receiptsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.TotalSum});
            this.receiptsDataGridView.DataSource = this.receiptsBindingSource;
            this.receiptsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.receiptsDataGridView.MultiSelect = false;
            this.receiptsDataGridView.Name = "receiptsDataGridView";
            this.receiptsDataGridView.ReadOnly = true;
            this.receiptsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.receiptsDataGridView.Size = new System.Drawing.Size(776, 397);
            this.receiptsDataGridView.TabIndex = 1;
            this.receiptsDataGridView.DoubleClick += new System.EventHandler(this.receiptsDataGridView_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "No";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PurchaseDatePT";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date / Time";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StoreId";
            this.dataGridViewTextBoxColumn2.DataSource = this.storesBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Store";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Id";
            // 
            // storesBindingSource
            // 
            this.storesBindingSource.AllowNew = false;
            this.storesBindingSource.DataMember = "Stores";
            this.storesBindingSource.DataSource = this.budgetixDBDataSet;
            // 
            // budgetixDBDataSet
            // 
            this.budgetixDBDataSet.DataSetName = "BudgetixDBDataSet";
            this.budgetixDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TotalSum
            // 
            this.TotalSum.DataPropertyName = "TotalSum";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.TotalSum.DefaultCellStyle = dataGridViewCellStyle1;
            this.TotalSum.HeaderText = "Total";
            this.TotalSum.Name = "TotalSum";
            this.TotalSum.ReadOnly = true;
            // 
            // receiptsBindingSource
            // 
            this.receiptsBindingSource.DataMember = "Receipts";
            this.receiptsBindingSource.DataSource = this.budgetixDBDataSet;
            // 
            // receiptsTableAdapter
            // 
            this.receiptsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ReceiptDetailsTableAdapter = null;
            this.tableAdapterManager.StoreItemsTableAdapter = null;
            this.tableAdapterManager.StoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CourseProjectOleksiyDavidich.BudgetixDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // storesTableAdapter
            // 
            this.storesTableAdapter.ClearBeforeFill = true;
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.Location = new System.Drawing.Point(632, 415);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(713, 415);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // Receipts
            // 
            this.AcceptButton = this.openButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.receiptsDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Receipts";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.receiptsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetixDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private BudgetixDBDataSet budgetixDBDataSet;
        private System.Windows.Forms.BindingSource receiptsBindingSource;
        private BudgetixDBDataSetTableAdapters.ReceiptsTableAdapter receiptsTableAdapter;
        private BudgetixDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView receiptsDataGridView;
        private System.Windows.Forms.BindingSource storesBindingSource;
        private BudgetixDBDataSetTableAdapters.StoresTableAdapter storesTableAdapter;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSum;
    }
}