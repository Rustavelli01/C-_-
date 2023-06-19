/*Код с использованием генератора псевдослучайных чисел*/

/*А сейчас перепишем этот код с использованием генератора псевдослучайных чисел с использованием методов. Мы потренируем то, каким образом можно взять, например, метод, передать в него массив и
заполнить массив нужным количеством элементов. На следующем этапе опишем метод,
который будет выводить все элементы по порядку. Затем превратим наш код поиска нужного индекса в метод.*/

Console.Clear();


/*void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index +1
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position =0;
    while(position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);*/


/*Теперь разберёмся, для чего используется ключевое слово void. Дело в том, что в контексте языка С# есть методы, которые могут возвращать или не возвращать какие-то значения. Если метод ничего не возвращает, он называется void-методом. Обратите внимание, что в этом случае в коде оператор return, отвечающий за поиск максимума из 3, не используется.*/


/*Метод IndexOf*/

/*Мы попробовали написать свои первые методы: метод заполнения массива и метод его печати на экран. Теперь попробуем адаптировать решение предыдущей задачи, в которой находили нужные элементы и позицию нужного элемента в массиве.*/


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index +1
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] coollection, int find)
{
    int count = coollection.Length;
    int index = 0;
    int position = -1; //-2

    while (index < count)
    {
        if (coollection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);