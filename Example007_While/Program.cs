Console.Clear();                    // очистить терминал
//Console.SetCursorPosition(10, 4); //Console.SetCursorPosition- Отступы от края 10 - сколько символов отступили 4 - на кокой строке
//Console.WriteLine("+");

int xa = 30, ya = 1, 
    xb = 1, yb = 30,
    xc = 60, yc = 30;

 Console.SetCursorPosition(xa ,ya); //Выводим первую точку
 Console.WriteLine("+");            //Выводим '+' как точку

 Console.SetCursorPosition(xb ,yb);
 Console.WriteLine("+");

 Console.SetCursorPosition(xc ,yc);
 Console.WriteLine("+");

int x = xa, y = xb;                 // Определяем случайную точку  x = xa, y = xb

int count = 0;                     // сколько раз будет производиться цикл нахождение отрезка и деление пополам

while (count < 100);

    int whath = new Random().Next(0, 3); //Создаем переменную new Random().Next(0, 3)-случайное число от 0 до 2
  { 
    if  (whath == 0)                    //Если переменная whath == 0 

    x = (x + xa)/2;                     // Определение первой точки

    y = (y + ya)/2;
}


    if  (whath == 1)                    //Если переменная whath == 1
{
    x = (x + xb)/2;                     // Определение Второй точки

    y = (y + yb)/2;

}

    if  (whath == 2)                    //Если переменная whath == 2
{
    x = (x + xc)/2;                     // Определение первой точки

    y = (y + yc)/2;

}
    Console.SetCursorPosition(x, y);    //Нужная позиция при помоши  Console.SetCursorPosition(x, y)

    Console.WriteLine("+");             // Выводим на экран 

    count = count + 1;                 // Вводим чтобы цикл не работал не бесконечно можно написать count +=1

