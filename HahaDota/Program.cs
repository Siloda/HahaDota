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

            Inf.HelloWorld();
            Inf.HelloNeo();
            En.AddHero();
            En.AddItem();                          

            Lvl.frame.Clear();
            Lvl.buildLevelMap(); 
                    
            

            

                     
            }
    }
}



        




