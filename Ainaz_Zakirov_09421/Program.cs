// #1 Вывести на экран число e (основание натурального логарифма) с точностью до десятых.
Console.WriteLine("Номер 1:");
double a1 = Math.E;
Console.WriteLine(a1.ToString("0.0"));
Console.WriteLine("");
// #2 Вывести на экран числа 50 и 10 одно под другим.
Console.WriteLine("Номер 2:");
Console.WriteLine(50);
Console.WriteLine(10);
Console.WriteLine("");
// #3 Составить программу вывода на экран «столбиком» четырех любых чисел.
Console.WriteLine("Номер 3:");
Console.WriteLine(11);
Console.WriteLine(21);
Console.WriteLine(31);
Console.WriteLine(41);
Console.WriteLine("");
// #4 Пользователь вводит число. Выведите на экран число, которое больше введенного на 10.
Console.WriteLine("Номер 4:");
Console.Write("Введи любое число:");
int a4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a4 + 10);
Console.WriteLine("");
// #5 Дана сторона квадрата. Найти его периметр.
Console.WriteLine("Номер 5:");
Console.Write("Введите сторону квадрата: ");
int a5 = Convert.ToInt32(Console.ReadLine()); ;
int p5 = a5 * 4;
Console.WriteLine(p5);
Console.WriteLine("");
// #6 Дан радиус окружности. Найти длину окружности и площадь круга.
Console.WriteLine("Номер 6:");
Console.Write("Введите радиус круга: ");
int r6 = Convert.ToInt32(Console.ReadLine());
double pi6 = Math.PI;
double c = 2 * pi6 * r6;
double s = pi6 * (r6 * r6);
Console.WriteLine($"Длина круга = {c}");
Console.WriteLine($"Площадь круга = {s}");
Console.WriteLine("");
// #7 Найти значение y=cos(x)
Console.WriteLine("Номер 7:");
Console.Write("Введите градус угла: ");
int x = Convert.ToInt32(Console.ReadLine());
double rad = (x * Math.PI) / 180;
double cos = Math.Cos(rad);
Console.WriteLine(cos);
Console.WriteLine("");
// #8 Даны основания и высота равнобедренной трапеции. Найти ее периметр.
Console.WriteLine("Номер 8:");
Console.Write("Введите меньшее основание: ");
int osnm8 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите большее основание: ");
int osnb8 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту основание: ");
int vs8 = Convert.ToInt32(Console.ReadLine());
int raz8 = osnb8 - osnm8;
int bks88 = (vs8 * vs8 + raz8 * raz8);
double bks8 = Math.Sqrt(bks88);
double p8 = bks8 + bks8 + osnm8 + osnb8;
Console.WriteLine(p8);
Console.WriteLine("");
// #9 Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.
Console.WriteLine("Номер 9:");
Console.Write("Введите стоимость 1 кг конфет: ");
int skon9 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите стоимость 1 кг печенья: ");
int spech9 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 1 кг яблок: ");
int syabl9 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вес конфет: ");
int x9 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вес печенья: ");
int y9 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вес яблок: ");
int z9 = Convert.ToInt32(Console.ReadLine());
int st9 = skon9 * x9 + spech9 * y9 + syabl9 * z9;
Console.WriteLine(st9);
Console.WriteLine("");
/* #10Напишите программу, выводит на экран три строки "Мир", "Труд" и "Май"
(кавычки не нужны). Причём сделайте, чтобы выводилось сначала так:
Мир Труд Май
Затем так:
Мир
      Труд
              Май    */
