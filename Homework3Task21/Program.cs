// Задача 21. Принимает на вход координаты 2 точек и находит расстояние между ними в 3d пространстве

// A(3,6,8); B(2,1,-7) -> 15,84
// A(7,-5,0); B(1,-1,9) -> 11,53

Console.WriteLine("Введите координаты x(1)");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y(1)");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты z(1)");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты x(2)");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y(2)");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты z(2)");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x2 - x1),2)+Math.Pow((y2 - y1),2)+Math.Pow((z2 - z1),2));
Console.WriteLine($"Расстояние между точками - {result:f2}");