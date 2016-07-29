/* File: Boxing.cs
using System;

class TestBox
{
    static void Main()
    {
        int myInt = 20;

        // 1. (boxing)
        // myObj now contains the integer
        // value of 20.
        object myObj = myInt;

        // 2. myObj now contains 2001
        myObj = 2001;j

        // 3. (unboxing)
        // myOtherInt contains the value
        // contained in myObj.
        int myOtherInt = (int)myObj;

        // 4. (unboxing)
        // if you wanted to unbox myObj
        // into a double you FIRST need
        // to unbox it as an int and then
        // convert it to a double.
        double dbl = (double)(int)myObj;

        //object objdblx;
        //float fx = 3.5F;
        //objdblx = fx;

// #2 
//D.

//#3 from homewok
        float fx = (float)(double) objdblx;

//#6 from homework
        int ix = 30;
        float fx = ix;

        //#8
        // Mother




    }
}
*/

/* File: VerySimple.cs
using System;

class VerySimple //tool box
{
    int simpleValue;

    public VerySimple() //method : constructor
    {
        simpleValue = 0;
    }
}

class TestVerySimpleClass //Tester who wants to use teh tool box
{
    static void Main()
    {
        VerySimple ver; // notice that ver is null

        ver = new VerySimple();
    }
}
*/

/* File: tv.cs

class Television
{
    private int channel = 0;
    private int volume = 0;
    private bool isOn = false;

    public bool IsOn()
    {
        return isOn;
    }
    public void TurnOn()
    {
        isOn = true;
        // do the code to turn the tv on
    }
    public void TurnOff()
    {
        isOn = false;
        // do the code to turn the tv off
    }

    public int CurrentVolume()
    {
        return volume;
    }
    public void IncreaseVolume()
    {
        if (volume < 100)
        {
            volume = volume + 1;
            // do the code to increase the volume
        }
    }
    public void DecreaseVolume()
    {
        if (volume > 0)
        {
            volume = volume - 1;
            // do the code to decrease the volume
        }
    }

    public int CurrentChannel()
    {
        return channel;
    }
    public void ChangeChannel(int Channel)
    {
        if (Channel > 0 && Channel < 50)
        {
            channel = Channel;
            // do the code to change the
            // channel on the tv
        }
    }
}

class TestTV
{
    static void Main()
    hf{
        Television tv = new Television();

        if (tv.IsOn() == false)
        {
            tv.TurnOn();
        }

        tv.ChangeChannel(3);

        tv.IncreaseVolume();
        tv.IncreaseVolume();
        tv.IncreaseVolume();
        tv.IncreaseVolume();

        tv.TurnOff();
    }
}
*/
 
/* 


    // File: enum.cs 
using System;

enum MonthNames
{
    January = 1,
    February = 2,
    March = 3,
    April = 4
}

enum MonthDays
{
    January = 30,
    February = 28,
    March = 31,
    April = 40
}

class Test
{
    static void Main()
    {

        while (true)
        {
            MonthNames name;
            MonthDays days;

            Console.WriteLine("Enter a month number (EX: January = 1)...\n");
            String input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    name = MonthNames.January;
                    days = MonthDays.January;
                    break;
                case "2":
                    name = MonthNames.February;
                    days = MonthDays.February;
                    break;
                case "3":
                    name = MonthNames.March;
                    days = MonthDays.March;
                    break;
                case "4":
                    name = MonthNames.April;
                    days = MonthDays.April;
                    break;
                default:
                    Console.WriteLine("I didn't understand, try again later");
                    break;
            }
            Console.WriteLine("Write the message here");
            Console.ReadLine();

                x++;
            
        }





            MonthNames month;

        month = MonthNames.March;

        if (month == MonthNames.January)
        {
            Console.WriteLine("It's still Winter");
        }
        else if (month == MonthNames.February)
        {
            Console.WriteLine("It's still Winter");
        }
        else if (month == MonthNames.March)
        {
            Console.WriteLine("It's Spring");
        }

        Console.WriteLine("Month is {0} and its integer value is {1}",
            month, (int)month);

        Console.ReadLine();
    }
}
*/
 
 
    // File: Point2.cs
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

    public int GetX()
    {
        return X;
    }

    public int GetY()
    {
        return Y;
    }
}

class TestPoint2Class
{
    static void Main()
    {
        Point pt = new Point(10, 20);

        Console.WriteLine("{0},{1}", pt.GetX(), pt.GetY());
        Console.ReadLine();
    }
}