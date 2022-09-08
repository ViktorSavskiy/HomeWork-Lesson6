Console.WriteLine("Введите k1");
decimal k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b1");
decimal b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k2");
decimal k2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b2");
decimal b2 = int.Parse(Console.ReadLine());

if (b1==b2 && k1==k2)
{
    Console.WriteLine("Прямые совпадают и будут иметь бесконечное количество точек пересечения");
}
else
{
   if (k1==k2)
   {
    Console.WriteLine("Прямые параллельны друг другу и точек пересечения нет");
   } 
   else
   {
    decimal x = (b2 - b1)/(k1 - k2);
    decimal y = (k1 * x + b1);
    Console.WriteLine($"Координаты точки пересечения: ({x}; {y})");

   }
}
