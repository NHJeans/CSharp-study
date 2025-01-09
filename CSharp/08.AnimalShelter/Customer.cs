using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.AnimalShelter
{
    public class Customer
    {
        public string FirstName;
        public string LastName;
        private DateTime _Birthday;
        private bool _IsQualified;
        public string Address;
        public string Description;

        private List<Cat> _MyCats = new List<Cat>();
        public List<Cat> MyCats
        {
            get { return _MyCats; }
        }

        public bool Adopt(Cat cat)
        {
            if (_IsQualified)
            {
                _MyCats.Add(cat);
                return true;
            }
            else
            {
                return false;
            }
        }
        private List<Dog> _MyDogs =new List<Dog>();
        public List<Dog> MyDogs
        {
            get { return _MyDogs; }
        }

        // 함수의 오버로딩 (매개 변수를 다르게 하여 같은 이름의 함수를 여러개 만들 수 있음) 
        public bool Adopt(Dog dog)
        {
            if (_IsQualified)
            {
                _MyDogs.Add(dog);
                return true;
            }
            else
            {
                return false;
            }
        }



        public Customer(string firstName, string lastName, DateTime birthday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this._Birthday = birthday;

            this._IsQualified = Age >= 18;
        }

        public DateTime Birthday
        {
            get { return _Birthday; }
            set
            {
                _Birthday = value;
                _IsQualified = Age >= 18;
            }
        }

        public int Age
        {
            get { return DateTime.Now.Year - _Birthday.Year; ; }
        }
        public bool IsQualified
        {
            get
            {
                return _IsQualified;
            }
        }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
