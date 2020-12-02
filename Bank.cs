using System;
using System.Collections.Generic;

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

        public Bank()
        {
            Random r = new Random();
            AlarmScore = r.Next(0, 100);
            VaultScore = r.Next(0, 100);
            SecurityGuardScore = r.Next(0, 100);
            CashOnHand = r.Next(50000, 1000_000);
        }




    }
}