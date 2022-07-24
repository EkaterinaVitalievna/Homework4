// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// int NewArray = new int [8];
// FillArray(NewArray);
// Console.WriteLine(NewArray);

int[] DigitalDial = new int [8];//определили массив из 8 элементов
Random rand = new Random();
for (int x=0; x < DigitalDial.Length; x++)
{
    DigitalDial[x] = rand.Next(20);
    Console.WriteLine(DigitalDial[x]);
}