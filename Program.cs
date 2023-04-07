using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementOfAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo mảng ngẫu nhiên
            Console.Write("Nhap chieu dai mang: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(0, 10);
            }

            // Xuất mảng ra màn hình
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            // Yêu cầu nhập phần tử cần xóa
            Console.Write("Nhap phan tu can xoa khoi mang: ");
            int x = Convert.ToInt32(Console.ReadLine());

            // Tìm vị trí và xóa phần tử khỏi mảng
            int isFound = Array.Find(array, e => e == x);
            if (isFound == x)
            {
                Console.WriteLine("Tim thay phan tu can xoa");
                findElement(array, x);
                Console.WriteLine("Mang sau khi xoa phan tu");
                removeElement(array, x);
            }
            else
            {
                Console.WriteLine("Khong tim thay phan tu can xoa");
            }
        }

        static void findElement(int[] array, int a)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i].Equals(a))
                    Console.WriteLine("Vi tri phan tu can xoa: " + (i + 1));
            }
            return;
        }

        static void removeElement(int[] array, int a)
        {
            array = array.Where(e => e != a).ToArray();
            Console.WriteLine(String.Join(" ", array));
            return;
        }
    }   
}
