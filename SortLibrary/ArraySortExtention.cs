using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;

namespace SortLibrary
{
    public static class ArrayQuickSortExtention
    {
        private static void QuickSort<T>(this T[] array, int minIndex, int maxIndex) where T : IComparable<T>
        {
            if (minIndex >= maxIndex)
            {
                return;
            }
            var pivotIndex = Partition(minIndex, maxIndex);
            array.QuickSort(minIndex, pivotIndex - 1);
            array.QuickSort(pivotIndex + 1, maxIndex);
            static void Swap(ref T x, ref T y)
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
                    if (array[i].CompareTo(array[maxIndex]) < 0)
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
        public static void QuickSort<T>(this T[] array) where T : IComparable<T>
        {
            array.QuickSort(0, array.Length - 1);
        }
    }
    public static class ListQuickSortExtention
    {
        private static void QuickSort<T>(this List<T> array, int minIndex, int maxIndex) where T : IComparable<T>
        {
            if (minIndex >= maxIndex)
            {
                return;
            }
            var pivotIndex = Partition(minIndex, maxIndex);
            array.QuickSort(minIndex, pivotIndex - 1);
            array.QuickSort(pivotIndex + 1, maxIndex);
            static void Swap(ref T x, ref T y)
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
                    if (array[i].CompareTo(array[maxIndex]) < 0)
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
        public static void QuickSort<T>(this List<T> array) where T : IComparable<T>
        {
            array.QuickSort(0, array.Count - 1);
        }             
    }

