using System;
using heranca.Entities;

namespace heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Aula de Upcasting e Downcasting

               Account acc = new Account(1001, "Alex", 0);

               BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0, 500);

               // Upcasting

               Account acc1 = bacc;
               Account acc2 = new BusinessAccount(1003, "Bob", 0, 200);
               Account acc3 = new SavingAccount(1004, "Anna", 0, 0.01);

               // Downcasting - Operação insegura

               BusinessAccount acc4 = (BusinessAccount)acc2; // Casting
               acc4.Loan(100);

               // BusinessAccount acc5 = (BusinessAccount)acc3;
               if (acc3 is BusinessAccount)
               {
                   // Formas de se realizar o casting:
                   // 1 - BusinessAccount acc5 = (BusinessAccount)acc3;
                   BusinessAccount acc5 = acc3 as BusinessAccount; // 2
                   acc5.Loan(200);
                   Console.WriteLine("LOAN!!!");
               }

               if (acc3 is SavingAccount)
               {
                   // SavingAccount acc5 = (SavingAccount)acc3;
                   SavingAccount acc5 = acc3 as SavingAccount;
                   acc5.UpdateBalance();
                   Console.WriteLine("UPDATE!!");
               }
            */
            Account acc1 = new Account(1001, "Alex", 500);
            Account acc2 = new SavingAccount(1002, "Anna", 500, 0.01);

            acc1.WithDraw(10);
            acc2.WithDraw(10);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

        }
    }
}
