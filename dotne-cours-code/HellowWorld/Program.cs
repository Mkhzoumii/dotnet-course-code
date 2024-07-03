using System;
using System.Data;
using Dapper;
using HellowWorld.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Models;



namespace HellowWorld
{

    internal class Program
    {
        //     static void Main(string[] args)
        //     {
        //         IConfiguration config=new ConfigurationBuilder()
        //         .AddJsonFile("appsettings.json")
        //         .Build();
        //       dataContextDapper Dapper = new dataContextDapper(config);

        //       dataContextEF entityFramWork = new dataContextEF(config);
        //       DateTime rightTime = Dapper.loadDataSingle<DateTime>("SELECT GETDATE()");

        //       Computer myComputer = new Computer()
        //       {
        //         Motherboard = "z690",
        //         HasWifi = true,
        //         HasLTE = false,
        //         ReleaseDate = DateTime.Now,
        //         Price = 91000.23m,
        //         VideoCard = "RTX3070"

        //       };
        //       entityFramWork.Add(myComputer);
        //       entityFramWork.SaveChanges();


        //       // string sql = @"INSERT INTO TutorialAppSchema.Computer (
        //       //        Motherboard,
        //       //       HasWifi,
        //       //       HasLTE,
        //       //       ReleaseDate,
        //       //       Price,
        //       //       VideoCard
        //       //   )
        //       //   VALUES ('" + myComputer.Motherboard +
        //       //        "','" + myComputer.HasWifi +
        //       //         "','" + myComputer.HasLTE +
        //       //          "','" + myComputer.ReleaseDate +
        //       //           "','" + myComputer.Price +
        //       //            "','" + myComputer.VideoCard +
        //       // "')";
        //       // Console.WriteLine(sql);
        //       // bool result = Dapper.executSql(sql);
        //       // Console.WriteLine(result);

        //       // String sqlSelect = @"SELECT '" + myComputer.ComputerId + "','"
        //       //          + myComputer.Motherboard +
        //       //         "','" + myComputer.HasWifi +
        //       //          "','" + myComputer.HasLTE +
        //       //           "','" + myComputer.ReleaseDate +
        //       //            "','" + myComputer.Price +
        //       //             "','" + myComputer.VideoCard +
        //       //  "'  FROM TutorialAppSchema.Computer";
        //       // IEnumerable<Computer> Computers = Dapper.loadData<Computer>(sqlSelect);

        //       //   foreach (var item in Computers)
        //       //   {
        //       //     Console.WriteLine("'" + myComputer.Motherboard +
        //       //        "','" + myComputer.HasWifi +
        //       //         "','" + myComputer.HasLTE +
        //       //          "','" + myComputer.ReleaseDate +
        //       //           "','" + myComputer.Price +
        //       //            "','" + myComputer.VideoCard +
        //       // "'");

        //       // }
        //       IEnumerable<Computer>? ComputersEF = entityFramWork.Computer?.ToList<Computer>();

        //       if (ComputersEF != null)
        //       {
        //     //     foreach (Computer item in ComputersEF)
        //     //     {
        //     //       Console.WriteLine("'" + item.ComputerId + "','" +

        //     //          item.Motherboard +
        //     //          "','" + item.HasWifi +
        //     //           "','" + item.HasLTE +
        //     //            "','" + item.ReleaseDate +
        //     //             "','" + item.Price +
        //     //              "','" + item.VideoCard +
        //     //   "'");

        //     //     }
        //        }
        //     //   var Query=from Computer in Computer.AsEnumerable()
        //     //   where Computer.field<string>("Motherboard")=="z690"
        //     //   select new 
        //     //   {
        //     //    HasWifi=Computer.field<string>("HasWifi"),
        //     //    ComputerId=Computer.field<int>("ComputerId")

        //     //   };
        //    var context = new dataContextEF(config);
        //     var computers= from p in context.Computer select p;
        //     foreach (var p in computers)
        //     {
        //         Console.WriteLine($" haswifi : {p.HasWifi} price = {p.Price} has lte : {p.HasLTE} ");

        //     }


        //     }
        //   }}

        static void Main(string[] args)
        {
            Computer myComputer = new Computer()
            {
                Motherboard = "z690",
                HasWifi = true,
                HasLTE = false,
                ReleaseDate = DateTime.Now,
                Price = 91000.23m,
                VideoCard = "RTX3070"

            };



            string sql = "\n" + @"INSERT INTO TutorialAppSchema.Computer (
             Motherboard,
            HasWifi,
            HasLTE,
            ReleaseDate,
            Price,
            VideoCard
        )
        VALUES ('" + myComputer.Motherboard +
                   "','" + myComputer.HasWifi +
                    "','" + myComputer.HasLTE +
                     "','" + myComputer.ReleaseDate +
                      "','" + myComputer.Price +
                       "','" + myComputer.VideoCard +
            "')\n";
            File.WriteAllText("log.txt", sql);//هاي بتكتب مرة وحدة اذا رجعت كتبت بمسح الي كان موجود وبحط لجديد ما بضيف عليه
            using StreamWriter openFile = new("log.txt", append: true);//هاي بس تستخدمها عادي بتقدر تكتب جوا الفايل قد ما بدك ما بمسح الي جواته بضيف عليه وهاي هي
            openFile.WriteLine(sql);
            openFile.WriteLine(sql);
            openFile.WriteLine("abood waleed");
            openFile.Close();
            string zx=File.ReadAllText("log.txt");
            Console.WriteLine(zx);


        }

    }
}