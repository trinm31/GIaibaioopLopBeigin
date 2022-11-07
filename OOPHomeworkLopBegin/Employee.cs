namespace OOPHomeworkLopBegin
{
    public abstract class Employee
    {
        private int _id;
        private string _name;

        public int ID
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
            set{
                if (value.Length < 3)
                {
                    _name = value;
                }
            }
        }

        public Employee(int id)
        {
            _id = id;
            _name = "No Name";
        }

        public Employee(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public abstract void ShowInfo();
    }
}