// using System;
// using dataCarEF2;
// using Models;
// using Microsoft.Data.SqlClient;
// namespace carProgram;
// internal class carProgram
// {
//     static void Main(string[] args)
//     {

//         Car bmw = new Car()
//         {
//             carName = "ID4",
//             carColor = "red",
//             carPrice = 17000,
//         };
//         dataCarEF Ef = new dataCarEF();
//         Ef.Add(bmw);
//         Ef.SaveChanges();
//         // Console.WriteLine("abood");
//         var abood = new dataCarEF();
//         var cars = from car in abood.car select car;
//         foreach (var car in cars)
//         {
//             Console.WriteLine($"CarID = {car.carId} car name = {car.carName} car color : {car.carColor}");

//         }

//     }
// }