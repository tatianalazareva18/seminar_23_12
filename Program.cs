// Два правых слэша означает однострочный комментарий

//  просто текст (быстрое комментирование) cntrl+ правый слэш

// тип_данных имя_переменной = значение;

// using System.IO.Compression;

// int number = 9; //number = 9
// int result = number * number; //результат 81
// Console.Write("Введите число: ");
// int input = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine(input * input);

 Console.Write("Введите первое число: ");
 int firstNumber = Convert.ToInt32(Console.ReadLine());


 Console.Write("Введите второе число: ");
 int secondNumber = Convert.ToInt32(Console.ReadLine());

 if(firstNumber == secondNumber * secondNumber)
 {
    Console.WriteLine("Да");
 }
else {
    Console.WriteLine("Нет");
}
