/* #1 Написать программу ,которая справшивает имя пользователя и затем приветствует пользователся от имени. */
Console.WriteLine("Номер 1: ");
Console.Write("Введите ваше имя: ");
string a1 = Console.ReadLine();
Console.Write($"Привет, {a1}");
Console.WriteLine("");
/* #2 Написать программу ,которай на вход дается два целых числа, 
 * на выходк - результат деления одного числа на другое. Предусмотреть 
 * обработку исключительной ситуации, возникающей при делении числа на ноль */
Console.WriteLine("Номер 2: ");
Console.Write("Введи 1-ое число:");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи 2-ое число:");
int a22 = Convert.ToInt32(Console.ReadLine());
if (a22 != 0)
{
    Console.WriteLine(a2 / a22);
}
else
{
    Console.WriteLine("На ноль делить нельзя!!");

}
Console.WriteLine("");
/* #3 Прочитать букву с экрана и вывести на печать следующую за ней букву в алфавитном порядке */
Console.WriteLine("Номер 2: ");
Console.Write("Введите букву алфавита: "); // Запрашиваем букыу
char a3 = Convert.ToChar(Console.ReadLine()); // Переводим в символ
char cl3 = (char)(a3 + 1); // Преобразуем в след слимвол
Console.WriteLine(cl3);
/* #4 */
Console.WriteLine("Номер 16:");
Console.Write("Введите коэф. а: ");
int a16 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэф. b: ");
int b16 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэф. c: ");
int c16 = Convert.ToInt32(Console.ReadLine());
float d116 = b16 * b16 - 4 * a16 * c16;
double d16 = 0;
if (d116 >= 0)
{
    d16 = Math.Sqrt(d116);
}
else
{
    d16 = -5;
}
if (d16 > 0)
{
    double k16 = (-b16 - d16) / (a16 * 2);
    double k116 = (-b16 + d16) / (a16 * 2);
    Console.WriteLine($"Первый корень: {k16}");
    Console.WriteLine($"Второй корень: {k116}");
}
else if (d16 == 0)
{
    int kk16 = (-1 * b16) / 2 * a16;
    Console.WriteLine($"Единственный корень: {kk16}");
}
else if (d16 < 0)
{
    Console.WriteLine("Корней нет");
}
Console.WriteLine("");