    public static class ArrayInsertionSortExtention
    {
        public static void InsertionSort<T>(this T[] array) where T : IComparable<T>
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1].CompareTo(key) > 0))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }
                array[j] = key;
            }

            static void Swap(ref T e1, ref T e2)
            {
                var temp = e1;
                e1 = e2;
                e2 = temp;
            }
        }
    }
    public static class ListInsertionSortExtention
    {
        public static void InsertionSort<T>(this List<T> array) where T : IComparable<T>
        {
            for (var i = 1; i < array.Count; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1].CompareTo(key) > 0))
                {
                    Swap(ref array.ToArray()[j - 1], ref array.ToArray()[j]);
                    j--;
                }
                array[j] = key;
            }

            static void Swap(ref T e1, ref T e2)
            {
                var temp = e1;
                e1 = e2;
                e2 = temp;
            }
        }
    }

    public static class ArrayMergeSortExtention
    {
        private static T[] MergeSort<T>(this T[] array, int lowIndex, int highIndex) where T : IComparable<T>
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
                var tempArray = new T[highIndex - lowIndex + 1];
                var index = 0;

                while ((left <= middleIndex) && (right <= highIndex))
                {
                    if (array[left].CompareTo(array[right]) < 0)
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
        public static T[] MergeSort<T>(this T[] array) where T : IComparable<T>
        {
            return MergeSort(array, 0, array.Length - 1);
        }
    }
    public static class ListMergeSortextention
    {
        private static void MergeSort<T>(this List<T> array, int lowIndex, int highIndex) where T : IComparable<T>
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                array.MergeSort(lowIndex, middleIndex);
                array.MergeSort(middleIndex + 1, highIndex);
                Merge(lowIndex, middleIndex, highIndex);
            }

            void Merge(int lowIndex, int middleIndex, int highIndex)
            {
                var left = lowIndex;
                var right = middleIndex + 1;
                var tempArray = new T[highIndex - lowIndex + 1];
                var index = 0;

                while ((left <= middleIndex) && (right <= highIndex))
                {
                    if (array[left].CompareTo(array[right]) < 0)
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
        public static void MergeSort<T>(this List<T> array) where T : IComparable<T>
        {
            MergeSort(array, 0, array.Count - 1);
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

            public void Transform<T>(List<T> elements = null) where T : IComparable<T>
            {
                if (elements == null)
                {
                    elements = new List<T>();
                }

                if (Left != null)
                {
                    Left.Transform(elements);
                }

                elements.Add(Data);

                if (Right != null)
                {
                    Right.Transform(elements);
                }

                elements.ToArray();
            }
        }
        public static void TreeSort<T>(this T[] array) where T : IComparable<T>
        {
            var treeNode = new TreeNode(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                treeNode.Insert(new TreeNode(array[i]));
            }
            treeNode.Transform<T>();
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

            public List<T> Transform<T>(List<T> elements = null) where T : IComparable<T>
            {
                if (elements == null)
                {
                    elements = new List<T>();
                }

                if (Left != null)
                {
                    Left.Transform(elements);
                }

                elements.Add(Data);

                if (Right != null)
                {
                    Right.Transform(elements);
                }

                return elements;
            }
        }
        public static void TreeSort<T>(this List<T> array) where T : IComparable<T>
        {
            var treeNode = new TreeNode(array[0]);
            for (int i = 1; i < array.Count; i++)
            {
                treeNode.Insert(new TreeNode(array[i]));
            }
            treeNode.Transform<T>();
        }
    }

    public static class ArrayBogoSortExtention
    {
        public static void BogoSort<T>(this T[] array) where T : IComparable<T>
        {
            while (!IsSorted())
            {
                array = RandomPermutation(array);
            }
            bool IsSorted()
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                        return false;
                }

                return true;
            }
            T[] RandomPermutation(T[] arr)
            {
                Random random = new Random();
                var n = arr.Length;
                while (n > 1)
                {
                    n--;
                    var i = random.Next(n + 1);
                    var temp = arr[i];
                    arr[i] = arr[n];
                    arr[n] = temp;
                }
                return arr;
            }
        }
    }
    public static class ListBogoSortExtention
    {
        public static void BogoSort<T>(this List<T> array) where T : IComparable<T>
        {
            while (!IsSorted())
            {
                array = RandomPermutation(array);
            }
            bool IsSorted()
            {
                for (int i = 0; i < array.Count - 1; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                        return false;
                }

                return true;
            }
            List<T> RandomPermutation(List<T> arr)
            {
                Random random = new Random();
                var n = arr.Count;
                while (n > 1)
                {
                    n--;
                    var i = random.Next(n + 1);
                    var temp = arr[i];
                    arr[i] = arr[n];
                    arr[n] = temp;
                }
                return arr;
            }
        }
    }

    public static class ArrayBubbleSortExtention
    {
        public static void BubbleSort<T>(this T[] array) where T : IComparable<T>
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
            static void Swap(ref T e1, ref T e2)
            {
                var temp = e1;
                e1 = e2;
                e2 = temp;
            }
        }
    }
    public static class ListBubbleSortExtention
    {
        public static void BubbleSort<T>(this List<T> array) where T : IComparable<T>
        {
            var len = array.Count;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }
            void Swap(IList<T> list, int aInd, int bInd)
            {
                T value = list[aInd];
                list[aInd] = list[bInd];
                list[bInd] = value;
            }
        }
    }

    public static class ArrayShakerSortExtention
    {
        public static void ShakerSort<T>(this T[] array) where T : IComparable<T>
        {
            for (var i = 0; i < array.Length / 2; i++)
            {
                var swapFlag = false;
                for (var j = i; j < array.Length - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        swapFlag = true;
                    }
                }

                for (var j = array.Length - 2 - i; j > i; j--)
                {
                    if (array[j - 1].CompareTo(array[j]) > 0)
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

            static void Swap(ref T e1, ref T e2)
            {
                var temp = e1;
                e1 = e2;
                e2 = temp;
            }
        }
    }
    public static class ListShakerSortExtention
    {
        public static void ShakerSort<T>(this List<T> array) where T : IComparable<T>
        {
            for (var i = 0; i < array.Count / 2; i++)
            {
                var swapFlag = false;
                for (var j = i; j < array.Count - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        Swap(array, j, j + 1);
                        swapFlag = true;
                    }
                }

                for (var j = array.Count - 2 - i; j > i; j--)
                {
                    if (array[j - 1].CompareTo(array[j]) > 0)
                    {
                        Swap(array, j - 1, j);
                        swapFlag = true;
                    }
                }

                if (!swapFlag)
                {
                    break;
                }
            }

            void Swap(IList<T> list, int aInd, int bInd)
            {
                T value = list[aInd];
                list[aInd] = list[bInd];
                list[bInd] = value;
            }
        }
    }

    public static class ArrayStoogeSortExtention
    {
        private static void StoogeSort<T>(this T[] array, int startIndex, int endIndex) where T : IComparable<T>
        {
            if (array[startIndex].CompareTo(array[endIndex]) > 0)
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

            static void Swap(ref T a, ref T b)
            {
                var t = a;
                a = b;
                b = t;
            }
        }
        public static void StoogeSort<T>(this T[] array) where T : IComparable<T>
        {
            StoogeSort(array, 0, array.Length - 1);
        }

    }
    public static class ListStoogeSortExtention
    {
        private static void StoogeSort<T>(this List<T> array, int startIndex, int endIndex) where T : IComparable<T>
        {
            if (array[startIndex].CompareTo(array[endIndex]) > 0)
            {
                Swap(array,startIndex, endIndex);
            }

            if (endIndex - startIndex > 1)
            {
                var len = (endIndex - startIndex + 1) / 3;
                StoogeSort(array, startIndex, endIndex - len);
                StoogeSort(array, startIndex + len, endIndex);
                StoogeSort(array, startIndex, endIndex - len);
            }

            void Swap(IList<T> list, int aInd, int bInd)
            {
                T value = list[aInd];
                list[aInd] = list[bInd];
                list[bInd] = value;
            }
        }
        public static void StoogeSort<T>(this List<T> array) where T : IComparable<T>
        {
            StoogeSort(array, 0, array.Count - 1);
        }

    }

    public static class ArrayPancakeSortExtention
    {
        public static void PancakeSort<T>(this T[] array) where T : IComparable<T>
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
            int IndexOfMax(int n)
            {
                int result = 0;
                for (var i = 1; i <= n; ++i)
                {
                    if (array[i].CompareTo(array[result]) > 0)
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
    public static class ListPancakeSortExtention
    {
        public static void PancakeSort<T>(this List<T> array) where T : IComparable<T>
        {
            for (var subArrayLength = array.Count - 1; subArrayLength >= 0; subArrayLength--)
            {
                var indexOfMax = IndexOfMax(subArrayLength);
                if (indexOfMax != subArrayLength)
                {
                    Flip(indexOfMax);
                    Flip(subArrayLength);
                }
            }
            int IndexOfMax(int n)
            {
                int result = 0;
                for (var i = 1; i <= n; ++i)
                {
                    if (array[i].CompareTo(array[result]) > 0)
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
        static void ShellSort<T>(this T[] array) where T : IComparable<T>
        {
            var d = array.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (array[j - d].CompareTo(array[j]) > 0))
                    {
                        Swap(ref array[j], ref array[j - d]);
                        j = j - d;
                    }
                }

                d = d / 2;
            }

            static void Swap(ref T a, ref T b)
            {
                var t = a;
                a = b;
                b = t;
            }
        }
    }
    public static class ListShellSortExtention
    {
        static void ShellSort<T>(this List<T> array) where T : IComparable<T>
        {
            var d = array.Count / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Count; i++)
                {
                    var j = i;
                    while ((j >= d) && (array[j - d].CompareTo(array[j]) > 0))
                    {
                        Swap(array, j, j - d);
                        j = j - d;
                    }
                }

                d = d / 2;
            }

            void Swap(IList<T> list, int aInd, int bInd)
            {
                T value = list[aInd];
                list[aInd] = list[bInd];
                list[bInd] = value;
            }
        }
    }

    public static class ArraySelectionSortExtention
    {
        public static void SelectionSort<T>(this T[] array, int currentIndex = 0) where T : IComparable<T>
        {
            if (currentIndex == array.Length)
                return;

            var index = IndexOfMin(currentIndex);
            if (index != currentIndex)
            {
                Swap(array,index, currentIndex);
            }

            SelectionSort(array, currentIndex + 1);
            int IndexOfMin(int n)
            {
                int result = n;
                for (var i = n; i < array.Length; ++i)
                {
                    if (array[i].CompareTo(array[result]) < 0)
                    {
                        result = i;
                    }
                }

                return result;
            }
            void Swap(T[] list, int aInd, int bInd)
            {
                T value = list[aInd];
                list[aInd] = list[bInd];
                list[bInd] = value;
            }
        }
    }
    public static class ListSelectionSortExtention
    {
        public static void SelectionSort<T>(this List<T> array, int currentIndex = 0) where T : IComparable<T>
        {
            if (currentIndex == array.Count)
                return;

            var index = IndexOfMin(currentIndex);
            if (index != currentIndex)
            {
                Swap(array, index, currentIndex);
            }

            SelectionSort(array, currentIndex + 1);
            int IndexOfMin(int n)
            {
                int result = n;
                for (var i = n; i < array.Count; ++i)
                {
                    if (array[i].CompareTo(array[result]) < 0)
                    {
                        result = i;
                    }
                }

                return result;
            }
            void Swap(IList<T> list, int aInd, int bInd)
            {
                T value = list[aInd];
                list[aInd] = list[bInd];
                list[bInd] = value;
            }
        }
    }

    public static class ArrayGnomeSortExtention
    {
        public static void GnomeSort<T>(this T[] unsortedArray) where T : IComparable<T>
        {
            var index = 1;
            var nextIndex = index + 1;

            while (index < unsortedArray.Length)
            {
                if (unsortedArray[index - 1].CompareTo(unsortedArray[index]) < 0)
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
            void Swap(ref T item1, ref T item2)
            {
                var temp = item1;
                item1 = item2;
                item2 = temp;
            }
        }
    }
    public static class ListGnomeSortExtention
    {
        public static void GnomeSort<T>(this List<T> unsortedArray) where T : IComparable<T>
        {
            var index = 1;
            var nextIndex = index + 1;

            while (index < unsortedArray.Count)
            {
                if (unsortedArray[index - 1].CompareTo(unsortedArray[index]) < 0)
                {
                    index = nextIndex;
                    nextIndex++;
                }
                else
                {
                    Swap(unsortedArray,index - 1, index);
                    index--;
                    if (index == 0)
                    {
                        index = nextIndex;
                        nextIndex++;
                    }
                }
            }
            void Swap(IList<T> list, int aInd, int bInd)
            {
                T value = list[aInd];
                list[aInd] = list[bInd];
                list[bInd] = value;
            }
        }
    }

    public static class ArrayCombSortExtention
    {
        public static void CombSort<T>(this T[] array) where T : IComparable<T>
        {
            var arrayLength = array.Length;
            var currentStep = arrayLength - 1;

            while (currentStep > 1)
            {
                for (int i = 0; i + currentStep < array.Length; i++)
                {
                    if (array[i].CompareTo(array[i + currentStep]) > 0)
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
                    if (array[j].CompareTo(array[j + 1]) > 0)
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

            void Swap(ref T value1, ref T value2)
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
    public static class ListCombSortExtention
    {
        public static void CombSort<T>(this List<T> array) where T : IComparable<T>
        {
            var arrayLength = array.Count;
            var currentStep = arrayLength - 1;

            while (currentStep > 1)
            {
                for (int i = 0; i + currentStep < array.Count; i++)
                {
                    if (array[i].CompareTo(array[i + currentStep]) > 0)
                    {
                        Swap(array,i, i + currentStep);
                    }
                }

                currentStep = GetNextStep(currentStep);
            }
            for (var i = 1; i < arrayLength; i++)
            {
                var swapFlag = false;
                for (var j = 0; j < arrayLength - i; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        Swap(array,j, j + 1);
                        swapFlag = true;
                    }
                }
                if (!swapFlag)
                {
                    break;
                }
            }

            void Swap(IList<T> list, int aInd, int bInd)
            {
                T value = list[aInd];
                list[aInd] = list[bInd];
                list[bInd] = value;
            }
            int GetNextStep(int s)
            {
                s = s * 1000 / 1247;
                return s > 1 ? s : 1;
            }
        }
    }

    public static class ArrayTimSortExtention
    {
        public static void TimSort<T>(this T[] array) where T : IComparable<T>
        {
            TimSortClass<T>.sort(array);
        }
    }

    public class TimSortClass<T> where T :IComparable<T>
    {


        private const int MIN_MERGE = 32;

        private T[] a;



        private const int MIN_GALLOP = 7;

        private int minGallop = MIN_GALLOP;

        private const int INITIAL_TMP_STORAGE_LENGTH = 256;

        private T[] tmp;


        private int stackSize = 0;
        private int[] runBase;
        private int[] runLen;

        private TimSortClass(T[] a)
        {
            this.a = a;

            var len = a.Length;
            var newArray = (T[])new T[len < 2 * INITIAL_TMP_STORAGE_LENGTH ?
                                            len >> 1 : INITIAL_TMP_STORAGE_LENGTH];
            tmp = newArray;

            int stackLen = (len < 120 ? 5 :
                            len < 1542 ? 10 :
                            len < 119151 ? 19 : 40);
            runBase = new int[stackLen];
            runLen = new int[stackLen];

        }
        public static void sort(T[] a)
        {
            sort(a, 0, a.Length);
        }
        public static void sort(T[] a, int lo, int hi)
        {

            rangeCheck(a.Length, lo, hi);
            int nRemaining = hi - lo;
            if (nRemaining < 2)
                return;

            if (nRemaining < MIN_MERGE)
            {
                int initRunLen = countRunAndMakeAscending(a, lo, hi);
                binarySort(a, lo, hi, lo + initRunLen);
                return;
            }
            var ts = new TimSortClass<T>(a);
            int minRun = minRunLength(nRemaining);
            do
            {
                int runLen = countRunAndMakeAscending(a, lo, hi);

                if (runLen < minRun)
                {
                    int force = nRemaining <= minRun ? nRemaining : minRun;
                    binarySort(a, lo, lo + force, lo + runLen);
                    runLen = force;
                }

                ts.pushRun(lo, runLen);
                ts.mergeCollapse();

                lo += runLen;
                nRemaining -= runLen;
            } while (nRemaining != 0);

            Debug.Assert(lo == hi);
            ts.mergeForceCollapse();
            Debug.Assert(ts.stackSize == 1);
        }
        private static void binarySort(T[] a, int lo, int hi, int start)
        {
            Debug.Assert(lo <= start && start <= hi);
            if (start == lo)
                start++;
            for (; start < hi; start++)
            {
                var pivot = a[start];

                int left = lo;
                int right = start;
                Debug.Assert(left <= right);
                while (left < right)
                {
                    int mid = (left + right) >> 1;
                    if (pivot.CompareTo(a[mid]) < 0)
                        right = mid;
                    else
                        left = mid + 1;
                }
                Debug.Assert(left == right);
                int n = start - left;
                switch (n)
                {
                    case 2:
                        a[left + 2] = a[left + 1];
                        goto case 1;
                    case 1:
                        a[left + 1] = a[left];
                        break;
                    default:
                        Array.Copy(a, left, a, left + 1, n);
                        break;
                }
                a[left] = pivot;
            }
        }

        private static int countRunAndMakeAscending(T[] a, int lo, int hi)
        {
            Debug.Assert(lo < hi);
            int runHi = lo + 1;
            if (runHi == hi)
                return 1;

            if (a[runHi++].CompareTo(a[lo]) < 0)
            { 
                while (runHi < hi && a[runHi].CompareTo(a[runHi - 1]) < 0)
                    runHi++;
                reverseRange(a, lo, runHi);
            }
            else
            {                             
                while (runHi < hi && a[runHi].CompareTo(a[runHi - 1]) >= 0)
                    runHi++;
            }

            return runHi - lo;
        }

        private static void reverseRange(T[] a, int lo, int hi)
        {
            hi--;
            while (lo < hi)
            {
                var t = a[lo];
                a[lo++] = a[hi];
                a[hi--] = t;
            }
        }

        private static int minRunLength(int n)
        {
            Debug.Assert(n >= 0);
            int r = 0;    
            while (n >= MIN_MERGE)
            {
                r |= (n & 1);
                n >>= 1;
            }
            return n + r;
        }

        private void pushRun(int runBase, int runLen)
        {
            this.runBase[stackSize] = runBase;
            this.runLen[stackSize] = runLen;
            stackSize++;
        }

        private void mergeCollapse()
        {
            while (stackSize > 1)
            {
                int n = stackSize - 2;
                if (n > 0 && runLen[n - 1] <= runLen[n] + runLen[n + 1])
                {
                    if (runLen[n - 1] < runLen[n + 1])
                        n--;
                    mergeAt(n);
                }
                else if (runLen[n] <= runLen[n + 1])
                {
                    mergeAt(n);
                }
                else
                {
                    break;
                }
            }
        }

        private void mergeForceCollapse()
        {
            while (stackSize > 1)
            {
                int n = stackSize - 2;
                if (n > 0 && runLen[n - 1] < runLen[n + 1])
                    n--;
                mergeAt(n);
            }
        }

        private void mergeAt(int i)
        {
            Debug.Assert(stackSize >= 2);
            Debug.Assert(i >= 0);
            Debug.Assert(i == stackSize - 2 || i == stackSize - 3);

            int base1 = runBase[i];
            int len1 = runLen[i];
            int base2 = runBase[i + 1];
            int len2 = runLen[i + 1];
            Debug.Assert(len1 > 0 && len2 > 0);
            Debug.Assert(base1 + len1 == base2);

            runLen[i] = len1 + len2;
            if (i == stackSize - 3)
            {
                runBase[i + 1] = runBase[i + 2];
                runLen[i + 1] = runLen[i + 2];
            }
            stackSize--;
            int k = gallopRight(a[base2], a, base1, len1, 0);
            Debug.Assert(k >= 0);
            base1 += k;
            len1 -= k;
            if (len1 == 0)
                return;

            len2 = gallopLeft(a[base1 + len1 - 1], a, base2, len2, len2 - 1);
            Debug.Assert(len2 >= 0);
            if (len2 == 0)
                return;

            if (len1 <= len2)
                mergeLo(base1, len1, base2, len2);
            else
                mergeHi(base1, len1, base2, len2);
        }

        private static int gallopLeft(T key, T[] a, int basei, int len, int hint)
        {
            Debug.Assert(len > 0 && hint >= 0 && hint < len);
            int lastOfs = 0;
            int ofs = 1;
            if (key.CompareTo(a[basei + hint]) > 0)
            {
                int maxOfs = len - hint;
                while (ofs < maxOfs && key.CompareTo(a[basei + hint + ofs]) > 0)
                {
                    lastOfs = ofs;
                    ofs = (ofs << 1) + 1;
                    if (ofs <= 0)   
                        ofs = maxOfs;
                }
                if (ofs > maxOfs)
                    ofs = maxOfs;

                lastOfs += hint;
                ofs += hint;
            }
            else
            { 
                int maxOfs = hint + 1;
                while (ofs < maxOfs && key.CompareTo(a[basei + hint - ofs]) <= 0)
                {
                    lastOfs = ofs;
                    ofs = (ofs << 1) + 1;
                    if (ofs <= 0)  
                        ofs = maxOfs;
                }
                if (ofs > maxOfs)
                    ofs = maxOfs;

                int tmp = lastOfs;
                lastOfs = hint - ofs;
                ofs = hint - tmp;
            }
            Debug.Assert(-1 <= lastOfs && lastOfs < ofs && ofs <= len);

            lastOfs++;
            while (lastOfs < ofs)
            {              
                int m = lastOfs + ((ofs - lastOfs) >> 1);

                if (key.CompareTo(a[basei + m]) > 0)
                    lastOfs = m + 1;  
                else
                    ofs = m;  
            }
            Debug.Assert(lastOfs == ofs); 
            return ofs;
        }

        private static int gallopRight(T key, T[] a, int basei, int len,int hint)
        {
            Debug.Assert(len > 0 && hint >= 0 && hint < len);

            int ofs = 1;
            int lastOfs = 0;
            if (key.CompareTo(a[basei + hint]) < 0)
            {           
                int maxOfs = hint + 1;
                while (ofs < maxOfs && key.CompareTo(a[basei + hint - ofs]) < 0)
                {
                    lastOfs = ofs;
                    ofs = (ofs << 1) + 1;
                    if (ofs <= 0) 
                        ofs = maxOfs;
                }
                if (ofs > maxOfs)
                    ofs = maxOfs;

                int tmp = lastOfs;
                lastOfs = hint - ofs;
                ofs = hint - tmp;
            }
            else
            { 
                int maxOfs = len - hint;
                while (ofs < maxOfs && key.CompareTo(a[basei + hint + ofs]) >= 0)
                {
                    lastOfs = ofs;
                    ofs = (ofs << 1) + 1;
                    if (ofs <= 0) 
                        ofs = maxOfs;
                }
                if (ofs > maxOfs)
                    ofs = maxOfs;
            
                lastOfs += hint;
                ofs += hint;
            }
            Debug.Assert(-1 <= lastOfs && lastOfs < ofs && ofs <= len);

            lastOfs++;
            while (lastOfs < ofs)
            {              
                int m = lastOfs + ((ofs - lastOfs) >> 1);

                if (key.CompareTo(a[basei + m]) < 0)
                    ofs = m;        
                else
                    lastOfs = m + 1; 
            }
            Debug.Assert(lastOfs == ofs);
            return ofs;
        }

        private void mergeLo(int base1, int len1, int base2, int len2)
        {
            Debug.Assert(len1 > 0 && len2 > 0 && base1 + len1 == base2);
         
            var a = this.a; 
            var tmp = ensureCapacity(len1);
            Array.Copy(a, base1, tmp, 0, len1);

            int cursor1 = 0;       
            int cursor2 = base2;  
            int dest = base1;     

            a[dest++] = a[cursor2++];
            if (--len2 == 0)
            {
                Array.Copy(tmp, cursor1, a, dest, len1);
                return;
            }
            if (len1 == 1)
            {
                Array.Copy(a, cursor2, a, dest, len2);
                a[dest + len2] = tmp[cursor1];
                return;
            }

            int minGallop = this.minGallop;
        outer:
            while (true)
            {
                int count1 = 0; 
                int count2 = 0; 

                do
                {
                    Debug.Assert(len1 > 1 && len2 > 0);
                    if (a[cursor2].CompareTo(tmp[cursor1]) < 0)
                    {
                        a[dest++] = a[cursor2++];
                        count2++;
                        count1 = 0;
                        if (--len2 == 0)
                            goto outer;
                    }
                    else
                    {
                        a[dest++] = tmp[cursor1++];
                        count1++;
                        count2 = 0;
                        if (--len1 == 1)
                            goto outer;
                    }
                } while ((count1 | count2) < minGallop);

                do
                {
                    Debug.Assert(len1 > 1 && len2 > 0);
                    count1 = gallopRight(a[cursor2], tmp, cursor1, len1, 0);
                    if (count1 != 0)
                    {
                        Array.Copy(tmp, cursor1, a, dest, count1);
                        dest += count1;
                        cursor1 += count1;
                        len1 -= count1;
                        if (len1 <= 1) 
                            goto outer;
                    }
                    a[dest++] = a[cursor2++];
                    if (--len2 == 0)
                        goto outer;

                    count2 = gallopLeft(tmp[cursor1], a, cursor2, len2, 0);
                    if (count2 != 0)
                    {
                        Array.Copy(a, cursor2, a, dest, count2);
                        dest += count2;
                        cursor2 += count2;
                        len2 -= count2;
                        if (len2 == 0)
                            goto outer;
                    }
                    a[dest++] = tmp[cursor1++];
                    if (--len1 == 1)
                        goto outer;
                    minGallop--;
                } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);
                if (minGallop < 0)
                    minGallop = 0;
                minGallop += 2; 
            } 
            this.minGallop = minGallop < 1 ? 1 : minGallop; 

            if (len1 == 1)
            {
                Debug.Assert(len2 > 0);
                Array.Copy(a, cursor2, a, dest, len2);
                a[dest + len2] = tmp[cursor1];
            }
            else if (len1 == 0)
            {
                throw new ArgumentException(
                    "Comparison method violates its general contract!");
            }
            else
            {
                Debug.Assert(len2 == 0);
                Debug.Assert(len1 > 1);
                Array.Copy(tmp, cursor1, a, dest, len1);
            }
        }

        private void mergeHi(int base1, int len1, int base2, int len2)
        {
            Debug.Assert(len1 > 0 && len2 > 0 && base1 + len1 == base2);
            T[] a = this.a; 
            T[] tmp = ensureCapacity(len2);
            Array.Copy(a, base2, tmp, 0, len2);

            int cursor1 = base1 + len1 - 1;  
            int cursor2 = len2 - 1;          
            int dest = base2 + len2 - 1;    

            
            a[dest--] = a[cursor1--];
            if (--len1 == 0)
            {
                Array.Copy(tmp, 0, a, dest - (len2 - 1), len2);
                return;
            }
            if (len2 == 1)
            {
                dest -= len1;
                cursor1 -= len1;
                Array.Copy(a, cursor1 + 1, a, dest + 1, len1);
                a[dest] = tmp[cursor2];
                return;
            }  
            int minGallop = this.minGallop;   
        outer:
            while (true)
            {
                int count1 = 0; 
                int count2 = 0; 

                do
                {
                    Debug.Assert(len1 > 0 && len2 > 1);
                    if (tmp[cursor2].CompareTo(a[cursor1]) < 0)
                    {
                        a[dest--] = a[cursor1--];
                        count1++;
                        count2 = 0;
                        if (--len1 == 0)
                            goto outer;
                    }
                    else
                    {
                        a[dest--] = tmp[cursor2--];
                        count2++;
                        count1 = 0;
                        if (--len2 == 1)
                            goto outer;
                    }
                } while ((count1 | count2) < minGallop);

                do
                {
                    Debug.Assert(len1 > 0 && len2 > 1);
                    count1 = len1 - gallopRight(tmp[cursor2], a, base1, len1, len1 - 1);
                    if (count1 != 0)
                    {
                        dest -= count1;
                        cursor1 -= count1;
                        len1 -= count1;
                        Array.Copy(a, cursor1 + 1, a, dest + 1, count1);
                        if (len1 == 0)
                            goto outer;
                    }
                    a[dest--] = tmp[cursor2--];
                    if (--len2 == 1)
                        goto outer;

                    count2 = len2 - gallopLeft(a[cursor1], tmp, 0, len2, len2 - 1);
                    if (count2 != 0)
                    {
                        dest -= count2;
                        cursor2 -= count2;
                        len2 -= count2;
                        Array.Copy(tmp, cursor2 + 1, a, dest + 1, count2);
                        if (len2 <= 1)  // len2 == 1 || len2 == 0
                            goto outer;
                    }
                    a[dest--] = a[cursor1--];
                    if (--len1 == 0)
                        goto outer;
                    minGallop--;
                } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);
                if (minGallop < 0)
                    minGallop = 0;
                minGallop += 2;
            }  
            this.minGallop = minGallop < 1 ? 1 : minGallop;

            if (len2 == 1)
            {
                Debug.Assert(len1 > 0);
                dest -= len1;
                cursor1 -= len1;
                Array.Copy(a, cursor1 + 1, a, dest + 1, len1);
                a[dest] = tmp[cursor2];
            }
            else if (len2 == 0)
            {
                throw new ArgumentException(
                    "Comparison method violates its general contract!");
            }
            else
            {
                Debug.Assert(len1 == 0);
                Debug.Assert(len2 > 0);
                Array.Copy(tmp, 0, a, dest - (len2 - 1), len2);
            }
        }

        private T[] ensureCapacity(int minCapacity)
        {
            if (tmp.Length < minCapacity)
            {
                int newSize = minCapacity;
                newSize |= newSize >> 1;
                newSize |= newSize >> 2;
                newSize |= newSize >> 4;
                newSize |= newSize >> 8;
                newSize |= newSize >> 16;
                newSize++;

                if (newSize < 0)
                    newSize = minCapacity;
                else
                    newSize = Math.Min(newSize, a.Length >> 1);

                tmp = new T[newSize];
            }
            return tmp;
        }

        private static void rangeCheck(int arrayLen, int fromIndex, int toIndex)
        {
            if (fromIndex > toIndex)
                throw new ArgumentException("fromIndex(" + fromIndex +
                           ") > toIndex(" + toIndex + ")");
            if (fromIndex < 0)
                throw new ArgumentOutOfRangeException("fromIndex", fromIndex.ToString());
            if (toIndex > arrayLen)
                throw new ArgumentOutOfRangeException("toIndex", toIndex.ToString());
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
