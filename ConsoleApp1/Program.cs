using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
           
            bool checkExit = default(bool);
            int level;
            List<IAtack> MyArmy = new List<IAtack>();
            List<IAtack> EnemyArmy = null;
            while (true)
            {
                Console.WriteLine("1. Start Game\n2. Exit");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                    levelAgain:
                        Console.WriteLine("Chose game level\n1. Normal\n2. Hard");
                        if (!int.TryParse(Console.ReadLine(), out level)) goto levelAgain;
                        switch (level)
                        {
                            case 1:
                                NormalLevelStage_1 n1 = new NormalLevelStage_1();
                                Action.LevelCreator(n1, MyArmy, EnemyArmy, 1);
                                MyArmy = new List<IAtack>();
                                NormalLevelStage_2 n2 = new NormalLevelStage_2();
                                Action.LevelCreator(n2, MyArmy, EnemyArmy, 2);
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 2:
                                HardLevelStage_1 h1 = new HardLevelStage_1();
                                Action.LevelCreator(h1, MyArmy, EnemyArmy, 1);
                                MyArmy = new List<IAtack>();
                                HardLevelStage_2 h2 = new HardLevelStage_2();
                                Action.LevelCreator(h2, MyArmy, EnemyArmy, 2);
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            default:
                                break;
                        }
                        break;
                    case "2":
                        checkExit = true;
                        break;
                    default:
                        Console.WriteLine("Wrong choice !");
                        break;
                }
                if (checkExit) break;
            }
        }
        public static IAtack Create(IAtackerFactoryInterface atackerFactoryInterface)
        {
            return atackerFactoryInterface.CreateAtacker();
        }
    }
   

}