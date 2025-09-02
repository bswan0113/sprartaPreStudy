using prestudy.Step5.Lv1;

class Program
{
    public static void Main(string[] args)
    {
        var oddNumber = new OddNumber();

        oddNumber.PrintWithFor();
        oddNumber.PrintWithWhile();
        oddNumber.PrintWithDoWhile();
    }
}