// Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine(" ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных индексах.


int[] array = GetArray(10, 0, 999);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"Сумма на нечетных позициях {Sum(array)}");

int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for (int i=0; i<size; i++){
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
int Sum(int[] array){
    int sum=0;
    for (int i=0; i<array.Length; i++){
        if (i%2==1) sum+= array[i];
    }
    return sum;
}


// Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//Результат запишите в новом массиве.

int[] array = GetArray(10, 0, 999);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(String.Join(" ", ResultArray(array)));

int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for (int i=0; i<size; i++){
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int[] ResultArray(int[] array){
    int size = array.Length / 2;
    if(array.Length % 2 ==1) size++;
    int[] result = new int[size];
    for (int i=0; i<array.Length /2; i++){
        result[i] = array[i] * array[array.Length -1 -i];
    }
    if(array.Length %2 ==1) result[size-1] = array[array.Length /2];
    return result;
}