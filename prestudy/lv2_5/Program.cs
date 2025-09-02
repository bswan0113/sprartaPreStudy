int start = 2;
int end = 9 ;
Console.WriteLine("구구단 출력을 시작합니다.");
Console.WriteLine("세로 출력은 0, 가로출력은 그 외 버튼을 입력해주세요.");

string choice = Console.ReadLine();

if (choice == "0")
{
    for (int i = 1; i <= 9; i++)
    {
        for (int j = start; j <= end; j++)
        {
            Console.Write($"{j} x {i} = {j * i}\t");
        }
        Console.WriteLine();
    }
}
else
{
    for (int i = start; i <= end; i++)
    {
        for (int j = 1; j <= 9; j++)
        {
            Console.Write($"{i} x {j} = {i * j}\t");
        }
        Console.WriteLine();
    }
}