// Напишите программу, которая будет преобразовывать десятисное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void ToBinarySystem(int Num)
{
    if(Num <= 0)
    {
        return;
    }
    ToBinarySystem(Num/2);
    System.Console.Write(Num % 2);
}
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
ToBinarySystem(number);