using System;
using System.Linq;

class HangmanGame
{
    static void Main()
    {
        string[] wordList = { "Microsoft", "Hangman", "Programming", "Developer", "Artificial" };
        Random random = new Random();
        string answer = wordList[random.Next(wordList.Length)].ToLower(); // 랜덤 단어 선택 (소문자로 변환)
        char[] display = new string('_', answer.Length).ToCharArray(); // 언더바로 초기화
        bool[] revealed = new bool[answer.Length]; // 문자 활성화 여부
        int remaining = answer.Length;

        Console.WriteLine("행맨 게임 시작!");
        
        while (remaining > 0)
        {
            Console.WriteLine("\n현재 상태: " + string.Join(" ", display));
            Console.Write("문자 입력: ");
            char input = char.ToLower(Console.ReadKey().KeyChar); // 소문자로 변환
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