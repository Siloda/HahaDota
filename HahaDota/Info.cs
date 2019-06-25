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
  






        public void HelloWorld()
        {
            Console.WriteLine("                                               Приветствую тебя путник");
            Thread.Sleep(1000);
            Console.WriteLine("Нажмите 1 или 2");
            Thread.Sleep(5000);
            Console.WriteLine("Нажмите 1 или 2");

        }
    }
}
