using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class TextProcessor
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Nhập đoạn văn bản:");
        string input = Console.ReadLine();

        // Chuẩn hóa văn bản
        string normalizedText = NormalizeText(input);

        // Thống kê văn bản
        var wordStatistics = AnalyzeText(normalizedText);

        // Hiển thị kết quả
        Console.WriteLine("\nVăn bản đã chuẩn hóa:");
        Console.WriteLine(normalizedText);

        Console.WriteLine("\nThống kê tần suất từ:");
        Console.WriteLine("Từ\t\tTần suất");
        foreach (var word in wordStatistics.Frequency)
        {
            Console.WriteLine($"{word.Key}\t\t{word.Value}");
        }

        Console.WriteLine($"\nTổng số từ: {wordStatistics.TotalWords}");
        Console.WriteLine($"Số lượng từ khác nhau: {wordStatistics.DistinctWords}");
    }

    static string NormalizeText(string text)
    {
        // Xóa khoảng trắng thừa và chuẩn hóa dấu câu
        text = Regex.Replace(text, @"\s+", " ").Trim();

        // Chuyển ký tự đầu mỗi câu thành chữ hoa
        text = Regex.Replace(text, @"(^\s*|[.!?]\s+)(\w)", m => m.Groups[1].Value + m.Groups[2].Value.ToUpper());

        return text;
    }

    static (int TotalWords, int DistinctWords, Dictionary<string, int> Frequency) AnalyzeText(string text)
    {
        // Chuyển văn bản về chữ thường và tách từ
        string[] words = text.ToLower().Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        // Đếm tổng số từ
        int totalWords = words.Length;

        // Thống kê tần suất từ
        var frequency = words.GroupBy(word => word)
                             .ToDictionary(group => group.Key, group => group.Count());

        // Đếm số từ khác nhau
        int distinctWords = frequency.Count;

        return (totalWords, distinctWords, frequency);
    }
}
