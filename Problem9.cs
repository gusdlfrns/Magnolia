using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] answer = Enumerable.Range(1, 9).OrderBy(_ => random.Next()).Take(4).ToArray();

        while (true)
        {
            Console.Write("숫자 입력 (4개): ");
            int[] guess = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int strike = 0, ball = 0;
            for (int i = 0; i < 4; i++)
            {
                if (answer[i] == guess[i]) strike++;
                else if (answer.Contains(guess[i])) ball++;
            }

            Console.WriteLine($"{strike} Strike, {ball} Ball");
            if (strike == 4)
            {
                Console.WriteLine("정답입니다!");
                break;
            }
        }
    }
}