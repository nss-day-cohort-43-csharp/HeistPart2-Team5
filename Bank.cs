using System;

namespace HeistPart2
{
    public class Bank
    {
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }
        bool IsSecure { get; set; }


        public void SecurityCheck()
        {
            int TotalScore = AlarmScore + VaultScore + SecurityGuardScore;
            if (TotalScore <= 0)
            {
                IsSecure = false;
            }
            else if (AlarmScore >= 0 || VaultScore >= 0 || SecurityGuardScore >= 0)
            {
                IsSecure = true;
            }
        }

    }
}