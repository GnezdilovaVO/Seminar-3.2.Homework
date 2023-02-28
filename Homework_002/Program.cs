string ThreeNumbers (int count) {
string output = String.Empty;
while (count > 1000) {
    count = count/10;   
}
int a = count/100;
if (a == 0) {
    output = ("Третей цифры нет");
}
else {
    int b = count%10;
    output = output + b;
    }
return output;
}
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
string result = ThreeNumbers(N);
Console.WriteLine(result);



