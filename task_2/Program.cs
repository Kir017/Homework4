// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetValue(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());

}

void SumNumber (int Number)
{
int sum = 0;
while (Number > 0)
{
    sum += Number % 10;
    Number /= 10;
}
Console.WriteLine(sum);    
}

int number = GetValue("Введите число: ");
SumNumber(number);