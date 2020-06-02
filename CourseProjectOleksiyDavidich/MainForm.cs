using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseProjectOleksiyDavidich.Managers;
using CourseProjectOleksiyDavidich.Repositories;

namespace CourseProjectOleksiyDavidich
{
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Receipt f = new Receipt {MdiParent = this, Text = $"New receipt #{childFormNumber++}"};
            f.Show();
        }

        private void OpenReceipts(object sender, EventArgs e)
        {
            var listForm = new Receipts { StartPosition = FormStartPosition.CenterParent };
            var result = listForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                var repo = new ReceiptRepository();
                var receipt = repo.Load(listForm.SelectedReceiptId);

                var receiptForm = new Receipt(receipt)
                {
                    MdiParent = this, 
                    Text = $"Receipt #{receipt.Id}"
                };
                receiptForm.Show();
                //receiptForm.WindowState = FormWindowState.Maximized;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Categories {StartPosition = FormStartPosition.CenterParent};
            f.ShowDialog();
        }

        private void storesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Stores { StartPosition = FormStartPosition.CenterParent };
            f.ShowDialog();
        }

        private void storesItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new StoreItems { StartPosition = FormStartPosition.CenterParent };
            f.ShowDialog();
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            if (ActiveMdiChild is Receipt tt)
            {
                tt.Save();
            }
        }

        private void OnPrintClick(object sender, EventArgs e)
        {
            if (ActiveMdiChild is Receipt receipt)
            {
                receipt.Print();
            }
        }
    }
}
