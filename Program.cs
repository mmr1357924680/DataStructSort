using System;

namespace DataStructSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 8, 5, 7, 1, 4};
            InsertSort(arr);
            Console.ReadKey();
        }
        public static void InsertSort(int[] arr)
        {
            for (int i=1;i<arr.Length;i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while (j>=0 && temp < arr[j])
                {
                    arr[j+1] = arr[j];
                    j--;
                }
                arr[j+1] = temp;
            }
            foreach (int item in arr)
            {
                Console.Write(item + ",");
            }
        }
        public static void BinarySort(int[] arr)
        {
            for (int i=1;i<arr.Length;i++)
            {
                int temp = arr[i];
                int low = 0;
                int high = i - 1;
                while (low <= high)
                {
                    int mid = (low + high) / 2;
                    if (temp>arr[mid])
                    {
                        high = mid - 1;


                    }else if (temp<=arr[mid])
                    {
                        low = mid + 1;
                    }
                }
                for (int j=i-1;j>=low;j--)
                {
                    arr[j + 1] = arr[j]; 
                }
                arr[low] = temp;              
            }
        }

        public static void ShellSort(int[] arr)
        {
            for (int gap = arr.Length / 2; gap >= 1; gap /= 2)          //步长的循环
            {
                for (int i = gap; i < arr.Length; i++)                //该步长下循环
                {
                    int temp = arr[i];
                    int j = i - gap;                            //被交换的元素
                    while (j >= 0 && temp < arr[j])
                    {
                        //交换
                        arr[j + gap] = arr[j];
                        j -= gap;
                    }
                    arr[j + gap] = temp;

                }
            }
            foreach (int item in arr)
            {
                Console.Write(item);
            }
        }
        public static void BubbleSort(int[] arr)
        {
            int temp = 0;
            for (int i=0;i<arr.Length-1;i++)
            {
                for (int j=0;j<arr.Length-i-1;j++)
                {
                    if (arr[j]> arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            foreach (int item in arr)
            {
                Console.Write(item);
            }
        }
        public static void CockTailSort(int[] arr)
        {

            for (int i = 1; i < arr.Length / 2; i++)
            {
                for(int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j]>arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                for (int j=arr.Length-i;j>=i;j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }
            foreach (int item in arr)
            {
                Console.Write(item);
            }
        }
    
        /// <summary>
        /// 快速排序
        /// </summary>
        /// <param name="arr">待排序的序列</param>
        /// <param name="low">最小索引</param>
        /// <param name="high">最大索引</param>
        static void QuickSort(int[] arr,int low,int high)
        {

            int i = low;
            int j = high;                                     //右侧索引号
            int temp = arr[i];                                //基准值
            while (i<j)                                       
            {
                while (i < j && arr[j] >= temp)
                {
                    j--;
                }
                arr[i] = arr[j];
                while (i < j && arr[i] <= temp)
                {
                    i++;                                            //从左到右扫描直到找到比基准值大的元素
                }
                arr[j] = arr[i];
            }
            arr[i] = temp;                                          //基准值归位
            QuickSort(arr, low, i - 1);                             //递归左侧区间
            QuickSort(arr,i+1,high);                                //递归右侧区间
        }
    }
}
