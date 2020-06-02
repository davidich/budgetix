namespace CourseProjectOleksiyDavidich
{
    partial class Receipt
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label storeIdLabel;
            System.Windows.Forms.Label purchaseDateUTCLabel;
            System.Windows.Forms.Label storeItemIdLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.unitsLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseDateUTCDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.storeItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeItemsTableAdapter = new CourseProjectOleksiyDavidich.BudgetixDBDataSetTableAdapters.StoreItemsTableAdapter();
            this.storesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storesComboBox = new System.Windows.Forms.ComboBox();
            this.receiptDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreItemId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.allStoreItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.printButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.storeItemComboBox = new System.Windows.Forms.ComboBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.addButton = new System.Windows.Forms.Button();
            this.itemDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new CourseProjectOleksiyDavidich.BudgetixDBDataSetTableAdapters.CategoriesTableAdapter();
            this.storesTableAdapter = new CourseProjectOleksiyDavidich.BudgetixDBDataSetTableAdapters.StoresTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            storeIdLabel = new System.Windows.Forms.Label();
            purchaseDateUTCLabel = new System.Windows.Forms.Label();
            storeItemIdLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allStoreItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDetailsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.itemDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(6, 26);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // storeIdLabel
            // 
            storeIdLabel.AutoSize = true;
            storeIdLabel.Location = new System.Drawing.Point(6, 52);
            storeIdLabel.Name = "storeIdLabel";
            storeIdLabel.Size = new System.Drawing.Size(35, 13);
            storeIdLabel.TabIndex = 3;
            storeIdLabel.Text = "Store:";
            // 
            // purchaseDateUTCLabel
            // 
            purchaseDateUTCLabel.AutoSize = true;
            purchaseDateUTCLabel.Location = new System.Drawing.Point(6, 81);
            purchaseDateUTCLabel.Name = "purchaseDateUTCLabel";
            purchaseDateUTCLabel.Size = new System.Drawing.Size(61, 13);
            purchaseDateUTCLabel.TabIndex = 5;
            purchaseDateUTCLabel.Text = "Date/Time:";
            // 
            // storeItemIdLabel
            // 
            storeItemIdLabel.AutoSize = true;
            storeItemIdLabel.Location = new System.Drawing.Point(7, 49);
            storeItemIdLabel.Name = "storeItemIdLabel";
            storeItemIdLabel.Size = new System.Drawing.Size(30, 13);
            storeItemIdLabel.TabIndex = 16;
            storeItemIdLabel.Text = "Item:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(7, 75);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(49, 13);
            quantityLabel.TabIndex = 18;
            quantityLabel.Text = "Quantity:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(190, 76);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(49, 13);
            unitPriceLabel.TabIndex = 20;
            unitPriceLabel.Text = "Price ($):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 101);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 13);
            label3.TabIndex = 30;
            label3.Text = "Total ($):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(9, 22);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(52, 13);
            label4.TabIndex = 32;
            label4.Text = "Category:";
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(497, 22);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(171, 13);
            label5.TabIndex = 33;
            label5.Text = "(optional, works as a filter for items)";
            // 
            // unitsLabel
            // 
            this.unitsLabel.AutoSize = true;
            this.unitsLabel.Location = new System.Drawing.Point(323, 78);
            this.unitsLabel.Name = "unitsLabel";
            this.unitsLabel.Size = new System.Drawing.Size(0, 13);
            this.unitsLabel.TabIndex = 27;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(71, 23);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataSource = typeof(CourseProjectOleksiyDavidich.Models.Receipt);
            // 
            // purchaseDateUTCDateTimePicker
            // 
            this.purchaseDateUTCDateTimePicker.CustomFormat = "MMM dd, yyyy   hh:mm tt";
            this.purchaseDateUTCDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.receiptBindingSource, "PurchaseDate", true));
            this.purchaseDateUTCDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.purchaseDateUTCDateTimePicker.Location = new System.Drawing.Point(71, 75);
            this.purchaseDateUTCDateTimePicker.Name = "purchaseDateUTCDateTimePicker";
            this.purchaseDateUTCDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.purchaseDateUTCDateTimePicker.TabIndex = 6;
            // 
            // storeItemsBindingSource
            // 
            this.storeItemsBindingSource.DataSource = typeof(CourseProjectOleksiyDavidich.Models.StoreItem);
            // 
            // storeItemsTableAdapter
            // 
            this.storeItemsTableAdapter.ClearBeforeFill = true;
            // 
            // storesBindingSource
            // 
            this.storesBindingSource.DataSource = typeof(CourseProjectOleksiyDavidich.Models.Store);
            // 
            // storesComboBox
            // 
            this.storesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.receiptBindingSource, "StoreId", true));
            this.storesComboBox.DataSource = this.storesBindingSource;
            this.storesComboBox.DisplayMember = "Name";
            this.storesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storesComboBox.FormattingEnabled = true;
            this.storesComboBox.Location = new System.Drawing.Point(71, 48);
            this.storesComboBox.Name = "storesComboBox";
            this.storesComboBox.Size = new System.Drawing.Size(200, 21);
            this.storesComboBox.TabIndex = 12;
            this.storesComboBox.ValueMember = "Id";
            // 
            // receiptDetailsDataGridView
            // 
            this.receiptDetailsDataGridView.AllowUserToAddRows = false;
            this.receiptDetailsDataGridView.AllowUserToDeleteRows = false;
            this.receiptDetailsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.receiptDetailsDataGridView.AutoGenerateColumns = false;
            this.receiptDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receiptDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.StoreItemId,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Total});
            this.receiptDetailsDataGridView.DataSource = this.receiptDetailsBindingSource;
            this.receiptDetailsDataGridView.Location = new System.Drawing.Point(12, 156);
            this.receiptDetailsDataGridView.MultiSelect = false;
            this.receiptDetailsDataGridView.Name = "receiptDetailsDataGridView";
            this.receiptDetailsDataGridView.ReadOnly = true;
            this.receiptDetailsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.receiptDetailsDataGridView.Size = new System.Drawing.Size(688, 287);
            this.receiptDetailsDataGridView.TabIndex = 12;
            this.receiptDetailsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.receiptDetailsDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LineNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "LineNumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // StoreItemId
            // 
            this.StoreItemId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StoreItemId.DataPropertyName = "StoreItemId";
            this.StoreItemId.DataSource = this.allStoreItemsBindingSource;
            this.StoreItemId.DisplayMember = "Title";
            this.StoreItemId.HeaderText = "Title";
            this.StoreItemId.Name = "StoreItemId";
            this.StoreItemId.ReadOnly = true;
            this.StoreItemId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StoreItemId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.StoreItemId.ValueMember = "Id";
            // 
            // allStoreItemsBindingSource
            // 
            this.allStoreItemsBindingSource.DataSource = typeof(CourseProjectOleksiyDavidich.Models.StoreItem);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn5.HeaderText = "Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle2;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // receiptDetailsBindingSource
            // 
            this.receiptDetailsBindingSource.DataSource = typeof(CourseProjectOleksiyDavidich.Models.ReceiptDetail);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.printButton);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.purchaseDateUTCDateTimePicker);
            this.groupBox1.Controls.Add(purchaseDateUTCLabel);
            this.groupBox1.Controls.Add(storeIdLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(this.storesComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 105);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receipt info";
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.printButton.Image = global::CourseProjectOleksiyDavidich.Properties.Resources.icons8_print_16;
            this.printButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printButton.Location = new System.Drawing.Point(589, 53);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(93, 30);
            this.printButton.TabIndex = 1008;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Image = global::CourseProjectOleksiyDavidich.Properties.Resources.icons8_save_16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(589, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 30);
            this.button1.TabIndex = 1007;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(278, 52);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(44, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Refresh";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Purchased items:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.receiptDetailsBindingSource, "Quantity", true));
            this.numericUpDown1.DecimalPlaces = 3;
            this.numericUpDown1.Location = new System.Drawing.Point(62, 73);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1002;
            this.numericUpDown1.ThousandsSeparator = true;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            this.numericUpDown1.Enter += new System.EventHandler(this.numericUpDown_Enter);
            this.numericUpDown1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.numericUpDown_MouseDown);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.receiptDetailsBindingSource, "UnitPrice", true));
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Location = new System.Drawing.Point(245, 74);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(74, 20);
            this.numericUpDown2.TabIndex = 1003;
            this.numericUpDown2.ThousandsSeparator = true;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            this.numericUpDown2.Enter += new System.EventHandler(this.numericUpDown_Enter);
            this.numericUpDown2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.numericUpDown_MouseDown);
            // 
            // storeItemComboBox
            // 
            this.storeItemComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storeItemComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.receiptDetailsBindingSource, "StoreItemId", true));
            this.storeItemComboBox.DataSource = this.storeItemsBindingSource;
            this.storeItemComboBox.DisplayMember = "Title";
            this.storeItemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storeItemComboBox.FormattingEnabled = true;
            this.storeItemComboBox.Location = new System.Drawing.Point(62, 46);
            this.storeItemComboBox.Name = "storeItemComboBox";
            this.storeItemComboBox.Size = new System.Drawing.Size(429, 21);
            this.storeItemComboBox.TabIndex = 1001;
            this.storeItemComboBox.ValueMember = "Id";
            this.storeItemComboBox.SelectedIndexChanged += new System.EventHandler(this.storeItemComboBox_SelectedIndexChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.receiptDetailsBindingSource, "Total", true));
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.Location = new System.Drawing.Point(62, 99);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.ReadOnly = true;
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 1004;
            this.numericUpDown3.ThousandsSeparator = true;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addButton.Image = global::CourseProjectOleksiyDavidich.Properties.Resources.icons8_add_16;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(490, 94);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(93, 30);
            this.addButton.TabIndex = 1005;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // itemDetailsGroupBox
            // 
            this.itemDetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemDetailsGroupBox.Controls.Add(this.removeButton);
            this.itemDetailsGroupBox.Controls.Add(label5);
            this.itemDetailsGroupBox.Controls.Add(label4);
            this.itemDetailsGroupBox.Controls.Add(this.addButton);
            this.itemDetailsGroupBox.Controls.Add(this.categoryComboBox);
            this.itemDetailsGroupBox.Controls.Add(this.storeItemComboBox);
            this.itemDetailsGroupBox.Controls.Add(unitPriceLabel);
            this.itemDetailsGroupBox.Controls.Add(label3);
            this.itemDetailsGroupBox.Controls.Add(quantityLabel);
            this.itemDetailsGroupBox.Controls.Add(this.numericUpDown3);
            this.itemDetailsGroupBox.Controls.Add(storeItemIdLabel);
            this.itemDetailsGroupBox.Controls.Add(this.numericUpDown1);
            this.itemDetailsGroupBox.Controls.Add(this.unitsLabel);
            this.itemDetailsGroupBox.Controls.Add(this.numericUpDown2);
            this.itemDetailsGroupBox.Location = new System.Drawing.Point(12, 449);
            this.itemDetailsGroupBox.Name = "itemDetailsGroupBox";
            this.itemDetailsGroupBox.Size = new System.Drawing.Size(688, 130);
            this.itemDetailsGroupBox.TabIndex = 32;
            this.itemDetailsGroupBox.TabStop = false;
            this.itemDetailsGroupBox.Text = "Item details";
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Image = global::CourseProjectOleksiyDavidich.Properties.Resources.icons8_delete_16;
            this.removeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeButton.Location = new System.Drawing.Point(589, 94);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(93, 30);
            this.removeButton.TabIndex = 1006;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryComboBox.DataSource = this.categoriesBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(62, 19);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(429, 21);
            this.categoryComboBox.TabIndex = 1000;
            this.categoryComboBox.ValueMember = "Id";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataSource = typeof(CourseProjectOleksiyDavidich.Models.ItemCategory);
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // storesTableAdapter
            // 
            this.storesTableAdapter.ClearBeforeFill = true;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 582);
            this.Controls.Add(this.itemDetailsGroupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.receiptDetailsDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allStoreItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDetailsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.itemDetailsGroupBox.ResumeLayout(false);
            this.itemDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker purchaseDateUTCDateTimePicker;
        private System.Windows.Forms.BindingSource storeItemsBindingSource;
        private BudgetixDBDataSetTableAdapters.StoreItemsTableAdapter storeItemsTableAdapter;
        private System.Windows.Forms.BindingSource storesBindingSource;
        private System.Windows.Forms.ComboBox storesComboBox;
        private System.Windows.Forms.DataGridView receiptDetailsDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ComboBox storeItemComboBox;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox itemDetailsGroupBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private BudgetixDBDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.Label unitsLabel;
        private BudgetixDBDataSetTableAdapters.StoresTableAdapter storesTableAdapter;
        private System.Windows.Forms.BindingSource receiptDetailsBindingSource;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private System.Windows.Forms.BindingSource allStoreItemsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn StoreItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button printButton;
    }
}