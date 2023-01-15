// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите три числа: ");

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
 
int max = 0;

if (num1 >= num2)
  {
    max = num1;
  }
else 
  {
    max = num2;
  }

if (max >= num3)
  {
    
  }
else
  {
    max = num3;
  }

System.Console.WriteLine("Максимально число: " + max);

