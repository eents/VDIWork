using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WPFDogLibrary
{
    public interface IMammal
    {
        int Age { get; set; }
        int Weight { get; set; }
        string Name { get; set; }
    }
}
