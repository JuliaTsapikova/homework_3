// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом

int GetUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return(result);
}


void checkNumber(int n)
{
    int c_n = n;
    int r_v = 0;

    while(n != 0)
{
    int d = n % 10;
    r_v = r_v *10 + d;
    n = n /10;
}

    Console.WriteLine(r_v);
    if(c_n == r_v)
{
    Console.WriteLine("Введенное число является палиндромом");
}
    else
{
    Console.WriteLine("Введенное число не является палиндромом");
}
 
}
 
 int n = GetUserValue("Введите пятизначное число: ");
 checkNumber(n);




