using System;

namespace ProgChallenge
{
    class SavingsAcct : Acct
    {
        

        public SavingsAcct(string firstname, string lastname, decimal interestrate, decimal initialbalance)
            : base(firstname, lastname, initialbalance)
        {
            InterestRate = interestrate;
        }

        public decimal InterestRate
        {
            get; set;
        }

        public void ApplyInterest() {
            Balance *= 1+InterestRate;
        }
        public void Withdraw(decimal withdrawal)
        {
            if (Balance < withdrawal)
            {
                Console.WriteLine($"Attempt to overdraw savings - denied (Balance: {Balance}, Requested Amount: {withdrawal}).");
            }
            else if (WithdrawalCounter > 3 & ((Balance - 2.00m) < withdrawal))  {
                Console.WriteLine($"Attempt to overdraw savings - denied (Balance: {Balance}, Requested Amount + 2$Fee: {withdrawal + 2.0m}).");
            }
            else
            {
                Balance -= withdrawal;
                WithdrawalCounter++;
                if (WithdrawalCounter > 3)
                {
                    Balance -= 2.00m;
                }
            }
        }
    }
}