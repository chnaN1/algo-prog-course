Console.WriteLine("Конвертер температур:");
double celsius = 24.5;
const double KelvinOffset = 273.15;
double fahrenheit = celsius * 9 / 5 + 32;
double kelvin = celsius + KelvinOffset;
Console.WriteLine($"{celsius}°C = {fahrenheit}°F = {kelvin}K");