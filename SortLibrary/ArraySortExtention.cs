using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SortLibrary
{
    public static class ArrayQuickSortExtention
    {
        private static byte[] QuickSort(this byte[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            var pivotIndex = Partition(minIndex, maxIndex);
            array.QuickSort(minIndex, pivotIndex - 1);
            array.QuickSort(pivotIndex + 1, maxIndex);
            return array;
            static void Swap(ref byte x, ref byte y)
            {
                var t = x;
                x = y;
                y = t;
            }
            int Partition(int minIndex, int maxIndex)
            {
                var pivot = minIndex - 1;
                for (var i = minIndex; i < maxIndex; i++)
                {
                    if (array[i] < array[maxIndex])
                    {
                        pivot++;
                        Swap(ref array[pivot], ref array[i]);
                    }
                }

                pivot++;
                Swap(ref array[pivot], ref array[maxIndex]);
                return pivot;
            }
        }
        public static byte[] QuickSort(this byte[] array)
        {
            return array.QuickSort(0, array.Length - 1);
        }

        private static short[] QuickSort(this short[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            var pivotIndex = Partition(minIndex, maxIndex);
            array.QuickSort(minIndex, pivotIndex - 1);
            array.QuickSort(pivotIndex + 1, maxIndex);
            return array;
            static void Swap(ref short x, ref short y)
            {
                var t = x;
                x = y;
                y = t;
            }
            int Partition(int minIndex, int maxIndex)
            {
                var pivot = minIndex - 1;
                for (var i = minIndex; i < maxIndex; i++)
                {
                    if (array[i] < array[maxIndex])
                    {
                        pivot++;
                        Swap(ref array[pivot], ref array[i]);
                    }
                }

                pivot++;
                Swap(ref array[pivot], ref array[maxIndex]);
                return pivot;
            }
        }
        public static short[] QuickSort(this short[] array)
        {
            return array.QuickSort(0, array.Length - 1);
        }

        private static int[] QuickSort(this int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            var pivotIndex = Partition(minIndex, maxIndex);
            array.QuickSort(minIndex, pivotIndex - 1);
            array.QuickSort(pivotIndex + 1, maxIndex);
            return array;
            static void Swap(ref int x, ref int y)
            {
                var t = x;
                x = y;
                y = t;
            }
            int Partition(int minIndex, int maxIndex)
            {
                var pivot = minIndex - 1;
                for (var i = minIndex; i < maxIndex; i++)
                {
                    if (array[i] < array[maxIndex])
                    {
                        pivot++;
                        Swap(ref array[pivot], ref array[i]);
                    }
                }

                pivot++;
                Swap(ref array[pivot], ref array[maxIndex]);
                return pivot;
            }
        }
        public static int[] QuickSort(this int[] array)
        {
            return array.QuickSort(0, array.Length - 1);
        }

        private static long[] QuickSort(this long[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            var pivotIndex = Partition(minIndex, maxIndex);
            array.QuickSort(minIndex, pivotIndex - 1);
            array.QuickSort(pivotIndex + 1, maxIndex);
            return array;
            static void Swap(ref long x, ref long y)
            {
                var t = x;
                x = y;
                y = t;
            }
            int Partition(int minIndex, int maxIndex)
            {
                var pivot = minIndex - 1;
                for (var i = minIndex; i < maxIndex; i++)
                {
                    if (array[i] < array[maxIndex])
                    {
                        pivot++;
                        Swap(ref array[pivot], ref array[i]);
                    }
                }

                pivot++;
                Swap(ref array[pivot], ref array[maxIndex]);
                return pivot;
            }
        }
        public static long[] QuickSort(this long[] array)
        {
            return array.QuickSort(0, array.Length - 1);
        }

        private static decimal[] QuickSort(this decimal[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            var pivotIndex = Partition(minIndex, maxIndex);
            array.QuickSort(minIndex, pivotIndex - 1);
            array.QuickSort(pivotIndex + 1, maxIndex);
            return array;
            static void Swap(ref decimal x, ref decimal y)
            {
                var t = x;
                x = y;
                y = t;
            }
            int Partition(int minIndex, int maxIndex)
            {
                var pivot = minIndex - 1;
                for (var i = minIndex; i < maxIndex; i++)
                {
                    if (array[i] < array[maxIndex])
                    {
                        pivot++;
                        Swap(ref array[pivot], ref array[i]);
                    }
                }

                pivot++;
                Swap(ref array[pivot], ref array[maxIndex]);
                return pivot;
            }
        }
        public static decimal[] QuickSort(this decimal[] array)
        {
            return array.QuickSort(0, array.Length - 1);
        }

        private static float[] QuickSort(this float[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            var pivotIndex = Partition(minIndex, maxIndex);
            array.QuickSort(minIndex, pivotIndex - 1);
            array.QuickSort(pivotIndex + 1, maxIndex);
            return array;
            static void Swap(ref float x, ref float y)
            {
                var t = x;
                x = y;
                y = t;
            }
            int Partition(int minIndex, int maxIndex)
            {
                var pivot = minIndex - 1;
                for (var i = minIndex; i < maxIndex; i++)
                {
                    if (array[i] < array[maxIndex])
                    {
                        pivot++;
                        Swap(ref array[pivot], ref array[i]);
                    }
                }

                pivot++;
                Swap(ref array[pivot], ref array[maxIndex]);
                return pivot;
            }
        }
        public static float[] QuickSort(this float[] array)
        {
            return array.QuickSort(0, array.Length - 1);
        }

        private static double[] QuickSort(this double[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            var pivotIndex = Partition(minIndex, maxIndex);
            array.QuickSort(minIndex, pivotIndex - 1);
            array.QuickSort(pivotIndex + 1, maxIndex);
            return array;
            static void Swap(ref double x, ref double y)
            {
                var t = x;
                x = y;
                y = t;
            }
            int Partition(int minIndex, int maxIndex)
            {
                var pivot = minIndex - 1;
                for (var i = minIndex; i < maxIndex; i++)
                {
                    if (array[i] < array[maxIndex])
                    {
                        pivot++;
                        Swap(ref array[pivot], ref array[i]);
                    }
                }

                pivot++;
                Swap(ref array[pivot], ref array[maxIndex]);
                return pivot;
            }
        }
        public static double[] QuickSort(this double[] array)
        {
            return array.QuickSort(0, array.Length - 1);
        }

    }
    public static class ListQuickSortExtention
    {
        private static List<byte> QuickSort(this List<byte> array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            var pivotIndex = Partition(minIndex, maxIndex);
            array.QuickSort(minIndex, pivotIndex - 1);
            array.QuickSort(pivotIndex + 1, maxIndex);
            return array;
            static void Swap(ref byte x, ref byte y)
            {
                var t = x;
                x = y;
                y = t;
            }
            int Partition(int minIndex, int maxIndex)
            {
                var pivot = minIndex - 1;
                for (var i = minIndex; i < maxIndex; i++)
                {
                    if (array[i] < array[maxIndex])
                    {
                        pivot++;
                        Swap(ref array.ToArray()[pivot], ref array.ToArray()[i]);
                    }
                }

                pivot++;
                Swap(ref array.ToArray()[pivot], ref array.ToArray()[maxIndex]);
                return pivot;
            }
        }
        public static List<byte> QuickSort(this List<byte> array)
        {
            return array.QuickSort(0, array.Count - 1);
        }

        private static List<short> QuickSort(this List<short> array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            var pivotIndex = Partition(minIndex, maxIndex);
            array.QuickSort(minIndex, pivotIndex - 1);
            array.QuickSort(pivotIndex + 1, maxIndex);
            return array;
            static void Swap(ref short x, ref short y)
            {
                var t = x;
                x = y;
                y = t;
            }
            int Partition(int minIndex, int maxIndex)
            {
                var pivot = minIndex - 1;
                for (var i = minIndex; i < maxIndex; i++)
                {
                    if (array[i] < array[maxIndex])
                    {
                        pivot++;
                        Swap(ref array.ToArray()[pivot], ref array.ToArray()[i]);
                    }
                }

                pivot++;
                Swap(ref array.ToArray()[pivot], ref array.ToArray()[maxIndex]);
                return pivot;
            }
        }
        public static List<short> QuickSort(this List<short> array)
        {
            return array.QuickSort(0, array.Count - 1);
        }

        private static List<int> QuickSort(this List<int> array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            var pivotIndex = Partition(minIndex, maxIndex);
            array.QuickSort(minIndex, pivotIndex - 1);
            array.QuickSort(pivotIndex + 1, maxIndex);
            return array;
            static void Swap(ref int x, ref int y)
            {
                var t = x;
                x = y;
                y = t;
            }
            int Partition(int minIndex, int maxIndex)
            {
                var pivot = minIndex - 1;
                for (var i = minIndex; i < maxIndex; i++)
                {
                    if (array[i] < array[maxIndex])
                    {
                        pivot++;
                        Swap(ref array.ToArray()[pivot], ref array.ToArray()[i]);
                    }
                }

                pivot++;
                Swap(ref array.ToArray()[pivot], ref array.ToArray()[maxIndex]);
                return pivot;
            }
        }
        public static List<int> QuickSort(this List<int> array)
        {
            return array.QuickSort(0, array.Count - 1);
        }

        private static List<long> QuickSort(this List<long> array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            var pivotIndex = Partition(minIndex, maxIndex);
            array.QuickSort(minIndex, pivotIndex - 1);
            array.QuickSort(pivotIndex + 1, maxIndex);
            return array;
            static void Swap(ref long x, ref long y)
            {
                var t = x;
                x = y;
                y = t;
            }
            int Partition(int minIndex, int maxIndex)
            {
                var pivot = minIndex - 1;
                for (var i = minIndex; i < maxIndex; i++)
                {
                    if (array[i] < array[maxIndex])
                    {
                        pivot++;
                        Swap(ref array.ToArray()[pivot], ref array.ToArray()[i]);
                    }
                }

                pivot++;
                Swap(ref array.ToArray()[pivot], ref array.ToArray()[maxIndex]);
                return pivot;
            }
        }
        public static List<long> QuickSort(this List<long> array)
        {
            return array.QuickSort(0, array.Count - 1);
        }

        private static List<decimal> QuickSort(this List<decimal> array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            var pivotIndex = Partition(minIndex, maxIndex);
            array.QuickSort(minIndex, pivotIndex - 1);
            array.QuickSort(pivotIndex + 1, maxIndex);
            return array;
            static void Swap(ref decimal x, ref decimal y)
            {
                var t = x;
                x = y;
                y = t;
            }
            int Partition(int minIndex, int maxIndex)
            {
                var pivot = minIndex - 1;
                for (var i = minIndex; i < maxIndex; i++)
                {
                    if (array[i] < array[maxIndex])
                    {
                        pivot++;
                        Swap(ref array.ToArray()[pivot], ref array.ToArray()[i]);
                    }
                }

                pivot++;
                Swap(ref array.ToArray()[pivot], ref array.ToArray()[maxIndex]);
                return pivot;
            }
        }
        public static List<decimal> QuickSort(this List<decimal> array)
        {
            return array.QuickSort(0, array.Count - 1);
        }

        private static List<float> QuickSort(this List<float> array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            var pivotIndex = Partition(minIndex, maxIndex);
            array.QuickSort(minIndex, pivotIndex - 1);
            array.QuickSort(pivotIndex + 1, maxIndex);
            return array;
            static void Swap(ref float x, ref float y)
            {
                var t = x;
                x = y;
                y = t;
            }
            int Partition(int minIndex, int maxIndex)
            {
                var pivot = minIndex - 1;
                for (var i = minIndex; i < maxIndex; i++)
                {
                    if (array[i] < array[maxIndex])
                    {
                        pivot++;
                        Swap(ref array.ToArray()[pivot], ref array.ToArray()[i]);
                    }
                }

                pivot++;
                Swap(ref array.ToArray()[pivot], ref array.ToArray()[maxIndex]);
                return pivot;
            }
        }
        public static List<float> QuickSort(this List<float> array)
        {
            return array.QuickSort(0, array.Count - 1);
        }

        private static List<double> QuickSort(this List<double> array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            var pivotIndex = Partition(minIndex, maxIndex);
            array.QuickSort(minIndex, pivotIndex - 1);
            array.QuickSort(pivotIndex + 1, maxIndex);
            return array;
            static void Swap(ref double x, ref double y)
            {
                var t = x;
                x = y;
                y = t;
            }
            int Partition(int minIndex, int maxIndex)
            {
                var pivot = minIndex - 1;
                for (var i = minIndex; i < maxIndex; i++)
                {
                    if (array[i] < array[maxIndex])
                    {
                        pivot++;
                        Swap(ref array.ToArray()[pivot], ref array.ToArray()[i]);
                    }
                }

                pivot++;
                Swap(ref array.ToArray()[pivot], ref array.ToArray()[maxIndex]);
                return pivot;
            }
        }
        public static List<double> QuickSort(this List<double> array)
        {
            return array.QuickSort(0, array.Count - 1);
        }
    }
    public static class ArrayInsertionSortExtention
    {
        public static int[] InsertionSort(this int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }
                array[j] = key;
            }
            return array;

            static void Swap(ref int e1, ref int e2)
            {
                var temp = e1;
                e1 = e2;
                e2 = temp;
            }
        }

        public static byte[] InsertionSort(this byte[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }
                array[j] = key;
            }
            return array;

            static void Swap(ref byte e1, ref byte e2)
            {
                var temp = e1;
                e1 = e2;
                e2 = temp;
            }
        }

        public static short[] InsertionSort(this short[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }
                array[j] = key;
            }
            return array;

            static void Swap(ref short e1, ref short e2)
            {
                var temp = e1;
                e1 = e2;
                e2 = temp;
            }
        }

        public static long[] InsertionSort(this long[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }
                array[j] = key;
            }
            return array;

            static void Swap(ref long e1, ref long e2)
            {
                var temp = e1;
                e1 = e2;
                e2 = temp;
            }
        }

        public static decimal[] InsertionSort(this decimal[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }
                array[j] = key;
            }
            return array;

            static void Swap(ref decimal e1, ref decimal e2)
            {
                var temp = e1;
                e1 = e2;
                e2 = temp;
            }
        }

        public static double[] InsertionSort(this double[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }
                array[j] = key;
            }
            return array;

            static void Swap(ref double e1, ref double e2)
            {
                var temp = e1;
                e1 = e2;
                e2 = temp;
            }
        }

        public static float[] InsertionSort(this float[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }
                array[j] = key;
            }
            return array;

            static void Swap(ref float e1, ref float e2)
            {
                var temp = e1;
                e1 = e2;
                e2 = temp;
            }
        }
    }
    public static class ListInsertionSortExtention
    {
        public static List<int> InsertionSort(this List<int> array)
        {
            for (var i = 1; i < array.Count; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array.ToArray()[j - 1], ref array.ToArray()[j]);
                    j--;
                }
                array[j] = key;
            }
            return array;

            static void Swap(ref int e1, ref int e2)
            {
                var temp = e1;
                e1 = e2;
                e2 = temp;
            }
        }

        public static List<byte> InsertionSort(this List<byte> array)
        {
            for (var i = 1; i < array.Count; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array.ToArray()[j - 1], ref array.ToArray()[j]);
                    j--;
                }
                array[j] = key;
            }
            return array;

            static void Swap(ref byte e1, ref byte e2)
            {
                var temp = e1;
                e1 = e2;
                e2 = temp;
            }
        }

        public static List<short> InsertionSort(this List<short> array)
        {
            for (var i = 1; i < array.Count; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array.ToArray()[j - 1], ref array.ToArray()[j]);
                    j--;
                }
                array[j] = key;
            }
            return array;

            static void Swap(ref short e1, ref short e2)
            {
                var temp = e1;
                e1 = e2;
                e2 = temp;
            }
        }

        public static List<long> InsertionSort(this List<long> array)
        {
            for (var i = 1; i < array.Count; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array.ToArray()[j - 1], ref array.ToArray()[j]);
                    j--;
                }
                array[j] = key;
            }
            return array;

            static void Swap(ref long e1, ref long e2)
            {
                var temp = e1;
                e1 = e2;
                e2 = temp;
            }
        }

        public static List<decimal> InsertionSort(this List<decimal> array)
        {
            for (var i = 1; i < array.Count; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array.ToArray()[j - 1], ref array.ToArray()[j]);
                    j--;
                }
                array[j] = key;
            }
            return array;

            static void Swap(ref decimal e1, ref decimal e2)
            {
                var temp = e1;
                e1 = e2;
                e2 = temp;
            }
        }

        public static List<double> InsertionSort(this List<double> array)
        {
            for (var i = 1; i < array.Count; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array.ToArray()[j - 1], ref array.ToArray()[j]);
                    j--;
                }
                array[j] = key;
            }
            return array;

            static void Swap(ref double e1, ref double e2)
            {
                var temp = e1;
                e1 = e2;
                e2 = temp;
            }
        }

        public static List<float> InsertionSort(this List<float> array)
        {
            for (var i = 1; i < array.Count; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array.ToArray()[j - 1], ref array.ToArray()[j]);
                    j--;
                }
                array[j] = key;
            }
            return array;

            static void Swap(ref float e1, ref float e2)
            {
                var temp = e1;
                e1 = e2;
                e2 = temp;
            }
        }
    }
    public static class ArrayMergeSortExtention
    {
        private static byte[] MergeSort(this byte[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                array.MergeSort(lowIndex, middleIndex);
                array.MergeSort(middleIndex + 1, highIndex);
                Merge(lowIndex, middleIndex, highIndex);
            }
            return array;
            void Merge(int lowIndex, int middleIndex, int highIndex)
            {
                var left = lowIndex;
                var right = middleIndex + 1;
                var tempArray = new byte[highIndex - lowIndex + 1];
                var index = 0;

                while ((left <= middleIndex) && (right <= highIndex))
                {
                    if (array[left] < array[right])
                    {
                        tempArray[index] = array[left];
                        left++;
                    }
                    else
                    {
                        tempArray[index] = array[right];
                        right++;
                    }

                    index++;
                }

                for (var i = left; i <= middleIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = right; i <= highIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = 0; i < tempArray.Length; i++)
                {
                    array[lowIndex + i] = tempArray[i];
                }
            }
        }
        public static byte[] MergeSort(this byte[] array)
        {
            return MergeSort(array, 0, array.Length - 1);
        }

        private static short[] MergeSort(this short[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                array.MergeSort(lowIndex, middleIndex);
                array.MergeSort(middleIndex + 1, highIndex);
                Merge(lowIndex, middleIndex, highIndex);
            }
            return array;
            void Merge(int lowIndex, int middleIndex, int highIndex)
            {
                var left = lowIndex;
                var right = middleIndex + 1;
                var tempArray = new short[highIndex - lowIndex + 1];
                var index = 0;

                while ((left <= middleIndex) && (right <= highIndex))
                {
                    if (array[left] < array[right])
                    {
                        tempArray[index] = array[left];
                        left++;
                    }
                    else
                    {
                        tempArray[index] = array[right];
                        right++;
                    }

                    index++;
                }

                for (var i = left; i <= middleIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = right; i <= highIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = 0; i < tempArray.Length; i++)
                {
                    array[lowIndex + i] = tempArray[i];
                }
            }
        }
        public static short[] MergeSort(this short[] array)
        {
            return MergeSort(array, 0, array.Length - 1);
        }

        private static int[] MergeSort(this int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                array.MergeSort(lowIndex, middleIndex);
                array.MergeSort(middleIndex + 1, highIndex);
                Merge(lowIndex, middleIndex, highIndex);
            }
            return array;
            void Merge(int lowIndex, int middleIndex, int highIndex)
            {
                var left = lowIndex;
                var right = middleIndex + 1;
                var tempArray = new int[highIndex - lowIndex + 1];
                var index = 0;

                while ((left <= middleIndex) && (right <= highIndex))
                {
                    if (array[left] < array[right])
                    {
                        tempArray[index] = array[left];
                        left++;
                    }
                    else
                    {
                        tempArray[index] = array[right];
                        right++;
                    }

                    index++;
                }

                for (var i = left; i <= middleIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = right; i <= highIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = 0; i < tempArray.Length; i++)
                {
                    array[lowIndex + i] = tempArray[i];
                }
            }
        }
        public static int[] MergeSort(this int[] array)
        {
            return MergeSort(array, 0, array.Length - 1);
        }

        private static long[] MergeSort(this long[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                array.MergeSort(lowIndex, middleIndex);
                array.MergeSort(middleIndex + 1, highIndex);
                Merge(lowIndex, middleIndex, highIndex);
            }
            return array;
            void Merge(int lowIndex, int middleIndex, int highIndex)
            {
                var left = lowIndex;
                var right = middleIndex + 1;
                var tempArray = new long[highIndex - lowIndex + 1];
                var index = 0;

                while ((left <= middleIndex) && (right <= highIndex))
                {
                    if (array[left] < array[right])
                    {
                        tempArray[index] = array[left];
                        left++;
                    }
                    else
                    {
                        tempArray[index] = array[right];
                        right++;
                    }

                    index++;
                }

                for (var i = left; i <= middleIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = right; i <= highIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = 0; i < tempArray.Length; i++)
                {
                    array[lowIndex + i] = tempArray[i];
                }
            }
        }
        public static long[] MergeSort(this long[] array)
        {
            return MergeSort(array, 0, array.Length - 1);
        }

        private static decimal[] MergeSort(this decimal[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                array.MergeSort(lowIndex, middleIndex);
                array.MergeSort(middleIndex + 1, highIndex);
                Merge(lowIndex, middleIndex, highIndex);
            }
            return array;
            void Merge(int lowIndex, int middleIndex, int highIndex)
            {
                var left = lowIndex;
                var right = middleIndex + 1;
                var tempArray = new decimal[highIndex - lowIndex + 1];
                var index = 0;

                while ((left <= middleIndex) && (right <= highIndex))
                {
                    if (array[left] < array[right])
                    {
                        tempArray[index] = array[left];
                        left++;
                    }
                    else
                    {
                        tempArray[index] = array[right];
                        right++;
                    }

                    index++;
                }

                for (var i = left; i <= middleIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = right; i <= highIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = 0; i < tempArray.Length; i++)
                {
                    array[lowIndex + i] = tempArray[i];
                }
            }
        }
        public static decimal[] MergeSort(this decimal[] array)
        {
            return MergeSort(array, 0, array.Length - 1);
        }

        private static float[] MergeSort(this float[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                array.MergeSort(lowIndex, middleIndex);
                array.MergeSort(middleIndex + 1, highIndex);
                Merge(lowIndex, middleIndex, highIndex);
            }
            return array;
            void Merge(int lowIndex, int middleIndex, int highIndex)
            {
                var left = lowIndex;
                var right = middleIndex + 1;
                var tempArray = new float[highIndex - lowIndex + 1];
                var index = 0;

                while ((left <= middleIndex) && (right <= highIndex))
                {
                    if (array[left] < array[right])
                    {
                        tempArray[index] = array[left];
                        left++;
                    }
                    else
                    {
                        tempArray[index] = array[right];
                        right++;
                    }

                    index++;
                }

                for (var i = left; i <= middleIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = right; i <= highIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = 0; i < tempArray.Length; i++)
                {
                    array[lowIndex + i] = tempArray[i];
                }
            }
        }
        public static float[] MergeSort(this float[] array)
        {
            return MergeSort(array, 0, array.Length - 1);
        }

        private static double[] MergeSort(this double[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                array.MergeSort(lowIndex, middleIndex);
                array.MergeSort(middleIndex + 1, highIndex);
                Merge(lowIndex, middleIndex, highIndex);
            }
            return array;
            void Merge(int lowIndex, int middleIndex, int highIndex)
            {
                var left = lowIndex;
                var right = middleIndex + 1;
                var tempArray = new double[highIndex - lowIndex + 1];
                var index = 0;

                while ((left <= middleIndex) && (right <= highIndex))
                {
                    if (array[left] < array[right])
                    {
                        tempArray[index] = array[left];
                        left++;
                    }
                    else
                    {
                        tempArray[index] = array[right];
                        right++;
                    }

                    index++;
                }

                for (var i = left; i <= middleIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = right; i <= highIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = 0; i < tempArray.Length; i++)
                {
                    array[lowIndex + i] = tempArray[i];
                }
            }
        }
        public static double[] MergeSort(this double[] array)
        {
            return MergeSort(array, 0, array.Length - 1);
        }

    }
    public static class ListMergeSortextention
    {
        private static List<byte> MergeSort(this List<byte> array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                array.MergeSort(lowIndex, middleIndex);
                array.MergeSort(middleIndex + 1, highIndex);
                Merge(lowIndex, middleIndex, highIndex);
            }
            return array;
            void Merge(int lowIndex, int middleIndex, int highIndex)
            {
                var left = lowIndex;
                var right = middleIndex + 1;
                var tempArray = new byte[highIndex - lowIndex + 1];
                var index = 0;

                while ((left <= middleIndex) && (right <= highIndex))
                {
                    if (array[left] < array[right])
                    {
                        tempArray[index] = array[left];
                        left++;
                    }
                    else
                    {
                        tempArray[index] = array[right];
                        right++;
                    }

                    index++;
                }

                for (var i = left; i <= middleIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = right; i <= highIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = 0; i < tempArray.Length; i++)
                {
                    array[lowIndex + i] = tempArray[i];
                }
            }
        }
        public static List<byte> MergeSort(this List<byte> array)
        {
            return MergeSort(array, 0, array.Count - 1);
        }

        private static List<short> MergeSort(this List<short> array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                array.MergeSort(lowIndex, middleIndex);
                array.MergeSort(middleIndex + 1, highIndex);
                Merge(lowIndex, middleIndex, highIndex);
            }
            return array;
            void Merge(int lowIndex, int middleIndex, int highIndex)
            {
                var left = lowIndex;
                var right = middleIndex + 1;
                var tempArray = new short[highIndex - lowIndex + 1];
                var index = 0;

                while ((left <= middleIndex) && (right <= highIndex))
                {
                    if (array[left] < array[right])
                    {
                        tempArray[index] = array[left];
                        left++;
                    }
                    else
                    {
                        tempArray[index] = array[right];
                        right++;
                    }

                    index++;
                }

                for (var i = left; i <= middleIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = right; i <= highIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = 0; i < tempArray.Length; i++)
                {
                    array[lowIndex + i] = tempArray[i];
                }
            }
        }
        public static List<short> MergeSort(this List<short> array)
        {
            return MergeSort(array, 0, array.Count - 1);
        }

        private static List<int> MergeSort(this List<int> array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                array.MergeSort(lowIndex, middleIndex);
                array.MergeSort(middleIndex + 1, highIndex);
                Merge(lowIndex, middleIndex, highIndex);
            }
            return array;
            void Merge(int lowIndex, int middleIndex, int highIndex)
            {
                var left = lowIndex;
                var right = middleIndex + 1;
                var tempArray = new int[highIndex - lowIndex + 1];
                var index = 0;

                while ((left <= middleIndex) && (right <= highIndex))
                {
                    if (array[left] < array[right])
                    {
                        tempArray[index] = array[left];
                        left++;
                    }
                    else
                    {
                        tempArray[index] = array[right];
                        right++;
                    }

                    index++;
                }

                for (var i = left; i <= middleIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = right; i <= highIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = 0; i < tempArray.Length; i++)
                {
                    array[lowIndex + i] = tempArray[i];
                }
            }
        }
        public static List<int> MergeSort(this List<int> array)
        {
            return MergeSort(array, 0, array.Count - 1);
        }

        private static List<long> MergeSort(this List<long> array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                array.MergeSort(lowIndex, middleIndex);
                array.MergeSort(middleIndex + 1, highIndex);
                Merge(lowIndex, middleIndex, highIndex);
            }
            return array;
            void Merge(int lowIndex, int middleIndex, int highIndex)
            {
                var left = lowIndex;
                var right = middleIndex + 1;
                var tempArray = new long[highIndex - lowIndex + 1];
                var index = 0;

                while ((left <= middleIndex) && (right <= highIndex))
                {
                    if (array[left] < array[right])
                    {
                        tempArray[index] = array[left];
                        left++;
                    }
                    else
                    {
                        tempArray[index] = array[right];
                        right++;
                    }

                    index++;
                }

                for (var i = left; i <= middleIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = right; i <= highIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = 0; i < tempArray.Length; i++)
                {
                    array[lowIndex + i] = tempArray[i];
                }
            }
        }
        public static List<long> MergeSort(this List<long> array)
        {
            return MergeSort(array, 0, array.Count - 1);
        }

        private static List<decimal> MergeSort(this List<decimal> array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                array.MergeSort(lowIndex, middleIndex);
                array.MergeSort(middleIndex + 1, highIndex);
                Merge(lowIndex, middleIndex, highIndex);
            }
            return array;
            void Merge(int lowIndex, int middleIndex, int highIndex)
            {
                var left = lowIndex;
                var right = middleIndex + 1;
                var tempArray = new decimal[highIndex - lowIndex + 1];
                var index = 0;

                while ((left <= middleIndex) && (right <= highIndex))
                {
                    if (array[left] < array[right])
                    {
                        tempArray[index] = array[left];
                        left++;
                    }
                    else
                    {
                        tempArray[index] = array[right];
                        right++;
                    }

                    index++;
                }

                for (var i = left; i <= middleIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = right; i <= highIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = 0; i < tempArray.Length; i++)
                {
                    array[lowIndex + i] = tempArray[i];
                }
            }
        }
        public static List<decimal> MergeSort(this List<decimal> array)
        {
            return MergeSort(array, 0, array.Count - 1);
        }

        private static List<float> MergeSort(this List<float> array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                array.MergeSort(lowIndex, middleIndex);
                array.MergeSort(middleIndex + 1, highIndex);
                Merge(lowIndex, middleIndex, highIndex);
            }
            return array;
            void Merge(int lowIndex, int middleIndex, int highIndex)
            {
                var left = lowIndex;
                var right = middleIndex + 1;
                var tempArray = new float[highIndex - lowIndex + 1];
                var index = 0;

                while ((left <= middleIndex) && (right <= highIndex))
                {
                    if (array[left] < array[right])
                    {
                        tempArray[index] = array[left];
                        left++;
                    }
                    else
                    {
                        tempArray[index] = array[right];
                        right++;
                    }

                    index++;
                }

                for (var i = left; i <= middleIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = right; i <= highIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = 0; i < tempArray.Length; i++)
                {
                    array[lowIndex + i] = tempArray[i];
                }
            }
        }
        public static List<float> MergeSort(this List<float> array)
        {
            return MergeSort(array, 0, array.Count - 1);
        }

        private static List<double> MergeSort(this List<double> array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                array.MergeSort(lowIndex, middleIndex);
                array.MergeSort(middleIndex + 1, highIndex);
                Merge(lowIndex, middleIndex, highIndex);
            }
            return array;
            void Merge(int lowIndex, int middleIndex, int highIndex)
            {
                var left = lowIndex;
                var right = middleIndex + 1;
                var tempArray = new double[highIndex - lowIndex + 1];
                var index = 0;

                while ((left <= middleIndex) && (right <= highIndex))
                {
                    if (array[left] < array[right])
                    {
                        tempArray[index] = array[left];
                        left++;
                    }
                    else
                    {
                        tempArray[index] = array[right];
                        right++;
                    }

                    index++;
                }

                for (var i = left; i <= middleIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = right; i <= highIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (var i = 0; i < tempArray.Length; i++)
                {
                    array[lowIndex + i] = tempArray[i];
                }
            }
        }
        public static List<double> MergeSort(this List<double> array)
        {
            return MergeSort(array, 0, array.Count - 1);
        }
    }
    public static class ArrayTreeSortExtention
    {
        private class TreeNode
        {
            public TreeNode(dynamic data)
            {
                Data = data;
            }

            public dynamic Data { get; set; }

            public TreeNode Left { get; set; }

            public TreeNode Right { get; set; }

            public void Insert(TreeNode node)
            {
                if (node.Data < Data)
                {
                    if (Left == null)
                    {
                        Left = node;
                    }
                    else
                    {
                        Left.Insert(node);
                    }
                }
                else
                {
                    if (Right == null)
                    {
                        Right = node;
                    }
                    else
                    {
                        Right.Insert(node);
                    }
                }
            }

            public int[] Transform(int op, List<int> elements = null)
            {
                if (elements == null)
                {
                    elements = new List<int>();
                }

                if (Left != null)
                {
                    Left.Transform(op, elements);
                }

                elements.Add(Data);

                if (Right != null)
                {
                    Right.Transform(op, elements);
                }

                return elements.ToArray();
            }
            public byte[] Transform(byte op, List<byte> elements = null)
            {
                if (elements == null)
                {
                    elements = new List<byte>();
                }

                if (Left != null)
                {
                    Left.Transform(op, elements);
                }

                elements.Add(Data);

                if (Right != null)
                {
                    Right.Transform(op, elements);
                }

                return elements.ToArray();
            }
            public short[] Transform(short op, List<short> elements = null)
            {
                if (elements == null)
                {
                    elements = new List<short>();
                }

                if (Left != null)
                {
                    Left.Transform(op, elements);
                }

                elements.Add(Data);

                if (Right != null)
                {
                    Right.Transform(op, elements);
                }

                return elements.ToArray();
            }
            public long[] Transform(long op, List<long> elements = null)
            {
                if (elements == null)
                {
                    elements = new List<long>();
                }

                if (Left != null)
                {
                    Left.Transform(op, elements);
                }

                elements.Add(Data);

                if (Right != null)
                {
                    Right.Transform(op, elements);
                }

                return elements.ToArray();
            }
            public decimal[] Transform(decimal op, List<decimal> elements = null)
            {
                if (elements == null)
                {
                    elements = new List<decimal>();
                }

                if (Left != null)
                {
                    Left.Transform(op, elements);
                }

                elements.Add(Data);

                if (Right != null)
                {
                    Right.Transform(op, elements);
                }

                return elements.ToArray();
            }
            public float[] Transform(float op, List<float> elements = null)
            {
                if (elements == null)
                {
                    elements = new List<float>();
                }

                if (Left != null)
                {
                    Left.Transform(op, elements);
                }

                elements.Add(Data);

                if (Right != null)
                {
                    Right.Transform(op, elements);
                }

                return elements.ToArray();
            }
            public double[] Transform(double op, List<double> elements = null)
            {
                if (elements == null)
                {
                    elements = new List<double>();
                }

                if (Left != null)
                {
                    Left.Transform(op, elements);
                }

                elements.Add(Data);

                if (Right != null)
                {
                    Right.Transform(op, elements);
                }

                return elements.ToArray();
            }

        }
        public static byte[] TreeSort(this byte[] array)
        {
            var treeNode = new TreeNode(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                treeNode.Insert(new TreeNode(array[i]));
            }
            byte op = 0;
            return treeNode.Transform(op);
        }
        public static short[] TreeSort(this short[] array)
        {           
            var treeNode = new TreeNode(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                treeNode.Insert(new TreeNode(array[i]));
            }
            short op = 0;
            return treeNode.Transform(op);
        }
        public static int[] TreeSort(this int[] array)
        {
            var treeNode = new TreeNode(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                treeNode.Insert(new TreeNode(array[i]));
            }
            int op = 0;
            return treeNode.Transform(op);
        }
        public static long[] TreeSort(this long[] array)
        {
            var treeNode = new TreeNode(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                treeNode.Insert(new TreeNode(array[i]));
            }
            long op = 0;
            return treeNode.Transform(op);
        }
        public static decimal[] TreeSort(this decimal[] array)
        {
            var treeNode = new TreeNode(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                treeNode.Insert(new TreeNode(array[i]));
            }
            decimal op = 0;
            return treeNode.Transform(op);
        }
        public static float[] TreeSort(this float[] array)
        {
            var treeNode = new TreeNode(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                treeNode.Insert(new TreeNode(array[i]));
            }
            float op = 0;
            return treeNode.Transform(op);
        }
        public static double[] TreeSort(this double[] array)
        {
            var treeNode = new TreeNode(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                treeNode.Insert(new TreeNode(array[i]));
            }
            double op = 0;
            return treeNode.Transform(op);
        }
    }
    public static class ListTreeSortExtention
    {
        private class TreeNode
        {
            public TreeNode(dynamic data)
            {
                Data = data;
            }

            public dynamic Data { get; set; }

            public TreeNode Left { get; set; }

            public TreeNode Right { get; set; }

            public void Insert(TreeNode node)
            {
                if (node.Data < Data)
                {
                    if (Left == null)
                    {
                        Left = node;
                    }
                    else
                    {
                        Left.Insert(node);
                    }
                }
                else
                {
                    if (Right == null)
                    {
                        Right = node;
                    }
                    else
                    {
                        Right.Insert(node);
                    }
                }
            }

            public List<int> Transform(int op, List<int> elements = null)
            {
                if (elements == null)
                {
                    elements = new List<int>();
                }

                if (Left != null)
                {
                    Left.Transform(op, elements);
                }

                elements.Add(Data);

                if (Right != null)
                {
                    Right.Transform(op, elements);
                }

                return elements;
            }
            public List<byte> Transform(byte op, List<byte> elements = null)
            {
                if (elements == null)
                {
                    elements = new List<byte>();
                }

                if (Left != null)
                {
                    Left.Transform(op, elements);
                }

                elements.Add(Data);

                if (Right != null)
                {
                    Right.Transform(op, elements);
                }

                return elements;
            }
            public List<short> Transform(short op, List<short> elements = null)
            {
                if (elements == null)
                {
                    elements = new List<short>();
                }

                if (Left != null)
                {
                    Left.Transform(op, elements);
                }

                elements.Add(Data);

                if (Right != null)
                {
                    Right.Transform(op, elements);
                }

                return elements;
            }
            public List<long> Transform(long op, List<long> elements = null)
            {
                if (elements == null)
                {
                    elements = new List<long>();
                }

                if (Left != null)
                {
                    Left.Transform(op, elements);
                }

                elements.Add(Data);

                if (Right != null)
                {
                    Right.Transform(op, elements);
                }

                return elements;
            }
            public List<decimal> Transform(decimal op, List<decimal> elements = null)
            {
                if (elements == null)
                {
                    elements = new List<decimal>();
                }

                if (Left != null)
                {
                    Left.Transform(op, elements);
                }

                elements.Add(Data);

                if (Right != null)
                {
                    Right.Transform(op, elements);
                }

                return elements;
            }
            public List<float> Transform(float op, List<float> elements = null)
            {
                if (elements == null)
                {
                    elements = new List<float>();
                }

                if (Left != null)
                {
                    Left.Transform(op, elements);
                }

                elements.Add(Data);

                if (Right != null)
                {
                    Right.Transform(op, elements);
                }

                return elements;
            }
            public List<double> Transform(double op, List<double> elements = null)
            {
                if (elements == null)
                {
                    elements = new List<double>();
                }

                if (Left != null)
                {
                    Left.Transform(op, elements);
                }

                elements.Add(Data);

                if (Right != null)
                {
                    Right.Transform(op, elements);
                }

                return elements;
            }

        }
        public static List<byte> TreeSort(this List<byte> array)
        {
            var treeNode = new TreeNode(array[0]);
            for (int i = 1; i < array.Count; i++)
            {
                treeNode.Insert(new TreeNode(array[i]));
            }
            byte op = 0;
            return treeNode.Transform(op);
        }
        public static List<short> TreeSort(this List<short> array)
        {
            var treeNode = new TreeNode(array[0]);
            for (int i = 1; i < array.Count; i++)
            {
                treeNode.Insert(new TreeNode(array[i]));
            }
            short op = 0;
            return treeNode.Transform(op);
        }
        public static List<int> TreeSort(this List<int> array)
        {
            var treeNode = new TreeNode(array[0]);
            for (int i = 1; i < array.Count; i++)
            {
                treeNode.Insert(new TreeNode(array[i]));
            }
            int op = 0;
            return treeNode.Transform(op);
        }
        public static List<long> TreeSort(this List<long> array)
        {
            var treeNode = new TreeNode(array[0]);
            for (int i = 1; i < array.Count; i++)
            {
                treeNode.Insert(new TreeNode(array[i]));
            }
            long op = 0;
            return treeNode.Transform(op);
        }
        public static List<decimal> TreeSort(this List<decimal> array)
        {
            var treeNode = new TreeNode(array[0]);
            for (int i = 1; i < array.Count; i++)
            {
                treeNode.Insert(new TreeNode(array[i]));
            }
            decimal op = 0;
            return treeNode.Transform(op);
        }
        public static List<float> TreeSort(this List<float> array)
        {
            var treeNode = new TreeNode(array[0]);
            for (int i = 1; i < array.Count; i++)
            {
                treeNode.Insert(new TreeNode(array[i]));
            }
            float op = 0;
            return treeNode.Transform(op);
        }
        public static List<double> TreeSort(this List<double> array)
        {
            var treeNode = new TreeNode(array[0]);
            for (int i = 1; i < array.Count; i++)
            {
                treeNode.Insert(new TreeNode(array[i]));
            }
            double op = 0;
            return treeNode.Transform(op);
        }
    }
    public static class ArrayBogoSortExtention
    {
        public static int[] BogoSort(this int[] array)
        {
            while (!IsSorted())
            {
                array = RandomPermutation();
            }

            return array;
            bool IsSorted()
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                        return false;
                }

                return true;
            }
            int[] RandomPermutation()
            {
                Random random = new Random();
                var n = array.Length;
                while (n > 1)
                {
                    n--;
                    var i = random.Next(n + 1);
                    var temp = array[i];
                    array[i] = array[n];
                    array[n] = temp;
                }

                return array;
            }
        }
    }
    public static class ArrayBubbleSortExtention
    {
        public static int[] BubbleSort(this int[] array)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
            return array;
            static void Swap(ref int e1, ref int e2)
            {
                var temp = e1;
                e1 = e2;
                e2 = temp;
            }
        }
    }
    public static class ArrayShakerSortExtention
    {
        public static int[] ShakerSort(this int[] array)
        {
            for (var i = 0; i < array.Length / 2; i++)
            {
                var swapFlag = false;
                for (var j = i; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        swapFlag = true;
                    }
                }

                for (var j = array.Length - 2 - i; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        Swap(ref array[j - 1], ref array[j]);
                        swapFlag = true;
                    }
                }

                if (!swapFlag)
                {
                    break;
                }
            }

            return array;

            static void Swap(ref int e1, ref int e2)
            {
                var temp = e1;
                e1 = e2;
                e2 = temp;
            }
        }
    }
    public static class ArrayStoogeSortExtention
    {
        private static int[] StoogeSort(int[] array, int startIndex, int endIndex)
        {
            if (array[startIndex] > array[endIndex])
            {
                Swap(ref array[startIndex], ref array[endIndex]);
            }

            if (endIndex - startIndex > 1)
            {
                var len = (endIndex - startIndex + 1) / 3;
                StoogeSort(array, startIndex, endIndex - len);
                StoogeSort(array, startIndex + len, endIndex);
                StoogeSort(array, startIndex, endIndex - len);
            }

            return array;
            static void Swap(ref int a, ref int b)
            {
                var t = a;
                a = b;
                b = t;
            }
        }
        public static int[] StoogeSort(this int[] array)
        {
            return StoogeSort(array, 0, array.Length - 1);
        }

    }
    public static class ArrayPancakeSortExtention
    {
        public static int[] PancakeSort(this int[] array)
        {
            for (var subArrayLength = array.Length - 1; subArrayLength >= 0; subArrayLength--)
            {
                var indexOfMax = IndexOfMax(subArrayLength);
                if (indexOfMax != subArrayLength)
                {
                    Flip(indexOfMax);
                    Flip(subArrayLength);
                }
            }
            return array;
            int IndexOfMax(int n)
            {
                int result = 0;
                for (var i = 1; i <= n; ++i)
                {
                    if (array[i] > array[result])
                    {
                        result = i;
                    }
                }

                return result;
            }
            void Flip(int end)
            {
                for (var start = 0; start < end; start++, end--)
                {
                    var temp = array[start];
                    array[start] = array[end];
                    array[end] = temp;
                }
            }
        }
    }
    public static class ArrayShellSortExtention
    {
        static int[] ShellSort(this int[] array)
        {
            //расстояние между элементами, которые сравниваются
            var d = array.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (array[j - d] > array[j]))
                    {
                        Swap(ref array[j], ref array[j - d]);
                        j = j - d;
                    }
                }

                d = d / 2;
            }

            return array;
            static void Swap(ref int a, ref int b)
            {
                var t = a;
                a = b;
                b = t;
            }
        }
    }
    public static class ArraySelectionSortExtention
    {
        public static int[] SelectionSort(this int[] array, int currentIndex = 0)
        {
            if (currentIndex == array.Length)
                return array;

            var index = IndexOfMin(currentIndex);
            if (index != currentIndex)
            {
                Swap(ref array[index], ref array[currentIndex]);
            }

            return SelectionSort(array, currentIndex + 1);
            int IndexOfMin(int n)
            {
                int result = n;
                for (var i = n; i < array.Length; ++i)
                {
                    if (array[i] < array[result])
                    {
                        result = i;
                    }
                }

                return result;
            }
            void Swap(ref int x, ref int y)
            {
                var t = x;
                x = y;
                y = t;
            }
        }
    }
    public static class ArrayGnomeSortExtention
    {
        public static int[] GnomeSort(this int[] unsortedArray)
        {
            var index = 1;
            var nextIndex = index + 1;

            while (index < unsortedArray.Length)
            {
                if (unsortedArray[index - 1] < unsortedArray[index])
                {
                    index = nextIndex;
                    nextIndex++;
                }
                else
                {
                    Swap(ref unsortedArray[index - 1], ref unsortedArray[index]);
                    index--;
                    if (index == 0)
                    {
                        index = nextIndex;
                        nextIndex++;
                    }
                }
            }

            return unsortedArray;
            void Swap(ref int item1, ref int item2)
            {
                var temp = item1;
                item1 = item2;
                item2 = temp;
            }
        }
    }
    public static class ArrayCombSortExtention
    {
        public static int[] CombSort(this int[] array)
        {
            var arrayLength = array.Length;
            var currentStep = arrayLength - 1;

            while (currentStep > 1)
            {
                for (int i = 0; i + currentStep < array.Length; i++)
                {
                    if (array[i] > array[i + currentStep])
                    {
                        Swap(ref array[i], ref array[i + currentStep]);
                    }
                }

                currentStep = GetNextStep(currentStep);
            }
            for (var i = 1; i < arrayLength; i++)
            {
                var swapFlag = false;
                for (var j = 0; j < arrayLength - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        swapFlag = true;
                    }
                }
                if (!swapFlag)
                {
                    break;
                }
            }

            return array;
            void Swap(ref int value1, ref int value2)
            {
                var temp = value1;
                value1 = value2;
                value2 = temp;
            }
            int GetNextStep(int s)
            {
                s = s * 1000 / 1247;
                return s > 1 ? s : 1;
            }
        }
    }
    public static class ArrayBasicCountingSortExtention
    {
        public static byte[] CountingSort(this byte[] array)
        {
            var min = array[0];
            var max = array[0];
            foreach (var element in array)
            {
                if (element > max)
                {
                    max = element;
                }
                else if (element < min)
                {
                    min = element;
                }
            }

            dynamic correctionFactor = min != 0 ? -min : 0;
            max += correctionFactor;

            var count = new int[max + 1];
            for (var i = 0; i < array.Length; i++)
            {
                count[array[i] + correctionFactor]++;
            }

            var index = 0;
            for (var i = 0; i < count.Length; i++)
            {
                for (var j = 0; j < count[i]; j++)
                {
                    array[index] = i - correctionFactor;
                    index++;
                }
            }

            return array;
        }
        public static short[] CountingSort(this short[] array)
        {
            var min = array[0];
            var max = array[0];
            foreach (var element in array)
            {
                if (element > max)
                {
                    max = element;
                }
                else if (element < min)
                {
                    min = element;
                }
            }

            dynamic correctionFactor = min != 0 ? -min : 0;
            max += correctionFactor;

            var count = new int[max + 1];
            for (var i = 0; i < array.Length; i++)
            {
                count[array[i] + correctionFactor]++;
            }

            var index = 0;
            for (var i = 0; i < count.Length; i++)
            {
                for (var j = 0; j < count[i]; j++)
                {
                    array[index] = i - correctionFactor;
                    index++;
                }
            }

            return array;
        }
        public static int[] CountingSort(this int[] array)
        {
            var min = array[0];
            var max = array[0];
            foreach (int element in array)
            {
                if (element > max)
                {
                    max = element;
                }
                else if (element < min)
                {
                    min = element;
                }
            }

            var correctionFactor = min != 0 ? -min : 0;
            max += correctionFactor;

            var count = new int[max + 1];
            for (var i = 0; i < array.Length; i++)
            {
                count[array[i] + correctionFactor]++;
            }

            var index = 0;
            for (var i = 0; i < count.Length; i++)
            {
                for (var j = 0; j < count[i]; j++)
                {
                    array[index] = i - correctionFactor;
                    index++;
                }
            }

            return array;
        }
        public static long[] CountingSort(this long[] array)
        {
            var min = array[0];
            var max = array[0];
            foreach (var element in array)
            {
                if (element > max)
                {
                    max = element;
                }
                else if (element < min)
                {
                    min = element;
                }
            }

            dynamic correctionFactor = min != 0 ? -min : 0;
            max += correctionFactor;

            var count = new int[max + 1];
            for (var i = 0; i < array.Length; i++)
            {
                count[array[i] + correctionFactor]++;
            }

            var index = 0;
            for (var i = 0; i < count.Length; i++)
            {
                for (var j = 0; j < count[i]; j++)
                {
                    array[index] = i - correctionFactor;
                    index++;
                }
            }

            return array;
        }
    }
    public static class ArrayTools
    {
        public static bool IsSortedAscending<TSource>(this IList<TSource> dataSource) where TSource : IComparable
        {
            for (var index = 0; index < dataSource.Count() - 1; index++)
            {
                if (dataSource[index].CompareTo(dataSource[index + 1]) > 0)
                {
                    return false;
                }
            }

            return true;
        }
        static int[] GetRandomArray(this int[] array, int minValue, int maxValue)
        {
            var r = new Random();
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(minValue, maxValue);
            }

            return array;
        }

    }
}
