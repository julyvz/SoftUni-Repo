using System;
using System.Collections.Generic;

namespace _7MilitaryElite
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Private> allPrivates = new List<Private>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                try
                {
                    string[] tokens = input.Split();

                    string soldierType = tokens[0];

                    switch (soldierType)
                    {
                        case "Private":
                            Private nextPrivate = new Private(int.Parse(tokens[1]), tokens[2], tokens[3], decimal.Parse(tokens[4]));
                            allPrivates.Add(nextPrivate);
                            Console.WriteLine(nextPrivate);
                            break;

                        case "LieutenantGeneral":
                            LieutenantGeneral nextGeneral = new LieutenantGeneral(int.Parse(tokens[1]), tokens[2], tokens[3], decimal.Parse(tokens[4]));
                            for (int i = 5; i < tokens.Length; i++)
                            {
                                int nextPrivateId = int.Parse(tokens[i]);
                                nextGeneral.Privates.Add(allPrivates.Find(x => x.Id == nextPrivateId));
                            }

                            Console.WriteLine(nextGeneral);
                            break;

                        case "Engineer":
                            Engineer nextEngineer = new Engineer(int.Parse(tokens[1]), tokens[2], tokens[3], decimal.Parse(tokens[4]), tokens[5]);

                            for (int i = 6; i < tokens.Length; i += 2)
                            {
                                string nextPart = tokens[i];
                                int nextHours = int.Parse(tokens[i + 1]);

                                Tuple<string, int> repair = new Tuple<string, int>(nextPart, nextHours);
                                nextEngineer.Repairs.Add(repair);
                            }

                            Console.WriteLine(nextEngineer);
                            break;

                        case "Commando":
                            Commando nextCommando = new Commando(int.Parse(tokens[1]), tokens[2], tokens[3], decimal.Parse(tokens[4]), tokens[5]);

                            for (int i = 6; i < tokens.Length; i += 2)
                            {
                                string missionName = tokens[i];
                                string missionState = tokens[i + 1];
                                try
                                {
                                    Mission nextMission = new Mission(missionName, missionState);
                                    nextCommando.Missions.Add(nextMission);
                                }
                                catch (Exception)
                                {
                                    continue;
                                }
                            }
                            Console.WriteLine(nextCommando);
                            break;

                        case "Spy":
                            Spy nextSpy = new Spy(int.Parse(tokens[1]), tokens[2], tokens[3], int.Parse(tokens[4]));
                            Console.WriteLine(nextSpy);
                            break;
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }
    }
}
