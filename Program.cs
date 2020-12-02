using System;
using System.Collections.Generic;
using System.Linq;

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

            //LoopToken allows while loop to continuously, once changed to false.. loop terminates
            bool LoopToken = true;
            while (LoopToken == true)
            {
                Console.WriteLine($"Current number of operatives {rolodex.Count}");
                Console.WriteLine("------------------------");
                Console.WriteLine("Enter a new team member");
                string NewTeamMember = Console.ReadLine();
                Console.WriteLine("");
                if (NewTeamMember == "")
                { LoopToken = false; }


                else
                {


                    Console.WriteLine("What is their specialty");
                    Console.WriteLine("1) Hacker (Disables alarms)");
                    Console.WriteLine("2) Muscle (Disarms guards)");
                    Console.WriteLine("3) Lock Specialist (cracks vault)");
                    string ChooseSpecialty = Console.ReadLine();
                    Console.WriteLine("");

                    Console.WriteLine("What is the team member's skill level? (a number between 1-100)");
                    string MemberSkill = Console.ReadLine();
                    int NewSkillLevel = int.Parse(MemberSkill);
                    Console.WriteLine("");

                    Console.WriteLine("What percentage do they get?");
                    string MemberCut = Console.ReadLine();
                    int NewMemberCut = int.Parse(MemberCut);
                    Console.WriteLine("");

                    if (ChooseSpecialty == "1")
                    {
                        rolodex.Add(new Hacker()
                        {
                            Name = NewTeamMember,
                            SkillLevel = NewSkillLevel,
                            PercentageCut = NewMemberCut
                        });
                        Console.WriteLine("You've added a new Hacker to the team!");
                    }
                    else if (ChooseSpecialty == "2")
                    {
                        rolodex.Add(new Muscle()
                        {
                            Name = NewTeamMember,
                            SkillLevel = NewSkillLevel,
                            PercentageCut = NewMemberCut
                        });
                        Console.WriteLine("You've added new Muscle to the team!");

                    }
                    else if (ChooseSpecialty == "3")
                    {
                        rolodex.Add(new LockSpecialist()
                        {
                            Name = NewTeamMember,
                            SkillLevel = NewSkillLevel,
                            PercentageCut = NewMemberCut
                        });

                        Console.WriteLine("You've added a new Lock Specialist to the team!");
                    }
                }
            }
            Bank FirstBank = new Bank();
            List<int> BankItem = new List<int>()
         {
            FirstBank.AlarmScore,
            FirstBank.VaultScore,
            FirstBank.SecurityGuardScore,

         };
            int MostSecure = BankItem.Max();
            int LeastSecure = BankItem.Min();

            //Most Secure
            if (FirstBank.AlarmScore == MostSecure)
            {
                Console.WriteLine("Most secure: Alarm");
            }
            else if (FirstBank.VaultScore == MostSecure)
            {
                Console.WriteLine("Most secure: Vault");
            }
            else if (FirstBank.SecurityGuardScore == MostSecure)
            {
                Console.WriteLine("Most secure: Security Guard");
            }
            // least Secure
            if (FirstBank.AlarmScore == LeastSecure)
            {
                Console.WriteLine("Least Secure: Alarm");
            }

            else if (FirstBank.VaultScore == LeastSecure)
            {
                Console.WriteLine("Least Secure: Vault");
            }
            else if (FirstBank.SecurityGuardScore == LeastSecure)
            {

                Console.WriteLine("Least Secure: Security Guard");


                else
                {


                    Console.WriteLine("What is their specialty");
                    Console.WriteLine("1) Hacker (Disables alarms)");
                    Console.WriteLine("2) Muscle (Disarms guards)");
                    Console.WriteLine("3) Lock Specialist (cracks vault)");
                    string ChooseSpecialty = Console.ReadLine();
                    Console.WriteLine("");

                    Console.WriteLine("What is the team member's skill level? (a number between 1-100)");
                    string MemberSkill = Console.ReadLine();
                    int NewSkillLevel = int.Parse(MemberSkill);
                    Console.WriteLine("");

                    Console.WriteLine("What percentage do they get?");
                    string MemberCut = Console.ReadLine();
                    int NewMemberCut = int.Parse(MemberCut);
                    Console.WriteLine("");

                    if (ChooseSpecialty == "1")
                    {
                        rolodex.Add(new Hacker() { });
                        Console.WriteLine("You've added a new Hacker to the team!");
                    }
                    else if (ChooseSpecialty == "2")
                    {
                        rolodex.Add(new Muscle() { });
                        Console.WriteLine("You've added new Muscle to the team!");

                    }
                    else if (ChooseSpecialty == "3")
                    {
                        rolodex.Add(new LockSpecialist() { });

                        Console.WriteLine("You've added a new Lock Specialist to the team!");
                    }
                }

            }
        }
    }
}


