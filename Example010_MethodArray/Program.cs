// Имеется одномерный массив array из n элементов,
// требуется найти элемент массива, равный find

Console.Clear();

int [] array = {13,27,31,86,59,64,73,86};

int n = array.Length;
int find = 86;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1;
    index++;
}