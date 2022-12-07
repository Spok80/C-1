// Ввод случайного троичного числа и удаление второй цифры

int number = new Random().Next(100, 1000); // интервал от 100 до 999
int digit3 = number % 10;
int digit2 = number % 100 / 10;
int digit1 = number / 100;

Console.WriteLine($"Случайное число = {number}, без второй цифры = {digit1}{digit3}");
// Console.WriteLine(number/100*10+number%10); // Сразу поиск первой и 3 цифры числа
