public class Account
{
    public decimal Balance { get; set; }

    public void TransferMoney(decimal amount)
    {
        Balance -= amount;
        Console.WriteLine($"Transferred {amount}. Remaining balance: {Balance}");
    }
}
