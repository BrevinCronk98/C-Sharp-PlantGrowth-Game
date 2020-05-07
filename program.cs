using System;
using System.Collections.Generic;
using Plantae.Flora;


namespace Plantae
{
    public class Program
    {
      
       
        public static void Main()
        {
            int turnCount = 1;
            int water = 0;
            int food = 0;
            int sun = 0;
            string age = age;
            
           
           
            List<Plant> Plants = new List<Plant>(){};
            Console.WriteLine("Enter a Name");
            string name = Console.ReadLine();
               
            Console.WriteLine("Enter Plant Type");
            string type = Console.ReadLine();
           
          

            foreach(Plant planty in Plants)
            {
                
                Console.WriteLine("Your plants name is " + planty.GetName());
                Console.WriteLine(planty.GetType());
                Console.WriteLine(planty.GetAge());
                Console.WriteLine(planty.GetFood());
                Console.WriteLine(planty.GetWater());
                Console.WriteLine(planty.GetSunshine()); 

                for(int i = 0; i < turnCount; i ++)
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
                    if(turnCount <= 4)
                    {
                        return planty.age;
                    } else if(turnCount >=5 && turnCount <= 8)
                    {
                        return planty.age;
                    } else if(turnCount >= 9 && turnCount <= 12)
                    {
                        return planty.age;
                    } else if (turnCount >= 13 && turnCount <= 15)
                    {
                        return planty.age;
                    } else if(turnCount >= 16 && turnCount <= 20)
                    {
                        return planty.age;
                    } else 
                    {
                        return planty.age;
                    }  
                    turnCount ++; 
                }
            }     
        }   
    }   
}



