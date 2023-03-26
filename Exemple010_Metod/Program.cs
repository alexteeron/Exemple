//Метод поиска позиций нужного элемента
int[] arrey = { 1, 12, 31, 4, 18, 15, 16, 17, 18 };

int n = arrey.Length;  //длинна или количество элементов массива

int Find = 18;
int index = 0;

while (index < n)
{
    if(arrey[index] == Find)
    {
        Console.WriteLine(index);
        break;  //Останавливает цикл
    }
    index++;  //index = index + 1;
}

