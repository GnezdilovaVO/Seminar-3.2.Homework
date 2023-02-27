int SecondNumber (int number)
{
int a = number/10;
int output = a%10;
return output;
}
Console.WriteLine("Введите 3-х значное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int result = SecondNumber(N);
Console.WriteLine(result);