using System;

namespace OOPHomeworkLopBegin
{
    public class Programmer : Employee, IPeople
    {
        private string _skills;
        private DateTime _DOB;
        private int _age;

        public string Skills
        {
            get { return _skills; }
            set { _skills = value; }
        }

        public DateTime DateOfBirth
        {
            get { return _DOB; }
        }

        public int Age
        {
            get { return _age; }
        }

        public Programmer(int id, string name) : base(id, name)
        {
            _skills = String.Empty; // ""
            _DOB = DateTime.Now; // thời gian hiện tại
            _age = (int)((DateTime.Now - _DOB).TotalDays / 365);
        }
        
        public Programmer(int id, string name, string skills, DateTime DOB) : base(id, name)
        {
            _skills = skills;
            _DOB = DOB;
            _age = (int)((DateTime.Now - _DOB).TotalDays / 365);
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Id: {ID}, Name: {Name}, Skills: {_skills}, Date Of Birth: {_DOB}, Age: {_age}");
        }
    }
}