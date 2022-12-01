Console.Write("Введите имя: ");
string username = Console.ReadLine();

if (username.ToLower () == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else 
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}