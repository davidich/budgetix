 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
 using System.Diagnostics;
 using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProjectOleksiyDavidich
{
    public partial class Receipts : Form
    {
        public int SelectedReceiptId { get; set; }
        public Receipts()
        {
            InitializeComponent();
        }

        private void Receipts_Load(object sender, EventArgs e)
        {
            this.storesTableAdapter.Fill(this.budgetixDBDataSet.Stores);
            this.receiptsTableAdapter.Fill(this.budgetixDBDataSet.Receipts);
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            var selectedRow = receiptsDataGridView.SelectedRows[0];
            SelectedReceiptId = (int) selectedRow.Cells["Id"].Value;
            DialogResult = DialogResult.OK;
        }

        private void receiptsDataGridView_DoubleClick(object sender, EventArgs e)
        {
            openButton_Click(null, null);
        }
    }
}
