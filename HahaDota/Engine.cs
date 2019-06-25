using System;
using System.Collections.Generic;
using System.Threading;

namespace HahaDota
{
    public class Engine
        
    {
        static Map Map;

        protected static Engine En;

        public Engine()
        {

        }

        public static Engine Letsgo
        {
            get
            {
                if (En == null)
                {
                    En = new Engine();
                }
                return En;
            }
        }
        public List<Hero> heroesList = new List<Hero>();
        public List<Item> itemList = new List<Item>();
     


        public void Match()
        {
            while (true)
            {
                
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        Random hero = new Random();
                        int hero1Index = hero.Next(0, 4);
                        int hero2Index = hero1Index;
                        while (hero1Index == hero2Index)
                        {
                            hero2Index = hero.Next(0, 4);
                        }


                        Random item = new Random();
                        int item1Index = item.Next(0, 2);
                        int item2Index = item1Index;
                        while (item1Index == item2Index)
                        {
                            item2Index = item.Next(0, 3);

                        }



                        En.heroesList[hero1Index].takeItem(hero1Index, item1Index);
                        En.heroesList[hero2Index].takeItem(hero2Index, item2Index);



                        while (En.heroesList[hero1Index].hp > 0 && En.heroesList[hero2Index].hp > 0)

                        {
                            Console.WriteLine((En.heroesList[hero1Index].getInfo()) + " \n   " + "\n" + (En.heroesList[hero2Index].getInfo()));
                            Thread.Sleep(1000);
                            En.heroesList[hero1Index].HitHero(hero2Index);
                            Thread.Sleep(1000);
                            En.heroesList[hero2Index].HitHero(hero1Index);

                            Console.Clear();
                        }


                        if (En.heroesList[hero1Index].hp > 0 && En.heroesList[hero2Index].hp <= 0)
                            Console.WriteLine("1st win");
                        else if (En.heroesList[hero1Index].hp <= 0 && En.heroesList[hero2Index].hp > 0)
                            Console.WriteLine("2nd win");
                        else if (En.heroesList[hero1Index].hp <= 0 && En.heroesList[hero2Index].hp <= 0)
                            Console.WriteLine("draw");
                        Map.buildLevelMap();

                        continue;
                    case "2":
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Вы нажали неизвестную букву");
                        break;
                }
                if (selection == "2")
                    break;
                   
                   
            }
        }
    }

}
