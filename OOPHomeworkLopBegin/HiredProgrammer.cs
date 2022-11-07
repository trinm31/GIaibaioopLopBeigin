using System.Collections.Generic;

namespace OOPHomeworkLopBegin
{
    public class HiredProgrammer
    {
        private List<Programmer> _programmers;

        public HiredProgrammer()
        {
            _programmers = new List<Programmer>();
        }

        public void AddNewProgrammer(Programmer programmer)
        {
            _programmers.Add(programmer);
        }

        public void ShowFilterInfo(int underage)
        {
            foreach (var programmer in _programmers)
            {
                if (programmer.Age < underage )
                {
                    programmer.ShowInfo();
                }
            }
        }
    }
}