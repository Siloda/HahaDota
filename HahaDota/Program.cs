using System;

namespace HahaDota
{
    class Hero
    {
        protected int hp;
        protected int strength;
        protected int agility;
        protected int intelligence;
        protected int attak;
        public Hero()
        {
            getInfo();
        }
        public Hero(int hp, int strength, int agility, int intelligence, int attak)
        {
            
            this.hp = hp;
            this.strength = strength;
            this.agility = agility;
            this.intelligence = intelligence;
            this.attak = attak;
        
        }
        public virtual int getHp()
        {
            return hp;
        }
        public virtual int getStrenght()
        {
            return strength;
        }
        public virtual int getAgillity()
        {
            return agility;
        }
        public virtual int getIntelligence()
        {
            return intelligence;
        }
        public virtual String getInfo()
        {
            return "hp: " + hp + "strength: " + strength + "agility: " + agility + "intelligence: " + intelligence + "attak: " + attak;
        }

    }
    
    class First : Hero
    {

        public First(int hp, int strength, int agility, int intelligence, int attak)
        {
            this.hp = 10;
            this.strength = 10;
            this.agility = 10;
            this.intelligence = 10;
            this.attak = 10;
            getHp();
            getInfo();

        }       
        public override String getInfo()
        {
            return "hp: " + hp + "strength: " + strength + "agility: " + agility + "intelligence: " + intelligence + "attak: " + attak;
        }

    } 

    class Program
    {
        static void Main(string[] args)
        {
            First name = new First(100,10,10,10,10);
            name.getInfo();
        }
    }
}