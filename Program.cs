using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Ararat Amirjanyan", true, 120, 45, 250000);
            employee.GiveBonus(100000);
            employee.Show();

            Director director = new Director("Soxomon Hakobyan",false,1,25,400000, " Employer's Son", "Red diploma");
            director.GiveBonus(150000);
            director.Show();

            Console.ReadLine();
        }
    }
}
