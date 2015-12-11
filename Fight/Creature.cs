using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    class Creature
    {
        private int _strength;
        private int _hitpoints;
        private string _name;
        private int _damage;

        public Creature()
        {
            _strength = 5;
            _hitpoints = 100;
            _name = "Base Creature";
        }
        public Creature(int strength, int hitpoints)
        {
            _strength = strength;
            _hitpoints = hitpoints;
            _name = "Base Creature";
        }
        public int Strength
        {
            get { return _strength; }
            set { _strength = value; }
        }
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
