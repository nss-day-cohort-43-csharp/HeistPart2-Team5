using System;

namespace HeistPart2
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            int NewScore = (bank.SecurityGuardScore - SkillLevel);
            Console.WriteLine($"{Name} is fighting the guards. Decreased security {SkillLevel} points");
            if (NewScore <= 0)
            {
                Console.WriteLine($"{Name} has taken out the security guards!");
            }
        }
    }
}