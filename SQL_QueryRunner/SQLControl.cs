using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Runtime.InteropServices;
using SqlUtilities;
using ADODB;

namespace SQL_QueryRunner
{
    public partial class SQLControl : UserControl
    {
        // delegates to point to form functions from a thread
        private delegate void DataTableDelegate(DataTable dt, string message);
        private DataTableDelegate ShowResultsDel;

        private delegate void BoolDelegate(bool arg);
        private BoolDelegate SetUpFormDel;

        private delegate void StringDelegate(string arg);
        private StringDelegate SetMessageDel;

        private delegate void RunThreadDel(ThreadObj obj);

        private delegate void StringBoolDelegate(string arg, bool b);
        private StringBoolDelegate SetResultsDel;

        private delegate void CursorDelegate(Cursor c);
        private CursorDelegate ChangeCursorDel;

        // bool to store whether the user canceled or not and if query is running
        private bool m_bUserCancel;
        private bool m_bQueryRunning;
        private bool m_bConnected;

        ConnectionDialog Condlg;

        public bool QueryRunning { get { return m_bQueryRunning; } }
        public bool Connected { get { return m_bConnected; } }

        public SQLControl()
        {
            InitializeComponent();

            // initialize delegates
            SetResultsDel = new StringBoolDelegate(this.SetMessage);
            ShowResultsDel = new DataTableDelegate(this.ShowResults);
            SetUpFormDel = new BoolDelegate(this.SetUpForm);
            ChangeCursorDel = new CursorDelegate(this.ChangeCursor);
            SetMessageDel = new StringDelegate(this.ShowMessage);

            Condlg = new ConnectionDialog();
            m_bQueryRunning = false;
            m_bConnected = false;
        }

        public void Cut()
        {
            // Grab the active control
            Control ActControl = (Control)ActiveControl;

            // if the active control isnt null and a split container, we need to get the active control
            if (ActControl != null && ActControl is SplitContainer)
            {
                SplitContainer temp = (SplitContainer)ActControl;
                ActControl = (Control)temp.ActiveControl;
            }

            // if the control is not null and a textbox
            if (ActControl != null && ActControl is TextBox)
            {
                // cut the selected text
                TextBox temp = (TextBox)ActControl;
                temp.Cut();
            }
        }

        public void Copy()
        {
            // Grab the active control
            Control ActControl = (Control)ActiveControl;

            // if the active control isnt null and a split container, we need to get the active control
            if (ActControl != null && ActControl is SplitContainer)
            {
                SplitContainer temp = (SplitContainer)ActControl;
                ActControl = (Control)temp.ActiveControl;
            }

            // if the control is not null and a textbox
            if (ActControl != null && ActControl is TextBox)
            {
                // copy the selected text
                TextBox temp = (TextBox)ActControl;
                temp.Copy();
            }
        }

        public void Paste()
        {
            // Grab the active control
            Control ActControl = (Control)ActiveControl;

            // if the active control isnt null and a split container, we need to get the active control
            if (ActControl != null && ActControl is SplitContainer)
            {
                SplitContainer temp = (SplitContainer)ActControl;
                ActControl = (Control)temp.ActiveControl;
            }

            // if the control is not null and a textbox
            if (ActControl != null && ActControl is TextBox)
            {
                // Past the text into the textbox
                TextBox temp = (TextBox)ActControl;
                temp.Paste();
            }
        }

        public void Undo()
        {
            // Grab the active control
            Control ActControl = (Control)ActiveControl;

            // if the active control isnt null and a split container, we need to get the active control
            if (ActControl != null && ActControl is SplitContainer)
            {
                SplitContainer temp = (SplitContainer)ActControl;
                ActControl = (Control)temp.ActiveControl;
            }

            // if the control is not null and a textbox
            if (ActControl != null && ActControl is TextBox)
            {
                // undo the last change
                TextBox temp = (TextBox)ActControl;
                temp.Undo();
            }
        }

        public void Redo()
        {
        }

        public void SelectAll()
        {
            // Grab the active control
            Control ActControl = (Control)ActiveControl;

            // if the active control isnt null and a split container, we need to get the active control
            if (ActControl != null && ActControl is SplitContainer)
            {
                SplitContainer temp = (SplitContainer)ActControl;
                ActControl = (Control)temp.ActiveControl;
            }

            // if the control is not null and a textbox
            if (ActControl != null && ActControl is TextBox)
            {
                // select all text
                TextBox temp = (TextBox)ActControl;
                temp.SelectAll();
            }
        }

