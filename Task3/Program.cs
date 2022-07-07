// Задача 3.Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] CreateAndFillArr(int large, int min, int max)
{
    int [] array = new int [large];
    for (int ifill=0; ifill<array.Length; ifill++)
    {
        array[ifill]=new Random().Next(min,max+1);
    }
    return array;
}
void printArr(int[] arr)
{
    for (int i=0; i< arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}  ");
    }
    System.Console.WriteLine();
}
int difference = 0;

 int [] Array (int [] arr)
 {
        int max = arr[0];
        int min = arr[0];
         
     for (int i=0; i<arr.Length; i++)
     { 
         if (max<arr[i]) max=arr[i];
         if (min>arr[i]) min=arr[i];
     }
      difference=max-min;   
     return arr;
}
int [] myArray = CreateAndFillArr(5, 1, 10);
printArr(myArray);
Array (myArray);
System.Console.WriteLine($"разница максимального и минимального элемента = {difference}"); 
