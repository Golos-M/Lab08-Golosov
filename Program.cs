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