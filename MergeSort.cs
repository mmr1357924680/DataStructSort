using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructSort
{
    /// <summary>
    /// 二路归并排序
    /// </summary>
    class MergeSortDS
    {
        private int[] array;                             //待排序序列
        public MergeSortDS(int[] _arr)
        {
            this.array = _arr;
        }
        private void MergeSort(int low,int high)
        {
            if (low<high)                                //low与high分别是最小索引和最大索引
            {
                int mid = (low + high) / 2;
                MergeSort(low, mid);                     //递归左侧部分
                MergeSort(mid + 1, high);                //递归右侧部分
                Merge(low, mid, high);
            }
        }
        //将两个有序序列array[low,....mid]与array[low+1,.....high]合并

        private void Merge(int low,int mid,int high)
        {
            //临时空间，存放合并后的数据
            int[] array1 = new int[high - low + 1];         //版本1test
            int i = low;                                 
            int j = mid + 1;
        }
    }
}
