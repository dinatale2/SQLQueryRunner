using System;
using System.Windows.Forms;

//TODO: Finish Exception handling

namespace SQL_QueryRunner
{
    internal struct ThreadObj
    {
        public string ConnectionString;
        public string Query;
    }

    public partial class MainForm : Form
    {
        private uint tabCount;

        public MainForm()
        {
            InitializeComponent();

            // show the main form
            this.Show();
        }

        void AddTab()
        {
            AddTab(string.Format("newSQL{0}", ++tabCount));
        }

        void AddTab(string tabName)
        {
            TabPage t = new TabPage(tabName);
            t.Controls.Add(new SQLControl() { Dock = DockStyle.Fill });
            tabQueries.TabPages.Add(t);
            tabQueries.SelectedTab = t;
        }

        private SQLControl GetCurrentSqlControl()
        {
            TabPage t = tabQueries.SelectedTab;

            if (t == null)
                return null;

            if (!(t.Controls[0] is SQLControl))
                return null;

            return (SQLControl)t.Controls[0];
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLControl c = GetCurrentSqlControl();

            if (c == null)
                return;

            if (!c.GetConnection())
                DisableInput();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Grab the active control
            Control ActControl = (Control)ActiveControl;

            if (ActControl is SQLControl)
                ((SQLControl)ActControl).Paste();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Grab the active control
            Control ActControl = (Control)ActiveControl;

            if (ActControl is SQLControl)
                ((SQLControl)ActControl).Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Grab the active control
            Control ActControl = (Control)ActiveControl;

            if (ActControl is SQLControl)
                ((SQLControl)ActControl).Cut();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Grab the active control
            Control ActControl = (Control)ActiveControl;

            if (ActControl is SQLControl)
                ((SQLControl)ActControl).Undo();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Grab the active control
            Control ActControl = (Control)ActiveControl;

            if (ActControl is SQLControl)
                ((SQLControl)ActControl).SelectAll();
        }

        private void runSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Grab the active control
            Control ActControl = (Control)ActiveControl;

            if (ActControl is SQLControl)
                ((SQLControl)ActControl).RunSQL();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab();

            SQLControl c = GetCurrentSqlControl();

            if (c == null)
                return;

            if (!c.GetConnection())
                DisableInput();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Grab the active control
            Control ActControl = (Control)ActiveControl;

            if (ActControl is SQLControl)
                ((SQLControl)ActControl).Redo();
        }

        private void SetUpForm(bool EnableInput)
        {
            connectToolStripMenuItem.Enabled = EnableInput;
            runSQLToolStripMenuItem.Enabled = EnableInput;
        }

        private void DisableInput()
        {
            runSQLToolStripMenuItem.Enabled = false;
        }

        private void QueryTabSelected(object sender, TabControlEventArgs e)
        {
            SQLControl c = GetCurrentSqlControl();

            if (c == null)
                return;

            if (!c.Connected)
            {
                DisableInput();
                return;
            }

            SetUpForm(!c.QueryRunning);
        }

        private void onShown(object sender, EventArgs e)
        {
            AddTab();

            SQLControl c = GetCurrentSqlControl();

            if (c == null)
                return;

            if (!c.GetConnection())
                DisableInput();
        }
    }
}