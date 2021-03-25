using System;
using System.Collections.Generic;

namespace employee
{
    class Employer : IComparable<Employer>
    {
        public Employer(string name_, DateTime birthDay_)
        {
            name = name_;
            birthDay = birthDay_;
            AgeCalc();
        }
        public string name;
        public DateTime birthDay; 

        public int age;

        private void AgeCalc()
        {
            age = (DateTime.Today.Year - birthDay.Year - 1) +
            (((DateTime.Today.Month > birthDay.Month) || 
            ((DateTime.Today.Month == birthDay.Month) && (DateTime.Today.Day >= birthDay.Day))) ? 1 : 0);
        }
        public int CompareTo(Employer p)
        {
            int i = this.birthDay.Month.CompareTo(p.birthDay.Month);
            if (i == 0)
            {
                return this.birthDay.Day.CompareTo(p.birthDay.Day);
            }
            else
            {
                return i;
            }
        }

    }
    
    class ListOfEmployee<T> : List<T>
    {
        public DateTime today = DateTime.Today;  
        // public DateTime nextMonth = DateTime.Today.AddMonths(1);  
        // public DateTime nextMonth2 = DateTime.Today.AddMonths(2);

        public string ToString(int monghtLenght, ListOfEmployee<Employer> list)
        {   
            string result = "";
            for (int i = 0; i <= monghtLenght; i++)
            {
                result += $"{today.AddMonths(i).ToString("MMMM yyyy")}\n";
                foreach (Employer employer in list)
                {
                    if (employer.birthDay.Month == today.AddMonths(i).Month)
                        result += $"({employer.birthDay.ToString("dd")}) - {employer.name} ({employer.age} лет)\n";
                }
            }
            return result;
        }        
        //куча кода...
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {   
            ListOfEmployee<Employer> listOfEmployee1 = new ListOfEmployee<Employer>();
            listOfEmployee1.Add(new Employer("Ваня Иванов", new DateTime(1992,03,20)));
            listOfEmployee1.Add(new Employer("Петя Петров", new DateTime(1995,03,23)));
            listOfEmployee1.Add(new Employer("Коля Новогодний", new DateTime(1991,04,01)));
            listOfEmployee1.Add(new Employer("Стас Рождественский", new DateTime(1998,04,07)));
            listOfEmployee1.Add(new Employer("Антон Павлович", new DateTime(1986,05,03)));
            listOfEmployee1.Add(new Employer("Денис Какойто", new DateTime(1990,05,25)));
            Console.WriteLine(listOfEmployee1.ToString(2, listOfEmployee1));
        }
    }

    
}
