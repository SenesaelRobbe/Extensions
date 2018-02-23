using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ExtensionLibrary
{
    public static class LibExtensions
    {
        public static bool In<T>(this T t, IEnumerable c)
        {

            foreach(T x in c)
            {
                if (x.Equals(c)) return true;
            }
            return false;
        }
        //public static bool In(object o, IEnumerable c)
        //{
        //    foreach(object i in c)
        //    {
        //        if (i.Equals(o)) return true;
        //    }
        //    return false;
        //}
    }
}
