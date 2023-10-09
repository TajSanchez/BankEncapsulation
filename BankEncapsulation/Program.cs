using BankEncapsulation;
using System.Runtime.CompilerServices;

var userBalance = new BankAccount();
userBalance.Deposit(600);

Console.WriteLine("Hello please type your username");
userBalance.Name = Console.ReadLine();


if (userBalance.Name == "Taj")
{
    Console.WriteLine($"Hello {userBalance.Name}, please type your password");

    userBalance.Password = Console.ReadLine();
}

else if ((userBalance.Name)!= "Taj")
{
    Console.WriteLine("Get out");
}

if (userBalance.Password == "password")
{
    Console.WriteLine($"Hello {userBalance.Name}, as of today October 9th, 2023 your account balance is:");
    Console.WriteLine(userBalance.GetBalance());
}
else if (userBalance.Password != "password")
{
    Console.WriteLine("Get out");
}
