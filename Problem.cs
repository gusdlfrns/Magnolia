using Sysyem;

string word = "hello"

int maxLives = 7;
int currentLives=maxLives;

bool win = false;

List<char> guessedLetters = new List<char>();

while(currentLives > 0 && !win)
{
    foreach(char c in word)
    {
        if (guessedLetters.Contains(c))
        Console.write(c);
        else
        Console.write(_);
    }
    Console.WriteLine("\nGuess the letter : ");
    Console.WriteLine(currentLives + "/" + maxLives + " lives remaining.");

    char guess = Convert.ToChar(Console.ReadLine());

    if(word.Contains(guess) && )
}