        public bool GetConnection()
        {
            // show the dialog and wait for a result
            Condlg = new ConnectionDialog();
            Condlg.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = Condlg.ShowDialog();

            // if the user hit ok, we assume we have a connection
            if (result == DialogResult.OK)
            {
                // set up the form for input
                // clear the message since a residual message from earlier in the session can exist
                SetUpForm(true);
                SetMessage("", false);
                m_bConnected = true;
                return true;
            }

            // otherwise, we didnt get an OK disable the form and display an error message
            DisableInput();
            SetMessage("No Connection Established.", true);
            m_bConnected = false;
            return false;
        }

        public void RunSQL()
        {
            // simply start to execute a SQL command
            StartSQLExec();
        }

        public void DisableInput()
        {
            // disable the queries textbox
            tb_queries.Enabled = false;
        }

        private void SetUpForm(bool EnableInput)
        {
            // set the set the query textbox to EnableInput
            tb_queries.Enabled = EnableInput;

            // set the dgv to the flag also
            dgv_Results.Enabled = EnableInput;
        }

        private void StartSQLExec()
        {
            // if there is no text in the query textbox, do nothing
            if (tb_queries.Text == "")
                return;

            // user hasnt canceled yet, set to false
            m_bUserCancel = false;

            // string for the query
            string query;

            // the datasource for the grid view is no longer valid, throw it away
            dgv_Results.DataSource = null;

            // set the message textbox to have nothing in it
            SetMessage("", false);

            // if the selection length is 0 or less, just take the entire textbox
            if (tb_queries.SelectionLength <= 0)
                query = tb_queries.Text;
            else
                // other wise, take whats selected
                query = tb_queries.SelectedText;

            // set up the form appropriately
            SetUpForm(false);

            ThreadObj ForThread = new ThreadObj();
            ForThread.ConnectionString = Condlg.ConnectionString;
            ForThread.Query = query;

            // start a thread to execute the sql and fill in results
            RunThreadDel RunSql = new RunThreadDel(ExecuteSql);
            RunSql.BeginInvoke(ForThread, null, null);

            m_bQueryRunning = true;
        }

        private void ChangeCursor(Cursor c)
        {
            this.Cursor = c;
        }

