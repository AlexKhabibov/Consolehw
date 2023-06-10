Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это ж та самая легендарная Маша!");
}
else
{
    Console.Write("Ты не Маша, пох на тебя, ");
    Console.WriteLine(username);
}