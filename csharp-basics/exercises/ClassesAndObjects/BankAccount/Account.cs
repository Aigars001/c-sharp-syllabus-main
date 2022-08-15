using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        public string _userAccountName;
        public decimal _userAccountBalance;
        public string _userAccountDetails;

        public Account(string userAccountName, decimal userAccountBalance)
        {
            _userAccountName = userAccountName;
            _userAccountBalance = userAccountBalance;
        }

        public string ShowUSerDetails()
        {
            var format = $"{Math.Abs(_userAccountBalance):0.00}";
            if (_userAccountBalance < 0)
            {
                return _userAccountDetails = $"{_userAccountName}, -${format}";
            }

            return _userAccountDetails = $"{_userAccountName}, ${format}";
        }
    }
}
