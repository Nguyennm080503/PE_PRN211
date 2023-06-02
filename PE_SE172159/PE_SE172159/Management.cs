using Microsoft.EntityFrameworkCore;
using Repository.Models;
using Repository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace PE_SE172159
{
    public partial class Management : Form
    {
        BankAccountService bankAccountService;
        BankAccountTypeContext bankAccountTypeContext;
        AccountService accountService;
        public Management()
        {
            InitializeComponent();
            accountService = new AccountService();
            bankAccountService = new BankAccountService();
            var accounts = bankAccountService.GetAll();
            var type = accountService.GetAll();
            boxType.DataSource = new BindingSource() { DataSource = type };
            tableBankAccount.DataSource = new BindingSource() { DataSource = accounts };
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            bankAccountService = new BankAccountService();
            string search = txt_search.Text;
            if (search == "")
            {
                var accounts = bankAccountService.GetAll();
                tableBankAccount.DataSource = new BindingSource() { DataSource = accounts };
                tableBankAccount.Visible = true;
                title.Visible = false;
            }
            else
            {
                var accounts = bankAccountService.GetAllByBranchName(search);
                if (accounts.Count < 1)
                {
                    tableBankAccount.Visible = false;
                    title.Visible = true;
                }
                else
                {
                    tableBankAccount.DataSource = new BindingSource() { DataSource = accounts };
                    tableBankAccount.Visible = true;
                    title.Visible = false;
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string id = txt_accid.Text;
            string name = txt_accname.Text;
            string branch = txt_branch.Text;
            DateTime dateTime = DateTime.Parse(Date.Text);
            string combobox = boxType.Text;
            string typeid = accountService.GetTypeID(combobox);
            Utils utils = new Utils();
            if (utils.CheckAllValidation(id, name, branch) == true)
            {
                BankAccount bankAccount = new BankAccount();
                bankAccount.AccountId = id.ToUpper();
                bankAccount.AccountName = name;
                bankAccount.OpenDate = dateTime;
                bankAccount.BranchName = branch;
                bankAccount.TypeId = typeid;
                bankAccountService.Create(bankAccount);
                accountService = new AccountService();
                bankAccountService = new BankAccountService();
                var accounts = bankAccountService.GetAll();
                var type = accountService.GetAll();
                boxType.DataSource = new BindingSource() { DataSource = type };
                tableBankAccount.DataSource = new BindingSource() { DataSource = accounts };
                MessageBox.Show("Add successfully!!", "Message", MessageBoxButtons.OK);
            }
        }

        private void tableBankAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string search = txt_search.Text;
            var account = bankAccountService.GetAllByBranchName(search)[e.RowIndex];
            txt_accid.Text = account.AccountId;
            txt_accname.Text = account.AccountName;
            txt_branch.Text = account.BranchName;
            Date.Text = account.OpenDate.ToString();
            boxType.Text = account.Type.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bankAccountTypeContext = new BankAccountTypeContext();
            string accountID = txt_accid.Text;
            string accountName = txt_accname.Text;
            string branchName = txt_branch.Text;
            DateTime dateTime = DateTime.Parse(Date.Text);
            string combobox = boxType.Text;
            string typeid = accountService.GetTypeID(combobox);
            DbSet<BankAccount> newBankAccounts = bankAccountTypeContext.Set<BankAccount>();
            var bankAccounts = bankAccountService.GetAllBankAccount();
            if (bankAccounts
                .Any(acc => acc.AccountId == accountID && acc.AccountName == accountName && acc.OpenDate == dateTime && acc.BranchName == branchName && acc.TypeId == typeid) == true)
            {
                BankAccount account = new BankAccount();
                account.AccountId = accountID;
                account.AccountName = accountName;
                account.OpenDate = dateTime;
                account.BranchName = branchName;
                account.TypeId = typeid;
                newBankAccounts.Remove(account);
                bankAccountTypeContext.SaveChanges();
                accountService = new AccountService();
                bankAccountService = new BankAccountService();
                var newaccounts = bankAccountService.GetAll();
                var type = accountService.GetAll();
                boxType.DataSource = new BindingSource() { DataSource = type };
                tableBankAccount.DataSource = new BindingSource() { DataSource = newaccounts };
                MessageBox.Show("Delete successfully!!!!", "Message", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Delete unsuccessfully because some fields do not macth with data", "Message", MessageBoxButtons.OK);
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            bankAccountTypeContext = new BankAccountTypeContext();
            Utils utils = new Utils();
            string accountID = txt_accid.Text;
            string accountName = txt_accname.Text;
            string branchName = txt_branch.Text;
            DateTime dateTime = DateTime.Parse(Date.Text);
            string combobox = boxType.Text;
            string typeid = accountService.GetTypeID(combobox);
            if (utils.CheckAllValidationUpdate(accountID, accountName, branchName) == true)
            {
                BankAccount bankAccount = new BankAccount();
                bankAccount.AccountId = accountID;
                bankAccount.AccountName = accountName;
                bankAccount.OpenDate = dateTime;
                bankAccount.BranchName = branchName;
                bankAccount.TypeId = typeid;
                var tracker = bankAccountTypeContext.Attach(bankAccount);
                tracker.State = EntityState.Modified;
                bankAccountTypeContext.SaveChanges();
                accountService = new AccountService();
                bankAccountService = new BankAccountService();
                var accounts = bankAccountService.GetAll();
                var type = accountService.GetAll();
                boxType.DataSource = new BindingSource() { DataSource = type };
                tableBankAccount.DataSource = new BindingSource() { DataSource = accounts };
                MessageBox.Show("Update successfully!!", "Message", MessageBoxButtons.OK);
            }
        }

        private void tableBankAccount_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            e.Control.Enabled = false;
        }
    }
}
