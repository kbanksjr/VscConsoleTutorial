namespace Banking.Models;

public class Account
{
    public int AccountNo { get; set; }
    public string Description { get; set; } = string.Empty;
    public decimal Balance { get; set; }

    public bool Deposit(decimal Amount) {
        Balance += Amount;
        return true;
    }

    public bool Withdraw(decimal Amount) {
        if(Amount <= Balance) {
            Balance -= Amount;
            return true;
        } else
        {
            Console.WriteLine($"Insufficient funds, please try another amount");
        }
        return false;
    }

    public bool Transfer(decimal Amount, Account ToAccount) {
        bool success = Withdraw(Amount);
        if(success) {
            success = ToAccount.Deposit(Amount);
        }
        return success;
    }
}
