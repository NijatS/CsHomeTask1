#region task1

/*
Console.Write("mark : ");
int mark = int.Parse(Console.ReadLine());

if (mark <= 100 && mark > 90)
{
    Console.WriteLine("A");
}
else if (mark <= 90 && mark > 80)
{
    Console.WriteLine("B");
}
else if (mark <= 80 && mark > 70)
{
    Console.WriteLine("C");
}
else if (mark <= 70 && mark > 60)
{
    Console.WriteLine("D");
}
else if (mark <= 60 && mark >= 50)
{
    Console.WriteLine("E");
}
else if (mark <= 50 && mark > 0)
{
    Console.WriteLine("Kesildin brat!!!");
}
else
{
    Console.WriteLine("Duzgun daxil edin...");
}
*/




//task1 other version
/*Console.Write("mark : ");
double mark = double.Parse(Console.ReadLine());

if(mark > 100 || mark < 0)
{
    Console.WriteLine("Please enter correct mark!!!");
    
}
else
{
    switch (mark/10)
    {
        case 10:
        case > 9:
            Console.WriteLine("A");
            break;
        case > 8:
            Console.WriteLine("B");
            break;
        case > 7:
            Console.WriteLine("C");
            break;
        case > 6:
            Console.WriteLine("D");
            break;
        case > 5:
            Console.WriteLine("E");
            break;
        default:
            Console.WriteLine("F kesildin!!");
            break;
    }
}
*/

#endregion

#region task2
//int[] numbers = { -5, -1, -3, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int count1 = 0, count2 = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] > 0)
//    {
//        count1++;
//    }
//    else
//    {
//        count2++;
//    }
//}

//Console.WriteLine("Count of positive numbers : " + count1);
//Console.WriteLine("Count of negative numbers : " + count2);

#endregion

#region task3
//int[] numbers = { 3, 55, 2, 5, 62, 56, 32 };
//int max = numbers[0];

//for (int i = 1; i < numbers.Length; i++)
//{
//    if (numbers[i] > max)
//    {
//        max = numbers[i];
//    }
//}

//Console.WriteLine("Maximum Number : " + max);
#endregion
