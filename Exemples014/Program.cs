using System.Linq;

Console.Clear();

/*string text = "(1,2) (2,3) (4,5) (6,7)"
                .Replace("(", "")
                .Replace(")", "");

var data = text.Split(" ")
            .Select(item => item.Split(','))
            .Select (e => int.Parse(item[0]), int.Parse(item[1]));
            .ToArray();
for (int i = 0; i < data.Length; i++)
{
    //Console.Write(data [i]);
    for (int k = 0; k < data[i].Length; k++)
    {
        Console.Write($"{data[i][k]}, ");   
    }
    Console.WriteLine();
}*/

void FindWords (string text, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{new String (word)}");
        return;
    }
    for (int i = 0; i < text.Length; i++)
    {
        word[length] = text[i];
        FindWords(text, word, length+1);
    }
}

FindWords("0123456789", new char[4]);

