using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployerApp
{
    class Employee
    {
        public Employee()
        {

        }

        public Employee(string name,bool work, int id, int age, float currPay)
        {
            _name = name;
            _work = work;
            _id = id;
            _age = age;
            _currPay = currPay;
        }

        private string _name;
        private bool _work;
        private int _id;
        private int _age;
        private float _currPay;

        public void GiveBonus(float amount)
        {
            if (_work)
            {
                _currPay += amount;
                Console.WriteLine("Good job!!");
            }
            if (!_work)
            {
                Console.WriteLine("DISMISS!");
            }
        }

        public void Show()
        {
            Console.WriteLine($"Name-{_name},ID-{_id},Age-{_age},CurrPay-{_currPay}");
        }

    }
}
