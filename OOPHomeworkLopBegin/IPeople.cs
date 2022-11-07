using System;

namespace OOPHomeworkLopBegin
{
    public interface IPeople
    {
        string Skills { get; set; }
        DateTime DateOfBirth { get; }
        int Age { get; }
    }
}