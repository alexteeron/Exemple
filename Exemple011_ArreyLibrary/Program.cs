//метод вывода элементов по порядку
void FillArrey(int[] collection) //void метод - метод который ни чего не возвращает
{
    int length = collection.Length;  // получаем длинну массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);

        index++;  //index = index + 1;    
    }
}

void PrintArrey(int[] col)
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;  //position = position + 1;
    }
}

int IndexOf(int[] collection,int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;

    while (index < count)
    {
        if(collection[index]==find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] arrey = new int[10]; // по умолчанию будет заполнен [0,0,0,0,0,0,0,0,0,0];


FillArrey(arrey);
arrey[4] = 4;
arrey[6] = 4;

PrintArrey(arrey);
Console.WriteLine();


int pos = IndexOf(arrey, 4);
Console.WriteLine(pos);
