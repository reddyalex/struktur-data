using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DFS
{
    class Program
    {
        static int[,] map = new int[11, 11];
        static int ukuranmap = 10;
        static int maxim = int.MinValue;
        class Tdata
        {
            public int x, y, arah, sum,level;
        };

        static void gerak(int x, int y, int arah, int sum, int level, List<int> lokasi)
        {
            if (level > 0)
            {

                if (y - 1 >= 0 && !lokasi.Contains((y - 1) * ukuranmap + x))
                {
                    //atas

                    lokasi.Add((y - 1) * ukuranmap + x);
                    y--;
                    gerak(x, y, 0, sum + map[x, y], level - 1, lokasi);
                    lokasi.Remove((y) * ukuranmap + x);
                    y++;
               
                }
                
                if (x + 1 < ukuranmap && !lokasi.Contains((y) * ukuranmap + x + 1))
                {
                    //kanan

                    lokasi.Add((y) * ukuranmap + x + 1);
                    x++;
                    gerak(x, y, 1, sum + map[x, y], level - 1, lokasi);
                    lokasi.Remove((y) * ukuranmap + x);
                    x--;                           
                }
                if (y + 1 < ukuranmap && !lokasi.Contains((y + 1) * ukuranmap + x))
                {
                    //bawah
                    lokasi.Add((y+1)*ukuranmap +x);
                    y++;
                    gerak(x, y, 2, sum + map[x, y], level - 1, lokasi);
                    lokasi.Remove((y) * ukuranmap + x);
                    y--;
               
                }
                if (x - 1 >= 0 && !lokasi.Contains((y) * ukuranmap + x - 1 ))
                {
                    //kiri
                    lokasi.Add((y) * ukuranmap + x - 1);
                    
                    x--;
                    gerak(x, y, 3, sum + map[x, y], level - 1, lokasi);
                    lokasi.Remove((y) * ukuranmap + x);
                    x++;
               
                }
            }
            else
            {
                if (maxim < sum)
                {
                    maxim = sum;
                    Console.WriteLine("sum= " + sum);
                    Console.WriteLine("x= " + x);
                    Console.WriteLine("y= " + y);
                    Console.WriteLine("arah= " + arah);
                    Console.Write("path= "); 
                    for (int i = 0; i < ukuranmap; i++)
                    {
                        Console.Write(lokasi[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }


        }

        /*map = new int[,]{ {65,91,58,24},
                       {0,-84,20,0}, 
                       {26,21, 90, -17},
                       {97,-6,-62,-27}
                      };
        */

        static void Main(string[] args)
        {

            map = new int[,] {{69,26,6,64,67,-22,-68,-67,11,-29 }, 
            {38,14,-28,56,44,54,42,60,48,49   } , 
            {1,4,37,67,83,71,91,5,90,0},
            {31,-12,44,96,-33,-44,37,38,16,-84},
            {-82,42,-75,-6,-91,92,-77,22,30,21},
            {-2,31,6,99,93,1,30,-61,2,58      },
            {-90,-72,36,93,59,47,35,18,43,58  },
            {78,34,-79,28,26,37,43,77,27,65   },
            {71,83,-7,43,70,54,-84,-73,23,94  },
            {47,46,24,27,17,32,11,14,73,82    }
            };

            int starty;
            int startx;

            starty = 2;
            startx = 9;

            List<int> xxx = new List<int>();

            for (int arah = 0; arah < 4; arah++)
            {
                gerak(startx, starty, arah, 0, 11,xxx);               
            }


            Console.ReadLine();
        }
/*            Stack<Tdata> st = new Stack<Tdata>();
            Tdata awal = new Tdata();
            awal.arah = 0;
            awal.x = startx;
            awal.y = starty;
            awal.sum = 0;
            awal.level = 10;


            while (st.Count > 0)
            {
                Tdata temp = st.Pop();
                int level = temp.level ;

                while (level <= 0)
                {

                    for (int i = 0; i < 4; i++)
                    {


                    }
                }

            }
 */
        }


            



    }
}
