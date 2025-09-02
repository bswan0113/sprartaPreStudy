Console.WriteLine("숫자 맞추기 게임을 시작합니다.");

bool corrected = false;
Random rand = new Random();
int min = 1;
int max = 100;
int result = rand.Next(min, max);
do
{
    Console.WriteLine($"Enter your guess ({min}-{max}): ");
    int num = 0;
    try
    {
        while (num <= 0)
        {
            string userInput = Console.ReadLine();
            if(int.TryParse(userInput, out int number))
            {
                num = number;
            }else
            {
                Console.WriteLine("숫자를 입력하지 않았습니다. 다시 시도해주세요.");
            }
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    if (num < result)
    {
        Console.WriteLine("Too low! Try again.");
    }else if (num > result)
    {
        Console.WriteLine("Too high! Try again.");
    }
    else if(num == result)
    {
        corrected = true;
        Console.WriteLine("Congratulations! You guessed the number.");
    }
} while (!corrected);