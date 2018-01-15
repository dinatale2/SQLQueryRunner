namespace SQL_QueryRunner
{
  partial class ConnectionDialog
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btn_OK = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.tb_password = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.tb_username = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.tb_database = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.tb_address = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.btn_Cancel = new System.Windows.Forms.Button();
      this.tb_timeout = new System.Windows.Forms.TextBox();
      this.btn_testconn = new System.Windows.Forms.Button();
      this.rb_Sql = new System.Windows.Forms.RadioButton();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.tb_ConnectionString = new System.Windows.Forms.TextBox();
      this.rb_ConnString = new System.Windows.Forms.RadioButton();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btn_OK
      // 
      this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btn_OK.Location = new System.Drawing.Point(31, 236);
      this.btn_OK.Name = "btn_OK";
      this.btn_OK.Size = new System.Drawing.Size(75, 23);
      this.btn_OK.TabIndex = 10;
      this.btn_OK.Text = "OK";
      this.btn_OK.UseVisualStyleBackColor = true;
      this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(18, 198);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(45, 13);
      this.label1.TabIndex = 8;
      this.label1.Text = "Timeout";
      // 
      // tb_password
      // 
      this.tb_password.Location = new System.Drawing.Point(83, 169);
      this.tb_password.Name = "tb_password";
      this.tb_password.Size = new System.Drawing.Size(215, 20);
      this.tb_password.TabIndex = 7;
      this.tb_password.UseSystemPasswordChar = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(18, 172);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Password";
      // 
      // tb_username
      // 
      this.tb_username.Location = new System.Drawing.Point(83, 143);
      this.tb_username.Name = "tb_username";
      this.tb_username.Size = new System.Drawing.Size(215, 20);
      this.tb_username.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(18, 146);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(55, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Username";
      // 
      // tb_database
      // 
      this.tb_database.Location = new System.Drawing.Point(83, 117);
      this.tb_database.Name = "tb_database";
      this.tb_database.Size = new System.Drawing.Size(215, 20);
      this.tb_database.TabIndex = 3;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(18, 120);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(53, 13);
      this.label4.TabIndex = 2;
      this.label4.Text = "Database";
      // 
      // tb_address
      // 
      this.tb_address.Location = new System.Drawing.Point(83, 91);
      this.tb_address.Name = "tb_address";
      this.tb_address.Size = new System.Drawing.Size(215, 20);
      this.tb_address.TabIndex = 1;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(18, 94);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(45, 13);
      this.label5.TabIndex = 0;
      this.label5.Text = "Address";
      // 
      // btn_Cancel
      // 
      this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btn_Cancel.Location = new System.Drawing.Point(112, 236);
      this.btn_Cancel.Name = "btn_Cancel";
      this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
      this.btn_Cancel.TabIndex = 11;
      this.btn_Cancel.Text = "Cancel";
      this.btn_Cancel.UseVisualStyleBackColor = true;
      // 
      // tb_timeout
      // 
      this.tb_timeout.Location = new System.Drawing.Point(83, 198);
      this.tb_timeout.Name = "tb_timeout";
      this.tb_timeout.Size = new System.Drawing.Size(85, 20);
      this.tb_timeout.TabIndex = 9;
      this.tb_timeout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_timeout_KeyPress);
      // 
      // btn_testconn
      // 
      this.btn_testconn.Location = new System.Drawing.Point(193, 236);
      this.btn_testconn.Name = "btn_testconn";
      this.btn_testconn.Size = new System.Drawing.Size(93, 23);
      this.btn_testconn.TabIndex = 12;
      this.btn_testconn.Text = "Test Connection";
      this.btn_testconn.UseVisualStyleBackColor = true;
      this.btn_testconn.Click += new System.EventHandler(this.btn_testconn_Click);
      // 
      // rb_Sql
      // 
      this.rb_Sql.AutoSize = true;
      this.rb_Sql.Checked = true;
      this.rb_Sql.Location = new System.Drawing.Point(6, 68);
      this.rb_Sql.Name = "rb_Sql";
      this.rb_Sql.Size = new System.Drawing.Size(77, 17);
      this.rb_Sql.TabIndex = 13;
      this.rb_Sql.TabStop = true;
      this.rb_Sql.Text = "Sql Server:";
      this.rb_Sql.UseVisualStyleBackColor = true;
      this.rb_Sql.CheckedChanged += new System.EventHandler(this.rb_Sql_CheckedChanged);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.tb_ConnectionString);
      this.groupBox1.Controls.Add(this.rb_ConnString);
      this.groupBox1.Controls.Add(this.tb_address);
      this.groupBox1.Controls.Add(this.rb_Sql);
      this.groupBox1.Controls.Add(this.btn_OK);
      this.groupBox1.Controls.Add(this.btn_testconn);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.tb_timeout);
      this.groupBox1.Controls.Add(this.tb_password);
      this.groupBox1.Controls.Add(this.btn_Cancel);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.tb_username);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.tb_database);
      this.groupBox1.Location = new System.Drawing.Point(12, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(308, 275);
      this.groupBox1.TabIndex = 14;
      this.groupBox1.TabStop = false;
      // 
      // tb_ConnectionString
      // 
      this.tb_ConnectionString.Enabled = false;
      this.tb_ConnectionString.Location = new System.Drawing.Point(21, 42);
      this.tb_ConnectionString.Name = "tb_ConnectionString";
      this.tb_ConnectionString.Size = new System.Drawing.Size(277, 20);
      this.tb_ConnectionString.TabIndex = 15;
      // 
      // rb_ConnString
      // 
      this.rb_ConnString.AutoSize = true;
      this.rb_ConnString.Location = new System.Drawing.Point(6, 19);
      this.rb_ConnString.Name = "rb_ConnString";
      this.rb_ConnString.Size = new System.Drawing.Size(112, 17);
      this.rb_ConnString.TabIndex = 14;
      this.rb_ConnString.TabStop = true;
      this.rb_ConnString.Text = "Connection String:";
      this.rb_ConnString.UseVisualStyleBackColor = true;
      this.rb_ConnString.CheckedChanged += new System.EventHandler(this.rb_ConnString_CheckedChanged);
      // 
      // ConnectionDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btn_Cancel;
      this.ClientSize = new System.Drawing.Size(332, 289);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ConnectionDialog";
      this.Text = "Connection Details";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btn_OK;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tb_password;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tb_username;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tb_database;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox tb_address;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btn_Cancel;
    private System.Windows.Forms.TextBox tb_timeout;
    private System.Windows.Forms.Button btn_testconn;
    private System.Windows.Forms.RadioButton rb_Sql;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox tb_ConnectionString;
    private System.Windows.Forms.RadioButton rb_ConnString;
  }
}