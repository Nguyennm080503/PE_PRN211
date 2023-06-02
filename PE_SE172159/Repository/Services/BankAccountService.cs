using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class BankAccountService :ContextBase<BankAccount>
    {
        BankAccountTypeContext bankAccountTypeContext;
        DbSet<BankAccount> bankAccounts;
        public class NewBankAccount
        {
            public string AccountId { get; set; }
            public string AccountName { get; set; }
            public DateTime? OpenDate { get; set; }
            public string BranchName { get; set; }
            public string Type { get; set; }
        }
        
        public new List<NewBankAccount> GetAll() 
        { 
            bankAccountTypeContext = new BankAccountTypeContext();
            return base.GetAll().Select(account => new NewBankAccount
            {
                AccountId = account.AccountId, 
                AccountName = account.AccountName, 
                OpenDate = account.OpenDate, 
                BranchName = account.BranchName, 
                Type = bankAccountTypeContext.AccountTypes.FirstOrDefault(t => t.TypeId ==  account.TypeId)?.TypeName
            }).ToList(); 
        }

        public List<NewBankAccount> GetAllByBranchName(string search)
        {
            bankAccountTypeContext = new BankAccountTypeContext();
            return base.GetAll().Where(account => account.BranchName.Contains(search, StringComparison.OrdinalIgnoreCase))
                .Select(account => new  NewBankAccount 
                {
                    AccountId = account.AccountId,
                    AccountName = account.AccountName,
                    OpenDate = account.OpenDate,
                    BranchName = account.BranchName,
                    Type = bankAccountTypeContext.AccountTypes.FirstOrDefault(t => t.TypeId == account.TypeId)?.TypeName
                })
                .ToList();
        }

        public List<BankAccount> GetAllBankAccount()
        {
            return base.GetAll().Select(account => new BankAccount { 
                AccountId = account.AccountId, 
                AccountName = account.AccountName, 
                BranchName = account.BranchName, 
                OpenDate = account.OpenDate, 
                Type = account.Type,
                TypeId = account.TypeId
            }).ToList();
        }
    }
}
