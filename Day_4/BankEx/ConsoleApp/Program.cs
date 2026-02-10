// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        Customer customer = new Customer { Name = "Amit" };
        customer.OpenAccount();

        Bank bank = new Bank { LoanApplication = "Home Loan" };
        bank.ProcessLoanApplication();

        Account account = new Account { Balance = 5000 };
        account.TransferMoney(1000);
    }
}

