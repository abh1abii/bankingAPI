using System;
namespace BankDemo
{ //Account Implementation 
  class BankAcc
  {
      private double balance = 0;
      public double Bal 
      {
        get { return balance;}
        set { balance = value; }
      }
  }
  //Class containing deposit and withdrawl functions
  class BankingFuctions
  {
      BankAcc accInstance = new BankAcc();
      string name;
      int account;
      double withdraw,dep,toBal;

      //Deposit Function
      public void DepositAcc()
      {
        Console.WriteLine("Enter Name of the depositor :");
        name = Console.ReadLine();
        Console.WriteLine("Enter Account Number  :");
        account = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Deposit Amount :");
        dep = Convert.ToDouble(Console.ReadLine());
        toBal = accInstance.Bal + dep;
        Console.WriteLine("——————————\nName of the depositor : " + name + "\nAccount Number: " + account + "\nTotal Balance amount in the account  : " +toBal);
      }

      //Withdrawl Function
      public void WithdrawAcc()
      {
        Console.WriteLine("Enter Account Name :");
        name = Console.ReadLine();
        Console.WriteLine("Enter Account Number  :");
        account = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Withdraw Amount :");
        withdraw = Convert.ToDouble(Console.ReadLine());
        if (withdraw <= accInstance.Bal)
        {
            toBal = accInstance.Bal - withdraw;
            Console.WriteLine("——————————\n");
            Console.WriteLine("Account Name : " + name);
            Console.WriteLine("Account Number: " + account);
            Console.WriteLine("After Withdraw Amount balnace is : " + toBal);
        }
        else
            Console.WriteLine("\n\nWithdraw Ammount does not Exist your Account.");
      }
  }

  //Driver Class
  class DriverClass
  {
    static void Main(string[] args)
    {
      char agn;
      do
      {
        BankingFuctions userInstance = new BankingFuctions();
        int num;
        Console.WriteLine("Please Select Any Function.\nPress 1 for Deposit an Amount. \nPress 2 for Withdraw an Amount.");
        num = Convert.ToInt32(Console.ReadLine());
        switch (num)
        {
          case 1:
            userInstance.DepositAcc();
            break;
          case 2:
            userInstance.WithdrawAcc();
            break;
          default:
            Console.WriteLine("Invalid Selection!");
            break;
        }
        Console.WriteLine("\nMenu - press y\nExit - press any key");
        agn=Convert.ToChar(Console.ReadLine());
      } while (agn == 'y');
      Console.ReadKey();
    }
  }
} 