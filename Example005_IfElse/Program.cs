Console.Write("Введите имя пользователя: ");
string userName = Console.ReadLine();

if(userName.ToLower() == "вася")
{
    Console.WriteLine("Ура, это же ВАСЯ!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}
