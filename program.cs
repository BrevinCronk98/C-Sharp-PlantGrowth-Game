using System;
using System.Collections.Generic;
using Plantae.Flora;


namespace Plantae
{
    public class Program
    {
        public static void Main()
        {
            List<Plant> Plants = new List<Plant>(){};
            Console.WriteLine("Enter a Name");
            string name = Console.ReadLine();
               
            Console.WriteLine("Enter Plant Type");
            string type = Console.ReadLine();
           
           
            Plant myPlant = new Plant(name,type);
           
            Plants.Add(myPlant);
            foreach(Plant planty in Plants)
            {
                
                Console.WriteLine("Your plants name is " + planty.GetName());
                Console.WriteLine("Plant Age: " + planty.GetAge());
                Console.WriteLine("Water Level: " + planty.GetWater());
                Console.WriteLine("Sunlight Amount: " + planty.GetSunshine());
                Console.WriteLine("Fertilizer Level: " + planty.GetFood());
                Console.WriteLine("Turn Count: " + planty.GetTurn());
                myPlant.UpdateGame(); 
            }        
        }   
    }   
}



