//int numberA = 10;                       // Чтобы делить дробные числа dooble  numberA = 10;
//int numbreB = 5;                                                    //dooble  numbreB = 5;
//Console.WriteLine(numberA / numbreB);                               //Console.WriteLine(numberA / numbreB);


int numberA = new Random() .Next(1, 10);  // случайное число от 1 до 9 Next - целочисленное число int
Console.WriteLine(numberA);               // Вывод первое число 
int numbreB = new Random() .Next(1, 10);
Console.WriteLine(numbreB);               // Вывод второе число
int resolt = numberA + numbreB;
Console.WriteLine(resolt);