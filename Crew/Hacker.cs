using System;

namespace HeistPart2
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public string Specialty { get; set; }


        public void PerformSkill(Bank bank)
        {
            int NewScore = (bank.AlarmScore - SkillLevel);
            Console.WriteLine($"{Name} is hacking the alarm system. Decreased alarm score {SkillLevel} points");
            if (NewScore <= 0)
            {
                Console.WriteLine($"{Name} has turned off the alarms!");
            }
        }
    }
}