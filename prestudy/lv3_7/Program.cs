Console.WriteLine("행맨 게임을 시작합니다.");

string secretWord = "hangman";
char[] secretChars = secretWord.ToCharArray();
char[] guessWord =  new string('_', secretWord.Length).ToCharArray();
int attempt = 6;
bool wordGuessed = false;

do
{
     Console.WriteLine($"{secretWord.Length}자리 글자를 입력하세요.");
     string input = Console.ReadLine();
     char[] inputChar = input.ToCharArray();
     char[] answer = new string('X', secretWord.Length).ToCharArray();


     for (int i = 0; i < answer.Length && i < inputChar.Length; i++)
     {
          if (inputChar[i] == secretChars[i])
          {
               answer[i] = 'O';
               guessWord[i] = inputChar[i];

          }
     }
     Console.WriteLine($"시행결과 : {new string(answer)}");
     Console.WriteLine($"guessWord : {new string(guessWord)}");
     if (guessWord.SequenceEqual(secretChars))
     {
          wordGuessed = true;
     }
     else
     {
          attempt--;
          Console.WriteLine($"남은 시행횟수 : {attempt}");

     }
}while (wordGuessed == false && attempt > 0);

if (wordGuessed)
{
     Console.WriteLine("축하합니다 정답을 맞췄습니다.");
}
else
{
     Console.WriteLine("정답을 맞추지 못했습니다.");
}