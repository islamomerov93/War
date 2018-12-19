using System;

namespace ConsoleApp9
{
    interface IAtack
    {
        void Atack(IAtack atack);
        string Name();
        int Life();
    }

    abstract class Base : IAtack
    {
        protected Random random = new Random();
        public int life = 100;
        public void Atack(IAtack atack) {}

        public string Name() { return null; }

        int IAtack.Life() { return 0; }
    }

    class Panzer : Base
    {
        public string Name()
        {
            return "Panzer";
        }
        int Life() { return life; }
        public void Atack(Base atacked) {  atacked.life -= random.Next(10, 15); }
    }

    class Copper : Base
    {
        public string Name()
        {
            return "Panzer";
        }
        int Life() { return life; }
        public void Atack(Base atacked)  { atacked.life -= random.Next(5, 10); }
    }

    class Soldier : Base
    {
        public string Name()
        {
            return "Panzer";
        }
        int Life() { return life; }
        public void Atack(Base atacked) { atacked.life -= random.Next(1, 5); }
    }

    //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

    interface IAtackerFactoryInterface
    {
        Base CreateAtacker();
    }

    class PanzerFactory : IAtackerFactoryInterface
    {
        public Base CreateAtacker() { return new Panzer(); }
    }

    class CopperFactory : IAtackerFactoryInterface
    {
        public Base CreateAtacker() { return new Copper(); }
    }

    class SoldierFactory : IAtackerFactoryInterface
    {
        public Base CreateAtacker() { return new Soldier(); }
    }
}