        private void ExecuteSql(ThreadObj Param)
        {
            string query = Param.Query;

            // new recordset reference
            ADODB.Recordset Data = null;

            // keep a connection reference
            ADODB.Connection Connect = null;

            try
            {
                // change cursor to wait cursor
                this.Invoke(ChangeCursorDel, new object[] { Cursors.WaitCursor });

                // initialize the message string to be empty
                string Message = "";
                string Warnings = "";

                // keep track of the max number of columns
                int nMaxNumCols = 0;

                // fill in a data table with our results
                DataTable SqlResults = new DataTable();

                // open the connection
                Connect = new Connection();
                Connect.ConnectionString = Param.ConnectionString;
                Connect.CursorLocation = CursorLocationEnum.adUseClient;
                Connect.Open();

                // initialize an object to store the number of records affected
                object obRecsAffected;

                // number of queries returned so far is none
                int nQueriesReturned = 0;

                // construct a command object
                ADODB.Command SqlCmd = new Command();
                SqlCmd.ActiveConnection = Connect;
                SqlCmd.CommandText = (string)query;
                SqlCmd.CommandType = CommandTypeEnum.adCmdText;

                // execute the sql statement
                Data = Connect.Execute((string)query, out obRecsAffected);

                // while there are recordsets
                while (Data != null)
                {
                    // for this query, print out all the errors that occurred
                    foreach (ADODB.Error e in Connect.Errors)
                    {
                        Warnings += e.Description + "\r\n";
                    }

                    // we have another query, increment the count
                    nQueriesReturned++;

                    // if there is something to read (hence the object is not closed)...
                    if ((ADODB.ObjectStateEnum)Data.State != ADODB.ObjectStateEnum.adStateClosed)
                    {
                        // count of rows retrieved
                        int nRowsRecieved = 0;

                        // if this recordset has more columns in it than previous columns
                        for (int i = nMaxNumCols; i < Data.Fields.Count; i++)
                        {
                            // add a column and increment the max col count
                            DataColumn temp = new DataColumn(Data.Fields[i].Name, typeof(string));
                            SqlResults.Columns.Add(temp);
                            nMaxNumCols++;
                        }

                        // grab the current time in ticks
                        long InitialTime = DateTime.Now.Ticks;

                        // while there is stuff in the recordset
                        while (!Data.EOF)
                        {
                            // create a new row
                            DataRow tempRow = SqlResults.NewRow();

                            // fill each column with data
                            for (int i = 0; i < Data.Fields.Count; i++)
                            {
                                tempRow[i] = Data.Fields[i].Value.ToString();
                            }

                            // add it to the results
                            SqlResults.Rows.Add(tempRow);

                            nRowsRecieved++;

                            // if the user didnt cancel, display the record number being loaded, otherwise the user did cancel so stop doing work
                            if (!m_bUserCancel)
                                this.Invoke(SetResultsDel, new object[] { String.Format("Loading Record {0} in Query {1}...", nRowsRecieved, nQueriesReturned), false });
                            else
                            {
                                this.Invoke(SetResultsDel, new object[] { "Canceling... Please wait...", false });
                                break;
                            }

                            // continue to the next record in the recordset
                            Data.MoveNext();
                        }

                        // the time elapsed is the time now minus the initial
                        double TimeElapsed = ((float)(DateTime.Now.Ticks - InitialTime)) / 10000000.0;

                        // add the number of rows returned and how long it took to the messages to display once the results are ready to be displayed
                        Message += nQueriesReturned + ": " + nRowsRecieved + " row(s) returned. " + String.Format("({0:0.0000} seconds)", TimeElapsed) + "\r\n";
                    }
                    else
                    {
                        // otherwise, it was a non action query, so records must have been affected
                        Message += nQueriesReturned + ": " + (int)obRecsAffected + " record(s) affected.\r\n";
                    }

                    // if the user canceled, just return the form to its original state and state that the user canceled
                    if (m_bUserCancel)
                    {
                        this.Invoke(SetUpFormDel, new object[] { true });
                        this.Invoke(ShowResultsDel, new object[] { SqlResults, Message });
                        this.Invoke(SetResultsDel, new object[] { "Loading Was Canceled by User.", true });
                        return;
                    }

                    // try to go to the next recordset
                    try
                    {
                        Data = Data.NextRecordset(out obRecsAffected);
                    }
                    catch (COMException ex)
                    {
                        // if for some reason, the provider doesnt like that, just break out on the first recordset
                        if (ex.ErrorCode == -2146825037)
                        {
                            Data = null;
                        }
                        else
                        {
                            // otherwise, just rethrow our excetion, its a bigger problem
                            throw ex;
                        }
                    }
                }

                this.Invoke(SetMessageDel, new object[] { Warnings.Trim() });

                // after all records have been run through, go ahead and show the results
                this.Invoke(ShowResultsDel, new object[] { SqlResults, Message });
            }
            catch (Exception ex)
            {
                string ErrorText = "";
                if (Connect.Errors.Count > 0)
                {
                    // for this query, print out all the errors that occurred
                    foreach (ADODB.Error e in Connect.Errors)
                    {
                        ErrorText += "Error " + e.Number + ": " + e.Description + "\r\n";
                    }

                    Connect.Errors.Clear();
                }
                else
                {
                    ErrorText = "Error: " + ex.Message;
                }

                // if any exception does happen, dont display results, but print out the error
                this.Invoke(SetResultsDel, new object[] { ErrorText.Trim(), true });
                this.Invoke(SetUpFormDel, new object[] { true });

                // change cursor to default cursor
                this.Invoke(ChangeCursorDel, new object[] { Cursors.Default });
                return;
            }
            finally
            {
                if (Data != null && Data.State != (int)ConnectionState.Closed)
                    Data.Close();
            }
        }

        private void SetMessage(string Message, bool IsError)
        {
            if (IsError)
                tb_Results.BackColor = Color.Tomato;
            else
                tb_Results.BackColor = Color.White;

            tb_Results.Text = Message;
        }

        private void ShowResults(DataTable results, string message)
        {
            // display the datatable that are passed in and set up for the form appropriately
            dgv_Results.DataSource = results;
            SetUpForm(true);

            // set the message to the one passed
            SetMessage(message, false);

            // regardless, reset the user canceled flag
            m_bUserCancel = false;

            // set the cursor back to the original cursor
            this.Cursor = Cursors.Default;

            // put focus on the query textbox
            tb_queries.Focus();

            // query no longer running
            m_bQueryRunning = false;
        }

        private void ShowMessage(string message)
        {
            tb_Messages.Text = message;
        }
    }
}
