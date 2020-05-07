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
       
        
        public Plant(string name, string type)
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

        public void GiveWater()
        {
            _water += 5;
        }
        public void GiveFood()
        {
            _food += 5;
        }
        public void GiveSun()
        {
            _sun += 5;
        }

        // Public Method
        public void UpdateGame()
        {
            Update();
            IncreaseAge();
            IsAlive();
            _turn ++;
        }
        

        // Private Method
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

        private void IsAlive()
        {
            if((_food >= 15|| _water >= 15 || _sun >= 15) || _age == "MegaSumoPlantaeVerus")
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

        private void Update()
        {
          for(int i = 0; i < _turn; i ++)
                {
                    Console.WriteLine("Press 1 to Water Your Plant. Press 2 to Move Your Plant Into UV Incubator. Press 3 To Give Your Plant Fertilizer."); 
                    string keyPress  = Console.ReadLine();
                    int playerInput = int.Parse(keyPress);
                    
                    if(playerInput == 1)
                    { 
                     _water ++;
                    }
                    if (playerInput == 2)
                    {
                       _sun ++;
                    }
                    if(playerInput == 3)
                    {
                        _food ++;
                    }
                   
                    Console.WriteLine("Plant Age: " + _age);
                    Console.WriteLine("Water Level: " + _water);
                    Console.WriteLine("Sunlight Amount: " + _sun);
                    Console.WriteLine("Fertilizer Level: " + _food);
                    Console.WriteLine("Turn Count: " + _turn);
                }  
        }
    }
}
