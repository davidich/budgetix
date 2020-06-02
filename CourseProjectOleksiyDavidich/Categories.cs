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
    public partial class Categories : FormBase
    {
        public override BindingSource BindingSource => categoriesBindingSource;

        public override TableAdapterManager TableAdapterManager => tableAdapterManager;

        public override BudgetixDBDataSet DbDataSet => budgetixDBDataSet;

        public override DataGridView DataGridView => categoriesDataGridView;

        public override ToolStripButton AddNewButton => bindingNavigatorAddNewItem;

        public override ToolStripButton SaveButton => categoriesBindingNavigatorSaveItem;

        public Categories()
        {
            InitializeComponent();
            HookupEvents();
        }

        protected override void LoadData()
        {
            categoriesTableAdapter.Fill(budgetixDBDataSet.Categories);
        }
    }
}
