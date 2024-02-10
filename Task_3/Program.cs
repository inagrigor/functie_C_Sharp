// // 
// void Foo(int a)
// {
//     Console.Write(a);
// }
// int value = 5;
// Foo(value);

// Обнуляем четные элименты массива

// void ZeroEvenElements(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0)
//         {
//             arr[i] = 0;
//         }
//     }
// }
// void PrintArray(int[] arr)
// {
//     foreach (int e in arr)
//     {
//         Console.Write($"{e} ");
//     }
// }

// int[] array = { 10, 20, 30, 40, 50 };
// ZeroEvenElements(array);
// PrintArray(array);

int n = 10;
 int[] array = new int[n];
  int i = 0;
 while (i < n)
 {
         array[i] = i + 1;
}
 i = 0;
 while (i < n)
 {
         Console.Write($"{array[i]} ");
 }