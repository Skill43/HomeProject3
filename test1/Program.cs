const int Size = 8;
const int LeftRange = 0;
const int RightRange = 1;

int[] array = new int[Size];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(LeftRange, RightRange + 1);
}
System.Console.WriteLine(string.Join(" | ", array));
