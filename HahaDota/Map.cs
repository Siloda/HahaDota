using System;
using System.Collections.Generic;
using System.Text;

namespace HahaDota
{
    class Map
    {
        protected static Map World;

        public Map()
        {

        }

        public static Map ThisWorld
        {
            get
            {
                if (World == null)
                {
                    World = new Map();
                }
                return World;
            }
        }
        static List<string[]> frame = new List<string[]>();
        static bool gameStatus = true;
        static string hero = "H";
        static string wall = "#";
        static string target = "E";
    }
}
