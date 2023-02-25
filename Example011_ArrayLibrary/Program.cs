void FillArray(int[] collection)  
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)      // void метод ничего не возвращает, 
                                //отсутствует "return"
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine (col[position]);
        position++;
    }
}

int Indexof(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;  // если элемента нет - значение будет (-1)
    while(index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; // фиксирует первую позицию индекса
        }
        index++;
    }
    return position;
} 

int[] array = new int[10];         // массив создается с нулями


FillArray(array);               // метод, который заполнил массив
PrintArray(array);              // метод, который распечатал массив
Console.WriteLine();

int pos = Indexof(array, 4);
Console.WriteLine(pos);