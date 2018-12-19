using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Action
    {
        public static void CreateMyArmy(List<IAtack> MyArmy, int level)
        {
        panAgain:
            Console.Write("Enter number of Panzer  : ");
            if (!int.TryParse(Console.ReadLine(), out int pan) || pan > level || pan < 0)
            {
                Console.WriteLine("Enter Correct number\nYour panzer should be in the same quantity(or less) with enemy due to stage of level");
                goto panAgain;
            }
            for (int i = 0; i < pan; i++)
            {
                MyArmy.Add(Program.Create(new PanzerFactory()));
            }
        copAgain:
            Console.Write("Enter number of Copper  : ");
            if (!int.TryParse(Console.ReadLine(), out int cop) || cop > level || cop < 0)
            {
                Console.WriteLine("Enter Correct number\nYour copper should be in the same quantity(or less) with enemy due to stage of level");
                goto copAgain;
            }
            for (int i = 0; i < cop; i++)
            {
                MyArmy.Add(Program.Create(new CopperFactory()));
            }
        solAgain:
            Console.Write("Enter number of Soldier : ");
            if (!int.TryParse(Console.ReadLine(), out int sol) || sol > level || sol < 0)
            {
                Console.WriteLine("Enter Correct number\nYour soldier should be in the same quantity(or less) with enemy due to stage of level");
                goto solAgain;
            }
            for (int i = 0; i < sol; i++)
            {
                MyArmy.Add(Program.Create(new SoldierFactory()));
            }
            Console.WriteLine("Army created successfully");
            Thread.Sleep(2000);
            Console.Clear();
        }
        public static void LevelCreator(LevelBase levelBase, List<IAtack> MyArmy, List<IAtack> EnemyArmy, int level)
        {
            LevelBase normalLevelStage_1 = levelBase;
            EnemyArmy = normalLevelStage_1.CreateEnemyArmy();
            CreateMyArmy(MyArmy, level);
            while (true)
            {
                foreach (var MyUnit in MyArmy)
                {
                    foreach (var EnemyUnit in EnemyArmy)
                    {
                        if (EnemyUnit.Life() != 0)
                        {
                            Console.WriteLine($"My {MyUnit.Name()} atacked to enemy {EnemyUnit.Name()}. Enemy {EnemyUnit.Name()}'s life is {EnemyUnit.Life()}");
                            MyUnit.Atack(EnemyUnit);
                        }
                    }
                }
                foreach (var EnemyUnit in EnemyArmy)
                {
                    foreach (var MyUnit in MyArmy)
                    {
                        if (MyUnit.Life() != 0)
                        {
                            Console.WriteLine($"My {EnemyUnit.Name()} atacked to {MyUnit.Name()}. My {MyUnit.Name()}'s life is {MyUnit.Life()}");
                            EnemyUnit.Atack(MyUnit);
                        }
                    }
                }
                bool chck = false;
                foreach (var MyUnit in MyArmy)
                {
                    if (MyUnit.Life() != 0) chck = true;
                }
                if (chck == false) break;
                foreach (var EnemyUnit in EnemyArmy)
                {
                    if (EnemyUnit.Life() != 0) chck = true;
                }
                if (chck == false) break;
                Console.ReadKey();
            }
        }
    }
}
