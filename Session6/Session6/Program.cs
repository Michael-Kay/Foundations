/*
// File: Struct.cs
using System;

struct Person
{
    public string Name;
    public int Age;
}

class Test
{
    static void Main()
    {
        Person[] persons = new Person[2];

        persons[0].Name = "Steve";
        persons[0].Age = 31;

        persons[1].Name = "Lisa";
        persons[1].Age = 28;

        foreach (Person p in persons)
        {
            Console.WriteLine("{0} is {1} years old.", p.Name, p.Age);
            Console.ReadLine();
        }
    }
}
*/

/*
    using System;

class MyString
{
    // "normal" fields (X) and readonly fields
    // can be initialized in the constructor
    public MyString(string str)
    {
        Str = str;
        Length = str.Length;
    }

    // "normal" field (variable)
    public string Str;

    // readonly fields can only be initialized
    // here or in the constructor
    public readonly int Length = 0;

    // const fields must use simple types
    // such as a byte, int, long, float, etc
    public const int MaxLength = 255;  //could replace cont with static and no intanciation is neccisary. it'll become freely avaliable

}

class TestMyString
{
    static void Main()
    {
        MyString mystr = new MyString("Test me");

        // Initialize a "normal" field
        mystr.Str = "Hello";

        // Error: The following field
        // is readonly
        //mystr.Length = 5;

        Console.WriteLine("Str is {0}",
            mystr.Str);

        Console.WriteLine("Length is {0}",
            mystr.Length);

        // Because MaxLength is a const field, you must
        // access it through its class name
        Console.WriteLine("Length is {0}",
            MyString.MaxLength);

        Console.ReadLine();
    }
}
*/


/*
    // File: Point3.cs
using System;

class Point
{
    private int X;
    private int Y;

    // public Constructor
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void GetPointByVal(int x, int y)
    {
        x = X;
        y = Y;
    }
    public void GetPointByRef(ref int x, ref int y)
    {
        x = X;
        y = Y;
    }
    public void GetPointByOut(out int x, out int y)
    {
        x = X;
        y = Y;
    }
}

class TestPoint3Class
{
    static void Main()
    {
        Point pt = new Point(10, 20);

        // take it dont need it back
        int px = 0;
        int py = 0;
        pt.GetPointByVal(px, py);
        Console.WriteLine("{0},{1}", px, py);

        // initialize and then gets it abck
        int x = 0;
        int y = 0;
        pt.GetPointByRef(ref x, ref y);
        Console.WriteLine("{0},{1}", x, y);

        //no need to initialize, gets it back
        int ox;
        int oy;
        pt.GetPointByOut(out ox, out oy);
        Console.WriteLine("{0},{1}", ox, oy);

        Console.ReadLine();
    }
}
*/

// EXCERIZES BEGIN BELOW

/*
 
//file: BankAccount.cs

using System;

class BankAccount
{
    private decimal Balance;

    public BankAccount()
    {
        Balance = 0;
    }
    //TODO: create the deposit fucntion
    public void Deposit(decimal Deposit)
    {
        Deposit = Balance + Deposit;
    }
    //TODO: create the withdrawal function
    public void Withdrawal(decimal Withdrawal)
    {
        balance = Balance - Withdrawal;
    }
    //TODO: Create the balance field
    public void GetBalance(decimal GetBalance)
    {
        return balance;
    }
}

class Test
{
    static void main()
    {
        BankAccount acct = new BankAccount(100);


        acct.Deposit(200m);
        acct.Withdrawal(40m);

        Console.WriteLine("Balance {O:C}", acct.GetBalance());
        Console.ReadLine();
    }
}
*/


using System;

class TestAverage
{
    static int iAvg;
    static double dAvg;

    //1. Create the integer Average() fucntion here.
    public static int Average(int x, int y, int z, int a)
    {
        int x = 5;
        int y = 4;
        int z = 2;
        int a = 8;
    }

    //2. create the double average() function here.
    public static double Average(double dx, double dy, double dz, double da, double da)
    {
        dAvg = Average;
    }

    //3. Nothing to do here.
    static void Main()
    {
        int iAvg = Average(5, 4, 2, 8);
        Console.WriteLine("The average is {0}", iAvg);

        double dAvg = Average(5.0, 4.0, 2.0, 8.0);
        Console.WriteLine("The average is {0}", dAvg);

        Console.ReadLine();
    }
}
