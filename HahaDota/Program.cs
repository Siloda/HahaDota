using System;

namespace HahaDota
{
    class Hero
    {
        private String name;
        private int hp;
        private int strength;
        private int agility;
        private int intelligence;
        private int attak;
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
        public String getName()
        {
            return name;
        }
        public int getHp()
        {
            return hp;
        }
        public int getStrenght()
        {
            return strength;
        }
        public int getAgillity()
        {
            return agility;
        }
        public int getIntelligence()
        {
            return intelligence;
        }
        public virtual String getInfo()
        {

            return "Name: " + name + "hp: " + hp + "strength: " + strength + "agility: " + agility + "intelligence: " + intelligence + "attak: " + attak;
        }

    }
    class Sniper : Hero
    {
        String name = "Sniper";
        int hp = 580;
        int strength = 19;
        int agility = 21;
        int intelligence = 15;
        int attak = 10;

        public Sniper()
        {
        }
        public override String getInfo()
        {
            return "Name: " + name + "\n hp: " + hp + "\n strength: " + strength + "\n agility: " + agility + "\n intelligence: " + intelligence + "\n attak: " + attak;
        }
    }
    class Pudg : Hero
    {
        String name = "Pudg";
        int hp = 700;
        int strength = 25;
        int agility = 14;
        int intelligence = 16;
        int attak = 10;

        public Pudg()
        {

        }
        public override String getInfo()
        {
            return "Name: " + name + "\n hp: " + hp + "\n strength: " + strength + "\n agility: " + agility + "\n intelligence: " + intelligence + "\n attak: " + attak;
        }
    }
    class Viper : Hero
    {
        String name = "Viper";
        int hp = 620;
        int strength = 21;
        int agility = 21;
        int intelligence = 15;
        int attak = 10;

        public Viper()
        {

        }
        public override String getInfo()
        {
            return "Name: " + name + "\n hp: " + hp + "\n strength: " + strength + "\n agility: " + agility + "\n intelligence: " + intelligence + "\n attak: " + attak;
        }
    }
    class Luna : Hero
    {
        String name = "Luna";
        int hp = 520;
        int strength = 16;
        int agility = 18;
        int intelligence = 16;
        int attak = 10;

        public Luna()
        {

        }
        public override String getInfo()
        {
            return "Name: " + name + "\n hp: " + hp + "\n strength: " + strength + "\n agility: " + agility + "\n intelligence: " + intelligence + "\n attak: " + attak;
        }
    }
    class EmberSpirit : Hero
    {
        String name = "EmberSpirit";
        int hp = 620;
        int strength = 21;
        int agility = 22;
        int intelligence = 20;
        int attak = 10;

        public EmberSpirit()
        {

        }
        public override String getInfo()
        {
            return "Name: " + name + "\n hp: " + hp + "\n strength: " + strength + "\n agility: " + agility + "\n intelligence: " + intelligence + "\n attak: " + attak;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hero[] hero = new Hero[4];
                        
            Sniper sniper = new Sniper();
            Pudg pudg = new Pudg();
            Viper viper = new Viper();
            Luna luna = new Luna();
            EmberSpirit emberspirit = new EmberSpirit();

            Console.WriteLine(sniper.getInfo());
            Console.WriteLine(" ");
            Console.WriteLine(pudg.getInfo());
            Console.WriteLine(" ");
            Console.WriteLine(viper.getInfo());
            Console.WriteLine(" ");
            Console.WriteLine(luna.getInfo());
            Console.WriteLine(" ");
            Console.WriteLine(emberspirit.getInfo());

        }
    }
    
}