using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq; //library untuk memanipulasi data 
using System.Text;
using System.Globalization;

enum Month
{
    Januari = 1, //1
    Maret = 2, //2
    April = 3//3
}


//=======================================================]//

namespace belajar_c_
{
    class Person 
    {
           private ushort age;
        public void setAge(ushort value) {
            age = value;
        }

        public ushort getAge(){
            return age;
        }  //setter dan mutator
    }

    class Program
    {
        private string name;
        private ushort age; //ushort 0-127

        static void Main(string[] args)
        {
            // primitive data type
            int a;
            a = 20;

            string message;
            message = "abcd";


            bool isActive = false;

            //Array

            int[] numbers ={1,2,3,4,5};

            //Type inference dapat mendifinisikan sesuatu tanpa inisiasi dia type apa

            var abc = "Isi Message";

            //Array list
            // bedanya dgn array, kalau array jumlah datanya fixed gabisa ditambah/kurang
            // kalau arraylist bisa macam2

            var collection1 = new ArrayList()
            {
                "Pisang",
                "apel",
                "jeruk",
                30,
                true
            };


            //list harus ditentukan namanya apa

            var collection = new List<double>()
            {
                200000
            };

            Console.WriteLine(a);
            Console.WriteLine(message);
            Console.WriteLine(numbers);

            // Type data enum
            // semua data enum akan menjadi angka, bisa diset angkanya
            // untuk mendefinisikan enum harus di luar funct atau method, dimanapun selain di dalam method

            var myMonth = (int)Month.Januari;
            var myMonth2 = Month.Januari;

            Console.WriteLine(myMonth);
            Console.WriteLine(myMonth2);

            var people = new List<Person>(); 
        // setter getter
        // sebaiknya tidak mengakses langsung ke dalam kelas
        
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();

            person1.setAge(21);
            person2.setAge(19);
            person3.setAge(32);
            
            Console.WriteLine(person1.getAge());

            // ada type data khusus fifo / stack
            // dan bisa dikonvert ke type array
            Stack<string> myStack = new Stack<string>();
            
            myStack.Push("mangga");
            myStack.Push("jeruk");
            myStack.Push("apel");

            var arr = myStack.ToArray();
            foreach (string str in arr) {
            Console.WriteLine(str);
            }

// dictionary untuk membuat pasangan variabel dengan type berbeda
            var tagihan = new Dictionary<string, int>();
            tagihan.Add("listrik", 100000);
            tagihan.Add("air",70000);
            tagihan.Add("kebutuhan",50000);

            Console.WriteLine(tagihan["listrik"]);

            foreach (var keyValue in tagihan){
                Console.WriteLine(keyValue.Key);
                Console.WriteLine(keyValue.Value);
            }

            foreach (var keyValue in tagihan) {
                Console.WriteLine("Tagihan {0} sebesar {1}", keyValue.Key, keyValue.Value);
            }

        //Type data queue

        var pasien = new Queue<string>();
        pasien.Enqueue("cece");
        pasien.Enqueue("cici");
        pasien.Enqueue("coco");
        pasien.Enqueue("cucu");
//Peek hanya untuk liat/ngintip aja
//untuk mengeluarkan dari antrian pake Dequeue

Console.WriteLine(pasien.Peek());
Console.WriteLine(pasien.Peek());
Console.WriteLine(pasien.Peek());
Console.WriteLine(pasien.Dequeue());
Console.WriteLine(pasien.Peek());

Console.WriteLine(" ------ ");

foreach(var p in pasien) {
    Console.WriteLine(p);
}

//SortedList otomatis mengurutkan data (sorting by key)

var myList = new SortedList<string, int>();

myList.Add("a", 30);
myList.Add("c", 25);
myList.Add("b", 59);
myList.Add("d", 70);

foreach (var keyValuePair in myList) {
    Console.WriteLine(keyValuePair);
}

Console.WriteLine("----------");

foreach (var keyValuePair in myList.OrderBy(item => item.Value)) {
    Console.WriteLine(keyValuePair);
}

var nama1 = "listrik";
var nilai1 = 1000;

var message1 = $"tagihan {nama1} senilai {nilai1}";
Console.WriteLine(message1);
        

        var pertama = "Rp";
        var kedua = 1000;
        var result = string.Concat(pertama,kedua,",-");

        Console.WriteLine(result);

        //"CSV"
        // Coma Separated Value

        var item = @"iphone x, 10000, Bandung
Pixel 4,20000,Jogja
        ";

        var items = item.Split(",");

        // foreach(var c in item)
        // {
        //     Console.WriteLine(c);
        // }

        var newItems = string.Join("---", items);

        Console.WriteLine(newItems);

        var now = DateTime.Now;
        Console.WriteLine(now.ToShortDateString());
        Console.WriteLine(now.ToString("F"));

        var ci = new CultureInfo("id-ID");
        Console.WriteLine(now.ToString("F",ci));
        Console.WriteLine(now.ToString("d",ci));
        Console.WriteLine(now.ToString("D",ci));
        Console.WriteLine(now.ToString("M",ci));
        // Console.WriteLine(now.ToString("yyyy-MM-dd".ci));

        var hariBaru = new DateTime(2020);
        var newDate = hariBaru.AddDays(3);

        Console.WriteLine(newDate.ToString("F",ci));

        var abc = new TimeSpan(3, 0, 0);

        abc.ToString("");

        

        }
    }
}


//memory stack
// mentriger garbage collector membuat performa aplikasi buruk
// string name = " ";

//memory heap
//lebih baik untuk performa aplikasi
// char[] name = {'n','a','m','a'};

//bisa pake string builder
// var name = new StringBuilder("biasa");
