Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = N/100;
if (a == 0) {
    Console.WriteLine("Третей цифры нет");
}
else {
    int b = N%10;
    Console.WriteLine(b);
}
