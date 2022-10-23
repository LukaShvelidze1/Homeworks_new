//Problem #1----

//topGMethod(0,0,0);



//static void topGMethod(int a, int b, int c)
//{
//    Console.WriteLine("Enter min number: ");
//    a = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("enter max number: ");
//    b = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Enter last number: ");
//    c = Convert.ToInt32(Console.ReadLine());

//    var numbersBetween = 0;

//    for (int i = 0; i < b; i++)
//    {
//        var power = Math.Pow(i, c);
//        if (power >= a && power <= b)
//        {
//            numbersBetween++;
//        }
//    }
//    Console.WriteLine(numbersBetween);

//}


//problem #2----

//findTwins();

//static void findTwins()
//{
//    string word = Convert.ToString(Console.ReadLine());
//    char[] wordToArray = word.ToCharArray();

//    var Twin = 0;

//    for (int i = 1; i < wordToArray.Length; i++)
//    {
//        for (int j = 0; j < i; j++)
//        {
//            if (wordToArray[j] == wordToArray[i])
//            {
//                Twin++;
//            }
//        }

//    }
//    Console.WriteLine(Twin);
//}

//Problem #3----



static void sameEnding()
{
    Console.WriteLine("Input first word: ");
    string firstWord = Convert.ToString(Console.ReadLine());
    char[] firstWordArray = firstWord.ToArray();

    Console.WriteLine("Input second word: ");
    string secondWord = Convert.ToString(Console.ReadLine());
    char[] secondWordArray = secondWord.ToArray();

    List<string> mutual = new List<string>();
    

    for (int i = 0; i < firstWordArray.Length; i++)
    {
        for(int j = 0; j < secondWordArray.Length; j++)
        {
            if (firstWordArray[i] == secondWordArray[j])
            {

                mutual.Add(firstWordArray[i]);
            }
        }
    }
    var backToString = String.Concat(mutual);
    Console.WriteLine(backToString);
}