using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_IS.Lib
{
    public class Helper
    {
        public void ReloadGrid<T>(DataGridView gridName, List<T> dataSource, List<int> hideCollIdx = null, bool hasTakeAction = false, bool hasReturnAction = false, bool hasOpenAction = false) where T : class
        {
            try
            {
                gridName.DataSource = null;
                gridName.Columns.Clear();
                gridName.DataSource = dataSource;

                if (hideCollIdx != null && hideCollIdx.Count > 0)
                {
                    foreach (int idx in hideCollIdx)
                    {
                        gridName.Columns[idx].Visible = false;
                    }
                }

                if (hasTakeAction)
                {
                    DataGridViewButtonColumn btnTake = new DataGridViewButtonColumn();
                    btnTake.HeaderText = "Actions";
                    btnTake.Name = "btnTake";
                    btnTake.Text = "Take";
                    btnTake.UseColumnTextForButtonValue = true;
                    gridName.Columns.Add(btnTake);
                }
                if (hasReturnAction)
                {
                    DataGridViewButtonColumn btnReturn = new DataGridViewButtonColumn();
                    btnReturn.HeaderText = "Actions";
                    btnReturn.Name = "btnReturn";
                    btnReturn.Text = "Return";
                    btnReturn.UseColumnTextForButtonValue = true;
                    gridName.Columns.Add(btnReturn);
                }
                if (hasOpenAction)
                {
                    DataGridViewButtonColumn btnOpen = new DataGridViewButtonColumn();
                    btnOpen.HeaderText = "Actions";
                    btnOpen.Name = "btnOpen";
                    btnOpen.Text = "Open Review";
                    btnOpen.UseColumnTextForButtonValue = true;
                    gridName.Columns.Add(btnOpen);
                }
            }
            catch { throw; }
        }
        public void ReloadGrid<T>(DataGridView gridName, List<T> dataSource, List<GridAction> gridActions, List<int> hideCollIdx = null) where T : class
        {
            try
            {
                gridName.DataSource = null;
                gridName.Columns.Clear();
                gridName.DataSource = dataSource;

                if (hideCollIdx != null && hideCollIdx.Count > 0)
                {
                    foreach (int idx in hideCollIdx)
                    {
                        gridName.Columns[idx].Visible = false;
                    }
                }
                if (gridActions != null)
                {
                    foreach (GridAction action in gridActions)
                    {
                        DataGridViewButtonColumn btnAction = new DataGridViewButtonColumn();
                        btnAction.HeaderText = "";
                        btnAction.Name = action.Name;
                        btnAction.Text = action.Text;
                        btnAction.UseColumnTextForButtonValue = true;
                        gridName.Columns.Add(btnAction);
                    }
                }
            }
            catch { throw; }
        }

        public void ReloadGrid2<T>(DataGridView gridName, List<T> dataSource, List<int> hideCollIdx = null, bool hasStartAction = false) where T : class
        {
            try
            {
                gridName.DataSource = null;
                gridName.Columns.Clear();
                gridName.DataSource = dataSource;

                if (hideCollIdx != null && hideCollIdx.Count > 0)
                {
                    foreach (int idx in hideCollIdx)
                    {
                        gridName.Columns[idx].Visible = false;
                    }
                }

                if (hasStartAction)
                {
                    DataGridViewButtonColumn btnStart = new DataGridViewButtonColumn();
                    btnStart.HeaderText = "";
                    btnStart.Name = "btnStart";
                    btnStart.Text = "Start";
                    btnStart.UseColumnTextForButtonValue = true;
                    gridName.Columns.Add(btnStart);
                }
            }
            catch { throw; }
        }
        public void ClearForm(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox && ((ComboBox)control).SelectedIndex != -1)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
                else if (control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = 0;
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                else if (control is RichTextBox)
                {
                    ((RichTextBox)control).Clear();
                }
                if (control.HasChildren)
                {
                    ClearForm(control.Controls);
                }
            }
        }
        public class GridAction
        {
            public string Name { get; set; }
            public string Text { get; set; }
        }
    }
}
