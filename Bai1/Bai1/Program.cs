using System;

class MatrixProgram
{
    // ===== Hàm nhập ma trận =====
    static int[,] NhapMaTran(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        Console.WriteLine($"Nhập ma trận {rows}x{cols}:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Phần tử [{i},{j}] = ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        return matrix;
    }

    // ===== Hàm in ma trận =====
    static void InMaTran(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        Console.WriteLine("Ma trận:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // ===== Hàm cộng hai ma trận =====
    static int[,] CongMaTran(int[,] A, int[,] B)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        int[,] C = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                C[i, j] = A[i, j] + B[i, j];
            }
        }
        return C;
    }

    // ===== Hàm nhân hai ma trận =====
    static int[,] NhanMaTran(int[,] A, int[,] B)
    {
        int rowsA = A.GetLength(0);
        int colsA = A.GetLength(1);
        int rowsB = B.GetLength(0);
        int colsB = B.GetLength(1);

        if (colsA != rowsB)
        {
            Console.WriteLine("❌ Không thể nhân hai ma trận (số cột A ≠ số dòng B).");
            return null;
        }

        int[,] C = new int[rowsA, colsB];
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                C[i, j] = 0;
                for (int k = 0; k < colsA; k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }
        return C;
    }

    // ===== Hàm chuyển vị ma trận =====
    static int[,] ChuyenVi(int[,] A)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        int[,] T = new int[cols, rows];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                T[j, i] = A[i, j];
            }
        }
        return T;
    }

    // ===== Hàm tìm min, max =====
    static void TimMinMax(int[,] A)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        int min = A[0, 0];
        int max = A[0, 0];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (A[i, j] < min) min = A[i, j];
                if (A[i, j] > max) max = A[i, j];
            }
        }

        Console.WriteLine($"🔹 Giá trị nhỏ nhất: {min}");
        Console.WriteLine($"🔹 Giá trị lớn nhất: {max}");
    }

    // ===== Hàm kiểm tra ma trận đối xứng =====
    static bool LaDoiXung(int[,] A)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != cols) return false; // Chỉ vuông mới đối xứng

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (A[i, j] != A[j, i])
                    return false;
            }
        }
        return true;
    }

    // ===== Hàm tính định thức (đệ quy) =====
    static int DinhThuc(int[,] A)
    {
        int n = A.GetLength(0);
        if (A.GetLength(0) != A.GetLength(1))
        {
            throw new Exception("❌ Chỉ tính định thức cho ma trận vuông.");
        }

        // TH cơ bản
        if (n == 1) return A[0, 0];
        if (n == 2) return A[0, 0] * A[1, 1] - A[0, 1] * A[1, 0];

        int det = 0;
        for (int col = 0; col < n; col++)
        {
            det += (int)Math.Pow(-1, col) * A[0, col] * DinhThuc(PhuHop(A, 0, col));
        }
        return det;
    }

    // Hàm tạo ma trận con khi bỏ dòng i, cột j
    static int[,] PhuHop(int[,] A, int rowToRemove, int colToRemove)
    {
        int n = A.GetLength(0);
        int[,] result = new int[n - 1, n - 1];
        int r = 0, c = 0;
        for (int i = 0; i < n; i++)
        {
            if (i == rowToRemove) continue;
            c = 0;
            for (int j = 0; j < n; j++)
            {
                if (j == colToRemove) continue;
                result[r, c] = A[i, j];
                c++;
            }
            r++;
        }
        return result;
    }

    // ===== Main program (Menu) =====
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Hỗ trợ tiếng Việt

        int[,] A = null;
        int[,] B = null;

        while (true)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Nhập ma trận A");
            Console.WriteLine("2. Nhập ma trận B");
            Console.WriteLine("3. In ma trận A và B");
            Console.WriteLine("4. Cộng A + B");
            Console.WriteLine("5. Nhân A × B");
            Console.WriteLine("6. Chuyển vị A");
            Console.WriteLine("7. Tìm min, max của A");
            Console.WriteLine("8. Kiểm tra A có đối xứng không");
            Console.WriteLine("9. Tính định thức của A");
            Console.WriteLine("0. Thoát");
            Console.Write(" Chọn chức năng: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Nhập số dòng của A: ");
                    int rowsA = int.Parse(Console.ReadLine());
                    Console.Write("Nhập số cột của A: ");
                    int colsA = int.Parse(Console.ReadLine());
                    A = NhapMaTran(rowsA, colsA);
                    break;

                case 2:
                    Console.Write("Nhập số dòng của B: ");
                    int rowsB = int.Parse(Console.ReadLine());
                    Console.Write("Nhập số cột của B: ");
                    int colsB = int.Parse(Console.ReadLine());
                    B = NhapMaTran(rowsB, colsB);
                    break;

                case 3:
                    if (A != null) { Console.WriteLine("🔹 Ma trận A:"); InMaTran(A); }
                    if (B != null) { Console.WriteLine("🔹 Ma trận B:"); InMaTran(B); }
                    break;

                case 4:
                    if (A != null && B != null &&
                        A.GetLength(0) == B.GetLength(0) &&
                        A.GetLength(1) == B.GetLength(1))
                    {
                        var C = CongMaTran(A, B);
                        Console.WriteLine("✅ Kết quả A + B:");
                        InMaTran(C);
                    }
                    else Console.WriteLine("❌ Không thể cộng (kích thước khác nhau hoặc chưa nhập đủ ma trận).");
                    break;

                case 5:
                    if (A != null && B != null)
                    {
                        var C = NhanMaTran(A, B);
                        if (C != null)
                        {
                            Console.WriteLine("✅ Kết quả A × B:");
                            InMaTran(C);
                        }
                    }
                    else Console.WriteLine("❌ Chưa nhập ma trận A hoặc B.");
                    break;

                case 6:
                    if (A != null)
                    {
                        var T = ChuyenVi(A);
                        Console.WriteLine("✅ Chuyển vị A:");
                        InMaTran(T);
                    }
                    else Console.WriteLine("❌ Chưa nhập ma trận A.");
                    break;

                case 7:
                    if (A != null)
                        TimMinMax(A);
                    else Console.WriteLine("❌ Chưa nhập ma trận A.");
                    break;

                case 8:
                    if (A != null)
                    {
                        if (LaDoiXung(A))
                            Console.WriteLine("✅ Ma trận A là đối xứng.");
                        else
                            Console.WriteLine("❌ Ma trận A không đối xứng.");
                    }
                    else Console.WriteLine("❌ Chưa nhập ma trận A.");
                    break;

                case 9:
                    if (A != null && A.GetLength(0) == A.GetLength(1))
                    {
                        Console.WriteLine($"✅ Định thức(A) = {DinhThuc(A)}");
                    }
                    else Console.WriteLine("❌ Chưa nhập ma trận vuông.");
                    break;

                case 0:
                    return;

                default:
                    Console.WriteLine("❌ Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}
