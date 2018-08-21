namespace Home_Rent_System
{
    partial class Admin_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textUserid = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textContactNo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textUsertype = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonInsert = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonDelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonUpdate = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonLogOut = new MaterialSkin.Controls.MaterialFlatButton();
            this.textSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 398);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(861, 300);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // textName
            // 
            this.textName.Depth = 0;
            this.textName.Hint = "";
            this.textName.Location = new System.Drawing.Point(203, 130);
            this.textName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textName.Name = "textName";
            this.textName.PasswordChar = '\0';
            this.textName.SelectedText = "";
            this.textName.SelectionLength = 0;
            this.textName.SelectionStart = 0;
            this.textName.Size = new System.Drawing.Size(459, 28);
            this.textName.TabIndex = 20;
            this.textName.UseSystemPasswordChar = false;
            // 
            // textPassword
            // 
            this.textPassword.Depth = 0;
            this.textPassword.Hint = "";
            this.textPassword.Location = new System.Drawing.Point(203, 181);
            this.textPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '\0';
            this.textPassword.SelectedText = "";
            this.textPassword.SelectionLength = 0;
            this.textPassword.SelectionStart = 0;
            this.textPassword.Size = new System.Drawing.Size(459, 28);
            this.textPassword.TabIndex = 21;
            this.textPassword.UseSystemPasswordChar = false;
            // 
            // textUserid
            // 
            this.textUserid.Depth = 0;
            this.textUserid.Hint = "";
            this.textUserid.Location = new System.Drawing.Point(203, 243);
            this.textUserid.MouseState = MaterialSkin.MouseState.HOVER;
            this.textUserid.Name = "textUserid";
            this.textUserid.PasswordChar = '\0';
            this.textUserid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textUserid.SelectedText = "";
            this.textUserid.SelectionLength = 0;
            this.textUserid.SelectionStart = 0;
            this.textUserid.Size = new System.Drawing.Size(459, 28);
            this.textUserid.TabIndex = 22;
            this.textUserid.UseSystemPasswordChar = false;
            // 
            // textContactNo
            // 
            this.textContactNo.Depth = 0;
            this.textContactNo.Hint = "";
            this.textContactNo.Location = new System.Drawing.Point(203, 295);
            this.textContactNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.textContactNo.Name = "textContactNo";
            this.textContactNo.PasswordChar = '\0';
            this.textContactNo.SelectedText = "";
            this.textContactNo.SelectionLength = 0;
            this.textContactNo.SelectionStart = 0;
            this.textContactNo.Size = new System.Drawing.Size(459, 28);
            this.textContactNo.TabIndex = 23;
            this.textContactNo.UseSystemPasswordChar = false;
            // 
            // textUsertype
            // 
            this.textUsertype.Depth = 0;
            this.textUsertype.Hint = "";
            this.textUsertype.Location = new System.Drawing.Point(203, 343);
            this.textUsertype.MouseState = MaterialSkin.MouseState.HOVER;
            this.textUsertype.Name = "textUsertype";
            this.textUsertype.PasswordChar = '\0';
            this.textUsertype.SelectedText = "";
            this.textUsertype.SelectionLength = 0;
            this.textUsertype.SelectionStart = 0;
            this.textUsertype.Size = new System.Drawing.Size(459, 28);
            this.textUsertype.TabIndex = 24;
            this.textUsertype.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 88);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 24);
            this.materialLabel1.TabIndex = 25;
            this.materialLabel1.Text = "Search";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 134);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(61, 24);
            this.materialLabel2.TabIndex = 26;
            this.materialLabel2.Text = "Name";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 185);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(94, 24);
            this.materialLabel3.TabIndex = 27;
            this.materialLabel3.Text = "Password";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 247);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(65, 24);
            this.materialLabel4.TabIndex = 28;
            this.materialLabel4.Text = "UserID";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 299);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(105, 24);
            this.materialLabel5.TabIndex = 29;
            this.materialLabel5.Text = "Contact No";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(12, 347);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(94, 24);
            this.materialLabel6.TabIndex = 30;
            this.materialLabel6.Text = "User Type";
            // 
            // buttonInsert
            // 
            this.buttonInsert.AutoSize = true;
            this.buttonInsert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonInsert.Depth = 0;
            this.buttonInsert.Location = new System.Drawing.Point(897, 398);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonInsert.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Primary = false;
            this.buttonInsert.Size = new System.Drawing.Size(71, 36);
            this.buttonInsert.TabIndex = 31;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click_1);
            // 
            // buttonDelete
            // 
            this.buttonDelete.AutoSize = true;
            this.buttonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDelete.Depth = 0;
            this.buttonDelete.Location = new System.Drawing.Point(993, 398);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Primary = false;
            this.buttonDelete.Size = new System.Drawing.Size(73, 36);
            this.buttonDelete.TabIndex = 32;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCancel.Depth = 0;
            this.buttonCancel.Location = new System.Drawing.Point(897, 475);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Primary = false;
            this.buttonCancel.Size = new System.Drawing.Size(78, 36);
            this.buttonCancel.TabIndex = 33;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AutoSize = true;
            this.buttonUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonUpdate.Depth = 0;
            this.buttonUpdate.Location = new System.Drawing.Point(1104, 398);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Primary = false;
            this.buttonUpdate.Size = new System.Drawing.Size(78, 36);
            this.buttonUpdate.TabIndex = 34;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click_1);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.AutoSize = true;
            this.buttonLogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogOut.BackgroundImage")));
            this.buttonLogOut.Depth = 0;
            this.buttonLogOut.Location = new System.Drawing.Point(1104, 88);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonLogOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Primary = false;
            this.buttonLogOut.Size = new System.Drawing.Size(84, 36);
            this.buttonLogOut.TabIndex = 35;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(203, 88);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(459, 22);
            this.textSearch.TabIndex = 0;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged_1);
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 710);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textUsertype);
            this.Controls.Add(this.textContactNo);
            this.Controls.Add(this.textUserid);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_Form_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textName;
        private MaterialSkin.Controls.MaterialSingleLineTextField textPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField textUserid;
        private MaterialSkin.Controls.MaterialSingleLineTextField textContactNo;
        private MaterialSkin.Controls.MaterialSingleLineTextField textUsertype;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialFlatButton buttonInsert;
        private MaterialSkin.Controls.MaterialFlatButton buttonDelete;
        private MaterialSkin.Controls.MaterialFlatButton buttonCancel;
        private MaterialSkin.Controls.MaterialFlatButton buttonUpdate;
        private MaterialSkin.Controls.MaterialFlatButton buttonLogOut;
        private System.Windows.Forms.TextBox textSearch;
    }
}