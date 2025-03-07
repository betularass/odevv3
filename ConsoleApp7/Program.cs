using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{ }






/*
                      // 1.soru
    {
    
   class Employee
           {
              public int Id { get; set; }
               public string Name { get; set; }
               public decimal Salary { get; set; }
               public string Department { get; set; }

               public Employee(int id, string name, decimal salary, string department)
               {
                   Id = id;
                   Name = name;
                   Salary = salary;
                   Department = department;
               }

               public virtual decimal CalculateBonus()
               {
                   return 0; // Varsayılan olarak bonus yoktur.
               }

               public override string ToString()
               {
                   return $"ID: {Id}, Name: {Name}, Salary: {Salary:C}, Department: {Department}";
               }
           }

           class Manager : Employee
           {
               public int TeamSize { get; set; }

               public Manager(int id, string name, decimal salary, string department, int teamSize)
                   : base(id, name, salary, department)
               {
                   TeamSize = teamSize;
               }

               public override decimal CalculateBonus()
               {
                   return Salary * 0.20m; 
               }

               public override string ToString()
               {
                   return base.ToString() + $", Team Size: {TeamSize}, Bonus: {CalculateBonus():C}";
               }
           }

           class Developer : Employee
           {
               public string About { get; set; }

               public Developer(int id, string name, decimal salary, string department, string about)
                   : base(id, name, salary, department)
               {
                   About = about;
               }

               public override decimal CalculateBonus()
               {
                   return Salary * 0.10m; // Maaşın %10'u prim olarak eklenir
               }

               public override string ToString()
               {
                   return base.ToString() + $", About: {About}, Bonus: {CalculateBonus():C}";
               }
           }

           class Program
           {
               static void Main()
               {
                   Manager manager = new Manager(1, "Ahmet Yılmaz", 50000, "IT", 10);
                   Developer developer = new Developer(2, "Zeynep Kaya", 40000, "IT", "Full Stack Developer");

                   Console.WriteLine(manager);
                   Console.WriteLine(developer); */



                    //2.soru


    /*
    using System;

    class BankAccount
    {
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accountHolder, decimal balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public virtual void CalculateInterest()
        {
            // Virtual metod, alt sınıflarda override edilecek
        }

        public override string ToString()
        {
            return $"Account Holder: {AccountHolder}, Balance: {Balance:C}";
        }
    }

    class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountHolder, decimal balance)
            : base(accountHolder, balance) { }

        public override void CalculateInterest()
        {
            decimal interest = Balance * 0.05m; // %5 faiz hesaplanıyor
            Console.WriteLine($"Interest for {AccountHolder}: {interest:C}");
        }
    }

    class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountHolder, decimal balance)
            : base(accountHolder, balance) { }

        public override void CalculateInterest()
        {
            Console.WriteLine($"Checking accounts do not earn interest.");
        }
    }

    class Program
    {
        static void Main()
        {
            BankAccount savings = new SavingsAccount("Ahmet Yılmaz", 10000);
            BankAccount checking = new CheckingAccount("Zeynep Kaya", 5000);

            Console.WriteLine(savings);
            savings.CalculateInterest();

            Console.WriteLine(checking);
            checking.CalculateInterest();
        }
    }

}
    */
