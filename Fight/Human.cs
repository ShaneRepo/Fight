using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    class Human : Creature
    {

        private int _hitpoints;
        private string _name;


        public Human()
        {
            _hitpoints = 100;
            _name = "Human";
        }

    }
}
