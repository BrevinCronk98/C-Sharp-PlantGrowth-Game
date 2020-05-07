using System;

namespace Plantae.Flora
{
    public class Plant
    {
        private string _name;
        private string _type;
        private string _age;
        private int _food;
        private int _water;
        private int _sun;
        private int _turn;
       
    
        public Plant(string name, string type, string name)
        {
            _name = name;
            _type = type;
            _age = "Baby Plant";
            _food = 0;
            _water = 0;
            _sun = 0;
            _turn = 1;
    
        }
        public string GetName()
        {
            return _name;
        }
        new public string GetType() 
        {
            return _type;
        }

        public int GetWater()
        {
            return _water;
        }
        
        public int GetSunshine()
        {
            return _sun;
        }
        public int GetFood()
        {
            return _food;
        }
        public string GetAge()
        {
            return _age;
        }
        
        public int GetTurn()
        {
            return _turn;
            
        }

    
        // Public Method
        public void UpdateGame()
        {
            Update();
        }
        

        // Private Method

        private void Update()
        {
          for(int i = 0; i < _turn; i ++)
                {
                    IncreaseAge();
                    WinCond();
                    Console.WriteLine("Press 1 to Water Your Plant. Press 2 to Move Your Plant Into UV Incubator. Press 3 To Give Your Plant Fertilizer."); 
                    string keyPress  = Console.ReadLine();
                    int playerInput = int.Parse(keyPress);
                    
                    if(playerInput == 1)
                    { 
                     _water += 5;
                    }
                    if (playerInput == 2)
                    {
                       _sun +=5;
                    }
                    if(playerInput == 3)
                    {
                        _food += 5;
                    }
                   
                    Console.WriteLine("Plant Age: " + _age);
                    Console.WriteLine("Water Level: " + _water);
                    Console.WriteLine("Sunlight Amount: " + _sun);
                    Console.WriteLine("Fertilizer Level: " + _food);
                    Console.WriteLine("Turn Count: " + _turn);
                     _turn ++;
                }        
        }
        private void IncreaseAge()
        {
            if(_turn <=3)
            {
                _age = "Baby Plant";
            } else if(_turn >=4 && _turn <=7)
            {
                _age = "Little Plant";
            } else if(_turn >=8 && _turn <=11)
            {
                _age = "Sightly Bigger Plant";
            } else if(_turn >= 12 && _turn <=15)
            {
                _age = "Big Boi Plant";
            } else
            {
                _age = "MegaSumoPlantaeVerus";
            }
        }

        private void WinCond()
        {
            if((_food >= 65|| _water >= 65 || _sun >= 65) || _age == "MegaSumoPlantaeVerus")
            {
                Console.WriteLine("You Win!");
                Console.WriteLine("Plant Age: " + _age);
                Console.WriteLine("Water Level: " +_water);
                Console.WriteLine("Sunlight Amount: " +_sun);
                Console.WriteLine("Fertilizer Level: " +_food);
                Console.WriteLine("Turn Count: " + _turn);
                Environment.Exit(0);
            }
              
        }

      
    }
}
