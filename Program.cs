// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите свое трёхзначное число");

int number = Convert.ToInt32(Console.ReadLine());
int numberOfDigit=DigitNumber(number);// Entered number should be thee-digit number. Let's check it.
if (numberOfDigit ==3)
   {
    int result = number / 10 % 10; // Find the second digit of the number
    Console.WriteLine("Второй цифрой числа "+ number+ " является " + result);
   }
else
   {
    Console.WriteLine("Ошибка! "+ number + " - не является трёхзначным" );
   }


int DigitNumber (int number)// Function to find number of digit
{
int numberOfDigit=0;
double buffer = number;
while (buffer>=1)
   {
    buffer=buffer/10;
    numberOfDigit++;
   }
return numberOfDigit;
}