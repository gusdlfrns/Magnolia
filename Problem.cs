using Sysyem;

Console.Write("Write the Word : ");
string word = string.Parse(Console.ReadLine);

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

    if(word.Contains(guess) && !guessedLetters.Contains(guess))
    {
        Console.WriteLine("Correct!");
    }
    else
    {
        Console.WriteLine("Incorrect!");
        currentLives--;
    }
    guessedLetters.Add(guess);

    bool wordComplete=true;

    foreach(char c in word)
    if(!guessedLetters.Contains(c))
    wordComplete=false;

    win = wordComplete;
}
if(win){
    Console.WriteLine("Congraguration. You Win!")
}
else{
    Console.WriteLine("You lose...");
}