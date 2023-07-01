using System;

namespace ProgChallenge
{
    class CheckingAcct : Acct 
    {
        public CheckingAcct(string firstname, string lastname, decimal initialbalance) 
            : base(firstname, lastname, initialbalance) {

        }

        public void Withdraw(decimal withdrawal)
        {
            if (Balance < withdrawal) {
                Balance -= (35.0m + withdrawal);
            } else {
                Balance -= withdrawal;
            }
        }
    }
}
