// Константа учебного заведения
const string CollegeName = "Волгоградский государственный университет";

// Не менее 6 переменных разных типов (string, int, double, bool)
string fullName = "Барабанов Георгий Валерьевич";
string group = "ИСП-253";
string specialty = "09.02.07 Информационные системы и программирование";
int currentCourse = 2;
double averageScore = 4.1;
bool isBudget = false;
int totalDaysInSemester = 120;
int daysPassed = 45;
int daysLeft = totalDaysInSemester - daysPassed;

// Вывод через интерполяцию с разделителями
Console.WriteLine("=================================================");
Console.WriteLine($"      ВИЗИТНАЯ КАРТОЧКА СТУДЕНТА          ");
Console.WriteLine("=================================================");
Console.WriteLine($"ФИО:           {fullName}");
Console.WriteLine($"Группа:        {group}");
Console.WriteLine($"Курс:          {currentCourse}");
Console.WriteLine($"Специальность: {specialty}");
Console.WriteLine($"ВУЗ/Колледж:   {CollegeName}");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine($"Средний балл:  {averageScore}");
Console.WriteLine($"Обучение на бюджете: {(isBudget ? "Да" : "Нет")}");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine($"Дней до конца семестра: {daysLeft} (прошло {daysPassed} из {totalDaysInSemester})");
Console.WriteLine("=================================================");