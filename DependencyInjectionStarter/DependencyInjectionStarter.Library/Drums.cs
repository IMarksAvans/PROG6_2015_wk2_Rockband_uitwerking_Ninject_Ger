using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjectionStarter.Library
{
    public class Drums: IInstrument 
    {
        public string Play()
        {
            return "Boom chack, Boom Boom chack";
        }
    }
}
