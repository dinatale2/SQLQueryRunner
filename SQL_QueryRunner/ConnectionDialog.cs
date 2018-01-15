using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SqlUtilities;
using ADODB;

namespace SQL_QueryRunner
{
  public partial class ConnectionDialog : Form
  {
    // not entirely necessary, but this stores information about our current connection
    //    may have some use for this later
    private string m_ConnectionString;
    public string ConnectionString
    {
      get { return m_ConnectionString; }
    }

    public ConnectionDialog()
    {
      InitializeComponent();

      // temporary for testing purposes, saves typing
      tb_timeout.Text = "60";
      tb_address.Text = "localhost\\sqlexpress";
      tb_database.Text = "Test";
      tb_password.Text = "omnom";
      tb_username.Text = "jdinatale";
    }

    private void btn_OK_Click(object sender, EventArgs e)
    {
      if (rb_Sql.Checked)
      {
        // if the address field is blank, dont do anything and alert the user
        if (tb_address.Text == "")
        {
          MessageBox.Show("No Address Specified. Specify an address.");
          this.DialogResult = DialogResult.None;
          return;
        }

        // if the database field is blank, dont do anything and alert the user
        if (tb_database.Text == "")
        {
          MessageBox.Show("No Database Specified. Specify a Database.");
          this.DialogResult = DialogResult.None;
          return;
        }

        // if the timeout field is blank, dont do anything and alert the user
        if (tb_timeout.Text == "")
        {
          MessageBox.Show("No Timeout Specified. Specify a Timeout value.");
          this.DialogResult = DialogResult.None;
          return;
        }
      }
      else
      {
        if (tb_ConnectionString.Text == "")
        {
          MessageBox.Show("No Connection String Specified. Specify a connection string.");
          this.DialogResult = DialogResult.None;
          return;
        }
      }

      try
      {
        String error;
        bool bSuccess = false;

        if (rb_Sql.Checked)
          using (ADOConnection Conn = new ADOConnection(null, tb_address.Text, tb_database.Text, tb_username.Text, tb_password.Text))
          {
            bSuccess = Conn.TestConnection(out error);
            if (bSuccess)
              m_ConnectionString = Conn.ConnectionString;
          }
        else
          using (ADOConnection Conn = new ADOConnection(tb_ConnectionString.Text))
          {
            bSuccess = Conn.TestConnection(out error);
            if (bSuccess)
              m_ConnectionString = tb_ConnectionString.Text;
          }

        if (!bSuccess)
        {
          this.DialogResult = DialogResult.None;
          MessageBox.Show(error);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
        this.DialogResult = DialogResult.None;
        return;
      }
    }

    private void tb_timeout_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsDigit(e.KeyChar) & e.KeyChar != (char)8)
        e.Handled = true;
    }

    private void btn_testconn_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.None;

      if (rb_Sql.Checked)
      {
        if (tb_address.Text == "")
        {
          MessageBox.Show("No Address Specified. Specify an address.");
          return;
        }

        if (tb_database.Text == "")
        {
          MessageBox.Show("No Database Specified. Specify a Database.");
          return;
        }

        if (tb_timeout.Text == "")
        {
          MessageBox.Show("No Timeout Specified. Specify a Timeout value.");
          return;
        }
      }
      else
      {
        if (tb_ConnectionString.Text == "")
        {
          MessageBox.Show("No Connection String Specified. Specify a connection string.");
          return;
        }
      }

      try
      {
        string error;

        if (rb_Sql.Checked)
          using (ADOConnection Conn = new ADOConnection(null, tb_address.Text, tb_database.Text, tb_username.Text, tb_password.Text))
          {
            if (Conn.TestConnection(out error))
              MessageBox.Show("Connection to " + tb_address.Text + "\\" + tb_database.Text + " was successful.");
            else
              MessageBox.Show("Connection to " + tb_address.Text + "\\" + tb_database.Text + " failed. " + error);
          }
        else
          using (ADOConnection Conn = new ADOConnection(tb_ConnectionString.Text))
          {
            if (Conn.TestConnection(out error))
              MessageBox.Show("Connection to " + tb_ConnectionString.Text + " was successful.");
            else
              MessageBox.Show("Connection to " + tb_ConnectionString.Text + " failed. " + error);
          }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error in ConnectionDialog.TestConnection." + ex.Message);
        return;
      }
    }

    private void rb_ConnString_CheckedChanged(object sender, EventArgs e)
    {
      tb_ConnectionString.Enabled = rb_ConnString.Checked;
    }

    private void rb_Sql_CheckedChanged(object sender, EventArgs e)
    {
      tb_database.Enabled = rb_Sql.Checked;
      tb_address.Enabled = rb_Sql.Checked;
      tb_password.Enabled = rb_Sql.Checked;
      tb_timeout.Enabled = rb_Sql.Checked;
      tb_username.Enabled = rb_Sql.Checked;
    }
  }
}
