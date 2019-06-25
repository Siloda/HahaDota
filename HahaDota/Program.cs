using System;
using System.Collections.Generic;


namespace HahaDota
{





    class Program
    {


        static Engine En;
        static Inform Inf;
        static Map Lvl;

        static void Main(string[] args)
        {

            En = Engine.Letsgo;
            Inf = Inform.Information;
            Lvl = Map.ThisWorld;

            

            En.heroesList.Clear();
            En.heroesList.Add(new Pudge());
            En.heroesList.Add(new Viper());
            En.heroesList.Add(new Luna());
            En.heroesList.Add(new Lion());
            En.heroesList.Add(new Sniper());

                
            En.itemList.Clear();
            En.itemList.Add(new Stik());
            En.itemList.Add(new Sword());
            En.itemList.Add(new Bow());
            En.itemList.Add(new Empty());

            Lvl.frame.Clear();
            Lvl.buildLevelMap();
           
            
            

            

                     

            //En.Match();

            }
    }
}



        




