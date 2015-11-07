using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BFS
{
    class Program
    {
        static int[,] map = new int[9, 9];
        static Queue<Node> open;
        static Stack<Node> close;
        static List<int> historykota;
        static Node start;
        static Node goal;
        static void Main(string[] args)
        {
            //kota = idkota
            //a=0;              d=4
            //b=1;              dst;
            //c=2;
            /*         map = new int[,] { {  0 , 2, -1,  1, -1, -1, -1 },
                                        {  2 , 0,  5, -1, -1, -1, -1 },
                                        { -1 , 5,  0,  3,  4, -1, -1 },
                                        {  1 ,-1,  3,  0,  2, -1, -1 },
                                        { -1 ,-1,  4,  2,  0,  3,  5 },
                                        { -1 ,-1, -1, -1,  3,  0, -1 },
                                        { -1 ,-1, -1, -1,  5, -1,  0 },
                                      };

                     map = new int[,] { {  0 , 14, 2,  5, -1, -1, -1 },
                                        { 14 ,  0, 1, -1, -1, -1,  2 },
                                        {  2 ,  1, 0, -1,  5, -1, -1 },
                                        {  5 , -1,-1,  0,  4, -1, -1 },
                                        { -1 , -1, 5,  4,  0,  8,  2 },
                                        { -1 , -1,-1, -1,  8,  0,  1 },
                                        { -1 ,  2,-1, -1,  2,  1,  0 },
                                      };
            */
            map = new int[,]{ {65,91,58,24},
                           {0,-84,20,0}, 
                           {26,21, 90, -17},
                           {97,-6,-62,-27}
                          };

            int starty;
            int startx = 0;
            
            starty = 1;
            














            start = new Node(0);
            goal = new Node(5);
        
            Console.WriteLine(goal.idtujuan);
            
            open = new Queue<Node>();
            close = new Stack<Node>();
            historykota = new List<int>();

            open.Enqueue(start);
            historykota.Add(start.idtujuan);
            
            bool blmketemu = true;
            while (open.Count>=0 && blmketemu)
            {
                
                Node yangdiexpand = open.Dequeue();
                close.Push(yangdiexpand);


                //yangdiexpand.idtujuan
                List<int> idkotacalonmasukopening = new List<int>();

                for (int idkota = 0; idkota < 7; idkota++)
                {

                             if (map[yangdiexpand.idtujuan,idkota]>0 && !historykota.Contains(idkota))
                    {
                                Node temp = new Node(idkota,yangdiexpand.idtujuan,map[yangdiexpand.idtujuan,idkota]);

                                open.Enqueue(temp);
                                historykota.Add(idkota);
            
                        idkotacalonmasukopening.Add(idkota);    
                    }
                }


                //for (int i = idkotacalonmasukopening.Count-1; i >= 0; i--)
                //{

                //    if (historykota.Contains(idkotacalonmasukopening[i]))
                //    {
                //        idkotacalonmasukopening.RemoveAt(i);
                //    }
                    
                //    //looping di bawah ini tergantikan oleh if contains
                //    //for (int j = 0; j < historykota.Count; j++)
                //    //{
                //    //    if (idkotacalonmasukopening[i] == historykota[j])
                //    //    {
                //    //        idkotacalonmasukopening.RemoveAt(i);
                //    //        //hapus idkota calon masuk opening
                //    //    }
                //    //}
                    
                //}

                // looping di bawah ini salah.. karena remove dari bawah, proses remove tidak boleh dari bawah, harus dari belakang!!!
                //for (int i = 0; i < idkotacalonmasukopening.Count; i++)
                //{
                //    for (int j = 0; j < historykota.Count; j++)
                //    {
                //        if (idkotacalonmasukopening[i] == historykota[j])
                //        {
                //            //hapus idkota calon masuk opening
                //        }
                //    }

                //}

                blmketemu = belumketemutujuan();
                //expand yang di open

            }

            Console.WriteLine("tujuan adalah di "+close.Peek().idtujuan + " jalur yang di pilih sebagai berikut");
            double totalcost = 0;
            goal = close.Peek();

            Console.WriteLine(goal.idtujuan + " berasal dari " + goal.idasal + " berjarak " + goal.bobot);
            totalcost += goal.bobot;
       
            while (close.Count>0 && close.Peek().idasal!=-1)
            {

                Node temp = close.Pop();
                if (temp.idtujuan == goal.idasal)
                {
                    Console.WriteLine(temp.idtujuan + " berasal dari " + temp.idasal + " berjarak " + temp.bobot);
                    totalcost += temp.bobot;
                    goal = temp;
                }
            }
            Console.WriteLine("totalcost jaraknya adalah "  + totalcost);
            Console.ReadKey();
        }

        static bool belumketemutujuan()
        {
            if (close.Count > 0)
            {
                if (close.Peek().idtujuan == goal.idtujuan)
                {
                    return false;
                }
            }
            return true;
        }
    }

    class Node
    {
        public int idasal { get; set; }
        public int idtujuan { get; set; }

        public double bobot { get; set; }

        //public Node(int kodetujuan)
        //{
        //    idtujuan = kodetujuan;
        //    // -1 berarti starting point dengan asumsi kode kota tidak ada yang bernilai -1
        //    idasal = -1;
        //    //constructor
        //}
        public Node(int kodetujuan, int kodeasal= -1, double vbobot = 0)
        {
            idtujuan = kodetujuan;
            // -1 berarti starting point dengan asumsi kode kota tidak ada yang bernilai -1
            idasal = kodeasal;
            bobot = vbobot;
            //constructor
        }
        

    }


}
