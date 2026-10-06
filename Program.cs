// Console.WriteLine("Границы целочисленных типов");
// Console.WriteLine($"byte:  {byte.MinValue}  {byte.MaxValue}");
// Console.WriteLine($"short:  {short.MinValue}  {short.MaxValue}");
// Console.WriteLine($"int:  {short.MinValue}  {int.MaxValue}");
// Console.WriteLine($"long:  {long.MinValue}  {long.MaxValue}");

// Console.WriteLine();
// Console.WriteLine("Границы дробных типов");
// Console.WriteLine($"float:  {float.MinValue}  {float.MaxValue}");
// Console.WriteLine($"double:  {double.MinValue}  {double.MaxValue}");
// Console.WriteLine($"decimal:  {decimal.MinValue}  {decimal.MaxValue}");

// Console.WriteLine();
// Console.WriteLine("Переполнение byte");

// byte maxByte = 255;
// byte overflowed = (byte)(maxByte + 1);
// Console.WriteLine($"255 + 1 для byte = {overflowed}");

// Console.WriteLine();
// Console.WriteLine("char");

// char firstLetter = 'A';
// char separator = '-';
// int charAsNumber = firstLetter; 

// Console.WriteLine($"Символ: {firstLetter}, разделитель:{separator}");
// Console.WriteLine($"Код символа '{firstLetter}' в Unicode: {charAsNumber}");
// Console.WriteLine($"Табуляция:\tпосле таба");
// Console.WriteLine($"Перенос:\nпосле переноса");

// Console.WriteLine();
// Console.WriteLine("decimal против double");

// double priceDouble = 0.1 + 0.2;
// decimal priceDecimal = 0.1m + 0.2m;

// Console.WriteLine($"double: 0.1 + 0.2 = {priceDouble}");
// Console.WriteLine($"decimal: 0.1 + 0.2 = {priceDecimal}");

// Console.WriteLine();
// Console.WriteLine("var");

// var studentAge = 20;
// var gpa = 4.75;
// var fullName = "Смирнова А.С.";

// Console.WriteLine($"{fullName}, возраст {studentAge}, средний балл {gpa}");

// Console.WriteLine();
// Console.WriteLine("Ввод текста");

// Console.Write("Введите ваше имя: ");
// string enteredName = Console.ReadLine();

// Console.Write("Введите название вашей группы: ");
// string enteredGroup = Console.ReadLine();

// Console.WriteLine($"Здравствуйте, {enteredName} из группы {enteredGroup}!");

// Console.WriteLine();
// Console.WriteLine("Ввод чисел: Convert и Parse");

// Console.Write("Введите ваш год рождения: ");
// string birthYearInput = Console.ReadLine();

// int birthYearConvert = Convert.ToInt32(birthYearInput);
// int birthYearParse = int.Parse(birthYearInput);

// Console.WriteLine($"Convert.ToInt32: {birthYearConvert}");
// Console.WriteLine($"int.Parse:       {birthYearParse}");
// Console.WriteLine($"В 2030 году вам будет: {2030 - birthYearConvert} лет");

// Console.WriteLine();
// Console.WriteLine("Ввод чисел: TryParse");

// Console.Write("Введите количество прочитанных книг за семестр: ");
// string booksInput = Console.ReadLine();

// bool wasSuccessful = int.TryParse(booksInput, out int booksCount);

// Console.WriteLine($"Удалось преобразовать: {wasSuccessful}");
// Console.WriteLine($"Значение переменной booksCount: {booksCount}");

// Console.WriteLine();
// Console.WriteLine("Введите имя и фамилию:");
// string studentName = Console.ReadLine();
// Console.WriteLine("Введите группу:");
// string groupName = Console.ReadLine();
// Console.WriteLine("Введите год рождения:");
// int birthYear = int.Parse(Console.ReadLine());
// Console.Write("Введите средний балл за прошлый семестр: ");
// double Score = double.Parse(Console.ReadLine());
// Console.Write("Введите любимую букву алфавита: ");
// char favoriteLetter = Console.ReadLine()[0];

// int ageIn2030 = 2030 - birthYear;
// bool isGoodStudent = Score >= 4.0;

// Console.WriteLine();
// Console.WriteLine("     Анкета");
// Console.WriteLine($"{studentName}, группа {groupName}");
// Console.WriteLine($"Год рождения: {birthYear} (в 2030 будет {ageIn2030} год)");
// Console.WriteLine($"Средний балл: {Score}");
// Console.WriteLine($"Балл >= 4.0: {isGoodStudent}");
// Console.WriteLine($"Любимая буква: {favoriteLetter}");

// Console.WriteLine();
// Console.WriteLine("Калькулятор ИМТ");

// Console.Write("Введите рост в метрах: ");
// double height = double.Parse(Console.ReadLine());
// Console.Write("Введите вес в килограммах: ");
// double weight = double.Parse(Console.ReadLine());
// double bmi = weight / (height * height);
// Console.WriteLine($"ИМТ: {bmi:F2}");

// Console.WriteLine();
// Console.WriteLine("Разбор ФИО");
// Console.Write("Введите фамилию: ");
// string surname = Console.ReadLine();
// Console.Write("Введите имя: ");
// string name = Console.ReadLine();
// char nameFirstLetter = name[0];
// Console.WriteLine($"{surname} {nameFirstLetter}.");

Console.WriteLine();
Console.WriteLine("TryParse для трёх типов");

Console.Write("Введите целое число: ");
string intInput = Console.ReadLine();

bool intSuccess = int.TryParse(
    intInput,
    out int intValue
);

Console.WriteLine(
    $"Целое число: успешно = {intSuccess}, значение = {intValue}"
);

Console.Write("Введите дробное число: ");
string doubleInput = Console.ReadLine();

bool doubleSuccess = double.TryParse(
    doubleInput,
    out double doubleValue
);

Console.WriteLine(
    $"Дробное число: успешно = {doubleSuccess}, значение = {doubleValue}"
);

Console.Write("Введите дату (дд.мм.гггг): ");
string dateInput = Console.ReadLine();

bool dateSuccess = DateTime.TryParse(
    dateInput,
    out DateTime dateValue
);

Console.WriteLine(
    $"Дата: успешно = {dateSuccess}, значение = {dateValue}"
);