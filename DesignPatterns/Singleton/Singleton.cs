using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{
    public class Singleton
    {
        private static Singleton _instance;
        public static Singleton Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}


/*
 usage 
 Singleton s1 = Singleton.Instance();
 Singleton s2 = Singleton.Instance(); -> same as s1

*/
