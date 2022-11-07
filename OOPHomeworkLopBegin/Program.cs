using System;

namespace OOPHomeworkLopBegin
{
    class Program
    {
        static void Main(string[] args)
        {
            var hiredProgrammer = new HiredProgrammer();

            var linh = new Programmer(1, "linh", "chém gió", new DateTime(2001,4,18));
            var tri = new Programmer(2, "tri", "chém gió", new DateTime(2003,4,18));
            var phong = new Programmer(3, "phong", "chém gió", new DateTime(2005,4,18));
            
            hiredProgrammer.AddNewProgrammer(linh);
            hiredProgrammer.AddNewProgrammer(tri);
            hiredProgrammer.AddNewProgrammer(phong);
            
            hiredProgrammer.ShowFilterInfo(22);
            
        }
    }
}