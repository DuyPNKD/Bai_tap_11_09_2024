using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Bai_1();

        Bai_2();
    }

    static void Bai_1()
    {
        Console.WriteLine("Bài 1: Tìm phần tử lớn nhất trong mảng!");
        Console.Write("Nhập số lượng phần từ của mảng: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        

        for(int i = 0; i < n; i++)
        {
            Console.Write($"Phần tử thứ {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());


        }

        int max = arr[0];

        for (int i = 1; i < n; i++) { 
            if(arr[i] > max )
            {
                max = arr[i];
            }
        }

        Console.WriteLine($"Phần tử lớn nhất trong mảng: {max}");
        Console.WriteLine();
    }

    static void Bai_2()
    {
        Console.WriteLine("Bài 2: Hãy chọn số đúng!");
        Random rand = new Random();
        int randomNumber = rand.Next(1, 7);

        Console.WriteLine("Nhập vào số bạn đoán (từ 1 đến 6): ");
        int guess = int.Parse(Console.ReadLine());

        if (guess == randomNumber) {
            Console.WriteLine("Chúc mừng! Bạn đã đoán đúng!");

        }
        else
        {
            Console.WriteLine($"Bạn đã thua! Số của tôi là {randomNumber}");
        }
    }
}
