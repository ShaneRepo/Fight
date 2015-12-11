using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    class Human : Creature
    {
        private int _strength;
        private int _hitpoints;
        private string _name;
        private int _damage;

        public Human()
        {
            _strength = 4;
            _hitpoints = 100;
            _name = "Human";
        }

        public Human(int strength, int hitpoints)
        {
            _strength = strength;
            _hitpoints = hitpoints;
            _name = "Human";
        }
    }
}
