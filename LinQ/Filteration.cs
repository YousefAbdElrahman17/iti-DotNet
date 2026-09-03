using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public delegate bool MyDelgate1(Employee e);
    class Filteration
    {
        public static List<Employee> FilterByDelgate(List<Employee> param, MyDelgate1 del1)
        {
            var result = new List<Employee>();
            foreach (var item in param)
            {
                if (del1(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        /********************************************/

        public static List<Employee> FilterByDelgatev2(List<Employee> param, Predicate<Employee> del1)
        {
            var result = new List<Employee>();
            foreach (var item in param)
            {
                if (del1(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
