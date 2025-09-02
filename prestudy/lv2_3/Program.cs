using System.Text;

int num = 0;
long result = 1;
try
{
    while (num <= 0)
    {
        Console.WriteLine("숫자를 입력해주세요. ");
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


StringBuilder sb = new StringBuilder();
sb.Append($"결과 : {num}! = ");

for (int i = 1; i <= num; i++)
{
    result *= i;
    sb.Append(i);

    if (i < num)
    {
        sb.Append(" X ");
    }
}

sb.Append($" = {result}");

Console.WriteLine(sb.ToString());