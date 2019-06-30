using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HahaDota
{
    public class Inform
    {

        protected static Inform Inf;
        public Inform()
        {

        }

        public static Inform Information
        {
            get
            {
                if (Inf == null)
                {
                    Inf = new Inform();
                }
                return Inf;
            }
        }
        public void Winner()
        {           
            Map rld = Map.ThisWorld;

            Console.Clear();
            Console.WriteLine("You're WINNER!!");
            refrenSolo();
            rld.tryAgain();
        }
       

        public void Draw()
        {
            Console.WriteLine("Draw");
            Thread.Sleep(2000);
        }

        public void Bye()
        {
            Console.Clear();
            Console.WriteLine("Good bye");
            Thread.Sleep(5000);
            Console.Clear();
            

           

        }
        static void refrenSolo()
        {
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Thread.Sleep(300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Thread.Sleep(300);
            Console.Beep(659, 300);
            Console.Beep(783, 300);
            Console.Beep(523, 300);
            Console.Beep(587, 300);
            Console.Beep(659, 300);
            Console.Beep(261, 300);
            Console.Beep(293, 300);
            Console.Beep(329, 300);
            Console.Beep(698, 300);
            Console.Beep(698, 300);
            Console.Beep(698, 300);
            Thread.Sleep(300);
            Console.Beep(698, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Thread.Sleep(300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Console.Beep(587, 300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Thread.Sleep(300);
            Console.Beep(783, 300);
            Thread.Sleep(300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Thread.Sleep(300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Thread.Sleep(300);
            Console.Beep(659, 300);
            Console.Beep(783, 300);
            Console.Beep(523, 300);
            Console.Beep(587, 300);
            Console.Beep(659, 300);
            Console.Beep(261, 300);
            Console.Beep(293, 300);
            Console.Beep(329, 300);
            Console.Beep(698, 300);
            Console.Beep(698, 300);
            Console.Beep(698, 300);
            Thread.Sleep(300);
            Console.Beep(698, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Thread.Sleep(300);
            Console.Beep(783, 300);
            Console.Beep(783, 300);
            Console.Beep(698, 300);
            Console.Beep(587, 300);
            Console.Beep(523, 600);
            Thread.Sleep(600);
        }
        static void coupleSolo()
        {
            Console.Beep(392, 300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Console.Beep(523, 300);
            Console.Beep(392, 600);
            Thread.Sleep(300 * 2);
            Console.Beep(392, 300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Console.Beep(523, 300);
            Console.Beep(440, 600);
            Thread.Sleep(600);
            Console.Beep(440, 300);
            Console.Beep(698, 300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Console.Beep(783, 600);
            Thread.Sleep(600);
            Console.Beep(880, 300);
            Console.Beep(880, 300);
            Console.Beep(783, 300);
            Console.Beep(622, 300);
            Console.Beep(659, 600);
            Thread.Sleep(600);
            Console.Beep(392, 300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Console.Beep(523, 300);
            Console.Beep(392, 600);
            Thread.Sleep(600);
            Console.Beep(392, 300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Console.Beep(523, 300);
            Console.Beep(440, 600);
            Thread.Sleep(600);
            Console.Beep(440, 300);
            Console.Beep(698, 300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Console.Beep(783, 600);
            Thread.Sleep(600);
            Console.Beep(880, 300);
            Console.Beep(783, 300);
            Console.Beep(698, 300);
            Console.Beep(587, 300);
            Console.Beep(523, 600);
            Thread.Sleep(600);
        }
    

        
        



        public void HelloNeo()
             {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Beep(659, 300);
            Console.WriteLine("Wake up Neo...");
            Thread.Sleep(5000);
            Console.Clear();
            Console.Beep(659, 300);
            Console.WriteLine("It's not Dota 2..");
            Thread.Sleep(5000);
            Console.Clear();
            Console.Beep(659, 300);
            Console.WriteLine("Matrix has You...");
            Thread.Sleep(5000);
            Console.Clear();
            Console.Beep(659, 300);
            Console.WriteLine("Follow the white rebbit...");
            Thread.Sleep(5000);
            Console.Clear();
        }
        public void HelloWorld()
            
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("▒█   ▒█   ▒█▀▀▀▀█    ▒█   ▒█   ▒█▀▀▀▀█ ▒█  ▒█▀▀▀▄ ▒█▀▀▀▀█ ▀▀▀█▀▀▀▒█▀▀▀▀█ ▒█▒█" +
                            "\n▒█░░░▒█░░░▒█░░░▒█░░░░▒█░░░▒█░░░▒█░░░▒█░▒█  ▒█░░░▒█▒█░░░▒█░░░▒█░░░▒█░░░▒█ ▒█▒█" +
                            "\n▒█▄▄▄▄█ ▄ ▒█▄▄▄▄█░░░░▒█▄▄▄▄█ ▄ ▒█▄▄▄▄█░▒█  ▒█░░░▒█▒█░░░▒█░░░▒█░░░▒█▄▄▄▄█ ▒█▒█" +
                            "\n▒█░░░▒█░░░▒█░░░▒█░░░░▒█░░░▒█░░░▒█   ▒█░░░  ▒█░░░▒█▒█░░░▒█░░░▒█░░░▒█░░░▒█ ▒█▒█" +
                            "\n▒█   ▒█   ▒█   ▒█    ▒█   ▒█   ▒█   ▒█ ▒█  ▒█▄▄▄▀░▒█▄▄▄▄█   ▒█   ▒█   ▒█ ▒█▒█" +
                            "\n                      ========AUTOMATIC  FIGHTS========                      " +
                            "\n                      ====PRESS ANY KEY TO CONTINUE====                      ");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
