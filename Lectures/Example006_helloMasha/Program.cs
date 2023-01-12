Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower()=="маша")//с помощью туловер команды, я теперь могу вводить МаШа, МАША, маша и тд, но в коде нельзя писать "Маша",обязательно надо маленькие буквы иначе не зработает
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);    
}