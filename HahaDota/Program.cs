using System;
using System.Collections.Generic;
using System.Threading;

namespace HahaDota
{
    public class Engine //синглтон
    {
        private static Engine instance;

        private Engine()
        {

        }

        public static Engine Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Engine();
                }
                return instance;
            }
        }
        public List<Hero> heroesList = new List<Hero>();// массив героев в сингл тоне
        public List<Item> itemList = new List<Item>(); //массив предметов в сингл тоне
    }

    //Родительский класс героев 
    public class Hero 
    {
        public String name;
        public int hp;
        public int strength;
        public int agility;
        public int intelligence;
        public int strike;
        public Item ite;
        public Hero()
        {

        }

        //получение бафа
        public Hero(Item predmet)
        {
            this.strength += predmet.strength2;
            this.agility += predmet.agility2;
            this.intelligence += predmet.intelligence2;
        }
        //получения хита
        public void HitHero(int heroIndex)
        {
            Engine en = Engine.Instance;
            en.heroesList[heroIndex].hp -= strike;
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
            return strike = (agility / 3) + (strength / 5) + (intelligence / 7);
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
    // родительский класс предметов
    public class Item 
    {
        public int strength2;
        public int agility2;
        public int intelligence2;

        public Item()
        {

        }
        public virtual int getStrenght()
        {
            return strength2;
        }
        public virtual int getAgility()
        {
            return agility2;
        }
        public virtual int getIntelligence()
        {
            return intelligence2;
        }
    }
    public class Stik : Item
    {
        private static int stikIntelligence = 155;
        public Stik()
        {
            intelligence2 = stikIntelligence;
        }
        public override int getIntelligence()
        {

            return intelligence2;
        }
    }
    public class Sword : Item
    {
        private static int swordStrength = 155;
        public Sword()
        {
            agility2 = swordStrength;

        }
        public int getStrength()
        {

                return strength2;
        }

    }  
    public class Bow : Item
    {
        private static int bowAgility = 155;
        public Bow()
        {
            agility2 = bowAgility;
        }
        public override int  getAgility()
        {

            return agility2;

        }
    }
    public class Pudge : Hero           //наследовательный класс c инициализацией значений
        {
            public String pudgeName = "Pudge";
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
            private static int sniperStrength = 19;
            private static int sniperAgility = 21;
            private static int sniperIntelligence = 15;
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
        //объявляем синглтон
        
        static Engine en; 
            static void Main(string[] args)
            {
                //инициализируем переменную для синглтона
                en = Engine.Instance;
               

            //добавляем героев в лист, который в синглтоне. 
            //Только вначале его очистим, чтоб при повторной загрузке сцены их не стало 10 (5 + 5)
                en.heroesList.Clear();
                en.heroesList.Add(new Pudge());
                en.heroesList.Add(new Viper());
                en.heroesList.Add(new Luna());
                en.heroesList.Add(new Lion());
                en.heroesList.Add(new Sniper());

            //добавляем предметы в лист, который в синглтоне. 
            //повторим процедуру чистки
               en.itemList.Clear();
               en.itemList.Add(new Stik());
               en.itemList.Add(new Sword());
               en.itemList.Add(new Bow());

            

            Random item = new Random();
            int item1Index = item.Next(0,2);
            int item2Index = item1Index;

            while (item1Index == item2Index)
            {
                item2Index = item.Next(0,2);
            }

            


            //Выбор игроков
            Random hero= new Random();
                int hero1Index = hero.Next(0, 4);
                int hero2Index = hero1Index;
                while (hero1Index == hero2Index)
                {
                    hero2Index = hero.Next(0, 4);
                }

            en.heroesList.Add(new Hero(en.itemList[item1Index]));

            while (en.heroesList[hero1Index].hp > 0 && en.heroesList[hero2Index].hp > 0)
                {

                    en.heroesList[hero1Index].HitHero(hero2Index);
                    en.heroesList[hero2Index].HitHero(hero1Index);
                    Console.WriteLine("Hero1: " + en.heroesList[hero1Index].name + "  " + "HP: " + en.heroesList[hero1Index].hp + "             " + "Hero2: " + en.heroesList[hero2Index].name + "  " + "HP: " + en.heroesList[hero2Index].hp);
                    Thread.Sleep(1000);

                }

                //Обьявление результата
                if (en.heroesList[hero1Index].hp > 0 && en.heroesList[hero2Index].hp <= 0)
                    Console.WriteLine("1st win");
                else if (en.heroesList[hero1Index].hp <= 0 && en.heroesList[hero2Index].hp > 0)
                    Console.WriteLine("2nd win");
                else if (en.heroesList[hero1Index].hp == 0 && en.heroesList[hero2Index].hp == 0)
                    Console.WriteLine("draw");
            }
        }

}



        




