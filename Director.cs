using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployerApp
{
    class Director:Employee
    {
        public Director(string name,bool work,int id, int age, float currPay,string status, string document)
        {
            _name = name;
            _work = work;
            _id = id;
            _age = age;
            _currPay = currPay;
            _status = status;
            _document = document;
        }

        private string _name;
        private bool _work;
        private int _id;
        private int _age;
        private float _currPay;
        private string _document;
        private string _status;

        public void GiveBonus(float amount)
        {
            if (_work)
            {
                _currPay += amount;
                Console.WriteLine("Gud employee");
            }
            if (!_work)
            {
                _currPay += amount;
                Console.WriteLine($"Because You have {_document} and you are the {_status}");
            }
        }

        public void Show()
        {
            Console.WriteLine($"Name-{_name},ID-{_id},Age-{_age},CurrPay-{_currPay}");
        }
    }
}
