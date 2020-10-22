using BasicClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENotesNET.Classes
{
    
    public class AppSingelton
    {
        public bool debugMode = false;
        public bool globalKeys = false;
        public NotifiesClass nf = new NotifiesClass();
        public bool GlobalKeys
        {
            get
            {
                return globalKeys;
            }
            set
            {
                globalKeys = value;
            }
        }

        public bool DebugMode
        {
            get
            {
                return debugMode;
            }
            set
            {
                debugMode = value;
                nf.AddToINFO("debugmode", "debugmode", value);
            }
        }

        public AppSingelton()
        {

        }
        private static readonly object _lock_this = new object();
        static private volatile AppSingelton instance = null;
        static public AppSingelton Instance()
        {
            if (instance == null)
            {
                lock (_lock_this)
                {
                    instance = new AppSingelton();
                }
            }
            return (instance);
        }
    }
}
