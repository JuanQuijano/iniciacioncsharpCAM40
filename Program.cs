using System;

Console.Clear();

string pangram = "The quick brown fox jumps over the lazy dog";
string[] words = pangram.Split(' ');
string[] reversedWords = new string[words.Length];

for (int i = 0; i < words.Length; i++)
{
    char[] chars = words[i].ToCharArray();
    Array.Reverse(chars);
    reversedWords[i] = new string(chars);
}

string resultado = string.Join(" ", reversedWords);
Console.WriteLine(resultado);

// ehT kciuq nworb xof spmuj revo eht yzal god