using System;
using System.Collections.Generic;

namespace HahaDota
{
  
   public class Hero
    {
        protected String name;
        protected int hp;
        protected int strength;
        protected int agility;
        protected int intelligence;
        protected int attak;
        protected int strike;
        public Hero()
        {

        }
        public virtual int setHitHero (Hero opponent)
        {
            return  opponent.hp = hp - strike;
        }
        
        public String getName()
        {
            return name;
        }
        public virtual int getHp()
        {
            return hp;
        }
        public int getStrenght()
        {
            return strength;
        }
        public int getAgility()
        {
            return agility;
        }
        public int getIntelligence()
        {
            return intelligence;
        }
        public int getAgirlitySrike()
        {
            return strike= (agility / 3) + (strength / 5) + (intelligence / 7);
        }
        public int getIntelligenceSrike()
        {
            return strike = (intelligence / 3) + (agility / 5) + (strength / 7);
        }
        public int getStrengthSrike()
        {
            return strike = (strength / 3) + (intelligence / 5) + (agility / 7);
        }
       
        public virtual String getInfo()
        {

            return "Name: " + name + "\n hp: " + hp + "\n strength: " + strength + "\n agility: " + agility + "\n intelligence: " + intelligence + "\n attak: " + strike;
        }

    }
    
    public class Pudge : Hero
    {
        private String pudgeName = "Pudge";
        public int pudgeHp = 700;
        private static int pudgeStrength = 25;
        private static int pudgeAgility = 14;
        private static int pudgeIntelligence = 16;
        private int pudgeStrike;

        public Pudge()
        {
            name = pudgeName;
            hp = pudgeHp;
            strength = pudgeStrength;
            agility = pudgeAgility;
            intelligence = pudgeIntelligence;
            strike = pudgeStrike;
            getStrengthSrike();
        }
        public override String getInfo()
        {
            return "Name: " + name + "\n hp: " + hp + "\n strength: " + strength + "\n agility: " + agility + "\n intelligence: " + intelligence + "\n attak: " + strike;
        }
    }
    public class Viper : Hero
    {
        private String viperName = "Viper";
        private int viperHp = 620;
        private static int viperStrength = 21;
        private static int viperAgility = 21;
        private static int viperIntelligence = 15;
        private int viperStrike;

        public Viper()
        {
            name = viperName;
            hp = viperHp;
            strength = viperStrength;
            agility = viperAgility;
            intelligence = viperIntelligence;
            strike = viperStrike;
            getIntelligenceSrike();
        }
       
        public override String getInfo()
        {
            return "Name: " + name + "\n hp: " + hp + "\n strength: " + strength + "\n agility: " + agility + "\n intelligence: " + intelligence + "\n attak: " + strike;
        }
    }

    public class Luna : Hero
    {
        private String lunaName = "Luna";
        private int lunaHp = 520;
        private static int lunaStrength = 16;
        private static int lunaAgility = 18;
        private static int lunaIntelligence = 16;
        private int lunaStrike;

        public Luna()
        {
            name = lunaName;
            hp = lunaHp;
            strength = lunaStrength;
            agility = lunaAgility;
            intelligence = lunaIntelligence;
            strike = lunaStrike;
            getAgirlitySrike();
        }
        public override String getInfo()
        {
            return "Name: " + name + "\n hp: " + hp + "\n strength: " + strength + "\n agility: " + agility + "\n intelligence: " + intelligence + "\n attak: " + strike;
        }
    }
    public class Lion : Hero
    {
        private String lionName = "Lion";
        private int lionHp = 560;
        private static int lionStrength = 18;
        private static int lionAgility = 15;
        private static int lionIntelligence = 18;
        private int emberSpiritStrike;

        public Lion()
        {
            name = lionName;
            hp = lionHp;
            strength = lionStrength;
            agility = lionAgility;
            intelligence = lionIntelligence;
            strike = emberSpiritStrike;
            getStrengthSrike();
        }
        public override String getInfo()
        {
            return "Name: " + name + "\n hp: " + hp + "\n strength: " + strength + "\n agility: " + agility + "\n intelligence: " + intelligence + "\n attak: " + strike;
        }
    }
    public class Sniper : Hero 
    {
        private String sniperName = "Sniper";

        private int sniperHp = 580;
        private static int sniperStrength =19;
        private static int sniperAgility=21;
        private static int sniperIntelligence=15;
        private int sniperStrike;
        
        public Sniper()
        {
            name = sniperName;
            hp = sniperHp;
            strength = sniperStrength;
            agility = sniperAgility;
            intelligence = sniperIntelligence;            
            strike = sniperStrike;
            getAgirlitySrike();
        }

        public override String getInfo()
        {
            return "Name: " + name + "\n hp: " + hp + "\n strength: " + strength + "\n agility: " + agility + "\n intelligence: " + intelligence + "\n attak: " + strike; 
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            List<Hero> people = new List<Hero>(4);
            people.Add(new Sniper());
            people.Add(new Pudge());
            people.Add(new Viper());
            people.Add(new Luna());
            people.Add(new Lion());


            foreach (Hero p in people)
            {
                //Console.WriteLine(p.getInfo());
            }





            Sniper sniper = new Sniper();
            Pudge pudge = new Pudge();

            do
            {
                sniper.setHitHero(pudge);
                pudge.getHp();
                Console.WriteLine(" ");
                Console.WriteLine(pudge.getInfo());
                Console.WriteLine();
                if (pudge.pudgeHp>0)
                {
                    pudge.getHp();
                }

            }
            while (pudge.pudgeHp > 0);

            


        }

       
    }
    
}