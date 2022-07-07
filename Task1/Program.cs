// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

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
int result = 0;
 int [] Array (int [] arr)
 {
    
     for (int i=0; i<arr.Length; i++)
     {
         if (arr[i]%2==1)
         {
        int count =0;
        result=result+1; 
        count++;
         }
      }
        
     return arr;
}
int [] myArray = CreateAndFillArr(10, 100, 999);
printArr(myArray);
Array(myArray);
System.Console.WriteLine($"количество четных элементов = {result}"); 