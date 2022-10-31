using System.Linq;

//Problem #1----

topGMethod(0, 0, 0);



static void topGMethod(int a, int b, int c)
{
    Console.WriteLine("Enter min number: ");
    a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("enter max number: ");
    b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter last number: ");
    c = Convert.ToInt32(Console.ReadLine());

    var numbersBetween = 0;

    for (int i = 0; i < b; i++)
    {
        var power = Math.Pow(i, c);
        if (power >= a && power <= b)
        {
            numbersBetween++;
        }
    }
    Console.WriteLine(numbersBetween);

}


//problem #2----

findTwins();

static void findTwins()
{
    string word = Convert.ToString(Console.ReadLine());
    char[] wordToArray = word.ToCharArray();

    var Twin = 0;

    for (int i = 1; i < wordToArray.Length; i++)
    {
        for (int j = 0; j < i; j++)
        {
            if (wordToArray[j] == wordToArray[i])
            {
                Twin++;
            }
        }

    }
    Console.WriteLine(Twin);
}

//Problem #3----

sameEnding();

static void sameEnding()
{
    Console.WriteLine("Input first word: ");
    string firstWord = Convert.ToString(Console.ReadLine());
    char[] firstWordArray = firstWord.ToArray();
    Array.Reverse(firstWordArray);

    Console.WriteLine("Input second word: ");
    string secondWord = Convert.ToString(Console.ReadLine());
    char[] secondWordArray = secondWord.ToArray();
    Array.Reverse(secondWordArray);

    List<char> mutual = new List<char>();

    for (int i = 0; i < firstWordArray.Length; i++)
    {
        if (firstWordArray[i] == secondWordArray[i])
        {
            mutual.Add(firstWordArray[i]);
        }
        else
        {
            break;
        }

    }

    mutual.Reverse();
    var backToString = String.Concat(mutual);
    Console.WriteLine(backToString);

}

//Problem #4----

