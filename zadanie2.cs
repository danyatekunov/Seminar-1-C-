Console.WriteLine("Введите первое число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int z = Convert.ToInt32(Console.ReadLine());

if (x>y && x>z)

   {
    Console.WriteLine("Первое число наибольшее");
   }

   if (y>x && y>z)

   {
    Console.WriteLine("Второе число наибольшее");
   }

   if (z>y && z>x)

   {
    Console.WriteLine("Первое число наибольшее");
   }
