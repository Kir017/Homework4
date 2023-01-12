// Напишите программу, которая выводит массив из N элементов, заполненный нулями и единицами в случайном порядке.
// Самое левое число != 0
// Данный массив есть двоичное представление десятичного числа [1,0,1,1,0,1,0,0]
// Реализовать перевод двоичного числа в десятичное

// 1. Ввод N
// int <- (string)
int GetValue(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());

}


// 2. Создание массива
// int[] <- (int)
int[] CreateArray(int size)
{
  int[] array = new int[size];
  return array;
}

// 3. Заполнение массива 0 и 1
// void <- (int[])
void FillArray(int[] binNumber)
{
  int count = binNumber.Length;
  for (int i = 0; i < count; i++)
  {
    binNumber[i] = Random.Shared.Next(2);
    binNumber[1] = 0;
  }
}

// 4. Печать массива
// string <- (int[])
string PrintArray(int[] Numbers)
{
  string output = String.Empty;
  int size = Numbers.Length;

  for (int i = 0; i < size; i++)
  {
    output = output + $"{Numbers[i]} ";
  }
  return output;
}

// 5. Конвертация из 2-ого в 10-ое
// int <- (int[])
int BinToDecimal(int[] arrBin)
{
  int count = arrBin.Length;
  int exponent = arrBin.Length - 1;
  int dec = 0;
  for (int i = 0; i < arrBin.Length; i++)
  {
    if (arrBin[i] == 1)
    {
      dec += Convert.ToInt32(Math.Pow(2, exponent));
    }
    exponent--;
  }
  return dec;
}

// 6. 10110100 >> 180
// string <- (int[] , int)
string GoodPrint(int[] bin, int dec)
{
  return $"{String.Join("", bin)} >> {dec}";
}


int number = GetValue("Введите число: ");
int[] bin = CreateArray(number);
FillArray(bin);
int dec = BinToDecimal(bin);
string binPrint = PrintArray(bin);

Console.WriteLine();
Console.WriteLine(binPrint);
Console.WriteLine();
Console.WriteLine(GoodPrint(bin, dec));



