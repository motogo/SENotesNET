namespace SENotesNET
{
    class AppClass
    {
        private static readonly object _lock_this = new object(); 
        static private volatile AppClass instance = null;

        static public AppClass Instance()
        {
            if (instance == null)
            {
                lock (_lock_this)
                {
                    instance = new AppClass();
                }
            }            
            return (instance);
        }
    }
}
