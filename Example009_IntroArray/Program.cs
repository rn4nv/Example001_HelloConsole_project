Console.Clear();

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

// Начальный вариант.

// int a1 = 34;
// int b1 = 12;
// int c1 = 24;
// int a2 = 65;
// int b2 = 41;
// int c2 = 81;
// int a3 = 36;
// int b3 = 96;
// int c3 = 27;


// int max = Max(
//     Max(a1, b1, c1),
//     Max(a2, b2, c2),
//     Max(a3, b3, c3));
// return max;

// Console.WriteLine(max);

//---Итоговое преобразование---.

int[] array = {19,28,37,46,55,64,73,82,91};
// array[0] = 12;
// Console.WriteLine(array[0]);

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(result);
