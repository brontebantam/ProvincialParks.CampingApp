using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using ProvincialParks.CampingApp.Infrastructure.Interfaces;
using System.Reflection;
namespace ProvincialParks.CampingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var expenseCalculator = kernel.Get<IExpenseCalculator>();

            Console.WriteLine("Enter Filename");
            var lineRead = Console.ReadLine();
            if (!string.IsNullOrEmpty(lineRead))
            {
                expenseCalculator.CalculateExpenses(lineRead);
            }
            else
            {
                Console.WriteLine("Filename Entered Invalid");
            }
        }
    }
}
