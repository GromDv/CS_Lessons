Console.Write("Ваше имя: ");
string userName = Console.ReadLine();

if(userName.ToLower() == "маша")
{
    Console.WriteLine("Это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}
