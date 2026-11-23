namespace ConsoleApp05G02;

internal class Program
{
    static void Main(string[] args)
    {
        #region Nullable Value Type

        //bool? b = null;

        //int? x = 0;
        ////Nullable<int> y = 20; // Old And Unused

        //Student student = new Student();

        ////Some Code

        //Console.WriteLine(student.Id); // 0 ? Mine : default


        //int? x = null;
        //int y = 10;

        ////x = y; // Safe

        ////y = (int)x; //UnSafe

        ////if (x != null) //هري
        ////    y = (int) x;
        ////else
        ////    y = 0;

        ////bool HasValue; int Value

        ////y = x != null ? (int) x : 0;

        ////y = x.HasValue ? x.Value : 0;

        //y = x.GetValueOrDefault();

        //Console.WriteLine(y);

        #endregion

        #region Nullable Reference Types

        //string? s1 = null;
        ////string s2 = "";
        //////Some Code
        //////s1 = "blabla";
        //////Student student = null;

        //////Console.WriteLine(student.Id);
        //Console.WriteLine(s1.Length);

        #endregion

        #region Null-Conditional Operator ?. && Null-Coalescing Operators ?? ??= && Null-Forgiving Operator !

        //string? s1 = null;
        ////Some Code

        //Console.WriteLine(s1 != null ? s1.Length : null);
        ////Console.WriteLine(string.IsNullOrEmpty(s1) ? null : s1.Length);
        ////Console.WriteLine(s1?.Length); //if s1 is null replace the entire term with null if not get the length

        //Student student = new Student()
        //{
        //    Id = 1,
        //    Name = "Tarek",
        //    Course = new Course()
        //    {
        //        Id = 1,
        //        Name = ".net"
        //    }
        //};

        ////string courseName = student?.Course?.Name ?? "No Course"; //string courseName = null;
        ////Console.WriteLine(courseName);

        //Student student2 = null!;
        //student2 = null;
        ////if(student2 == null)
        ////    student2 = new Student() { Id = 10, Name = "Alaa"};

        //student2 ??= new Student() { Id = 10, Name = "Alaa" };


        #endregion

        #region Arrays

        //int[] numbers = new int[5]; //x02f78 => 4 * 5 = 20 Bytes 
        //int[] numbers = [ 8, 256, 7, 15, 5 ];

        //Console.WriteLine(numbers[2]);

        //Console.WriteLine("Please Enter The Arr Length");
        //bool b = int.TryParse(Console.ReadLine(), out int arrLen);
        //int[] numbers = new int[arrLen];

        //for (int i = 0; numbers.Length > i; i++)
        //    b = int.TryParse(Console.ReadLine(), out numbers[i]);

        //Console.Clear();
        //foreach (int number in numbers)
        //    Console.WriteLine(number);

        //int[] numbers01 = { 1, 2, 3, 4, 5 };
        //int[] numbers02 = { 1, 2, 3, 4, 5 };

        //int[,] numbers = new int[5, 5];


        //int[,] numbers =
        //{
        //    { 1, 2, 3, 4, 5 },
        //    { 1, 2, 3, 4, 5 },
        //    { 1, 2, 30, 4, 5 }
        //};

        //Console.WriteLine(numbers[2,2]);


        #endregion

        #region Functions Intro

        //Print("Omar");

        //bool b = int.TryParse(Console.ReadLine(), out int result);

        //int a = 5, b = 6;

        //int x = Sum(a, b);
        //Console.WriteLine(x);

        #endregion

        #region Passing By value (Value Types & Reference Type)

        //int a = 0, b = 4;

        //Console.WriteLine(a);
        //int x = Sum(a, b);
        //Console.WriteLine(a);


        //int[] numbers = { 1, 2, 3 };

        //Console.WriteLine(numbers[0]); // 1
        //SumArr(numbers);
        //Console.WriteLine(numbers[0]); // 2

        //int[] numbers = { 1, 2, 3 };

        //Console.WriteLine(numbers[0]); // 1
        //reassignArr(numbers);
        //Console.WriteLine(numbers[0]); // 1


        #endregion

        #region Passing By reference (Value Types & Reference Type)

        //int a = 0, b = 4;

        //Console.WriteLine(a); // 0
        //int x = SumByRef(ref a, ref b);
        //Console.WriteLine(a); // 1

        //int[] numbers = { 1, 2, 3 };

        //Console.WriteLine(numbers[0]); // 1
        //SumArrByRef(ref numbers);
        //Console.WriteLine(numbers[0]); // 2

        //int[] numbers = { 1, 2, 3 };

        //Console.WriteLine(numbers[0]); // 1
        //reassignArr(ref numbers);
        //Console.WriteLine(numbers[0]); // 10


        #endregion

        #region Functions 02
        //int a = 5;
        //int b = 6;
        //Console.WriteLine(Sum(y: a, x: b));

        //Console.WriteLine("We're Done");

        //int price;
        //bool b = FindBook(Console.ReadLine() ?? "Default Book", out price);

        //Console.WriteLine(price);


        int x = 1, y = 2, z = 3;

        //int[] numbers = { x, y, z };

        //Console.WriteLine(numbers[0]);
        SumArrParams(x, "Ali", y, x, z, x);
        //Console.WriteLine(numbers[0]);


        #endregion


    }

    #region Functions

    static int SumArrParams(int number, string s, params int[] x)
    {
        x[0]++;
        return x[0] + x[1];
    }

    static bool FindBook(string bookName, out int? price)
    {
        if (bookName == ".NET")
        {
            price = 50;
            return true;
        }
        else if (bookName == "C#")
        {
            price = 100;
            return true;
        }
        else
        {
            price = null;
            return false;
        }
    }


    static int reassignArr(ref int[] x)
    {
        x = new int[] { 10, 20, 30 };
        return x[0] + x[1];
    }


    static int SumArrByRef(ref int[] x)
    {
        x[0]++;
        return x[0] + x[1];
    }

    static int SumByRef(ref int x, ref int y)
    {
        x++;
        return x + y;
    }

    static int reassignArr(int[] x)
    {
        x = new int[] { 10, 20, 30 };
        return x[0] + x[1];
    }

    static int SumArr(int[] x)
    {
        x[0]++;
        return x[0] + x[1];
    }
    static int Sum(int x, int y = 0)
    {
        x++;
        return x + y;
    }

    static void Print(string s)
    {
        Console.WriteLine(s);
    }




    #endregion



}