Console.WriteLine("Номер 10:");
Console.WriteLine("{0,-10}", "Мир");
Console.WriteLine("{0,10}", "Труд");
Console.WriteLine("{0,20}", "Май");
Console.WriteLine("");
/* #11 Программа просит пользователя ввести 2 числовые переменные. А после она
меняет их местами и выводит результат на экран. Но, так как пользователь может
ошибиться, необходимо предусмотреть тот факт, что пользователь может ввести,
например, букву или строку, а так же учесть, что число может быть дробным, и для
выделения её дробной части одни используют точку, другие – запятую. */
Console.WriteLine("Номер 11:");
Console.Write("Введите 1 числовую переменную: ");
string c11 = Console.ReadLine();
Console.Write("Введите 2 числовую переменную: ");
string c211 = Console.ReadLine();
int b11 = 0;
int b111 = 0;
if ((int.TryParse(c11, out b11)) & (int.TryParse(c211, out b111)))
{
    Console.WriteLine(b111);
    Console.WriteLine(b11);
}
else if ((float.TryParse(c11, out float v11)) & (float.TryParse(c211, out float v111)))
{
    Console.WriteLine(v111);
    Console.WriteLine(v11);
}
else
{
    Console.WriteLine("Нужно ввести число, если вы ввели дробное число с запятой, нужно запятую исправить на точку.");
}
Console.WriteLine("");
/* #12 Программа для подсчета периметра и площади фигур (треугольник,
четырехугольник, круг). Пользователь выбирает фигуру, указывает, что программа
будет считать – площадь или периметр. Задаётся все необходимые значения, а на
основе полученных результатов, программа должна подсчитать, какими могли бы
быть периметры или площади остальных фигур. */
Console.WriteLine("Номер 12:");
Console.Write("Если хотите выбрать круг,напишите 1;  Если хотите выбрать треугольник, напишите 2;  Если хотите выбрать четырехугольник, напишите 3: ");
int c112 = Convert.ToInt32(Console.ReadLine());
Console.Write("Если хотите узнать площадь вашей фигуры, введите 1, а если периметр, введите 2: ");
int c1212 = Convert.ToInt32(Console.ReadLine());
if (c112 == 1)
{
    Console.Write("Введите радиус круга: ");
    int r12 = Convert.ToInt32(Console.ReadLine());
    if (c1212 == 1)
    {
        double sk12 = Math.PI * (r12 * r12);
        Console.WriteLine($"Площадь круга равна {sk12}");
    }
    else if (c1212 == 2)
    {
        double pk12 = 2 * Math.PI * r12;
        Console.WriteLine($"Периметр круга равен {pk12}");
    }
}
else if (c112 == 2)
{
    Console.Write("Введите сторону равностороннего треугольника: ");
    int strtg12 = Convert.ToInt32(Console.ReadLine());
    if (c1212 == 1)
    {
        double pl12 = (strtg12 * strtg12 * Math.Sqrt(3)) / 4;
        Console.WriteLine($"Площадь равностороннего треугольника равен {pl12}");
    }
    else if (c1212 == 2)
    {
        int pr12 = strtg12 * 3;
        Console.WriteLine($"Периметр равностороннего треугольника равен {pr12}");
    }
}
else if (c112 == 3)
{
    Console.Write("Введите сторону квадрата: ");
    int strkv12 = Convert.ToInt32(Console.ReadLine());
    if (c1212 == 1)
    {
        int plch12 = strkv12 * strkv12;
        Console.WriteLine($"Площадь квадрата равен {plch12}");
    }
    else if (c1212 == 2)
    {
        int prch12 = strkv12 * 4;
        Console.WriteLine($"Площадь квадрата равен {prch12}");
    }
}
Console.WriteLine("");
// #13 Составить программу вывода на экран числа, вводимого с клавиатуры. Вводимому числу должно предшествовать сообщение «Вы ввели число».
Console.WriteLine("Номер 13:");
Console.Write("Введите число: ");
int ch13 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели число: {ch13}");
Console.WriteLine("");
/* #14 Составить программу вывода на экран следующей информации:
2 кг
13 17 */
Console.WriteLine("Номер 14:");
Console.WriteLine("2 кг");
Console.WriteLine("13 17");
Console.WriteLine("");
// #15 Составить программу вывода на экран «столбиком» четырех случайных чисел.
Console.WriteLine("Номер 15:");
Random r15 = new Random();
Console.WriteLine(r15.Next(10, 100));
Console.WriteLine(r15.Next(10, 100));
Console.WriteLine(r15.Next(10, 100));
Console.WriteLine(r15.Next(10, 100));
Console.WriteLine("");
// #16 Найти корни квадратного уравнения(коэффициента задаются пользователем с клавиатуры)
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
// #17 Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.
Console.WriteLine("Номер 17:");
Console.Write("Введите первое число: ");
int a17 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b17 = Convert.ToInt32(Console.ReadLine());
float sra17 = (a17 + b17) / 2;
Console.WriteLine($"Ср.ариф: {sra17}");
float pr17 = a17 * b17;
double srg17 = Math.Sqrt(pr17);
Console.WriteLine($"Ср.Геом: {srg17}");
Console.WriteLine("");
// #18 Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.
Console.WriteLine("Номер 18:");
Console.Write("Введите координату х первого числа: ");
int x18 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y первого числа: ");
int y18 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату х второго числа: ");
int xx18 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y второго числа: ");
int yy18 = Convert.ToInt32(Console.ReadLine());
int iy18 = yy18 - y18;
int ix18 = xx18 - x18;
double ot18 = Math.Sqrt((ix18 * ix18) + (iy18 * iy18));
Console.WriteLine($"Расстояние между точками {ot18}");
Console.WriteLine("");
/* #19 Составить программу обмена значениями трех переменных величин а, b, c по
следующим двум схемам:
а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
б) b присвоить значение а, с присвоить значение b, а присвоить значение с. */

