// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
int GetUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return(result);
}
void cubeTable(int N)
{
    for(int i = 1; i <= N; i++)
    {
        if(i < N)
        {
            Console.Write($"{Math.Pow(i, 3)},");
        } 
        else
        {
            Console.Write($"{Math.Pow(i, 3)}");
        }
    }
}
int N = GetUserValue("Введите число: ");
cubeTable(N);