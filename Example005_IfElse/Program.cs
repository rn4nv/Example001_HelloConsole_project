Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "лера")
{
    Console.WriteLine("Ура, это же Лера");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}