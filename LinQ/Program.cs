using System.Xml.Linq;

namespace LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LinQ Day1

            // 1 All using Query
            var allEmpQu = from e in Repository.GetEmployees()
                    select e;
            foreach (var emp in allEmpQu)
                Console.WriteLine(emp);

            // 2 All using Fluent
            var allEmpFs = Repository.GetEmployees().Select(e => e);
            foreach (var emp in allEmpFs)
                Console.WriteLine(emp);

            // 3 Over 30
            var empOver30 = from e in Repository.GetEmployees()
                       where e.Age > 30
                       select e;
            foreach (var emp in empOver30)
                Console.WriteLine(emp);

            // 4  Below 5k
            var empBelow5k = Repository.GetEmployees().Where(e => e.Salary < 5000);
            foreach (var emp in empBelow5k)
                Console.WriteLine(emp);

            // 5  Using query id=1 & slary>4k, order des by name
            var query5 = from e in Repository.GetEmployees()
                where e.DeptId == 1 && e.Salary > 4000
                orderby e.Name descending
                select e;
            foreach (var emp in query5)
                Console.WriteLine(emp);

            // 6  using fluent id=1 & name having 'm', order by salary
            var query6 = Repository.GetEmployees().Where(e => e.DeptId == 1 && e.Name.Contains('m')).OrderBy(e => e.Salary);
            foreach (var emp in query6)
                Console.WriteLine(emp);

            // 7  using fluent: first salary over 5k ,using first, firstordefault
            var firstEmp = Repository.GetEmployees().First(e => e.Salary > 5000);
            Console.WriteLine(firstEmp);
            var firstEmpOrDefault = Repository.GetEmployees().FirstOrDefault(e => e.Salary > 5000);
            Console.WriteLine(firstEmpOrDefault);

            // 8  using fluent: last id=10, using last, lastordefault
            var lastEmpOrDefault = Repository.GetEmployees().LastOrDefault(e => e.DeptId == 10);
            Console.WriteLine(lastEmpOrDefault == null ? "No employee found" : lastEmpOrDefault.ToString());
            var lastEmp = Repository.GetEmployees().Last(e => e.DeptId == 10);
            Console.WriteLine(lastEmp == null ? "No employee found" : lastEmp.ToString());


            // 9  using fluent: age=25 ,single, sigleordef
            var empAge25 = Repository.GetEmployees().Single(e => e.Age == 25);
            Console.WriteLine(empAge25)== null ? "No employee found" : empAge25.ToString();
            var empAge25OrDefault = Repository.GetEmployees().SingleOrDefault(e => e.Age == 25);
            Console.WriteLine(empAge25OrDefault == null ? "No employee found" : empAge25OrDefault.ToString());


            // 10 using fluent: id=8
            var empDept8OrDefault = Repository.GetEmployees().SingleOrDefault(e => e.DeptId == 8);
            Console.WriteLine(empDept8OrDefault == null ? "No employee found" : empDept8OrDefault.ToString());
            var empDept8 = Repository.GetEmployees().Single(e => e.DeptId == 8);
            Console.WriteLine(empDept8 == null ? "No employee found" : empDept8.ToString());

            // 11 using fluent: at 4
            var empAtIndex4 = Repository.GetEmployees().ElementAt(4);
            Console.WriteLine(empAtIndex4);
            var empAtIndex4Safe = Repository.GetEmployees().ElementAtOrDefault(4);
            Console.WriteLine(empAtIndex4Safe == null ? "No employee found" : empAtIndex4Safe.ToString());

            #endregion










            #region Named object:has refence name
            //var std = new Student { Id = 1, Name = "Ali" };
            //Console.WriteLine(std.Name);
            //std.Name = "Ahmed";
            //Console.WriteLine(std.Name);
            #endregion

            #region collections
            //base for all collections
            //1-IEnumerable
            //2-Icollection
            List<int> list = new List<int>();
            Dictionary<int,string> dic = new Dictionary<int,string>();
            IEnumerable<int> nums=new List<int>();
            ICollection<int> Collection=new List<int>();
            #endregion

            #region Anonymous object
            //object without name and without rerence name
            //List<Student> Sts = new List<Student>
            //{
            //     new Student{ Id = 1, Name = "Ali" },
            //     new Student{ Id = 2, Name = "mohamed" },
            //     new Student{ Id = 3, Name = "mayar" },

            //};
            //foreach(var item in Sts)
            //{
            //    Console.WriteLine(item.Name);
            //}

            #endregion

            #region anonymous Type
            //object with name , without refrence type
            //read only
            //var A = new { SSn = 1, FullName = "Ibraheem" };
            //Console.WriteLine(A);
            //Console.WriteLine(A.SSn);
            //Console.WriteLine(A.GetType());
            // A.SSn = 2; //error
            #endregion

            #region Anonymous Function
            //{int x,int y}=>{return x+y}
            Func<int,int,int>add =(x,y)=>x+y;
            //Action
            //Predicate
            #endregion

            #region Before Linq
            //List<int>l1=new List<int> { 1,2,3,4,5,6,7,8,9,10};
            //List<int> l2 = new List<int>();

            //foreach(var item in l1)
            //{
            //    if(item%2==0)
            //    {
            //        l2.Add(item);
            //    }
            //}
            //foreach(var item in l2)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Linq Declaration
            ///Features added on Collections
            ///40 Additional[Extension] Methods
            // "LINQ stands for Language Integrated Query, a Microsoft .NET Framework
            // that provides a standardized way to query data from various data sources using
            // a common syntax within programming languages like C#"

            #endregion

            #region How to Write LINQ
            // 1- Query Syntax [Limited = 12/40 Method]
            // 2- Method Syntax [Fluent API] [Fluent Syntax] [40] 
            #endregion

            #region Repository
            var emps = Repository.GetEmployees();
            var depts = Repository.GetDepartments();

            /****************** v1     **********/
            //MyDelgate1 del1 = e => e.DeptId == 1;
            //var filterdEmps2 = Filteration.FilterByDelgate(emps, del1);
            //foreach (Employee item in filterdEmps2)
            //{
            //    Console.WriteLine(item);
            //}
            /*******************delegate v2************/
            var filterdEmps2 = Filteration.FilterByDelgatev2(emps, e => e.DeptId == 1);

            //foreach (Employee emp in filterdEmps2)
            //{
            //    Console.WriteLine(emp);
            //}
            /****************************delegate v3***********/
           // var filterdEmps2 = emps.FilterByDelgatev2(e => e.Age > 25);

            #endregion

            #region Linq Methods 
            //class Enumerable => Contains All LINQ Method
            #endregion

            #region Linq Query Expression
            /////like equi join in sql    select from where 
            /////select * from Employees
            /////
            ///// Linq query expression must enclosed by select
            ///// Linq query expression is limited for linq  =>support 12 methods from 40
            ///// 
            /////item-> range 
            /////Emps -> Collection
            ///
            var q1 = from item in emps
                     select item;
            /********************************/
            var q2 = from item in emps
                     where item.Age > 25
                     select item;
            /*************************************/
            var q3 = from item in emps
                     where item.DeptId == 1 && item.Name.ToLower().Contains("m")
                     select item;
            /***************************************/
            var q4 = from item in emps
                     where item.DeptId == 1
                     orderby item.Name
                     select item;

            //foreach(var item in q4)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region [Fluent API] function expression Linq Lambda Expressions   =>function Chaining  => Most Used
            //var q5 = Enumerable.Where(emps, e => e.Age > 25);
            var q6 = emps.Where(e => e.Age > 25);
            /****************************************/
            var q7=emps.Where(w=>w.DeptId==1).OrderBy(w=>w.Name);
            /********************************/
            var q8=emps.Where(e=>e.Salary>5000).OrderBy(e=>e.Name)
                .ThenBy(e=>e.Age);
            /******************************************/
            //foreach (var item in q8)
            //{
            //    Console.WriteLine(item);
            //}
            /************************************/
            var q10 = emps.Max(e=>e.Salary);
            // Console.WriteLine(q10);
            /****************************************/

            #endregion

            #region single Object => These operators return a single element from a sequence
            // First
            // FirstOrDefault
            // Last
            // LastOrDefault
            // Single
            // SingleOrDefault
            // ElementAt
            // ElementAtOrDefault
            // Find => Later EF
            #region First & FirstOrDefault
            var q11 = emps.First();
            /**********************************/
            var q12 = emps.First(e=>e.DeptId==3);
            /****************************/
          //  var q13 = emps.First(e => e.DeptId == 15); //if not match : exception
            /***************************/
            var q14 = emps.FirstOrDefault(e=>e.DeptId==3);
             /****************************/
            var q15 = emps.FirstOrDefault(e => e.DeptId == 15); //null
                                                                //if(q15==null)
                                                                // Console.WriteLine(q15);
            #endregion

            #region single & singleOrDefault
            var q16 = emps.Single(x => x.Id == 1);//return match
                                                  // var q17 = emps.Single(x => x.Id == 11);//not match :exception
                                                  // var q18 = emps.Single(x => x.DeptId== 1); // more than one matching element:exception
            /******************************************/
            // var q19 = emps.SingleOrDefault(x => x.Id == 1);//return match
            // var q20 = emps.SingleOrDefault(x => x.Id == 11);//not match :Null
            // var q21 = emps.SingleOrDefault(x => x.DeptId == 1); // more than one matching element:exception

            // Console.WriteLine(q21);
            #endregion
            #region ElementAt , ElementAtOrDefault
            var q22 =emps.ElementAtOrDefault(15);
            Console.WriteLine(q22);
            #endregion
            #endregion



        }
    }
}
