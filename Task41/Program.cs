// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CheciIt(int[] arr) { // Проверяет количество чисел в массиве больше 0, и возвращает их количество.
    int count = 0;
    for(int i = 0; i < arr.Length; i++) {
        if(arr[i] > 0) count++;
    }
    return count;
}

void PrintArray(int[] arr) { // Выводит массив.
    for(int i = 0; i < arr.Length; i++) {
        Console.Write($"{arr[i]} ");
    }
}

int[] PullArray(int[] arr) { // Заполняет массив случайными числами.
    int length = arr.Length;
    var rnd = new Random();
    for(int i = 0; i < length; i++) {
        arr[i] = rnd.Next(1, 10);
    }
    return arr;
}

var length = new Random().Next(2, 8);
int[] array = new int[length];
PullArray(array);
for(int i = 0; i < length; i++) {
    Console.Write($"Введите число {i + 1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int count = CheciIt(array);
PrintArray(array);
Console.Write($"-> {count}");