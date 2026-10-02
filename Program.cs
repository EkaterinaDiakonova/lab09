using System.Runtime.Serialization.Formatters;

int totalExercisec = 8;

for (int number = totalExercisec; number >= 1; number--)
{
    Console.WriteLine($"Упражнение {number}");
}

Console.WriteLine("Домашнее задание готово");

for (int room = 5; room <= 50; room += 5)
{
    Console.WriteLine($"Кабинет {room}");
}

int totalWeeks = 3;

for (int week = 1; week <= totalWeeks; week++)
{
    for (int day = 1; day <= 5; day++)
    {
        Console.WriteLine($"Неделя {week}, день {day}");
    }
    Console.WriteLine("^_^");
}


int sum = 0;
for (int ticket = 1; ticket <= 30; ticket++)
{
    if (ticket == 4 || ticket == 12 || ticket == 19)
    {
        sum++;
        continue; // билет уже вытянут
    }

    Console.WriteLine($"Первый доступный билет: {ticket} ");
    Console.WriteLine($"Пропущено билетов до него: {sum}");
    break;
}

for (; ; )
{
    Console.Write("Введите код группы (для выхода - 'выход'): ");
    string groupCode = Console.ReadLine();

    if (groupCode == "выход")
    {
        break;
    }
    Console.WriteLine($"Записан код группы: {groupCode}");
}
Console.WriteLine("Работа с журналом завершена");



Console.WriteLine("Самостоятельные задания 'А'");
int n = 10;
for (int i = 1; i <= n; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("Самостоятельное задание 'Б'");

for (int b = 100; b >= 0; b -= 10)
{
    Console.WriteLine(b);
}

Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();
if (string.IsNullOrEmpty(surname)) {
Console.WriteLine("Фамилия не введена. Завершение работы.");
return;
}
Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
var assigned = Enumerable.Range(1, 10)
.OrderBy(_ => rnd.Next())
.Take(2)
.OrderBy(x => x)
.ToList();
Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

Console.WriteLine("Вариант 2:");
int n1 = 20;
int m = 5;
for (int c = n1; c >= 0; c -= m)
{
    Console.WriteLine(c);
}

Console.WriteLine("Вариант 6: Пропуск кратных чисел");
for (int d = 1; d <= 30; d++)
{
    if (d % 4 == 0)
    {
        continue;
    }
    Console.WriteLine(d);
}
