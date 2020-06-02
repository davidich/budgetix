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
    public partial class Stores : FormBase
    {
        public override BindingSource BindingSource => storesBindingSource;

        public override TableAdapterManager TableAdapterManager => tableAdapterManager;

        public override BudgetixDBDataSet DbDataSet => budgetixDBDataSet;

        public override DataGridView DataGridView => storesDataGridView;

        public override ToolStripButton AddNewButton => bindingNavigatorAddNewItem;

        public override ToolStripButton SaveButton => storesBindingNavigatorSaveItem;

        public Stores()
        {
            InitializeComponent();
            HookupEvents();
        }

        protected override void LoadData()
        {
            storesTableAdapter.Fill(budgetixDBDataSet.Stores);

            foreach (DataGridViewRow row in storesDataGridView.Rows)
            {
                ValidatePhoneCell(row.Cells[3]);
            }
        }

        private void storesDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var grid = (DataGridView)sender;
                var row = grid.Rows[e.RowIndex];
                row.Cells[3].Style.Format = "##########";
            }
        }

        private void storesDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var grid = (DataGridView)sender;
                var row = grid.Rows[e.RowIndex];
                row.Cells[3].Style.Format = "(###) ###-####";
            }
        }

        private void storesDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 3)
            {
                var grid = (DataGridView)sender;
                var column = grid.Rows[e.RowIndex];
                var cell = column.Cells[e.ColumnIndex];

                ValidatePhoneCell(cell);
            }
        }

        private static void ValidatePhoneCell(DataGridViewCell cell)
        {
            if (cell.Value != null && cell.Value.ToString().Length != 10)
                cell.ErrorText = "Incorrect value";
            else
                cell.ErrorText = "";
        }

        protected override bool HandleGridDataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                MessageBox.Show(
                    "Please, correct the phone number value. It should have 10 digit without any special charters.",
                    "Phone is incorrect",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return true;
            }

            return false;
        }
    }
}
