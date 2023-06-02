using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_SE172159
{
    public class Utils
    {
        BankAccountTypeContext bankAccountTypeContext = new BankAccountTypeContext();
        public Boolean CheckAllValidation(string id, string name, string branch)
        {
            Boolean check = false;
            if (id == "" && name == "" && branch == "")
            {
                MessageBox.Show("All fields must not empty!!!!", "Message", MessageBoxButtons.OK);
            }
            else
            {
                if (bankAccountTypeContext.BankAccounts.Any(account => account.AccountId.ToLower() == id.ToLower()))
                {
                    MessageBox.Show("Id had been existed!! Please input id again", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    if (branch.Length < 5 && branch.StartsWith(Char.ToUpper(branch[0])))
                    {
                        MessageBox.Show("Branch Name is greater than 5 characters and begin Branch Name must be a capital character", "Message", MessageBoxButtons.OK);
                    }
                    else
                    {
                        check = true;
                    }
                }
            }
            return check;
        }

        public Boolean CheckAllValidationUpdate(string id, string name, string branch)
        {
            Boolean check = false;
            if (name == "" && branch == "")
            {
                MessageBox.Show("All fields must not empty!!!!", "Message", MessageBoxButtons.OK);
            }
            else
            {
                if (bankAccountTypeContext.BankAccounts.Any(account => account.AccountId.ToLower() == id.ToLower()))
                {
                    if (branch.Length < 5 && branch.StartsWith(Char.ToUpper(branch[0])))
                    {
                        MessageBox.Show("Branch Name is greater than 5 characters and begin Branch Name must be a capital character", "Message", MessageBoxButtons.OK);
                    }
                    else
                    {
                        check = true;
                    }
                }
                else
                {
                    MessageBox.Show("Do not have any Id in data to update", "Message", MessageBoxButtons.OK);
                }
            }
            return check;
        }
    }
}
