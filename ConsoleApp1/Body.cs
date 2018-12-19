using System;

namespace ConsoleApp9
{
    interface IAtack
    {
        void Atack(IAtack atack);
        string Name();
        int Life { get; set; }
    }
    
    class Panzer : IAtack
    {
        Random random = new Random();
        private int life;

        public Panzer() => life = 100;
        int IAtack.Life
        {
            get
            {
                return life;
            }
            set
            {
                life = value;
                if (value < 0) life = 0;
            }
        }

        public string Name()
        {
            return "Panzer";
        }
        public void Atack(IAtack atacked) { atacked.Life -= random.Next(5, 10); }
    }

    class Copper : IAtack
    {
        Random random = new Random();
        private int life;

        public Copper() => life = 100;
        int IAtack.Life {
            get
            {
                return life;
            }
            set
            {
                life = value;
                if (value < 0) life = 0;
            }
        }

        public string Name()
        {
            return "Copper";
        } 
        public void Atack(IAtack atacked)  { atacked.Life -= random.Next(5, 10); } 
    }

    class Soldier : IAtack
    {
        Random random = new Random();
        private int life;

        public Soldier() => life = 100;
        int IAtack.Life
        {
            get
            {
                return life;
            }
            set
            {
                life = value;
                if (value < 0) life = 0;
            }
        }

        public string Name()
        {
            return "Soldier";
        }
        public void Atack(IAtack atacked) { atacked.Life -= random.Next(5, 10); }
    }

    //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

    interface IAtackerFactoryInterface
    {
        IAtack CreateAtacker();
    }

    class PanzerFactory : IAtackerFactoryInterface
    {
        public IAtack CreateAtacker() { return new Panzer(); }
    }

    class CopperFactory : IAtackerFactoryInterface
    {
        public IAtack CreateAtacker() { return new Copper(); }
    }

    class SoldierFactory : IAtackerFactoryInterface
    {
        public IAtack CreateAtacker() { return new Soldier(); }
    }
}
