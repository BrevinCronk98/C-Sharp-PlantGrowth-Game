using System;
using System.Collections.Generic;
using Plantae.Flora;


namespace Plantae
{
    public class Program
    {
      
       
        public static void Main()
        {
            int water = 0;
            int food = 0;
            int sun = 0;
            string age = "";
            
           
           
            List<Plant> Plants = new List<Plant>(){};
            Console.WriteLine("Enter a Name");
            string name = Console.ReadLine();
               
            Console.WriteLine("Enter Plant Type");
            string type = Console.ReadLine();
           
           
            Plant myPlant = new Plant(name,type,age,food,water,sun,turn);
            Plants.Add(myPlant);
            foreach(Plant planty in Plants)
            {
                
                Console.WriteLine("Your plants name is " + planty.GetName());
                Console.WriteLine(planty.GetType());
                Console.WriteLine(planty.GetAge());
                Console.WriteLine(planty.GetFood());
                Console.WriteLine(planty.GetWater());
                Console.WriteLine(planty.GetSunshine());
                planty.GetTurn();

                for(int i = 0; i < 5; i ++)
                {
                    Console.WriteLine("Press 1 to Water Your Plant. Press 2 to Move Your Plant Into UV Incubator. Press 3 To Give Your Plant Fertilizer."); 
                    string keyPress  = Console.ReadLine();
                    int playerInput = int.Parse(keyPress);
                    
                    if(playerInput == 1)
                    {
                        water += 5;
                        Console.WriteLine(water);
                    }
                    if (playerInput == 2)
                    {
                        sun += 5;
                    }
                    if(playerInput == 3)
                    {
                        food += 5;
                        Console.WriteLine("You Have Given " + food + "To Your Plant");
                    }
                    myPlant.Update();
                }
            }     
        }   
    }   
}



