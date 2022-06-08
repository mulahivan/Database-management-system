namespace DMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.table_Main = new System.Windows.Forms.DataGridView();
            this.buttonConnnect = new System.Windows.Forms.Button();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxTable = new System.Windows.Forms.TextBox();
            this.labelServer = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelDatabase = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelTable = new System.Windows.Forms.Label();
            this.textBoxForQuery = new System.Windows.Forms.TextBox();
            this.button_Run = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // table_Main
            // 
            this.table_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_Main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_Main.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.table_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Main.Location = new System.Drawing.Point(352, 48);
            this.table_Main.Name = "table_Main";
            this.table_Main.RowHeadersWidth = 51;
            this.table_Main.RowTemplate.Height = 29;
            this.table_Main.Size = new System.Drawing.Size(476, 226);
            this.table_Main.TabIndex = 0;
            // 
            // buttonConnnect
            // 
            this.buttonConnnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonConnnect.Location = new System.Drawing.Point(352, 280);
            this.buttonConnnect.Name = "buttonConnnect";
            this.buttonConnnect.Size = new System.Drawing.Size(94, 29);
            this.buttonConnnect.TabIndex = 1;
            this.buttonConnnect.Text = "Connect";
            this.buttonConnnect.UseVisualStyleBackColor = true;
            this.buttonConnnect.Click += new System.EventHandler(this.buttonConnnect_Click);
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(12, 48);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(186, 27);
            this.textBoxServer.TabIndex = 2;
            this.textBoxServer.Text = "localhost";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(12, 81);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(186, 27);
            this.textBoxUser.TabIndex = 3;
            this.textBoxUser.Text = "root";
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(12, 114);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(186, 27);
            this.textBoxDatabase.TabIndex = 4;
            this.textBoxDatabase.Text = "user";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(12, 147);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(186, 27);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.Text = "19021984";
            // 
            // textBoxTable
            // 
            this.textBoxTable.Location = new System.Drawing.Point(12, 180);
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.Size = new System.Drawing.Size(186, 27);
            this.textBoxTable.TabIndex = 6;
            this.textBoxTable.Text = "chiefs";
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(204, 55);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(50, 20);
            this.labelServer.TabIndex = 7;
            this.labelServer.Text = "Server";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(204, 84);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(38, 20);
            this.labelUser.TabIndex = 8;
            this.labelUser.Text = "User";
            // 
            // labelDatabase
            // 
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.Location = new System.Drawing.Point(204, 117);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new System.Drawing.Size(72, 20);
            this.labelDatabase.TabIndex = 9;
            this.labelDatabase.Text = "Database";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(204, 150);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(70, 20);
            this.labelPassword.TabIndex = 10;
            this.labelPassword.Text = "Password";
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.Location = new System.Drawing.Point(204, 183);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(44, 20);
            this.labelTable.TabIndex = 11;
            this.labelTable.Text = "Table";
            // 
            // textBoxForQuery
            // 
            this.textBoxForQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxForQuery.Location = new System.Drawing.Point(352, 315);
            this.textBoxForQuery.Multiline = true;
            this.textBoxForQuery.Name = "textBoxForQuery";
            this.textBoxForQuery.Size = new System.Drawing.Size(476, 171);
            this.textBoxForQuery.TabIndex = 12;
            // 
            // button_Run
            // 
            this.button_Run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Run.Location = new System.Drawing.Point(452, 280);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(94, 29);
            this.button_Run.TabIndex = 13;
            this.button_Run.Text = "Run";
            this.button_Run.UseVisualStyleBackColor = true;
            this.button_Run.Click += new System.EventHandler(this.button_Run_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 498);
            this.Controls.Add(this.button_Run);
            this.Controls.Add(this.textBoxForQuery);
            this.Controls.Add(this.labelTable);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelDatabase);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelServer);
            this.Controls.Add(this.textBoxTable);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxDatabase);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.textBoxServer);
            this.Controls.Add(this.buttonConnnect);
            this.Controls.Add(this.table_Main);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.table_Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView table_Main;
        private Button buttonConnnect;
        private TextBox textBoxServer;
        private TextBox textBoxUser;
        private TextBox textBoxDatabase;
        private TextBox textBoxPassword;
        private TextBox textBoxTable;
        private Label labelServer;
        private Label labelUser;
        private Label labelDatabase;
        private Label labelPassword;
        private Label labelTable;
        private TextBox textBoxForQuery;
        private Button button_Run;
    }
}