Console.WriteLine("Номер 19:");
Console.Write("Введите значение a: ");
int a19a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b: ");
int b19a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение c: ");
int c19a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"1a:{a19a},{b19a},{c19a}");
int rezb19 = b19a;
b19a = c19a;
c19a = a19a;
a19a = rezb19;
Console.WriteLine($"2a:{a19a},{b19a},{c19a}");
int a19b = 6;
int b19b = 8;
int c19b = 10;
Console.WriteLine($"1b:{a19b},{b19b},{c19b}");
int rezbb19 = b19b;
b19b = a19b;
a19b = c19b;
c19b = rezbb19;
Console.WriteLine($"2b:{a19b},{b19b},{c19b}");
Console.WriteLine("");
/* #20 С начала суток прошло n секунд. Определить:
а) сколько полных часов прошло с начала суток;
б) сколько полных минут прошло с начала очередного часа;
в) сколько полных секунд прошло с начала очередной минуты. */
Console.WriteLine("Номер 20:");
Console.Write("Введите кол-во секундк, кот. прошло с начала суток : ");
int n20 = Convert.ToInt32(Console.ReadLine());
int ch20 = n20 / 3600;
Console.WriteLine($"Ответ на а): {ch20}");
int cha20 = n20 % 3600;
int min20 = cha20 / 60;
Console.WriteLine($"Ответ на б): {min20}");
int chas20 = n20 % 3600;
int miin20 = chas20 % 60;
Console.WriteLine($"Ответ на а): {miin20}");
Console.WriteLine("");
/* #21 Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130
мм можно отрезать от него? */
Console.WriteLine("Номер 21:");
int shir21 = 130;
int dlin21 = 543;
int kvst21 = 130;
int plpr = shir21 * dlin21;
int plkv = kvst21 * kvst21;
int a21 = plpr / plkv;
Console.WriteLine(a21);
Console.WriteLine();
/* #22 Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали
ее в начале. Найти полученное число. */
Console.WriteLine("Номер 22:");
Console.Write("Введите трехзначное число: ");
int tr22 = Convert.ToInt32(Console.ReadLine());
string posl22 = $"{tr22 % 10}";
string tr222 = $"{tr22 / 10}";
string otv22 = posl22 + tr222;
Console.WriteLine(otv22);
Console.WriteLine();
/* #23 Дано натуральное число n (n > 999). Найти:
а) число сотен в нем;
б) число тысяч в нем. */
Console.WriteLine("Номер 23:");
Console.Write("Введите число n(n > 999): ");
int n23 = Convert.ToInt32(Console.ReadLine());
int sot23 = n23 / 100;
int tys23 = n23 / 1000;
Console.WriteLine($"а) {sot23}");
Console.WriteLine($"б) {tys23}");
Console.WriteLine();
/* #24 Дано четырехзначное число. Найти:
а) число, полученное при прочтении его цифр справа налево;
б) число, образуемое при перестановке первой и второй, третьей и четвертой цифр
заданного числа. Например, из числа 5434 получить 4543, из числа 7048 — 784;
в) число, образуемое при перестановке второй и третьей цифр заданного числа.
Например, из числа 5084 получить 5804;
г) число, образуемое при перестановке двух первых и двух последних цифр
заданного числа. Например, из числа 4566 получить 6645, из числа 7304 — 473.   */
Console.WriteLine("Номер 24:");
Console.Write("Введите четырехзначное число: ");

