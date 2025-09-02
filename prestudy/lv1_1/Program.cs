int min = 1;
int max = 100;


Console.WriteLine("---------------------FOR LOOP START-------------------------");
for (int i = 1; i <= max; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}
Console.WriteLine("---------------------FOR LOOP END-------------------------");
Console.WriteLine("\n---------------------WHILE LOOP START-------------------------");
{
    int i = min;
    while (i <= max)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
        i++;
    }
}
Console.WriteLine("---------------------WHILE LOOP END-------------------------");
Console.WriteLine("\n---------------------DO_WHILE LOOP START-------------------------");

{
    int i = min;
    do
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
        i++;
    } while (i <= max);
}
Console.WriteLine("\n---------------------DO_WHILE LOOP END-------------------------");