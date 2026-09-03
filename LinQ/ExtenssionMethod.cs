using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    //1-static class
    //2-method static,this
   public static class ExtenssionMethod
    {
        public static string WelcomeMessage ( this string s)
        {
            return $"welcome {s}";
        }
    }
}