int n24 = Convert.ToInt32(Console.ReadLine());
int siv4 = n24 % 10;
int siv3 = (n24 / 10) % 10;
int siv2 = (n24 / 100) % 10;
int siv1 = n24 / 1000;
string otv241 = "";
string otv242 = "";
string otv244 = "";
if (siv1 != 0)
{
    otv241 = $"{siv4}{siv3}{siv2}{siv1}";
}
else
{
    otv241 = $"{siv3}{siv2}{siv1}";
}
if (siv2 != 0)
{
    otv242 = $"{siv2}{siv1}{siv4}{siv3}";
}
else
{
    otv242 = $"{siv1}{siv4}{siv3}";
}
string otv243 = $"{siv1}{siv3}{siv2}{siv4}";
if (siv3 != 0)
{
    otv244 = $"{siv3}{siv4}{siv1}{siv2}";
}
else
{
    otv244 = $"{siv4}{siv1}{siv2}";
}
Console.WriteLine($"а) {otv241}");
Console.WriteLine($"б) {otv242}");
Console.WriteLine($"в) {otv243}");
Console.WriteLine($"г) {otv244}");
Console.WriteLine();
/* #25 Из трехзначного числа x вычли его последнюю цифру. Когда результат разделили
на 10, а к частному слева приписали последнюю цифру числа x, то получилось
число n. Найти число x. Значение n вводится с клавиатуры, 100 ≤ n ≤ 999 и при этом
число десятков в n не равно нулю. */
Console.WriteLine("Номер 25:");
Console.Write("Введите значение n: ");
int n25 = Convert.ToInt32(Console.ReadLine());
int chis1 = n25 / 100;
int n125 = n25 % 100; // Делаем все в обратном порядке
int n225 = n125 * 10;
int n325 = n225 + chis1;
Console.WriteLine(n325);
Console.WriteLine();
/* #26 Даны целые числа h, m, s (0 ≤ h ≤ 23, 0 ≤ m ≤ 59, 0 ≤ s ≤ 59), указывающие момент
времени: «h часов, m минут, s секунд». Определить угол (в градусах) между
положением часовой стрелки в начале суток и в указанный момент времени. */
Console.WriteLine("Номер 26:");
Console.Write("Введите кол-во часов: ");
int hh26 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во минут: ");
int m26 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во сек: ");
int s26 = Convert.ToInt32(Console.ReadLine());
int h26 = 0;
if (hh26 > 12)                // Переводим часы из 24 часового режима на 12 часовой режим для настенных часов
{
    h26 = hh26 - 12;
}
else if (hh26 == 12)
{
    h26 = 0;
}
else
{
    h26 = hh26;
}
int sum26 = h26 * 3600 + m26 * 60 + s26;   // Переводим в секунды
decimal g26 = 360; // Всего 360 градусов
decimal gg26 = 43200;  // Секунды в 12 часaх
decimal kol26 = g26 / gg26; // Находим на сколько градусов увел. угол за каждую секунду
decimal otv26 = kol26 * sum26;
decimal it26;
if (otv26 > 180)
{
    it26 = 360 - otv26;
}
else
{
    it26 = otv26;
}
Console.WriteLine($"Угол между стрелками {it26} градусов");
Console.WriteLine("");
/* #27 Часовая стрелка образует угол y с лучом, проходящим через центр и через точку,
соответствующую 12 часам на циферблате, 0 ≤ y ≤ 2 . Определить значение угла для
минутной стрелки, а также количество полных часов и полных минут. */
Console.WriteLine("Номер 27:");
Console.Write("Введите кол-во часов: ");
int h27 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во минут: ");
int m27 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во сек: ");
int s27 = Convert.ToInt32(Console.ReadLine());
int sum27 = m27 * 60 + s27;   // Переводим в секунды
decimal g27 = 360; // Всего 360 градусов
decimal gg27 = 3600;  // Секунды в 1 часaх
decimal kol27 = g27 / gg27; // Находим на сколько градусов увел. угол за каждую секунду
decimal otv27 = kol27 * sum27;
decimal it27;
if (otv27 > 180)
{
    it27 = 360 - otv27;
}
else
{
    it27 = otv27;
}
Console.WriteLine($"Угол между стрелками {it27} градусов");
Console.WriteLine($"Кол-во полных часов: {h27}, кол-во полных минут: {m27}");
Console.WriteLine("");
/* #28 Создать программу, которая будет выводить на экран меньшее по модулю из трёх
введённых пользователем вещественных чисел
 */
