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
       
        
        public Plant(string name, string type, string age, int food, int water, int sun)
        {
            _name = name;
            _type = type;
            _age = age;
            _food = food;
            _water = water;
            _sun = sun;
            
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
        
        public void SetName(string newName)
        {
            _name = newName;
        }

        public void SetAge(string age)
        {
            
        }
       
        // {
            
        // } 

    

    }

}