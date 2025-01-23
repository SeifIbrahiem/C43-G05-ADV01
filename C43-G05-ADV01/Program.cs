namespace C43_G05_ADV01
{
    internal class Program
    {
        static void Main()
        {
            #region non generic swap
            //Generic
            //c#frature 2005
            //before 2005 classobject
            //Ex1 swap
            // data type int 
            //int A = 1, B = 3;
            //  Console.WriteLine($"A: {A}");
            //  Console.WriteLine($"B: {B}");
            //  Console.WriteLine("*******AFTER SWAP");

            //  Helper.Swap( ref A, ref B ); // passing by ref
            //  Console.WriteLine($"A: {A}");
            //  Console.WriteLine($"B: {B}");
            //data type double
            //double L = 1.5, K = 2.5;
            //Console.WriteLine($"L: {L}");
            //Console.WriteLine($"K: {K}");
            //Console.WriteLine("*******AFTER SWAP");

            //Helper.Swap(ref L, ref K); // passing by ref
            //Console.WriteLine($"L: {L}");
            //Console.WriteLine($"K: {K}");

            // data type point 

            // point x , y 

            //Point po1 = new Point( 1 ,1 );
            //Point po2 = new Point( 2 ,1 );
            //Console.WriteLine($"po1: {po1}");
            //Console.WriteLine($"po2: {po2}");

            //Console.WriteLine("*****after swapping ******");
            //   Helper.Swap(ref po1 , ref po2);
            //Console.WriteLine($"po1: {po1}");
            //Console.WriteLine($"po2: {po2}"); 
            #endregion

            #region generic 
            //generic swap 
            //data type int 
            //int A = 1, B = 3;
            //  Console.WriteLine($"A: {A}");
            //  Console.WriteLine($"B: {B}");
            //  Console.WriteLine("*******AFTER SWAP");
            //  Helper.Swap/*<int>*/( ref A, ref B ); // passing by ref
            //  Console.WriteLine($"A: {A}");
            //  Console.WriteLine($"B: {B}");

            //data type double
            //double L = 1.5, K = 2.5;
            //Console.WriteLine($"L: {L}");
            //Console.WriteLine($"K: {K}");
            //Console.WriteLine("*******AFTER SWAP");

            //Helper.Swap(ref L, ref K); // passing by ref
            //Console.WriteLine($"L: {L}");
            //Console.WriteLine($"K: {K}"); 
            #endregion

            #region linear search
            //int[] Numberes = { 9, 7, 8, 5, 1, 2, 2, 5, 15, 14, 78, 10 };

            //int index = Helper.LinearSearch(Numberes, 5);

            //Console.WriteLine($"Index: {index}"); 
            #endregion

            #region employee
            //Employee Eo1 = new Employee { Id = 1, Name = "seif", age = 22, salary = 3000 };
            //Employee Eo2 = new Employee { Id = 2, Name = "sama", age = 25, salary = 30000 };
            //Employee Eo3 = new Employee { Id = 3, Name = "soha", age = 28, salary = 300000 };
            //Employee Eo4 = new Employee { Id = 4, Name = "sami", age = 24, salary = 4000 };
            //Console.WriteLine();
            //Employee[] employees = { Eo1, Eo2, Eo3, Eo4 };
            //int index = Helper.LinearSearch(employees, Eo1);
            //Console.WriteLine($"index: {index} "); 
            #endregion

            //notes 
            //class< has equal function which inhirted from object class -> compare references 
            //struct< has equal function which inhirted from object class ->  compare data 
            // struct donot have implementation from == operator 
        }
    }
}
