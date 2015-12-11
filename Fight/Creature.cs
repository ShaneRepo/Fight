using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    class Creature
    {
        private int _hitpoints;
        private string _name;

        public Creature()
        {
            _hitpoints = 100;
            _name = "Creature";
        }
        //public Creature(int strength, int hitpoints)
        //{
        //    _strength = strength;
        //    _hitpoints = hitpoints;
        //    _name = "Creature";
        //}
       
        public int Hitpoints
        {
            get { return _hitpoints; }
            set { _hitpoints = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        
    }
}
