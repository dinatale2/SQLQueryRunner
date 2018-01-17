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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_testconn = new System.Windows.Forms.Button();
            this.rb_Sql = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_ConnString = new System.Windows.Forms.RadioButton();
            this.tb_ConnectionString = new CustomControls.CuedTextbox();
            this.tb_address = new CustomControls.CuedTextbox();
            this.tb_timeout = new CustomControls.CuedTextbox();
            this.tb_password = new CustomControls.CuedTextbox();
            this.tb_username = new CustomControls.CuedTextbox();
            this.tb_database = new CustomControls.CuedTextbox();
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
            this.groupBox1.Controls.Add(this.tb_timeout);
            this.groupBox1.Controls.Add(this.tb_password);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.tb_username);
            this.groupBox1.Controls.Add(this.tb_database);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 275);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
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
            // tb_ConnectionString
            // 
            this.tb_ConnectionString.BackColor = System.Drawing.Color.White;
            this.tb_ConnectionString.CueOnFocus = false;
            this.tb_ConnectionString.CueText = "Connection String";
            this.tb_ConnectionString.Enabled = false;
            this.tb_ConnectionString.FocusBackColor = System.Drawing.SystemColors.Info;
            this.tb_ConnectionString.FocusForeColor = System.Drawing.Color.Black;
            this.tb_ConnectionString.ForeColor = System.Drawing.Color.Black;
            this.tb_ConnectionString.Location = new System.Drawing.Point(21, 42);
            this.tb_ConnectionString.MouseOverBackColor = System.Drawing.SystemColors.Info;
            this.tb_ConnectionString.MouseOverForeColor = System.Drawing.Color.Black;
            this.tb_ConnectionString.Name = "tb_ConnectionString";
            this.tb_ConnectionString.Size = new System.Drawing.Size(277, 20);
            this.tb_ConnectionString.StandBackColor = System.Drawing.Color.White;
            this.tb_ConnectionString.StandForeColor = System.Drawing.Color.Black;
            this.tb_ConnectionString.TabIndex = 15;
            // 
            // tb_address
            // 
            this.tb_address.BackColor = System.Drawing.Color.White;
            this.tb_address.CueOnFocus = false;
            this.tb_address.CueText = "Address";
            this.tb_address.FocusBackColor = System.Drawing.SystemColors.Info;
            this.tb_address.FocusForeColor = System.Drawing.Color.Black;
            this.tb_address.ForeColor = System.Drawing.Color.Black;
            this.tb_address.Location = new System.Drawing.Point(21, 91);
            this.tb_address.MouseOverBackColor = System.Drawing.SystemColors.Info;
            this.tb_address.MouseOverForeColor = System.Drawing.Color.Black;
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(277, 20);
            this.tb_address.StandBackColor = System.Drawing.Color.White;
            this.tb_address.StandForeColor = System.Drawing.Color.Black;
            this.tb_address.TabIndex = 1;
            // 
            // tb_timeout
            // 
            this.tb_timeout.BackColor = System.Drawing.Color.White;
            this.tb_timeout.CueOnFocus = false;
            this.tb_timeout.CueText = "Timeout";
            this.tb_timeout.FocusBackColor = System.Drawing.SystemColors.Info;
            this.tb_timeout.FocusForeColor = System.Drawing.Color.Black;
            this.tb_timeout.ForeColor = System.Drawing.Color.Black;
            this.tb_timeout.Location = new System.Drawing.Point(21, 198);
            this.tb_timeout.MouseOverBackColor = System.Drawing.SystemColors.Info;
            this.tb_timeout.MouseOverForeColor = System.Drawing.Color.Black;
            this.tb_timeout.Name = "tb_timeout";
            this.tb_timeout.Size = new System.Drawing.Size(85, 20);
            this.tb_timeout.StandBackColor = System.Drawing.Color.White;
            this.tb_timeout.StandForeColor = System.Drawing.Color.Black;
            this.tb_timeout.TabIndex = 9;
            this.tb_timeout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_timeout_KeyPress);
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.White;
            this.tb_password.CueOnFocus = false;
            this.tb_password.CueText = "Password";
            this.tb_password.FocusBackColor = System.Drawing.SystemColors.Info;
            this.tb_password.FocusForeColor = System.Drawing.Color.Black;
            this.tb_password.ForeColor = System.Drawing.Color.Black;
            this.tb_password.Location = new System.Drawing.Point(21, 169);
            this.tb_password.MouseOverBackColor = System.Drawing.SystemColors.Info;
            this.tb_password.MouseOverForeColor = System.Drawing.Color.Black;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(277, 20);
            this.tb_password.StandBackColor = System.Drawing.Color.White;
            this.tb_password.StandForeColor = System.Drawing.Color.Black;
            this.tb_password.TabIndex = 7;
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.White;
            this.tb_username.CueOnFocus = false;
            this.tb_username.CueText = "Username";
            this.tb_username.FocusBackColor = System.Drawing.SystemColors.Info;
            this.tb_username.FocusForeColor = System.Drawing.Color.Black;
            this.tb_username.ForeColor = System.Drawing.Color.Black;
            this.tb_username.Location = new System.Drawing.Point(21, 143);
            this.tb_username.MouseOverBackColor = System.Drawing.SystemColors.Info;
            this.tb_username.MouseOverForeColor = System.Drawing.Color.Black;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(277, 20);
            this.tb_username.StandBackColor = System.Drawing.Color.White;
            this.tb_username.StandForeColor = System.Drawing.Color.Black;
            this.tb_username.TabIndex = 5;
            // 
            // tb_database
            // 
            this.tb_database.BackColor = System.Drawing.Color.White;
            this.tb_database.CueOnFocus = false;
            this.tb_database.CueText = "Database";
            this.tb_database.FocusBackColor = System.Drawing.SystemColors.Info;
            this.tb_database.FocusForeColor = System.Drawing.Color.Black;
            this.tb_database.ForeColor = System.Drawing.Color.Black;
            this.tb_database.Location = new System.Drawing.Point(21, 117);
            this.tb_database.MouseOverBackColor = System.Drawing.SystemColors.Info;
            this.tb_database.MouseOverForeColor = System.Drawing.Color.Black;
            this.tb_database.Name = "tb_database";
            this.tb_database.Size = new System.Drawing.Size(277, 20);
            this.tb_database.StandBackColor = System.Drawing.Color.White;
            this.tb_database.StandForeColor = System.Drawing.Color.Black;
            this.tb_database.TabIndex = 3;
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
    private CustomControls.CuedTextbox tb_username;
    private CustomControls.CuedTextbox tb_database;
    private CustomControls.CuedTextbox tb_address;
    private System.Windows.Forms.Button btn_Cancel;
    private CustomControls.CuedTextbox tb_timeout;
    private System.Windows.Forms.Button btn_testconn;
    private System.Windows.Forms.RadioButton rb_Sql;
    private System.Windows.Forms.GroupBox groupBox1;
    private CustomControls.CuedTextbox tb_ConnectionString;
    private System.Windows.Forms.RadioButton rb_ConnString;
        private CustomControls.CuedTextbox tb_password;
    }
}