using System;
using System.Collections.Generic;

namespace HeistPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker hacker1 = new Hacker()
            {
                Name = "Faith",
                SkillLevel = 25,
                PercentageCut = 40
            };
            Hacker hacker2 = new Hacker()
            {
                Name = "Adam",
                SkillLevel = 25,
                PercentageCut = 10
            };

            Muscle muscle1 = new Muscle()
            {
                Name = "Joe",
                SkillLevel = 90,
                PercentageCut = 5
            };

            Muscle muscle2 = new Muscle()
            {
                Name = "Tyler",
                SkillLevel = 20,
                PercentageCut = 5
            };
            LockSpecialist lockSpecialist1 = new LockSpecialist()
            {
                Name = "Starkey",
                SkillLevel = 45,
                PercentageCut = 25
            };
            LockSpecialist lockSpecialist2 = new LockSpecialist()
            {
                Name = "Erik",
                SkillLevel = 35,
                PercentageCut = 25
            };



            List<IRobber> rolodex = new List<IRobber>()
           {
               hacker1, hacker2, muscle1, muscle2, lockSpecialist1, lockSpecialist2
           };
        }
    }
}
