using System;

namespace ClassLibrary
{
    public class Customer
    {
        private int _id;
        private string _FirstName;
        private string _LastName;
        private int _YearofReg;

        public Customer()
        {

        }

        public Customer(int id, string firstName, string lastName, int yearOfReg)
        {
           _id = id;
           _FirstName = firstName;
           _LastName= lastName;
           _YearofReg = yearOfReg;
        }

        public int Id
        {
            get => _id;
            set => _id = value;

        }

        public string FirstName
        {
            get => _FirstName;
            set => _FirstName = value;
        }
        public string Lastname
        {
            get => _LastName;
            set => _LastName = value;
        }


        public int YearOfReg
        {
            get => _YearofReg;
            set => _YearofReg = value;
        }


        public override string ToString()
        { 
            return $"{nameof(Id)}: {Id}, {nameof(FirstName)}: {FirstName}, {nameof(Lastname)}: {Lastname}, {nameof(YearOfReg)}: {YearOfReg}";
        }
    }
}
