using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseProjectOleksiyDavidich.Managers;
using CourseProjectOleksiyDavidich.Models;
using CourseProjectOleksiyDavidich.Repositories;

namespace CourseProjectOleksiyDavidich
{
    public partial class Receipt : Form
    {
        public Models.Receipt Data { get; }
        private List<StoreItem> _storeItems;

        public Receipt()
        {
            Data = new Models.Receipt
            {
                PurchaseDate = DateTime.Now,
                StoreId = -1,
                Details = new List<ReceiptDetail>()
            };

            InitializeComponent();
        }

        public Receipt(Models.Receipt data)
        {
            Data = data;
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            receiptBindingSource.DataSource = new[] {Data};
            receiptBindingSource.Position = 0;
            FillStores();
            FillCategories();
            FillStoreItems();
            ConfigureLayout();

            receiptDetailsBindingSource.DataSource = Data.Details;

            if (Data.Id == 0)
            {
                addButton_Click(null, null);
            }
        }

        private void ConfigureLayout()
        {
            if (Data.Id > 0 && linkLabel1.Visible)
            {
                linkLabel1.Visible = false;
                storesComboBox.Enabled = false;
                itemDetailsGroupBox.Visible = false;
                receiptDetailsDataGridView.Height += itemDetailsGroupBox.Height;
            }
        }

        private void FillStores()
        {
            List<Store> items = LoadStoresFromDb();

            if (Data.Id == 0)
            {
                items.Insert(0, new Store { Id = -1, Name = "" });
                storesBindingSource.DataSource = items;
            }
            else
            {
                var store = items.Single(i => i.Id == Data.StoreId);
                storesBindingSource.DataSource = new[] {store};
            }
        }

        

        private void FillCategories()
        {
            var data = new List<ItemCategory>
            {
                new ItemCategory {Id = -1, Name = ""}
            };

            foreach (var entry in categoriesTableAdapter.GetData())
            {
                data.Add( new ItemCategory
                {
                    Id = entry.Id,
                    Name = entry.Name
                });
            }

            categoriesBindingSource.DataSource = data;
        }

        private void FillStoreItems()
        {
            _storeItems = LoadStoreItemsFromDb();
            _storeItems.Insert(0, new StoreItem { Id = -1, Title = "" });

            storeItemsBindingSource.DataSource = _storeItems;
            allStoreItemsBindingSource.DataSource = _storeItems;
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedValue == null) 
                return;

            var categoryId = (int) categoryComboBox.SelectedValue;

            var data = _storeItems
                .Where(i => i.CategoryId == categoryId || categoryId == -1)
                .ToList();

            data.Insert(0, new StoreItem { Id = -1, Title = "" });

            storeItemsBindingSource.DataSource = data;

            storeItemsBindingSource.Position = 0;
            storeItemComboBox_SelectedIndexChanged(null, null);
        }

        private void storeItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = storeItemComboBox.SelectedItem as StoreItem;
            unitsLabel.Text = item?.Units;

            receiptDetailsBindingSource.EndEdit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FillStores();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            receiptDetailsBindingSource.AddNew();
            storeItemsBindingSource.Position = 0;
            RefreshLineNumbers();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            receiptDetailsBindingSource.RemoveCurrent();
            RefreshLineNumbers();
        }

        private void RefreshLineNumbers()
        {
            var cnt = 0;
            foreach (var line in Data.Details)
            {
                line.LineNumber = ++cnt;
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            receiptDetailsBindingSource.EndEdit();
        }

        private void numericUpDown_Enter(object sender, EventArgs e)
        {
            var curBox = (NumericUpDown)sender;
            curBox.Select();
            curBox.Select(0, curBox.Text.Length);
            if (MouseButtons == MouseButtons.Left)
            {
                curBox.Tag = true;
            }
        }

        private void numericUpDown_MouseDown(object sender, MouseEventArgs e)
        {
            var curBox = (NumericUpDown)sender;
            if (curBox.Tag != null && (bool)curBox.Tag)
            {
                curBox.Select(0, curBox.Text.Length);
                curBox.Tag = false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        public void Save()
        {
            if (Data.Id > 0) 
                return;

            if (!IsValid())
                return;
            
            var repo = new ReceiptRepository();
            receiptBindingSource.SuspendBinding();
            repo.Save(Data);
            receiptBindingSource.ResumeBinding();
            //receiptBindingSource.EndEdit();
            Text = $"Receipt #{Data.Id}";

            ConfigureLayout();
        }

        public void Print()
        {
            if (!IsValid())
                return;

            var stores = LoadStoresFromDb().ToDictionary(i => i.Id, i => i);
            var items = LoadStoreItemsFromDb().ToDictionary(i => i.Id, i => i);
            var printManager = new PrintManager(Data, stores, items);
            printManager.Print();
        }

        private bool IsValid()
        {
            receiptBindingSource.EndEdit();
            receiptDetailsBindingSource.EndEdit();

            var error = string.Empty;
            if (Data.StoreId == -1)
            {
                error = "Select store, please.";
            }
            else
            {
                foreach (var receiptDetail in Data.Details)
                {
                    if (receiptDetail.StoreItemId < 1)
                    {
                        error = $"Select an item in line #{receiptDetail.LineNumber}, please.";
                        break;
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(error)) 
                return true;

            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private void receiptDetailsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            Print();
        }

        private List<Store> LoadStoresFromDb()
        {
            return storesTableAdapter
                .GetData()
                .Select(i => new Store
                {
                    Id = i.Id,
                    Name = i.Name
                })
                .ToList();
        }

        private List<StoreItem> LoadStoreItemsFromDb()
        {
            return storeItemsTableAdapter
                .GetData()
                .Select(i => new StoreItem
                {
                    Id = i.Id,
                    Title = i.Title,
                    CategoryId = i.CategoryId,
                    Units = i.Units
                })
                .ToList();
        }
    }
}
