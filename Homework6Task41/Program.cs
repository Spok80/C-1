// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода слова "stop"

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

string number = InputNumber();

int sum = 0;
while (number != "STOP")
{
  int count = Convert.ToInt32(number);
  if (count > 0) sum++;  
  number = InputNumber();
}
Console.WriteLine($"Число введенных чисел больше нуля - {sum}");

string InputNumber()
{
    Console.WriteLine("Введите число");
    string number = Console.ReadLine();
    return number;
}
