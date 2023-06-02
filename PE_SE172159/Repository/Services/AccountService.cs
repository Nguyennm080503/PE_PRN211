using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    
    public class AccountService : ContextBase<AccountType>
    {
        public class Type
        {
            public String TypeName { get; set; }
        }

        BankAccountTypeContext bankAccountTypeContext;
        public new List<Type> GetAll()
        {
            return base.GetAll().Select(t => new Type
            {
                TypeName = t.TypeName
            }).ToList();
        }

        public string GetTypeID(string typeName)
        {
            bankAccountTypeContext = new BankAccountTypeContext();
            var accountType = bankAccountTypeContext.AccountTypes.FirstOrDefault(t => t.TypeName == typeName);
            if (accountType != null)
            {
                return accountType.TypeId.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        public string GetTypeName(string typeID)
        {
            bankAccountTypeContext = new BankAccountTypeContext();
            var accountType = bankAccountTypeContext.AccountTypes.FirstOrDefault(t => t.TypeId == typeID);
            if (accountType != null)
            {
                return accountType.TypeName.ToString();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
