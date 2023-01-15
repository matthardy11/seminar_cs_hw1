// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите положительное число: ");

int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
  if (num == 1)
  {
    System.Console.WriteLine("От 0 до 1 нет четных чисел");
  } 
  else
  {
    for(int i = 2; i <= num; i+=2)
    {
      System.Console.Write(i + ", ");
    }
  }
else
{
  System.Console.WriteLine("Число меньше или равно 0");
}
