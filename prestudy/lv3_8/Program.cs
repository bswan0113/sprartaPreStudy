Console.WriteLine("야구 게임을 시작합니다.");
int numCount = 3;
int [] targetNumber = new int[numCount];
int [] userGuess = new int[numCount];
int strikes = 0;
int balls = 0;
bool guessedCorrectly = false;
int attemptCount = 0;
int generatedCount = 0;

Random rand = new Random();

while (generatedCount < numCount)
{
    int newDigit = rand.Next(0, 10);

    if (!targetNumber.Contains(newDigit))
    {
        targetNumber[generatedCount] = newDigit;
        generatedCount++;
    }
}

do
{
    strikes = 0;
    balls = 0;
    Console.WriteLine("Enter your guess (3 digits) : ");
    int num = inputNumber();
    userGuess[0] = num / 100;
    userGuess[1] = (num / 10) % 10;
    userGuess[2] = num % 10;
    attemptCount++;
    for (int i = 0; i < numCount; i++)
    {
        for (int j = 0; j < numCount; j++)
        {
            if (userGuess[i] == targetNumber[j])
            {
                if (i == j) strikes++;
                else balls++;
            }
        }
    }

    if (strikes == 3)
    {
        guessedCorrectly = true;
        Console.WriteLine($"Congratulations! You've guessed the number in {attemptCount} attempts.");
    }
    else
    {
        Console.WriteLine($"{strikes} Strike(s),{balls} Ball(s)");
    }


}while(!guessedCorrectly);

int inputNumber()
{
    while (true)
    {
        Console.Write("3자리 숫자를 입력해주세요: ");
        string userInput = Console.ReadLine();

        if (userInput.Length != 3)
        {
            Console.WriteLine("입력 길이가 3자리가 아닙니다. 다시 시도해주세요.");
            continue;
        }

        if(int.TryParse(userInput, out int number))
        {
            if (number > 0) {
                return number;
            }
        }
        Console.WriteLine("유효한 3자리 숫자가 아닙니다. 다시 시도해주세요.");
    }
}
