using System;

namespace ProgChallenge
{
    class Acct
    {
        private string _firstname;
        private string _lastname;
        
        public Acct(string firstname, string lastname, decimal initialbalance, int withdrawalcounter = 0) {
            _firstname = firstname;
            _lastname = lastname;
            Balance = initialbalance;
            WithdrawalCounter = withdrawalcounter;
        }

        public string FirstName {
            get => _firstname;
        }
        public string LastName
        {
            get => _lastname;
        }
        public decimal Balance
        {
            get; set;
        }
        public int WithdrawalCounter {
            get; set;
        }
        public string AccountOwner
        {
            get => $"{_firstname} {_lastname}";
        }

        // Methods
        public virtual void Deposit(decimal deposit) {
            Balance += deposit;
        }
    }
}