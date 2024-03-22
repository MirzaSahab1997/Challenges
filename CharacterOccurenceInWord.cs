Console.WriteLine("Please Enter string to count letters");
var inputWord = Console.ReadLine();
var letterCounts = GetStringCount(inputWord == null ? "" : inputWord);

if (letterCounts == null)
{
    Console.WriteLine($"Please Provide word to be calculate letters.");
}

foreach (var letter in letterCounts.Keys)
{
    Console.WriteLine($"{letter} : {letterCounts[letter]}");
}

static Dictionary<char, int> GetStringCount(string wordToBeCountLetters)
{
    Dictionary<char, int> dict = new Dictionary<char, int>();

    if (string.IsNullOrWhiteSpace(wordToBeCountLetters))
    {
        return dict;
    }

    foreach (char ch in wordToBeCountLetters.Replace(" ", string.Empty))
    {
        if (dict.ContainsKey(ch))
        {
            dict[ch] = dict[ch] + 1;
        }
        else
        {
            dict.Add(ch, 1);
        }
    }

    return dict;
}
