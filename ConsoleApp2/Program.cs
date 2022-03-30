using ClassLibrary1;
using ConsoleApp2.Models;
using ConsoleApp2.OtherModels;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singer singer = new Singer();
            //singer.Name = "Mamed";
            //singer.SurName = "El Roman";
            //singer.Age = 40;

            //Song song = new Song();
            //song.Name = "Yene turme";
            //song.Genre = "Pop";
            //song.Singer = singer;

            //song.AddRating(5);
            //song.AddRating(4);
            //song.AddRating(3);
            //song.AddRating(2);
            //song.AddRating(1);
            //song.AddRating(100);


            //Console.WriteLine(song.GetAverageRating());

            //Teacher t = new Teacher();

            //Models.Worker w = new Models.Worker();
            //OtherModels.Worker w2 = new OtherModels.Worker();


            //Notification n = new Notification();
            //n.Notify("Salam", ConsoleColor.Red);
            //Notification n = new Notification();
            //n.Name = 10;


            //ClassLibrary1.Test t = new ClassLibrary1.Test();
            //t.test();

            Car car = new Car("BMW","F10",2018, "dfwshfiuwehdfiuwehf");
            car.Color = "red";
            car.Color = "white";
            Console.WriteLine(car.Make);

            Car car1 = new Car();

            Console.WriteLine(car1.Make);

            Notification n = new Notification;
        }
    }
}
