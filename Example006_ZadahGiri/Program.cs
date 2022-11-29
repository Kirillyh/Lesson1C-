int a = 1;   // создаем переменные
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;  // создаем переменную int max присваиваем ей значение a

if (a > max) max = a; // Условие если a > max то max = a
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;
Console.Write("max = ");   //выводим в консоль max =
Console.WriteLine(max);