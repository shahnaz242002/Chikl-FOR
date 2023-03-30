double summa = Convert.ToInt32(Console.ReadLine());
int prodoljitelnost = Convert.ToInt32(Console.ReadLine());
int procent = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < prodoljitelnost; i++)
{
    double result = summa * (100 + 10) / 100;
    Console.WriteLine(result);
    summa = result;
}
