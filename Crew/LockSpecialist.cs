using System;

namespace HeistPart2
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            int NewScore = (bank.VaultScore - SkillLevel);
            Console.WriteLine($"{Name} is picking the vault lock. Decreased vault {SkillLevel} points");
            if (NewScore <= 0)
            {
                Console.WriteLine($"{Name} has picked the lock!");
            }
        }
    }
}