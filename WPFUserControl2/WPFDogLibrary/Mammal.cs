using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WPFDogLibrary
{
    public abstract class Mammal : IMammal
    {
        public int Age
        {
            get;
            set;
        }
        
        public int Weight
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
    }
}
