int shift = 3; // Shift value for Caesar cipher 
string encrypted = "";



Console.Write("Enter a message to encrypt: ");   
string input = Console.ReadLine() ?? "";

foreach (char c in input)
{
    if (char.IsLetter(c))
    {
        char offset = char.IsUpper(c) ? 'A' : 'a';
        char shifted = (char)((((c + shift) - offset) % 26) + offset);
        encrypted += shifted;
    }
    else
    {
        encrypted += c;
    }
}