Console.WriteLine("Номер 28:");
Console.WriteLine("Введите первое число: ");
int aa28 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int bb28 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int cc28 = Convert.ToInt32(Console.ReadLine());
int a28 = Math.Abs(aa28);
int b28 = Math.Abs(bb28);
int c28 = Math.Abs(cc28);
if ((a28 < b28) & (a28 < c28))
{
    Console.WriteLine($"Минимальоне число по модулю: {a28}");
}
else if ((b28 < a28) & (b28 < c28))
{
    Console.WriteLine($"Минимальоне число по модулю: {b28}");
}
else if ((c28 < a28) & (c28 < b28))
{
    Console.WriteLine($"Минимальоне число по модулю: {c28}");
}
Console.WriteLine("");
/* #29 Найти сумму большего и меньшего из трёх заданных чисел */
Console.WriteLine("Номер 29:");
Console.Write("Введите первое число: ");
int a29 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b29 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c29 = Convert.ToInt32(Console.ReadLine());
int chmax29 = 0;
int chmin29 = 0;
if ((a29 < b29) & (a29 < c29))
{
    chmin29 = a29;
}
else if ((b29 < a29) & (b29 < c29))
{
    chmin29 = b29;
}
else if ((c29 < a29) & (c29 < b29))
{
    chmin29 = c29;
}
if ((a29 > b29) & (a29 > c29))
{
    chmax29 = a29;
}
else if ((b29 > a29) & (b29 > c29))
{
    chmax29 = b29;
}
else if ((c29 > a29) & (c29 > b29))
{
    chmax29 = c29;
}
int otv29 = chmin29 + chmax29;
Console.WriteLine($"Сумма мин и макс числа: {otv29}");
Console.WriteLine("");
/* #30 Подсчитать общее количество делителей натурального числа  */
Console.WriteLine("Номер 30:");
Console.Write("Введите натуральное число: ");
int a30 = Convert.ToInt32(Console.ReadLine());
int b30 = 1;
for (int i = 1; i < a30; i++)
{
    if (a30 % i == 0)
    {
        b30 += 1;
    }
}
Console.WriteLine($"Кол-во делителей: {b30}");
Console.WriteLine("");
/* #31 Вася в школе изучил квадратные уравнения и понял, как они легко решаются путем
вычисления дискриминанта. Но Петя поведал ему о методе решения кубических
уравнений вида A*X3 + B*X2 + C*X + D = 0. На факультативе по математике Васе
задали решить около ста уравнений как раз такого вида. Но, к сожалению, Вася
забыл формулы, о которых рассказывал ему Петя. Но Васе было известно, что все
корни уравнений – целые числа и находятся на отрезке [-100, 100]. Поэтому у Васи
есть шанс найти их методом перебора, но для этого ему придется затратить уйму
времени, т.к. возможно необходимо будет осуществить перебор нескольких тысяч
значений. Помогите Васе написать программу, которая поможет ему найти корни
кубических уравнений! */
Console.WriteLine("Номер 30:");
Console.Write("Введите коэф. а: ");
int a31 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэф. b: ");
int b31 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэф. c: ");
int c31 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэф. d: ");
int d31 = Convert.ToInt32(Console.ReadLine());
int bb31 = 0;
for (int i = -100; i < 201; i++)
{
    int x31 = i;
    if ((a31 * x31 * x31 * x31 + b31 * x31 * x31 + c31 * x31 + d31) == 0)
    {
        Console.WriteLine(i);
        bb31 += 1;
    }
}
if (bb31 == 0)
{
    Console.WriteLine("Нет корней");
}
Console.WriteLine("");
/* #32 Заданы первый и второй элементы арифметической прогрессии. Требуется
написать программу, которая вычислит элемент прогрессии по ее номеру. */
Console.WriteLine("Номер 32:");
Console.Write("Введите первый элемент геомт.прогрессии: ");
int a32 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй элемент геомт.прогрессии: ");
int b32 = Convert.ToInt32(Console.ReadLine());
int n32 = b32 / a32;
Console.Write("Введите номер элемента геомт.прогрессии: ");
int c32 = Convert.ToInt32(Console.ReadLine());
int d32 = b32;
for (int i = 3; i <= c32 + 1; i++)
{
    int e32 = d32 * n32;
    d32 = e32;
    if (i == c32)
    {
        Console.WriteLine($"{c32} элемент геом.прогресси: {d32}");
    }
}
Console.WriteLine("");
/* #33 Если я пенсионер или студент и не трудоустроен, то получаю кредит, а если
трудоустроен не получаю кредит. Ну а если я, и пенсионер и
студент,(трудоустройство тут не имеет значения) то не должен получить.
Необходимо вводить строки, содержащие информацию о том, студент, пенсионер
или кто-то ещё. Вывести информацию: дадут кредит или нет. */
Console.WriteLine("Номер 33:");
Console.Write("Вы пенсионер или студент, или сразу пенсионер и студент? Напишите  ответ: ");
string a33 = Console.ReadLine();
Console.Write("Вы трудоустроены? Напишите ответ: ");
string b33 = Console.ReadLine();
if ((a33 == "студент") & (b33 == "не трудоустроен"))
{
    Console.WriteLine("Вам дадут кредит");
}
else if ((a33 == "пенсионер") & (b33 == "не трудоустроен"))
{
    Console.WriteLine("Вам дадут кредит");
}
if ((a33 == "студент") & (b33 == "трудоустроен"))
{
    Console.WriteLine("Вам не дадут кредит");
}
else if ((a33 == "пенсионер") & (b33 == "трудоустроен"))
{
    Console.WriteLine("Вам не дадут кредит");
}
else if (a33 == "пенсионер и студент")
{
    Console.WriteLine("Вам не дадут кредит");
}
Console.WriteLine("");
/* #34 Составить программу, которая:
а) запрашивает имя человека и повторяет его на экране;

б) запрашивает имя человека и повторяет его на экране с приветствием. */
Console.WriteLine("Номер 34:");
Console.Write("Введите свое имя: ");
string a34 = Console.ReadLine();
Console.WriteLine(a34);
Console.WriteLine("Привет " + a34);
Console.WriteLine("");
/* #35 Воспроизвести разговор Гарри и дневника Тома Реддла. Пользователь здоровается с
консолью. Консоль спрашивает, как зовут пользователя. Пользователь называет
имя. Консоль пишет: привет, <имя пользователя>. После этого пользователь
спрашивает, знает ли консоль что-то о тайной комнате. Консоль отвечает «Да».
После этого пользователь спрашивает, может ли рассказать. Консоль отвечает
«Нет». Спустя 5 секунд консоль дополняет «но могу показать». Консоль меняет
цвет на любой случайный цвет. */
Console.WriteLine("Номер 35:");
Console.WriteLine("(Ползователь) Привет");
Console.Write("(Дневник Тома Редла) Скажи свое имя: ");
string a35 = Console.ReadLine();
Console.WriteLine($"(Дневник Тома Редла) Привет, {a35} ");
Console.WriteLine("(Ползователь) Знаешь ли ты о тайной комнате? ");
Console.WriteLine("(Дневник Тома Редла) Да");
Console.WriteLine("(Ползователь) Можешь ли рассказать? ");
Console.WriteLine("(Дневник Тома Редла) Нет");
Thread.Sleep(5000);
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("(Дневник Тома Редла) Но могу показать");
Console.WriteLine("");
Console.ResetColor();
/* #36 Вычислить контрольную цифру штрихкода(EAN13).
a. 12 цифр определяются случайным образом.
b. 12 цифр вводит пользователь */
Console.WriteLine("Номер 36:");
Random r36 = new Random();
string s36 = "";
for (int i = 0; i < 12; i++)
{
    s36 += r36.Next(0, 10);
}
Console.WriteLine("Введите 12 цифр: ");
string a36 = Console.ReadLine();
string b36 = s36 + a36;
Console.WriteLine(b36);
int sumch36 = 0;
int sumnech36 = 0;
for (int j = 0; j < 24; j++)
{
    char h36 = b36[j];  // char(тип символ)
    int c36 = int.Parse(h36.ToString());
    if ((j + 1) % 2 == 0)
    {
        sumch36 += c36;
    }
    else
    {
        sumnech36 += c36;
    }
}
int itogsum36 = sumch36 * 3 + sumnech36;
int d36 = itogsum36 / 10;
int otv36 = ((d36 + 1) * 10) - itogsum36;
Console.WriteLine(otv36);
Console.WriteLine("");

