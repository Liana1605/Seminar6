// Напишите программу, которая перевернет одномерный массив 
// (последний элемент будет на первом месте, а первый на последнем)
//[1 2 3 4 5] -> [5 4 3 2 1]

int[] arrOne = new int[6] {1,2,3,4,5,6};
int[] arrTwo = new int[6];
int iTwo = arrOne.Length - 1;

for (int i = 0; i < arrOne.Length; i++)
{
    arrTwo[iTwo] = arrOne[i];
    iTwo--;
}
foreach (int i in arrOne) Console.Write($" {i} ");
Console.WriteLine();
foreach (int i in arrTwo) Console.Write($" {i} ");