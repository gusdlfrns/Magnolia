using System;
using System.Linq;

class HangmanGame
{
    static void Main()
    {
        string[] wordList = { "Microsoft", "Linux", "MacOS", "Developer", "Artificial" };
        Random random = new Random();
        string answer = wordList[random.Next(wordList.Length)].ToLower();
        char[] display = new string('_', answer.Length).ToCharArray(); 
        bool[] revealed = new bool[answer.Length]; 
        int remaining = answer.Length;

        Console.WriteLine("행맨 게임 시작!");
        
        while (remaining > 0)
        {
            Console.WriteLine("\n현재 상태: " + string.Join(" ", display));
            Console.Write("문자 입력: ");
            char input = char.ToLower(Console.ReadKey().KeyChar); 
            Console.WriteLine();

            if (!char.IsLetter(input))
            {
                Console.WriteLine("알파벳만 입력하세요.");
                continue;
            }

            bool found = false;
            for (int i = 0; i < answer.Length; i++)
            {
                if (!revealed[i] && answer[i] == input)
                {
                    display[i] = answer[i]; 
                    revealed[i] = true;
                    found = true;
                    remaining--;
                }
            }

            if (!found)
            {
                Console.WriteLine("틀렸습니다! 다시 시도하세요.");
            }
        }

        Console.WriteLine("\n축하합니다! 정답은 '" + answer + "' 입니다!");
    }
}