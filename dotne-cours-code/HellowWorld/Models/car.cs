using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace Models;
public class Car
{
public int carId {get;set;}
public string? carName {get;set;}
public string? carColor{get;set;}
public int carPrice {get;set;}
public Car()
{
    if(carName==null)
    {
        carName=" ";
    }
     if(carColor==null)
    {
        carColor=" ";
    }

}
}

