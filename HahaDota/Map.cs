using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HahaDota
{
    public class Map
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

        public List<string[]> frame = new List<string[]>();

        static bool gameStatus = true;
        static string hero = "X";
        public string wall = "#";
        static string exit = "E";
        static string emptyCell = " ";
        static string enemy = "P";



        public void buildLevelMap()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Играть на стрелочках");
            Thread.Sleep(3000);
            frame.Add(new string[] { "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", "E", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", });
            frame.Add(new string[] { "#", "#", "#", " ", " ", "P", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", });
            frame.Add(new string[] { "#", "X", "#", "#", "#", " ", "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "E", "#", });
            frame.Add(new string[] { "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", });
            render();
            while (gameStatus)
            {
                var keyInfo = Console.ReadKey();
                moveHero(keyInfo);
                render();
            }

        }
        public void render()
        {
            Console.Clear();
            for (int x = 0; x < frame.Count; x++)
            {
                Console.WriteLine(string.Join(" ", frame[x]));
            }
        }
        public void moveHero(ConsoleKeyInfo keyInfo)
        {
            Engine En = Engine.Letsgo;
            for (int x = frame.Count - 1; x >= 0; x--)
            {
                for (int y = 0; y < frame[x].Length; y++)
                {
                    if (frame[x][y] == hero)
                    {
                        if (keyInfo.Key == ConsoleKey.UpArrow)
                        {
                            if ((x - 1) >= 0 && frame[x - 1][y] == emptyCell)
                            {
                                frame[x][y] = emptyCell;
                                frame[x - 1][y] = hero;
                                return;
                            }
                            if ((x - 1) >= 0 && frame[x - 1][y] == enemy)
                            {
                                frame[x][y] = emptyCell;
                                frame[x - 1][y] = hero;
                                En.Match();
                                return;
                            }


                        }

                        else if (keyInfo.Key == ConsoleKey.DownArrow)
                        {
                            if ((x + 1) <= (frame.Count - 1) && frame[x + 1][y] == emptyCell)
                            {
                                frame[x][y] = emptyCell;
                                frame[x + 1][y] = hero;
                                return;
                            }
                            else if ((x + 1) <= (frame.Count - 1) && frame[x + 1][y] == enemy)
                            {
                                frame[x][y] = emptyCell;
                                frame[x + 1][y] = hero;
                                En.Match();
                                return;
                            }
                        }
                        else if (keyInfo.Key == ConsoleKey.LeftArrow)
                        {
                            if ((y - 1) >= 0 && frame[x][y - 1] == emptyCell)
                            {
                                frame[x][y] = emptyCell;
                                frame[x][y - 1] = hero;

                            }
                            else if ((y - 1) >= 0 && frame[x][y - 1] == enemy)
                            {
                                frame[x][y] = emptyCell;
                                frame[x][y - 1] = hero;
                                En.Match();
                                return;
                            }
                        }
                        else if (keyInfo.Key == ConsoleKey.RightArrow)
                        {
                            if ((y + 1) <= (frame[x].Length - 1) && frame[x][y + 1] == emptyCell)
                            {
                                frame[x][y] = emptyCell;
                                frame[x][y + 1] = hero;
                                return;
                            }
                            else if ((y + 1) <= (frame[x].Length - 1) && frame[x][y + 1] == enemy)
                            {
                                frame[x][y] = emptyCell;
                                frame[x][y + 1] = hero;
                                En.Match();
                                return;
                            }
                        }
                    }
                }
            }

        }
    }
}
