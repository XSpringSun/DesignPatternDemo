using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    //public class ObjectClass
    //{
    //    private static ObjectClass singleton=new ObjectClass();
    //    private ObjectClass()
    //    {
    //    }

    //    public static  ObjectClass GetSingletone()
    //    {
    //        return singleton;
    //    }
    //}

    public class ObjectClass
    {
        private static ObjectClass singleton = new ObjectClass();
        private static object lockObj = new object();
        private ObjectClass()
        {
        }

        public static ObjectClass GetSingletone()
        {
            if (singleton == null)
            {
                lock (lockObj)
                {
                    if (singleton == null)
                    {
                        singleton = new ObjectClass();
                    }
                } 
            }
            return singleton;
        }
    }
}
