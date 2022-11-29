Console.Write("Введите имя пользователя:");  //Ввести имя пользователя в одной строке write
string username = Console.ReadLine();        //string - строка. username - переменная Console.Readline()-с читываем с консоли

if (username.ToLower() == "Маша")                      // Условие uzerneme == "Маша"   ToLower()-все значения "Маша" будут в нижнем регистре "маша"
{
    Console.WriteLine("Ура это же Маша");    // Выводим в консоль
}
else                                         // Иначе 
{
    Console.Write("Привет, ");               // Выводим в консоль в одной строке
    Console.WriteLine(username);           // Выводим в консоль по строчно
}