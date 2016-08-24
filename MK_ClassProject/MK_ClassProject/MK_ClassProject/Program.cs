// IT Fdn Class Project Template.cs
// Write a program to keep track of some inventory items as shown below.
// Hint: when creating arrays, as you get or read items into
// your array, then initialize each array spot before its use
// and place a counter or use your own Mylength to keep track
// of your array length as it is used.

using System;
struct ItemData
{
    public int itemIDNo;
    public string sDescription;
    public double dblPricePerItem;
    public int iQuantityOnHand;
    public double dblOurCostPerItem;
    public double dblValueOfItem;
}


class MyInventory
{
    public static void Main()
    {
        // use an interger to keep track of the count of items in your inventory	
        var numberOfItems = 0;				
        var Data = new ItemData[10];

        while (true) {

        Console.WriteLine("\nWould you like to \n1. Add Inventory \n2. Change Inventory \n3. Delete Inventory \n4. View Inventory \n5. Quit");
        var strx = Console.ReadLine();   // read user's input	
        int optx; 
        bool isNumeric = int.TryParse(strx, out optx); // convert the given string to integer to match our case types shown below


        Console.WriteLine(); // provides an extra blank line on screen

        switch (optx)
        {
            case 1:	// add an item to the list if this option is selected
                {
                    Console.Write("Item ID No. :");
                    var strInt = Console.ReadLine();
                    int itemidno = Int32.Parse(strInt);

                    Console.Write("Description :");
                    var sdescription = Console.ReadLine();

                    Console.Write("Price per Item :");
                    var strDbl1 = Console.ReadLine();
                    double dblpriceperitem = double.Parse(strDbl1);

                    Console.Write("QTY on Hand :");
                    var strInt2 = Console.ReadLine();
                    int iquantityonhand = Int32.Parse(strInt2);

                    Console.Write("Cost per Item :");
                    var strDbl3 = Console.ReadLine();
                    double dblourcostperitem = double.Parse(strDbl3);

                    Console.Write("Value of Item :");
                    var strDbl4 = Console.ReadLine();
                    double dblvalueofitem = double.Parse(strDbl4);

                    Data[numberOfItems].itemIDNo = itemidno;
                    Data[numberOfItems].sDescription = sdescription;
                    Data[numberOfItems].dblPricePerItem = dblpriceperitem;
                    Data[numberOfItems].iQuantityOnHand = iquantityonhand;
                    Data[numberOfItems].dblOurCostPerItem = dblourcostperitem;
                    Data[numberOfItems].dblValueOfItem = dblvalueofitem;

                    numberOfItems++;
                    break;
                }

            case 2: //change items in the list if this option is selected
                {
                    Console.Write("Please enter an item ID No:");
                    string strchgid = Console.ReadLine();
                    int chgid = int.Parse(strchgid);
                    bool fFound = false;

                    for (int x = 0; x < numberOfItems; x++)
                    {
                        if (Data[x].itemIDNo == chgid)
                        {
                           fFound = false;
                                for (var index = chgid - 1; index < numberOfItems; index++)
                                {
                                    Data[index] = Data[index + 1];
                                }
                                numberOfItems--;
                                goto case 1;
                       }
                    }

                    if (!fFound) // and if not found
                    {
                        Console.WriteLine("Item {0} not found", chgid);
                    }

                    break;
                }
                        
            case 3: //delete items in the list if this option is selected
                {
                    Console.Write("Please enter an item ID No:");
                    string strnewid = Console.ReadLine();
                    int newid = int.Parse(strnewid);
                    bool fDeleted = false;

                    for (int x = 0; x < numberOfItems; x++)
                    {
                        if (Data[x].itemIDNo == newid)
                        {
                            fDeleted = true;

                             for (var index = newid - 1; index < numberOfItems; index++)
                            {
                                Data[index] = Data[index + 1];
                            }
                            numberOfItems--;

                            break;						
                        }
                    }

                    if (fDeleted) // hint the user that you deleted the requested item
                    {
                        Console.WriteLine("Item deleted");
                    }
                    else // if did not find it, hint the user that you did not find it in your list
                    {
                        Console.WriteLine("Item {0} not found", newid);
                    }

                    break;
                }

            case 4:	 //list all items in current database if this option is selected
                {
                    Console.WriteLine("Item#  ItemID  Description           Price   QOH  Cost    Value");
                    Console.WriteLine("-----  ------  --------------------  ------  ---  ------  ------");

                        // code in this block. Use the above line format as a guide for printing or displaying the items in your list right under it
                        for (int index = 0; index < numberOfItems; index++)
                        {
                            Console.WriteLine("{0, -6} {1, -7} {2, -21} {3, -7:C} {4, -4} {5, -7:C} {6:C}", index + 1, Data[index].itemIDNo, Data[index].sDescription, Data[index].dblPricePerItem, Data[index].iQuantityOnHand, Data[index].dblOurCostPerItem, Data[index].dblValueOfItem);
                    }

                        break;
                }


            case 5: //quit the program if this option is selected
                {
                    Console.Write("Are you sure that you want to quit(y/n)?");
                    string strresp = Console.ReadLine();

                    if (strresp == "y")
                    {
                        optx = 0;	//as long as it is not 5, the process is not breaking
                        return;	
                    }
                    break;
                }

            default:
                {
                    Console.Write("Invalid Option, try again");
                    break;
                }
 
        }
    }
}
}