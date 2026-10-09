int lessonNumber = 1;
int totalLessons = 5;
while (lessonNumber <= totalLessons) 
{
    Console.WriteLine($"Пара {lessonNumber}");
    lessonNumber++;
}
Console.WriteLine("Пары закончились");



int lessonNumber = 5;
int totalLessons = 5;
while (lessonNumber >= 1) 
{
    Console.WriteLine($"Пара {lessonNumber}");
    lessonNumber--;
}
Console.WriteLine("Пары закончились");



Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());
while (grade != -1) 
{
    Console.WriteLine($"Оценка принята: {grade}");
    grade = int.Parse(Console.ReadLine());
}
Console.WriteLine("Ввод завершён");



Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());
int count = 0;
while (grade != -1) 
{
    Console.WriteLine($"Оценка принята: {grade}");
    count++;
    grade = int.Parse(Console.ReadLine());
}
Console.WriteLine("Ввод завершён");
Console.WriteLine($"Количество введённых оценок: {count}");



int sum = 0;
int count = 0;
Console.WriteLine("Вводите оценки, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());
while (grade != -1) 
{
    sum += grade;
    count++;
    grade = int.Parse(Console.ReadLine());
}
if (count > 0)
{
    double average = (double)sum / count;
    Console.WriteLine($"Средний балл: {average}");
}
else
{
    Console.WriteLine("Оценки не были введены");
}



int sum = 0;
int count = 0;
int max = int.MinValue;
Console.WriteLine("Вводите оценки, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());
while (grade != -1)
 {
    sum += grade;
    count++;
    if (grade > max) max = grade;
    grade = int.Parse(Console.ReadLine());
}
if (count > 0)
{
    double average = (double)sum / count;
    Console.WriteLine($"Средний балл: {average}");
    Console.WriteLine($"Наибольшая оценка: {max}");
}
else
{
    Console.WriteLine("Оценки не были введены");
}



string correctPassword = "qwerty123";
while (true)
{
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();

    if (password == correctPassword)
    {
        Console.WriteLine("Доступ разрешён");
        break;
    }

    Console.WriteLine("Неверный пароль, попробуйте снова");
}



string correctPassword = "qwerty123";
int failedAttempts = 0;
while (true)
{
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();

    if (password == correctPassword)
    {
        Console.WriteLine("Доступ разрешён");
        Console.WriteLine($"Количество неудачных попыток: {failedAttempts}");
        break;
    }

    Console.WriteLine("Неверный пароль, попробуйте снова");
    failedAttempts++;
}
