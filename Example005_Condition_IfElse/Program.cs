Console.WriteLine("Введите имя пользователя:");
string username = Console.ReadLine();

if (username.ToLower() == "руслан")
{
    Console.WriteLine("Ура, это же Руслан!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}