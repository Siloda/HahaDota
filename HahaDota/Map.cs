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
        static string hero = "2";
        public string wall = "#";
        static string exit = "R";
        static string emptyCell = " ";
        static string enemy = "A";



        public void buildLevelMap()
        {
           
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            
            Thread.Sleep(3000);
            frame.Add(new string[] { "1", "0", "1", "0", "1", "0", "1", "0", "1", "0", "1", "0", "1", "0", "1", "0", "0", "1", "0", "1", "0", "1", "0", "1", " ", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", });
            frame.Add(new string[] { "0", "1", " ", "1", "0", " ", "0", " ", " ", " ", " ", "1", " ", " ", " ", " ", " ", "A", "0", "1", "0", "1", "1", "0", " ", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", });
            frame.Add(new string[] { "1", "0", " ", "0", "1", " ", "1", " ", "0", "1", " ", "0", "1", "0", " ", "0", "1", "A", "1", "0", "1", "0", "0", "1", " ", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", });
            frame.Add(new string[] { "0", "1", " ", " ", "A", " ", "0", " ", "1", "0", " ", "1", "0", "1", " ", "1", "0", "A", "0", " ", " ", " ", "1", "0", " ", "#", "#", " ", "_", "_", "_", "_", "_", " ", " ", " ", "#", "#", });
            frame.Add(new string[] { "1", "0", " ", "0", " ", " ", "1", " ", "0", "1", " ", "0", "1", "0", " ", "0", "1", "A", " ", " ", "1", " ", " ", "1", " ", "#", "#", "-", "2", "-", "N", "е", "o", " ", " ", " ", "#", "#", });
            frame.Add(new string[] { "0", "2", " ", "1", "A", " ", "A", " ", " ", " ", " ", "1", "A", "A", " ", "1", "0", "A", "A", "A", "0", "1", " ", "0", " ", "#", "#", " ", "_", "_", "_", "_", "_", " ", " ", " ", "#", "#", });
            frame.Add(new string[] { "1", "0", "1", "0", "A", "1", "0", "1", "1", "0", "1", "0", "1", "0", "1", "0", "1", "0", "1", "0", "1", " ", " ", "1", " ", "#", "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", "#", });
            frame.Add(new string[] { "0", "1", "0", "1", "A", "0", "1", "0", "0", "1", "0", "1", "0", "1", "0", "1", "0", "1", "0", "1", "0", " ", "1", "0", " ", "#", "#", "-", "A", "-", "A", "g", "e", "n", "t", " ", "#", "#", });
            frame.Add(new string[] { "1", "0", " ", " ", " ", "1", "0", "1", " ", " ", "1", "0", " ", " ", " ", "1", "0", "1", "0", "1", " ", " ", "0", "1", " ", "#", "#", " ", "_", "_", "_", "_", "_", "_", "_", " ", "#", "#", });
            frame.Add(new string[] { "0", "1", " ", "1", " ", " ", "1", " ", "1", "0", " ", "1", " ", "0", " ", " ", "1", "0", "1", "0", " ", "0", "1", "0", " ", "#", "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", "#", });
            frame.Add(new string[] { "1", "0", " ", "0", "1", " ", "0", " ", "0", "1", " ", "0", " ", "1", "0", " ", "0", "1", "0", "1", " ", "1", "0", "1", " ", "#", "#", "-", "R", "-", "R", "a", "b", "b", "i", "t", "#", "#", });
            frame.Add(new string[] { "0", "1", " ", "1", "0", " ", "1", " ", "1", "0", " ", "1", " ", "0", "1", " ", "1", "0", "1", "0", " ", "0", "1", "0", " ", "#", "#", " ", "_", "_", "_", "_", "_", "_", "_", " ", "#", "#", });
            frame.Add(new string[] { "1", "0", " ", " ", " ", "1", "0", " ", "0", "1", " ", "0", " ", "1", "0", " ", "0", "1", "0", "1", " ", "1", "0", "1", " ", "#", "#", "-", "Т", "а", "р", " ", " ", " ", " ", " ", "#", "#", });
            frame.Add(new string[] { "0", "1", " ", "1", " ", " ", "1", " ", " ", " ", " ", "A", " ", "0", "1", " ", "1", "0", "1", "0", "A", "0", "1", "0", " ", "#", "#", " ", "А", "r", "r", "o", "w", " ", " ", " ", "#", "#", });
            frame.Add(new string[] { "1", "0", " ", "1", "1", " ", "0", " ", "1", "0", " ", "1", " ", "1", "0", " ", "0", "1", "0", "1", "A", "1", "0", "1", " ", "#", "#", " ", "a", "n", "d", " ", " ", " ", " ", " ", "#", "#", });
            frame.Add(new string[] { "0", "1", " ", "0", "0", " ", "A", " ", "0", "1", " ", "0", " ", "0", "1", " ", "1", "0", "1", "1", " ", "0", "1", "0", " ", "#", "#", " ", "M", "o", "v", "e", " ", " ", " ", " ", "#", "#", });
            frame.Add(new string[] { "1", "0", " ", "R", " ", " ", "1", " ", "1", "0", " ", "1", " ", "1", " ", " ", "A", "A", "A", "A", " ", "1", "0", "1", " ", "#", "#", " ", " ", " ", " ", " ", " ", " ", " ", "#", "#", "#", });
            frame.Add(new string[] { "0", "1", " ", " ", " ", "1", "0", " ", "0", "1", " ", "0", " ", " ", " ", "0", "1", "0", "1", "1", "1", "0", "1", "0", " ", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", });
            frame.Add(new string[] { "1", "0", "1", "0", "1", "0", "1", "0", "1", "0", "1", "1", "0", "1", "0", "1", "0", "1", "0", "1", "0", "1", "0", "1", " ", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", });
            render();
            while (gameStatus)
            {
                var keyInfo = Console.ReadKey();
                MoveHero(keyInfo);
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
        public void tryAgain()
        {
            
            bool re = true;
            while (re)
            {



                Console.WriteLine("Try again?");
                Console.WriteLine("1 - Yes");
                Console.WriteLine("2 - No");
                // coupleSolo();
                Map World = Map.ThisWorld;
                Inform inf = Inform.Information;
                string again = Console.ReadLine();


                switch (again)
                {
                    case "1":
                        World.frame.Clear();
                        World.buildLevelMap();
                        break;
                    case "2":

                        gameStatus = false;
                        inf.Bye();
                        World.frame.Clear();

                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong!!!");

                        break;
                }

                if (again == "2")
                {
                    re = false;
                }

            }
        }


        public void MoveHero(ConsoleKeyInfo keyInfo)
        {
            
            Inform Inf = Inform.Information;
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
                            if ((x - 1) >= 0 && frame[x - 1][y] == exit)
                            {
                                frame[x][y] = emptyCell;
                                frame[x - 1][y] = hero;
                                Inf.Winner();
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
                            else if ((x + 1) <= (frame.Count - 1) && frame[x + 1][y] == exit)
                            {
                                frame[x][y] = emptyCell;
                                frame[x + 1][y] = hero;
                                Inf.Winner(); ;
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
                            else if ((y - 1) >= 0 && frame[x][y - 1] == exit)
                            {
                               frame[x][y] = emptyCell;
                               frame[x][y - 1] = hero;
                                Inf.Winner();
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
                            else if ((y + 1) <= (frame[x].Length - 1) && frame[x][y + 1] == exit)
                            {
                                frame[x][y] = emptyCell;
                                frame[x][y + 1] = hero;
                                Inf.Winner();
                                return;
                            }
                        }
                    }
                }
            }

        }



    }
}
