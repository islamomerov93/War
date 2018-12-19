using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    abstract class LevelBase
    {
        protected List<IAtack> army = new List<IAtack>();
        public abstract List<IAtack> CreateEnemyArmy();
    }
    class NormalLevelStage_1 : LevelBase
    {
        public override List<IAtack> CreateEnemyArmy()
        {
            army.Add(Program.Create(new PanzerFactory()));

            army.Add(Program.Create(new CopperFactory()));

            army.Add(Program.Create(new SoldierFactory()));

            return army;
        }
    }
    class NormalLevelStage_2 : LevelBase
    {
        public override List<IAtack> CreateEnemyArmy()
        {
            army.Add(Program.Create(new PanzerFactory()));
            army.Add(Program.Create(new PanzerFactory()));

            army.Add(Program.Create(new CopperFactory()));
            army.Add(Program.Create(new CopperFactory()));

            army.Add(Program.Create(new SoldierFactory()));
            army.Add(Program.Create(new SoldierFactory()));

            return army;
        }
    }
    class HardLevelStage_1 : LevelBase
    {
        public override List<IAtack> CreateEnemyArmy()
        {
            army.Add(Program.Create(new PanzerFactory()));
            army.Add(Program.Create(new PanzerFactory()));
            army.Add(Program.Create(new PanzerFactory()));  

            army.Add(Program.Create(new CopperFactory()));
            army.Add(Program.Create(new CopperFactory()));
            army.Add(Program.Create(new CopperFactory()));

            army.Add(Program.Create(new SoldierFactory()));
            army.Add(Program.Create(new SoldierFactory()));
            army.Add(Program.Create(new SoldierFactory()));

            return army;
        }
    }
    class HardLevelStage_2 : LevelBase
    {
        public override List<IAtack> CreateEnemyArmy()
        {
            army.Add(Program.Create(new PanzerFactory()));
            army.Add(Program.Create(new PanzerFactory()));
            army.Add(Program.Create(new PanzerFactory()));
            army.Add(Program.Create(new PanzerFactory()));

            army.Add(Program.Create(new CopperFactory()));
            army.Add(Program.Create(new CopperFactory()));
            army.Add(Program.Create(new CopperFactory()));
            army.Add(Program.Create(new CopperFactory()));

            army.Add(Program.Create(new SoldierFactory()));
            army.Add(Program.Create(new SoldierFactory()));
            army.Add(Program.Create(new SoldierFactory()));
            army.Add(Program.Create(new SoldierFactory()));

            return army;
        }
    }
}
