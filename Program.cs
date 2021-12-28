int[] GetArray(int colEl, int minValue, int maxValue) 
{ 
    int[] Array = new int[colEl]; 
    for (int i = 0; i < Array.Length; i++) 
    { 
        Array[i] = new Random().Next(minValue, maxValue); 
 
    } 
    return Array; 
} 
void PrintArray(int[] Array) 
{ 
    for (int i = 0; i < Array.Length; i++) 
    { 
        System.Console.Write($"{Array[i]} "); 
    } 
    System.Console.WriteLine(); 
} 
 
int[] Array1 = GetArray(10, -10, 10); 
PrintArray(Array1); 
 
int CountEvent(int[] Array) 
{ 
    int count = 0; 
    for (int i = 0; i < Array.Length; i++) 
    { 
        if (Array[i] % 2 == 0) 
            count++; 
    } 
    return count; 
} 
int N = CountEvent(Array1); 
System.Console.WriteLine(N); 
 
int[] GetArrayEven(int[] array, int lenght) 
{ 
    int j = 0; 
    int[] arr = new int[lenght]; 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (array[i] % 2 == 0) 
        { 
        arr[j] = array[i]; 
        j++; 
        } 
    } 
    return arr; 
} 
int[] array2 = GetArrayEven(Array1, N); 
PrintArray(array2);