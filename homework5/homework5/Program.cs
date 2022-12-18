//Problem #1----

//int radius = Convert.ToInt32(Console.ReadLine());
//int diameter = radius * 2;

//var s2 = diameter * diameter;
//var s1 = 2*(radius * radius);

//var difference = s2 - s1;
//Console.WriteLine(difference);


//Problem #2----
List<char> listOfChars = new List<char>();


for (int i = 0; i < 4; i++)
{
    listOfChars.Add(Convert.ToChar(Console.ReadLine()));
}

var first = listOfChars.First();

for (int i = 1; i < listOfChars.Count; i++)
{
    if (listOfChars[i] != first )
    {
        Console.WriteLine("NO JACKPOT");
        break;
    }
    else
    {
        Console.WriteLine("JACKPOT");
    }
}


//Problem #3 ----
//Console.WriteLine("input number of wins: ");
//int win = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("input number fo ties: ");
//int tie = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("input number of loses: ");
//int lose = Convert.ToInt32(Console.ReadLine());

//int result = win * 3 + tie * 1 + lose * 0;
//Console.WriteLine(result);


//Problem #4----

//List<int> hoursWorked = new List<int>();

//for (int i = 0; i < 7; i++)
//{
//    hoursWorked.Add(Convert.ToInt32(Console.ReadLine()));
//}

//var overtime = 0;
//var overtimeSum = 0;
//var normalTime = 0;
//var normalTimeSum = 0;

//for (int i = 0; i < 5; i++)
//{
//    if (hoursWorked[i] <= 8)
//    {
//        normalTime = hoursWorked[i] * 10;
//        normalTimeSum = normalTime * 5;
//    }

//    else if (hoursWorked[i] > 8)
//    {
//        overtime = (hoursWorked[i] - 8) * 15;


//    }

//}

//var final = normalTimeSum + overtimeSum;

//Console.WriteLine(final);












