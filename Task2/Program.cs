// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

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
int summa = 0;
 int [] Array (int [] arr)
 {
     for (int i=1; i<arr.Length; i=i+2)
     {
        int count =0;
        summa=summa+arr[i]; 
        count++;
      }
        
     return arr;
}
int [] myArray = CreateAndFillArr(5, 1, 10);
printArr(myArray);
Array(myArray);
System.Console.WriteLine($"сумма элементов стоящих на нечетной позиции = {summa}"); 