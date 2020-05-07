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
       
        
        public Plant(string name, string type, string age, int food, int water, int sun, int turn)
        {
            _name = name;
            _type = type;
            _age = "Baby Plant";
            _food = 0;
            _water = 0;
            _sun = 0;
            _turn = 0;
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
        public void Update()
        {
            IncreaseAge();
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
    }
}
