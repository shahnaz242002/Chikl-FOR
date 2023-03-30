using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введите число покупок");
int a = Convert.ToInt32(Console.ReadLine());
int previous = 1;
int current = 1;
for (int i = 0; i < a - 2; i++)
{
    int sum = previous + current;
    previous = current;
    current = sum;
}
Console.WriteLine(current);
