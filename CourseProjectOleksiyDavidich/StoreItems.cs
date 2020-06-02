using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseProjectOleksiyDavidich.BudgetixDBDataSetTableAdapters;

namespace CourseProjectOleksiyDavidich
{
    public partial class StoreItems : FormBase
    {
        public override BindingSource BindingSource => storeItemsBindingSource;

        public override TableAdapterManager TableAdapterManager => tableAdapterManager;

        public override BudgetixDBDataSet DbDataSet => budgetixDBDataSet;

        public override DataGridView DataGridView => storeItemsDataGridView;

        public override ToolStripButton AddNewButton => bindingNavigatorAddNewItem;

        public override ToolStripButton SaveButton => storeItemsBindingNavigatorSaveItem;

        public StoreItems()
        {
            InitializeComponent();
            HookupEvents();
        }

        protected override void LoadData()
        {
            categoriesTableAdapter.Fill(budgetixDBDataSet.Categories);
            storeItemsTableAdapter.Fill(budgetixDBDataSet.StoreItems);
        }
    }
}
