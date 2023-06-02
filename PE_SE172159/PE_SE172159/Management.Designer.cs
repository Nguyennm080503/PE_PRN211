namespace PE_SE172159
{
    partial class Management
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
            components = new System.ComponentModel.Container();
            tableBankAccount = new DataGridView();
            btn_search = new Button();
            txt_search = new TextBox();
            title = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_accid = new TextBox();
            txt_accname = new TextBox();
            txt_branch = new TextBox();
            Date = new DateTimePicker();
            boxType = new ComboBox();
            accountTypeBindingSource1 = new BindingSource(components);
            bankAccountBindingSource = new BindingSource(components);
            accountTypeBindingSource = new BindingSource(components);
            btn_add = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            bankAccountBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)tableBankAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountTypeBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bankAccountBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountTypeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bankAccountBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // tableBankAccount
            // 
            tableBankAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableBankAccount.Location = new Point(12, 83);
            tableBankAccount.Name = "tableBankAccount";
            tableBankAccount.RowHeadersWidth = 51;
            tableBankAccount.RowTemplate.Height = 29;
            tableBankAccount.Size = new Size(776, 183);
            tableBankAccount.TabIndex = 0;
            tableBankAccount.CellDoubleClick += tableBankAccount_CellDoubleClick;
            tableBankAccount.EditingControlShowing += tableBankAccount_EditingControlShowing;
            // 
            // btn_search
            // 
            btn_search.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_search.Location = new Point(579, 31);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(175, 29);
            btn_search.TabIndex = 1;
            btn_search.Text = "Search By Branch Name";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(239, 33);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(325, 27);
            txt_search.TabIndex = 2;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(239, 146);
            title.Name = "title";
            title.Size = new Size(309, 22);
            title.TabIndex = 3;
            title.Text = "Do not have any data in your search!!!";
            title.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 285);
            label1.Name = "label1";
            label1.Size = new Size(194, 23);
            label1.TabIndex = 4;
            label1.Text = "Information Account :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 322);
            label2.Name = "label2";
            label2.Size = new Size(106, 22);
            label2.TabIndex = 5;
            label2.Text = "AccountID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 361);
            label3.Name = "label3";
            label3.Size = new Size(137, 22);
            label3.TabIndex = 6;
            label3.Text = "Account Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 403);
            label4.Name = "label4";
            label4.Size = new Size(100, 22);
            label4.TabIndex = 7;
            label4.Text = "OpenDate :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 443);
            label5.Name = "label5";
            label5.Size = new Size(128, 22);
            label5.TabIndex = 8;
            label5.Text = "Branch Name :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(15, 485);
            label6.Name = "label6";
            label6.Size = new Size(111, 22);
            label6.TabIndex = 9;
            label6.Text = "Type Name :";
            // 
            // txt_accid
            // 
            txt_accid.Location = new Point(184, 317);
            txt_accid.Name = "txt_accid";
            txt_accid.Size = new Size(199, 27);
            txt_accid.TabIndex = 10;
            // 
            // txt_accname
            // 
            txt_accname.Location = new Point(184, 356);
            txt_accname.Name = "txt_accname";
            txt_accname.Size = new Size(199, 27);
            txt_accname.TabIndex = 11;
            // 
            // txt_branch
            // 
            txt_branch.Location = new Point(184, 438);
            txt_branch.Name = "txt_branch";
            txt_branch.Size = new Size(199, 27);
            txt_branch.TabIndex = 13;
            // 
            // Date
            // 
            Date.Format = DateTimePickerFormat.Short;
            Date.Location = new Point(184, 398);
            Date.MaxDate = new DateTime(2022, 12, 31, 0, 0, 0, 0);
            Date.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            Date.Name = "Date";
            Date.Size = new Size(126, 27);
            Date.TabIndex = 14;
            Date.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // boxType
            // 
            boxType.DataSource = accountTypeBindingSource1;
            boxType.DisplayMember = "TypeName";
            boxType.FormattingEnabled = true;
            boxType.Location = new Point(184, 483);
            boxType.Name = "boxType";
            boxType.Size = new Size(151, 28);
            boxType.TabIndex = 15;
            boxType.ValueMember = "TypeId";
            // 
            // accountTypeBindingSource1
            // 
            accountTypeBindingSource1.DataSource = typeof(Repository.Models.AccountType);
            // 
            // bankAccountBindingSource
            // 
            bankAccountBindingSource.DataSource = typeof(Repository.Models.BankAccount);
            // 
            // accountTypeBindingSource
            // 
            accountTypeBindingSource.DataSource = typeof(Repository.Models.AccountType);
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.Info;
            btn_add.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.Location = new Point(590, 307);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(114, 44);
            btn_add.TabIndex = 16;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.Info;
            btn_delete.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.Location = new Point(590, 381);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(114, 44);
            btn_delete.TabIndex = 17;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.Info;
            btn_update.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.Location = new Point(590, 460);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(114, 44);
            btn_update.TabIndex = 18;
            btn_update.Text = "UPDATE";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // bankAccountBindingSource1
            // 
            bankAccountBindingSource1.DataSource = typeof(Repository.Models.BankAccount);
            // 
            // Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 611);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(boxType);
            Controls.Add(Date);
            Controls.Add(txt_branch);
            Controls.Add(txt_accname);
            Controls.Add(txt_accid);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(title);
            Controls.Add(txt_search);
            Controls.Add(btn_search);
            Controls.Add(tableBankAccount);
            Name = "Management";
            Text = "Management";
            ((System.ComponentModel.ISupportInitialize)tableBankAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountTypeBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bankAccountBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountTypeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bankAccountBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tableBankAccount;
        private Button btn_search;
        private TextBox txt_search;
        private Label title;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_accid;
        private TextBox txt_accname;
        private TextBox txt_branch;
        private DateTimePicker Date;
        private ComboBox boxType;
        private Button btn_add;
        private Button btn_delete;
        private Button btn_update;
        private BindingSource accountTypeBindingSource;
        private BindingSource bankAccountBindingSource;
        private BindingSource accountTypeBindingSource1;
        private BindingSource bankAccountBindingSource1;
    }
}