using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using CourseProjectOleksiyDavidich.BudgetixDBDataSetTableAdapters;

namespace CourseProjectOleksiyDavidich
{
    /// <summary>
    /// As designer doesn't support abstract base form we have to make all members virtual.
    /// Use RELEASE MODE for easier implementation of all required (abstract) members
    /// </summary>
#if DEBUG
    public class FormBase : Form
    {

        public virtual BindingSource BindingSource { get; }
        public virtual TableAdapterManager TableAdapterManager { get; }
        public virtual BudgetixDBDataSet DbDataSet { get; }
        public virtual DataGridView DataGridView { get; }
        public virtual ToolStripButton AddNewButton { get; }
        public virtual ToolStripButton SaveButton { get; }

        protected virtual void LoadData() { }
#else
    public abstract class FormBase : Form
    {
        public abstract BindingSource BindingSource { get; }
        public abstract TableAdapterManager TableAdapterManager { get; }
        public abstract BudgetixDBDataSet DbDataSet { get; }
        public abstract DataGridView DataGridView { get; }
        public abstract ToolStripButton AddNewButton { get; }
        public abstract ToolStripButton SaveButton { get; }

        protected abstract void LoadData();
#endif

        protected void HookupEvents()
        {
            AddNewButton.Click += (sender, e) =>
            {
                AddNewButton.Enabled = false;
            };

            SaveButton.Click += (sender, e) =>
            {
                Save();
            };
            
            DataGridView.DataError += (sender, e) =>
            {
                if (!HandleGridDataError(sender, e))
                {
                    MessageBox.Show(
                        e.Exception.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                
                e.Cancel = true;
                e.ThrowException = false;
            };

            DataGridView.RowsRemoved += (sender, e) =>
            {
                AddNewButton.Enabled = !DbDataSet.HasChanges();
            };

            Load += (o, args) =>
            {
                LoadData();
            };

            FormClosing += (sender, e) =>
            {
                BindingSource.EndEdit();

                if (!DbDataSet.HasChanges() && AddNewButton.Enabled) 
                    return;

                var result = MessageBox.Show(
                    "You have unsaved changes. Do you want to save them before closing this form?",
                    "Unsaved changes",
                    MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Cancel)
                    e.Cancel = true;
                else if (result == DialogResult.Yes && !this.Save())
                    e.Cancel = true;
            };
        }

        protected bool Save()
        {
            try
            {
                BindingSource.EndEdit();
                TableAdapterManager.UpdateAll(DbDataSet);

                AddNewButton.Enabled = true;

                return true;
            }
            catch (SqlException e)
            {
                if (e.Message.StartsWith("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    MessageBox.Show("You have removed an item which is referenced by other items.\r\nThis action jeopardizes data itegrity, so your changes will be reverted.", "An error has occured.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadData();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "An error has occured.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return false;
        }

        protected virtual bool HandleGridDataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return false;
        }
    }
}