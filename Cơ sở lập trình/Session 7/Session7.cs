using System.Buffers;
using System.ComponentModel;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal partial class session7
{

    static void RandomArray(int[] arr, int n)
    {
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            arr[i] = rnd.Next(1, 101);
        }
    }
    static void PrintArray(int[] arr)
    {
        Console.WriteLine("\n------YOUR OUTPUT RANDOM ARRAY------");
        Console.Write("[");
        foreach (int c in arr)
            Console.Write($"{c} ");
        Console.Write("]\n");
    }


    //1. to calculate the average value of array elements.
    static float calAve(int[] arr)
    {
        int sum = 0;
        foreach (int c in arr)
        {
            sum += c;
        }
        return (float)sum / arr.Length;
    }

    //2. to test if an array contains a specific value.
    static bool CheckContainer(int[] arr, int n)
    {
        foreach (int c in arr)
        {
            if (c == n) return true;
        }
        return false;
    }

    //3. to find the index of an array element.
    static int FindIndex(int[] arr, int n)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == n) return i;
        }
        return -1;
    }
    //4. to remove a specific element from an array.
    static int[] RemoveElement(int[] array, int value)
    {
        List<int> result = new List<int>();
        foreach (int item in array)
        {
            if (item != value)
            {
                result.Add(item);
            }
        }
        return result.ToArray();
    }
    //5. to find the maximum and minimum value of an array.
    static void FindMinMax(int[] array, out int min, out int max)
    {
        min = array[0];
        max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];
            if (array[i] > max) max = array[i];
        }
    }

    //6. to reverse an array of integer values.
    static int[] ReverseArray(int[] array)
    {
        int[] reversed = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            reversed[i] = array[array.Length - 1 - i];
        }
        return reversed;
    }
    //7. to find duplicate values in an array of values.
    static List<int> FindDuplicates(int[] array)
    {
        List<int> duplicates = new List<int>();

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    bool alreadyAdded = false;
                    for (int k = 0; k < duplicates.Count; k++)
                    {
                        if (duplicates[k] == array[i])
                        {
                            alreadyAdded = true;
                            break;
                        }
                    }

                    if (!alreadyAdded)
                    {
                        duplicates.Add(array[i]);
                    }
                    break;
                }
            }
        }
        return duplicates;
    }
    //8. to remove duplicate elements from an array.
    static int[] RemoveDuplicates(int[] array)
    {
        List<int> uniqueList = new List<int>();

        for (int i = 0; i < array.Length; i++)
        {
            bool isExist = false;
            for (int j = 0; j < uniqueList.Count; j++)
            {
                if (uniqueList[j] == array[i])
                {
                    isExist = true;
                    break;
                }
            }

            if (!isExist)
            {
                uniqueList.Add(array[i]);
            }
        }

        return uniqueList.ToArray();
    }


    private static void Main(string[] args)
    {
        Console.Write("Enter the number of elements: "); int x = int.Parse(Console.ReadLine());
        int[] mang = new int[x];
        RandomArray(mang, x);
        PrintArray(mang);

        ////Ex1:
        //float avg = calAve(mang);
        //Console.WriteLine($"\nThe average of your array is: {avg:F2}\n");

        ////Ex2:
        //Console.Write("Enter the number you want to check whether the array contains it: "); int num = int.Parse(Console.ReadLine());
        //bool check = CheckContainer(mang, num);
        //if (check) Console.WriteLine($"The array contains {num}\n");
        //else Console.WriteLine($"The array DOESN'T contain {num}\n");

        ////Ex3:
        //Console.Write("Enter the number you want to check its index: "); int num_index = int.Parse(Console.ReadLine());
        //int index = FindIndex(mang, num_index);
        //Console.WriteLine($"Number {num_index} has index \"{index}\" in the array");

        //Ex4:
        Console.Write("Enter the number you want to remove: "); int num = int.Parse(Console.ReadLine());
        int[] arrAfterRemove = RemoveElement(mang, num);
        Console.WriteLine($"\nArray after removing {num}: " + string.Join(", ", arrAfterRemove));

        //Ex5:
        FindMinMax(mang, out int min, out int max);
        Console.WriteLine($"Min: {min}, Max: {max}");

        //Ex6:
        int[] reversedArr = ReverseArray(mang);
        Console.WriteLine("Reversed Array: " + string.Join(", ", reversedArr));

        //Ex7:
        List<int> duplicates = FindDuplicates(mang);
        Console.WriteLine("Duplicate values: " + string.Join(", ", duplicates));

        //Ex8:
        int[] uniqueArr = RemoveDuplicates(mang);
        Console.WriteLine("Array after removing duplicates: " + string.Join(", ", uniqueArr));

        Console.WriteLine("BUBBLE SORT");
        int[] numbers = InputArray(10);

        BubbleSort(numbers);

        Console.Write("Mang sau khi sap xep tang dan: ");
        PrintArray(numbers);
        Console.WriteLine("\n");

        Console.WriteLine("LINEAR SEARCH");
        Console.Write("Nhap mot cau: ");
        string sentence = Console.ReadLine();

        Console.Write("Nhap tu can tim: ");
        string word = Console.ReadLine();

        bool isFound = LinearSearch(sentence, word);

        if (isFound)
        {
            Console.WriteLine("Tu '" + word + "' CO xuat hien trong cau.");
        }
        else
        {
            Console.WriteLine("Tu '" + word + "' KHONG xuat hien trong cau.");
        }

        Console.ReadLine();

        //MATRIX
        Console.Write("Nhap so hang N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Nhap so cot M: ");
        int m = int.Parse(Console.ReadLine());

        // 1
        int[,] matrix = CreateRandomMatrix(n, m);

        // 2
        Console.WriteLine("\n--- MA TRAN KHOI TAO ---");
        PrintMatrix(matrix);

        // 3
        Console.Write("\nNhap chi so hàng/cột i can in (tinh tu 0): ");
        int k = int.Parse(Console.ReadLine());
        PrintRowAndColumn(matrix, k);

        // 4
        int maxVal = FindMaxMatrix(matrix);
        Console.WriteLine($"\n-> Gia tri lon nhat trong ma tran: {maxVal}");

        // 5
        FindMinRowAndCol(matrix, k);

        // 6
        int[,] transposed = TransposeMatrix(matrix);
        Console.WriteLine("\n--- MA TRAN CHUYEN VI ---");
        PrintMatrix(transposed);

        // 7
        PrintDiagonals(matrix);

        Console.ReadLine();
    }


    static int[] InputArray(int n)
    {
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap so thu " + (i + 1) + ": ");
            a[i] = int.Parse(Console.ReadLine());
        }
        return a;
    }
    static void BubbleSort(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a.Length - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }
    }
    static bool LinearSearch(string sentence, string word)
    {
        string[] words = sentence.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == word)
            {
                return true;
            }
        }

        return false;
    }

    static int[,] CreateRandomMatrix(int rows, int cols)
    {
        Random rand = new Random();
        int[,] mat = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                mat[i, j] = rand.Next(1, 100);
            }
        }
        return mat;
    }
    static void PrintMatrix(int[,] mat)
    {
        int rows = mat.GetLength(0);
        int cols = mat.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(mat[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    static void PrintRowAndColumn(int[,] mat, int index)
    {
        int rows = mat.GetLength(0);
        int cols = mat.GetLength(1);

        // In hàng index
        if (index >= 0 && index < rows)
        {
            Console.Write($"Hang {index}: ");
            for (int j = 0; j < cols; j++)
            {
                Console.Write(mat[index, j] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"Chi so hang {index} khong hop le!");
        }

        // In cột index
        if (index >= 0 && index < cols)
        {
            Console.Write($"Cot {index}: ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write(mat[i, index] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"Chi so cot {index} khong hop le!");
        }
    }
    static int FindMaxMatrix(int[,] mat)
    {
        int max = mat[0, 0];
        int rows = mat.GetLength(0);
        int cols = mat.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (mat[i, j] > max)
                {
                    max = mat[i, j];
                }
            }
        }
        return max;
    }
    static void FindMinRowAndCol(int[,] mat, int index)
    {
        int rows = mat.GetLength(0);
        int cols = mat.GetLength(1);

        // Min hàng index
        if (index >= 0 && index < rows)
        {
            int minRow = mat[index, 0];
            for (int j = 1; j < cols; j++)
            {
                if (mat[index, j] < minRow) minRow = mat[index, j];
            }
            Console.WriteLine($"Gia tri nho nhat cua hang {index}: {minRow}");
        }

        // Min cột index
        if (index >= 0 && index < cols)
        {
            int minCol = mat[0, index];
            for (int i = 1; i < rows; i++)
            {
                if (mat[i, index] < minCol) minCol = mat[i, index];
            }
            Console.WriteLine($"Gia tri nho nhat cua cot {index}: {minCol}");
        }
    }
    static int[,] TransposeMatrix(int[,] mat)
    {
        int rows = mat.GetLength(0);
        int cols = mat.GetLength(1);
        int[,] result = new int[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[j, i] = mat[i, j];
            }
        }
        return result;
    }
    static void PrintDiagonals(int[,] mat)
    {
        int rows = mat.GetLength(0);
        int cols = mat.GetLength(1);

        if (rows != cols)
        {
            Console.WriteLine("\nKhong the in duong cheo vi day khong phai ma tran vuong.");
            return;
        }

        Console.Write("\nDuong cheo chinh: ");
        for (int i = 0; i < rows; i++)
        {
            Console.Write(mat[i, i] + " ");
        }

        Console.Write("\nDuong cheo phu: ");
        for (int i = 0; i < rows; i++)
        {
            Console.Write(mat[i, rows - 1 - i] + " ");
        }
        Console.WriteLine();
    }
}

