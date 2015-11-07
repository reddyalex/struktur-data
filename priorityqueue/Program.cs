using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using MSDN.FSharp;

namespace priorityqueue
{
    class Program
    {

        class buku
        {
            public buku()
            {
            }
            public string pengarang { get; set; }
            public int tahunterbit { get; set; }
        }
        static void Main(string[] args)
        {
            //yang depan adalah keynya
            //yang belakang adalah valuenya
            PriorityQueue<double, int> pq2 = new PriorityQueue<double, int>();



            PriorityQueue<int, buku> pq = new PriorityQueue<int, buku>();


            Stack<buku> aa = new Stack<buku>() ;

            buku jumbuku = aa.Pop();
            PriorityQueue<int, buku> priority = new PriorityQueue<int, buku>();


            priority.Enqueue(5, new buku());

            KeyValuePair<int, buku> temp = priority.Dequeue();
                        


            buku buku1 = new buku();
            buku1.pengarang = "aljabar";
            buku1.tahunterbit = 1999;
            pq.Enqueue(buku1.tahunterbit, buku1);

            buku1 = new buku();
            buku1.pengarang = "budia";
            buku1.tahunterbit = 2019;
            pq.Enqueue(buku1.tahunterbit, buku1);

            buku1 = new buku();
            buku1.pengarang = "budib";
            buku1.tahunterbit = 1992;
            pq.Enqueue(buku1.tahunterbit, buku1);

            buku1 = new buku();
            buku1.pengarang = "baljabar";
            buku1.tahunterbit = 2015;
            pq.Enqueue(buku1.tahunterbit, buku1);



            KeyValuePair<int,buku> node;
            node = pq.Dequeue();
            Console.Write(node.Value.pengarang);
            Console.WriteLine(" - " + node.Value.tahunterbit);

            Console.WriteLine(pq.Dequeue().Value.pengarang + " - " + pq.Dequeue().Value.tahunterbit);
           
            
            //string namafile=Console.ReadLine();

            //StreamReader sr = new StreamReader(namafile);

            //int jumlahkota= Convert.ToInt32( sr.ReadLine());
            //double[,] adjmatrix = new double[jumlahkota,jumlahkota];
            //for (int i = 1; i <=  jumlahkota; i++)
            //{
            // //masukkan nama kota   
            //    string namakota = sr.ReadLine();
            //}

            //int jumlahedge = Convert.ToInt32(sr.ReadLine());
            ////jumlah edge
            //for (int i = 0; i < jumlahedge; i++)
            //{
            //    //baca edge
            //    string baris = sr.ReadLine();
            //    //baris.Split(" ");

            //}

            
            
            Console.ReadKey();   
 



        }
    }
}
