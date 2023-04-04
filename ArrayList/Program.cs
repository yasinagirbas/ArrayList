using System.Collections;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace
            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('a');
            
            //içerisinde verilere erişim 
            
            Console.WriteLine(liste[1]);
            foreach (var item  in liste)
                Console.WriteLine(item);
            
            //addrange  birden fazla elemanı toplu halde nasıl ekleriz 
            
            Console.WriteLine("xxxxxxxxxx addrange xxxxxxxx");
            string[] renkler = {"kırmız", "sarı", "mavi"};
            List<int> sayılar = new List<int>() {1,23,7,9,3,4 };
            liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var item in liste)
            
                Console.WriteLine(item);
            
            //Sort
            Console.WriteLine("-************* short ***************");
            //liste.short(); // sayıları sıralar strıng ifadeleri silmemiz gerekiyor 
            
            //binary Search 
            
            Console.WriteLine("*************** binary search************");
            Console.WriteLine(liste.BinarySearch(9));
            
            //reverse  büyükten küçüğe doğru 
            Console.WriteLine("******************* reverse ***************");
            liste.Reverse();
            foreach (var item  in liste)
            {
                Console.WriteLine(item);
            }
            
            //clear listeyi temizler 
            liste.Clear();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

        }
    }
    
}

