using System.IO;
using System.Xml;
using System.Text.Json;
using Homework9.myfolder;
using System.Text.Json.Serialization;



//Problem #1----
string path = @"C:\Users\Geekster PC\Desktop\Homeworks_new\Homework9\Homework9\myfolder\New_file.txt";

//Write
if (!File.Exists(path))
{
    StreamWriter sw = File.CreateText(path);
}

int input = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < input; i++)
{
    string inputText = Convert.ToString(Console.ReadLine());

    File.AppendAllText(path, inputText + Environment.NewLine);
}

////READ
//StreamReader sr = File.OpenText(path);
var lastLine = File.ReadLines(path).Last();
Console.WriteLine(lastLine);

//Problem #2----

int number = Convert.ToInt32(Console.ReadLine());
using(StreamWriter sw = new StreamWriter(path))
{
    for (int j = 1; j <= number; j++)
    {
        sw.WriteLine("------------");
        for (int k = 1; k <= 10; k++)
        {
            sw.WriteLine("{0} X {1} = {2} ", j, k, j * k);
        }
    }
}



//Problem #3---- unfinished

//var XMLpath = @"C:\Users\Geekster PC\Desktop\Homeworks_new\Homework9\Homework9\XML.xml";


//Problem #4---- unfinished
var birthday = new birthday();

List<birthday> _data = new List<birthday>();
_data.Add(new birthday()
{
    CurrentDate = "currentDate : June 14, 2022",

    Birthday = "birthday : June 20, 2022"
}) ;








