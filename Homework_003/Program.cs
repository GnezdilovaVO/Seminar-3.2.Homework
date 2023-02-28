string Holiday(int count) {
string output = String.Empty;
if (count > 5) {
    output = "да";
}
else {
    output = "нет";
}
return output;
}
Console.WriteLine("Введите номер для недели: ");
int n = Convert.ToInt32(Console.ReadLine());
string result = Holiday(n);
Console.WriteLine(result);
