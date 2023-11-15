//4.1 слож
//string b = "1010101";

//int d = Convert.ToInt32(b, 2);

//int[] a = new int[100];
//int index = 0;

//while (d > 0)
//{
//    int r = d % 16;
//    a[index] = r;
//    d = d / 16;
//    index++;
//}

//Console.Write($"Шестнадцатеричное представление числа {b} равно ");
//4.2 сред
int[] mas = { 45, 6, 3, 12, 5, 6, 65, 8, 14, 10 };
int max2 = mas.Max() * 2;
foreach (int e in mas)
{
    Console.WriteLine("{0}", e + max2);
}
Console.WriteLine();

