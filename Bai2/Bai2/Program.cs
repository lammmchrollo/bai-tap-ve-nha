using System;

class ArrayProcessor
{
    private int[] arr;

    // ===== Nhập mảng từ bàn phím =====
    public void Input()
    {
        Console.Write("Nhập số phần tử của mảng: ");
        int n = int.Parse(Console.ReadLine());
        arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phần tử arr[{i}] = ");
            arr[i] = int.Parse(Console.ReadLine());
        }
    }

    // ===== Hiển thị mảng =====
    public void Display()
    {
        if (arr == null || arr.Length == 0)
        {
            Console.WriteLine("Mảng rỗng!");
            return;
        }

        Console.Write("Mảng: ");
        foreach (int x in arr)
            Console.Write(x + " ");
        Console.WriteLine();
    }

    // ===== Bubble Sort (Nổi bọt) =====
    public void BubbleSort()
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Hoán đổi
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // ===== Quick Sort =====
    public void QuickSort(int left, int right)
    {
        int i = left, j = right;
        int pivot = arr[(left + right) / 2]; // Chọn phần tử giữa làm chốt

        while (i <= j)
        {
            while (arr[i] < pivot) i++;
            while (arr[j] > pivot) j--;

            if (i <= j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
        }

        if (left < j) QuickSort(left, j);
        if (i < right) QuickSort(i, right);
    }

    // ===== Linear Search (Tìm tuyến tính) =====
    public int LinearSearch(int key)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == key) return i; // Trả về vị trí đầu tiên
        }
        return -1; // Không tìm thấy
    }

    // ===== Binary Search (Tìm nhị phân) =====
    public int BinarySearch(int key)
    {
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (arr[mid] == key) return mid;
            if (arr[mid] < key)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Hỗ trợ tiếng Việt
        ArrayProcessor ap = new ArrayProcessor();

        // Nhập mảng
        ap.Input();

        // In ra mảng ban đầu
        Console.WriteLine("\n🔹 Mảng ban đầu:");
        ap.Display();

        // Sắp xếp bằng Bubble Sort
        Console.WriteLine("\n🔹 Sắp xếp bằng Bubble Sort:");
        ap.BubbleSort();
        ap.Display();

        // Sắp xếp bằng Quick Sort
        Console.WriteLine("\n🔹 Sắp xếp bằng Quick Sort:");
        // (Nhập lại mảng ban đầu để thử Quick Sort)
        ap.Input();
        ap.QuickSort(0, apLength(ap) - 1);
        ap.Display();

        // Tìm kiếm
        Console.Write("\n👉 Nhập số cần tìm: ");
        int key = int.Parse(Console.ReadLine());

        int posLinear = ap.LinearSearch(key);
        if (posLinear != -1)
            Console.WriteLine($"✅ Linear Search: Tìm thấy {key} tại vị trí {posLinear}");
        else
            Console.WriteLine($"❌ Linear Search: Không tìm thấy {key}");

        // Trước khi tìm nhị phân phải sắp xếp lại
        ap.BubbleSort();
        int posBinary = ap.BinarySearch(key);
        if (posBinary != -1)
            Console.WriteLine($"✅ Binary Search: Tìm thấy {key} tại vị trí {posBinary}");
        else
            Console.WriteLine($"❌ Binary Search: Không tìm thấy {key}");
    }

    // Hàm phụ để lấy độ dài mảng private trong ArrayProcessor
    static int apLength(ArrayProcessor ap)
    {
        var arrField = typeof(ArrayProcessor).GetField("arr",
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Instance);
        int[] arr = (int[])arrField.GetValue(ap);
        return arr.Length;
    }
}
