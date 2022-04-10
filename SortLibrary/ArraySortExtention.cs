using System;
using System.Collections.Generic;
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
        public static void QuickSort<T>(this List<T> array) where T : IComparable<T>
        {
            array.Cloner(ArrayQuickSortExtention.QuickSort);
        }             
    }
    public static class IntQuickSortExtention
    {
        private static void QuickSort(this int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return;
            }
            var pivotIndex = Partition(minIndex, maxIndex);
            array.QuickSort(minIndex, pivotIndex - 1);
            array.QuickSort(pivotIndex + 1, maxIndex);
            void Swap(ref int x, ref int y)
            {
                var t = x;
                x = y;
                y = t;
            }
            int Partition(int nminIndex, int nmaxIndex)
            {
                var pivot = nminIndex - 1;
                for (var i = nminIndex; i < nmaxIndex; i++)
                {
                    if (array[i].CompareTo(array[nmaxIndex]) < 0)
                    {
                        pivot++;
                        Swap(ref array[pivot], ref array[i]);
                    }
                }

                pivot++;
                Swap(ref array[pivot], ref array[nmaxIndex]);
                return pivot;
            }
        }
        public static void IntQuickSort(this int[] array)
        {
            array.QuickSort(0, array.Length - 1);
        }
    }

    public static class ArrayInsertionSortExtention
    {
        public static void InsertionSort<T>(this T[] array) where T : IComparable<T>
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(key) > 0))
                {
                    array[j + 1] = array[j];
                    j -= 1;
                }
                array[j + 1] = key;
            }
        }
    }
    public static class ListInsertionSortExtention
    {
        public static void InsertionSort<T>(this List<T> array) where T : IComparable<T>
        {
            array.Cloner(ArrayInsertionSortExtention.InsertionSort);
        }
    }
    public static class IntInsertionSortExtention
    {
        public static void InsertionSort(this int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(key) > 0))
                {
                    array[j + 1] = array[j];
                    j -= 1;
                }
                array[j + 1] = key;
            }
        }
    }

    public static class ArrayMergeSortExtention
    {
        private static void MergeSort<T>(this T[] array, int lowIndex, int highIndex) where T : IComparable<T>
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
        public static void MergeSort<T>(this T[] array) where T : IComparable<T>
        {
            MergeSort(array, 0, array.Length - 1);
        }
    }
    public static class ListMergeSortextention
    {
        public static void MergeSort<T>(this List<T> array) where T : IComparable<T>
        {
            array.Cloner(ArrayMergeSortExtention.MergeSort);
        }
    }
    public static class IntMergeSortExtention
    {
        private static void MergeSort(this int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                array.MergeSort(lowIndex, middleIndex);
                array.MergeSort(middleIndex + 1, highIndex);
                Merge(lowIndex, middleIndex, highIndex);
            }
            void Merge(int nlowIndex, int middleIndex, int nhighIndex)
            {
                var left = nlowIndex;
                var right = middleIndex + 1;
                var tempArray = new int[highIndex - nlowIndex + 1];
                var index = 0;

                while ((left <= middleIndex) && (right <= nhighIndex))
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

                for (var i = right; i <= nhighIndex; i++)
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
        public static void IntMergeSort(this int[] array)
        {
            MergeSort(array, 0, array.Length - 1);
        }
    }

    public static class ArrayTreeSortExtention
    {
        static private int max = 0;
        private class tree<T> where T : IComparable<T>
        {
            public T value;
            public tree<T> left;
            public tree<T> right;
        }
        static private tree<T> add_to_tree<T>(tree<T> root, T new_value) where T : IComparable<T>
        {

            if (root == null)
            {
                root = new tree<T>();
                root.value = new_value;
                root.left = null;
                root.right = null;
                return root;
            }
            if (root.value.CompareTo(new_value) < 0)
            { root.right = add_to_tree(root.right, new_value); }
            else { root.left = add_to_tree(root.left, new_value); };
            return root;
        }

        static private void tree_to_array<T>(tree<T> root, T[] a) where T : IComparable<T>
        {
            if (root == null) return;
            tree_to_array(root.left, a);
            a[max++] = root.value;
            tree_to_array(root.right, a);
        }

        static public void TreeSort<T>(this T[] a) where T : IComparable<T>
        {
            tree<T> root = null;
            for (int i = 0; i < a.Length; i++)
            {
                root = add_to_tree(root, a[i]);
            }
            tree_to_array(root, a);
        }
    }
    public static class ListTreeSortExtention
    {       
        static public void TreeSort<T>(this List<T> a) where T : IComparable<T>
        {
            a.Cloner(ArrayTreeSortExtention.TreeSort);
        }
    }
    public static class IntTreeSortExtention
    {
        static private int max = 0;
        private class tree
        {
            public int value;
            public tree left;
            public tree right;
        }
        static private tree add_to_tree(tree root, int new_value)
        {

            if (root == null)
            {
                root = new tree();
                root.value = new_value;
                root.left = null;
                root.right = null;
                return root;
            }
            if (root.value.CompareTo(new_value) < 0)
            { root.right = add_to_tree(root.right, new_value); }
            else { root.left = add_to_tree(root.left, new_value); };
            return root;
        }

        static private void tree_to_array(tree root, int[] a)
        {
            if (root == null) return;
            tree_to_array(root.left, a);
            a[max++] = root.value;
            tree_to_array(root.right, a);
        }

        static public void TreeSort(this int[] a)
        {
            tree root = null;
            for (int i = 0; i < a.Length; i++)
            {
                root = add_to_tree(root, a[i]);
            }
            tree_to_array(root, a);
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
            array.Cloner(ArrayBogoSortExtention.BogoSort);
        }
    }
    public static class IntBogoSortExtention
    {
        public static void IntBogoSort(this int[] array)
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
            int[] RandomPermutation(int[] arr)
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
            array.Cloner(ArrayBubbleSortExtention.BubbleSort);
        }
    }
    public static class IntBubbleSortExtention
    {
        public static void IntBubbleSort(this int[] array)
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
            void Swap(ref int e1, ref int e2)
            {
                var temp = e1;
                e1 = e2;
                e2 = temp;
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
            array.Cloner(ArrayShakerSortExtention.ShakerSort);
        }
    }
    public static class IntShakerSortExtention
    {
        public static void IntShakerSort(this int[] array)
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

            void Swap(ref int e1, ref int e2)
            {
                var temp = e1;
                e1 = e2;
                e2 = temp;
            }
        }
    }

    public static class ArrayStoogeSortExtention
    {
        public static void StoogeSort<T>(this T[] array, int startIndex, int endIndex) where T : IComparable<T>
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
        public static void StoogeSort<T>(this List<T> array) where T : IComparable<T>
        {
            array.Cloner(ArrayStoogeSortExtention.StoogeSort);
        }
    }
    public static class IntStoogeSortExtention
    {
        public static void StoogeSort(this int[] array, int startIndex, int endIndex)
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

            void Swap(ref int a, ref int b)
            {
                var t = a;
                a = b;
                b = t;
            }
        }
        public static void IntStoogeSort(this int[] array)
        {
            StoogeSort(array, 0, array.Length - 1);
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
            array.Cloner(ArrayPancakeSortExtention.PancakeSort);
        }
    }
    public static class IntPancakeSortExtention
    {
        public static void IntPancakeSort(this int[] array)
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

    public static class ArrayShellSortExtention
    {
        public static void ShellSort<T>(this T[] array) where T : IComparable<T>
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
            array.Cloner(ArrayShellSortExtention.ShellSort);
        }
    }
    public static class IntShellSortExtention
    {
        public static void IntShellSort(this int[] array)
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

            void Swap(ref int a, ref int b)
            {
                var t = a;
                a = b;
                b = t;
            }
        }
    }

    public static class ArraySelectionSortExtention
    {
        internal static void SelectionSort<T>(this T[] array, int currentIndex = 0) where T : IComparable<T>
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
        public static void SelectionSort<T>(this T[] array) where T : IComparable<T>
        {
            array.SelectionSort();
        }
    }
    public static class ListSelectionSortExtention
    {
        public static void SelectionSort<T>(this List<T> array) where T : IComparable<T>
        {
            array.Cloner(ArraySelectionSortExtention.SelectionSort);
        }
    }
    public static class IntSelectionSortExtention
    {
        internal static void IntSelectionSort(this int[] array, int currentIndex = 0)
        {
            if (currentIndex == array.Length)
                return;

            var index = IndexOfMin(currentIndex);
            if (index != currentIndex)
            {
                Swap(array, index, currentIndex);
            }

            IntSelectionSort(array, currentIndex + 1);
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
            void Swap(int[] list, int aInd, int bInd)
            {
                int value = list[aInd];
                list[aInd] = list[bInd];
                list[bInd] = value;
            }
        }
        public static void IntSelectionSort(this int[] array)
        {
            array.SelectionSort();
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
            unsortedArray.Cloner(ArrayGnomeSortExtention.GnomeSort);
        }
    }
    public static class IntGnomeSortExtention
    {
        public static void IntGnomeSort(this int[] unsortedArray)
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
            array.Cloner(ArrayCombSortExtention.CombSort);
        }
    }
    public static class IntCombSortExtention
    {
        public static void IntCombSort(this int[] array)
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

    public static class ArrayTimSortExtention
    {
        public static void TimSort<T>(this T[] array) where T : IComparable<T>
        {
            TimSortClass<T>.sort(array);
        }
        internal class TimSortClass<T> where T : IComparable<T>
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

            private static int gallopRight(T key, T[] a, int basei, int len, int hint)
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
    }
    public static class ListTimSortExtention
    {
        public static void TimSort<T>(this List<T> array) where T : IComparable<T>
        {
            array.Cloner(ArrayTimSortExtention.TimSort);
        }
    }
    public static class IntTimSortExtention
    {
        public static void IntTimSort(this int[] array)
        {
            TimSortClass.sort(array);
        }
        internal class TimSortClass
        {


            private const int MIN_MERGE = 32;

            private int[] a;



            private const int MIN_GALLOP = 7;

            private int minGallop = MIN_GALLOP;

            private const int INITIAL_TMP_STORAGE_LENGTH = 256;

            private int[] tmp;


            private int stackSize = 0;
            private int[] runBase;
            private int[] runLen;

            private TimSortClass(int[] a)
            {
                this.a = a;

                var len = a.Length;
                var newArray = new int[len < 2 * INITIAL_TMP_STORAGE_LENGTH ?
                                                len >> 1 : INITIAL_TMP_STORAGE_LENGTH];
                tmp = newArray;

                int stackLen = (len < 120 ? 5 :
                                len < 1542 ? 10 :
                                len < 119151 ? 19 : 40);
                runBase = new int[stackLen];
                runLen = new int[stackLen];

            }
            public static void sort(int[] a)
            {
                sort(a, 0, a.Length);
            }
            public static void sort(int[] a, int lo, int hi)
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
                var ts = new TimSortClass(a);
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
            private static void binarySort(int[] a, int lo, int hi, int start)
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

            private static int countRunAndMakeAscending(int[] a, int lo, int hi)
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

            private static void reverseRange(int[] a, int lo, int hi)
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

            private static int gallopLeft(int key, int[] a, int basei, int len, int hint)
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

            private static int gallopRight(int key, int[] a, int basei, int len, int hint)
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
                int[] a = this.a;
                int[] tmp = ensureCapacity(len2);
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

            private int[] ensureCapacity(int minCapacity)
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

                    tmp = new int[newSize];
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
    }


    public static class ArrayHeapSortExtention
    {
        public class HeapSortClass<T> where T : IComparable<T>
        {
            public static void sort(T[] arr)
            {
                int n = arr.Length;

                for (int i = n / 2 - 1; i >= 0; i--)
                    heapify(arr, Operator<int, T>.Convert(n), Operator<int, T>.Convert(i));

                for (int i = n - 1; i >= 0; i--)
                {
                    T temp = arr[0];
                    arr[0] = arr[i];
                    arr[i] = temp;

                    heapify(arr,  Operator<int, T>.Convert(i), Operator<int, T>.Convert(0));
                }
            }

            static void heapify(T[] arr, T n, T i)
            {
                T largest = i;
                T l = Operator<long, T>.Convert(Operator<T, long>.Multiply(2, i) + 1); 
                T r = Operator<long, T>.Convert(Operator<T, long>.Multiply(2, i) + 2);

                if (l.CompareTo(n) < 0 && arr[Operator<T, long>.Convert(l)].CompareTo(arr[Operator<T, long>.Convert(largest)]) > 0)
                    largest = l;

                if (r.CompareTo(n) < 0 && arr[Operator<T, long>.Convert(r)].CompareTo(arr[Operator<T, long>.Convert(largest)]) > 0)
                    largest = r;

                if (Operator<T>.NotEqual(largest, i))
                {
                    T swap = arr[Operator<T, long>.Convert(i)];
                    arr[Operator<T, long>.Convert(i)] = arr[Operator<T, long>.Convert(largest)];
                    arr[Operator<T, long>.Convert(largest)] = swap;

                    heapify(arr, n, largest);
                }
            }
        }
        public static void HeapSort<T>(this T[] array) where T : IComparable<T>
        {
            HeapSortClass<T>.sort(array);
        }
    }
    public static class ListHeapSortExtention
    {
        public static void HeapSort<T>(this List<T> array) where T :IComparable<T>
        {
            array.Cloner(ArrayHeapSortExtention.HeapSort);
        }
    }
    public static class IntHeapSortExtention
    {
        public class IntHeapSortClass
        {
            public static void sort(int[] arr)
            {
                int n = arr.Length;

                for (int i = n / 2 - 1; i >= 0; i--)
                    heapify(arr, n, i);

                for (int i = n - 1; i >= 0; i--)
                {
                    int temp = arr[0];
                    arr[0] = arr[i];
                    arr[i] = temp;

                    heapify(arr, i, 0);
                }
            }

            static void heapify(int[] arr, int n, int i)
            {
                int largest = i;
                int l = 2 * i + 1; 
                int r = 2 * i + 2; 

                if (l < n && arr[l] > arr[largest])
                    largest = l;

                if (r < n && arr[r] > arr[largest])
                    largest = r;
                if (largest != i)
                {
                    int swap = arr[i];
                    arr[i] = arr[largest];
                    arr[largest] = swap;

                    heapify(arr, n, largest);
                }
            }
        }
        public static void IntHeapSort(this int[] array)
        {
            IntHeapSortClass.sort(array);
        }
    }


    public static class ArraySmoothSortExtention
    {
        class Smooth<T> where T : IComparable<T>
        {

            private static bool IsAscending(T A, T B)
            {
                return A.CompareTo(B) <= 0;
            }

            private static void UP(ref int IA, ref int IB, ref int temp)
            {
                temp = IA;
                IA += IB + 1;
                IB = temp;
            }

            private static void DOWN(ref int IA, ref int IB, ref int temp)
            {
                temp = IB;
                IB = IA - IB - 1;
                IA = temp;
            }

            private static int q, r, p, b, c, r1, b1, c1;
            private static T[] A;

            private static void Sift()
            {
                int r0, r2, temp = 0;
                T t;
                r0 = r1;
                t = A[r0];

                while (b1 >= 3)
                {
                    r2 = r1 - b1 + c1;

                    if (!IsAscending(A[r1 - 1], A[r2]))
                    {
                        r2 = r1 - 1;
                        DOWN(ref b1, ref c1, ref temp);
                    }

                    if (IsAscending(A[r2], t))
                    {
                        b1 = 1;
                    }
                    else
                    {
                        A[r1] = A[r2];
                        r1 = r2;
                        DOWN(ref b1, ref c1, ref temp);
                    }
                }

                if (Convert.ToBoolean(r1 - r0))
                    A[r1] = t;
            }

            private static void Trinkle()
            {
                int p1, r2, r3, r0, temp = 0;
                T t;
                p1 = p;
                b1 = b;
                c1 = c;
                r0 = r1;
                t = A[r0];

                while (p1 > 0)
                {
                    while ((p1 & 1) == 0)
                    {
                        p1 >>= 1;
                        UP(ref b1, ref c1, ref temp);
                    }

                    r3 = r1 - b1;

                    if ((p1 == 1) || IsAscending(A[r3], t))
                    {
                        p1 = 0;
                    }
                    else
                    {
                        --p1;

                        if (b1 == 1)
                        {
                            A[r1] = A[r3];
                            r1 = r3;
                        }
                        else
                        {
                            if (b1 >= 3)
                            {
                                r2 = r1 - b1 + c1;

                                if (!IsAscending(A[r1 - 1], A[r2]))
                                {
                                    r2 = r1 - 1;
                                    DOWN(ref b1, ref c1, ref temp);
                                    p1 <<= 1;
                                }
                                if (IsAscending(A[r2], A[r3]))
                                {
                                    A[r1] = A[r3]; r1 = r3;
                                }
                                else
                                {
                                    A[r1] = A[r2];
                                    r1 = r2;
                                    DOWN(ref b1, ref c1, ref temp);
                                    p1 = 0;
                                }
                            }
                        }
                    }
                }

                if (Convert.ToBoolean(r0 - r1))
                    A[r1] = t;

                Sift();
            }

            private static void SemiTrinkle()
            {
                T T;
                r1 = r - c;

                if (!IsAscending(A[r1], A[r]))
                {
                    T = A[r];
                    A[r] = A[r1];
                    A[r1] = T;
                    Trinkle();
                }
            }

            public static void SmoothSort(T[] Aarg)
            {
                int N = Aarg.Length;
                int temp = 0;
                A = Aarg;
                q = 1;
                r = 0;
                p = 1;
                b = 1;
                c = 1;

                while (q < N)
                {
                    r1 = r;
                    if ((p & 7) == 3)
                    {
                        b1 = b;
                        c1 = c;
                        Sift();
                        p = (p + 1) >> 2;
                        UP(ref b, ref c, ref temp);
                        UP(ref b, ref c, ref temp);
                    }
                    else if ((p & 3) == 1)
                    {
                        if (q + c < N)
                        {
                            b1 = b;
                            c1 = c;
                            Sift();
                        }
                        else
                        {
                            Trinkle();
                        }

                        DOWN(ref b, ref c, ref temp);
                        p <<= 1;

                        while (b > 1)
                        {
                            DOWN(ref b, ref c, ref temp);
                            p <<= 1;
                        }

                        ++p;
                    }

                    ++q;
                    ++r;
                }

                r1 = r;
                Trinkle();

                while (q > 1)
                {
                    --q;

                    if (b == 1)
                    {
                        --r;
                        --p;

                        while ((p & 1) == 0)
                        {
                            p >>= 1;
                            UP(ref b, ref c, ref temp);
                        }
                    }
                    else
                    {
                        if (b >= 3)
                        {
                            --p;
                            r = r - b + c;
                            if (p > 0)
                                SemiTrinkle();

                            DOWN(ref b, ref c, ref temp);
                            p = (p << 1) + 1;
                            r = r + c;
                            SemiTrinkle();
                            DOWN(ref b, ref c, ref temp);
                            p = (p << 1) + 1;
                        }
                    }
                }
            }
        }
        public static void SmoothSort<T>(this T[] array) where T : IComparable<T>
        {
            Smooth<T>.SmoothSort(array);
        }
    }
    public static class ListSmoothSortExtention
    {
        public static void SmoothSort<T>(this List<T> array) where T : IComparable<T>
        {
            array.Cloner(ArraySmoothSortExtention.SmoothSort);
        }
    }
    public static class IntSmoothSortExtention
    {
        class Smooth
        {

            private static bool IsAscending(int A, int B)
            {
                return (A <= B);
            }

            private static void UP(ref int IA, ref int IB, ref int temp)
            {
                temp = IA;
                IA += IB + 1;
                IB = temp;
            }

            private static void DOWN(ref int IA, ref int IB, ref int temp)
            {
                temp = IB;
                IB = IA - IB - 1;
                IA = temp;
            }

            private static int q, r, p, b, c, r1, b1, c1;
            private static int[] A;

            private static void Sift()
            {
                int r0, r2, temp = 0;
                int t;
                r0 = r1;
                t = A[r0];

                while (b1 >= 3)
                {
                    r2 = r1 - b1 + c1;

                    if (!IsAscending(A[r1 - 1], A[r2]))
                    {
                        r2 = r1 - 1;
                        DOWN(ref b1, ref c1, ref temp);
                    }

                    if (IsAscending(A[r2], t))
                    {
                        b1 = 1;
                    }
                    else
                    {
                        A[r1] = A[r2];
                        r1 = r2;
                        DOWN(ref b1, ref c1, ref temp);
                    }
                }

                if (Convert.ToBoolean(r1 - r0))
                    A[r1] = t;
            }

            private static void Trinkle()
            {
                int p1, r2, r3, r0, temp = 0;
                int t;
                p1 = p;
                b1 = b;
                c1 = c;
                r0 = r1;
                t = A[r0];

                while (p1 > 0)
                {
                    while ((p1 & 1) == 0)
                    {
                        p1 >>= 1;
                        UP(ref b1, ref c1, ref temp);
                    }

                    r3 = r1 - b1;

                    if ((p1 == 1) || IsAscending(A[r3], t))
                    {
                        p1 = 0;
                    }
                    else
                    {
                        --p1;

                        if (b1 == 1)
                        {
                            A[r1] = A[r3];
                            r1 = r3;
                        }
                        else
                        {
                            if (b1 >= 3)
                            {
                                r2 = r1 - b1 + c1;

                                if (!IsAscending(A[r1 - 1], A[r2]))
                                {
                                    r2 = r1 - 1;
                                    DOWN(ref b1, ref c1, ref temp);
                                    p1 <<= 1;
                                }
                                if (IsAscending(A[r2], A[r3]))
                                {
                                    A[r1] = A[r3]; r1 = r3;
                                }
                                else
                                {
                                    A[r1] = A[r2];
                                    r1 = r2;
                                    DOWN(ref b1, ref c1, ref temp);
                                    p1 = 0;
                                }
                            }
                        }
                    }
                }

                if (Convert.ToBoolean(r0 - r1))
                    A[r1] = t;

                Sift();
            }

            private static void SemiTrinkle()
            {
                int T;
                r1 = r - c;

                if (!IsAscending(A[r1], A[r]))
                {
                    T = A[r];
                    A[r] = A[r1];
                    A[r1] = T;
                    Trinkle();
                }
            }

            public static void SmoothSort(int[] Aarg)
            {
                int N = Aarg.Length;
                int temp = 0;
                A = Aarg;
                q = 1;
                r = 0;
                p = 1;
                b = 1;
                c = 1;

                while (q < N)
                {
                    r1 = r;
                    if ((p & 7) == 3)
                    {
                        b1 = b;
                        c1 = c;
                        Sift();
                        p = (p + 1) >> 2;
                        UP(ref b, ref c, ref temp);
                        UP(ref b, ref c, ref temp);
                    }
                    else if ((p & 3) == 1)
                    {
                        if (q + c < N)
                        {
                            b1 = b;
                            c1 = c;
                            Sift();
                        }
                        else
                        {
                            Trinkle();
                        }

                        DOWN(ref b, ref c, ref temp);
                        p <<= 1;

                        while (b > 1)
                        {
                            DOWN(ref b, ref c, ref temp);
                            p <<= 1;
                        }

                        ++p;
                    }

                    ++q;
                    ++r;
                }

                r1 = r;
                Trinkle();

                while (q > 1)
                {
                    --q;

                    if (b == 1)
                    {
                        --r;
                        --p;

                        while ((p & 1) == 0)
                        {
                            p >>= 1;
                            UP(ref b, ref c, ref temp);
                        }
                    }
                    else
                    {
                        if (b >= 3)
                        {
                            --p;
                            r = r - b + c;
                            if (p > 0)
                                SemiTrinkle();

                            DOWN(ref b, ref c, ref temp);
                            p = (p << 1) + 1;
                            r = r + c;
                            SemiTrinkle();
                            DOWN(ref b, ref c, ref temp);
                            p = (p << 1) + 1;
                        }
                    }
                }
            }
        }
        public static void IntSmoothSort(this int[] array)
        {
            Smooth.SmoothSort(array);
        }
    }

    public class AmericanFlagSortExtention
    {
        private int get_radix_val(int x, int digit, int radix)
        {
            return (int)(Math.Floor((double)(x / radix * digit))) % radix;
        }
        private int[] compute_offsets(int[] a_list, int start, int end, int digit, int radix)
        {
            int[] counts = new int[radix];
            for (int i = start; i < end; i++) //for i in range(start, end)
            {
                int val = get_radix_val(a_list[i], digit, radix);
                counts[val] += 1;
            }
            int[] offsets = new int[radix];
            int sum = 0;

            for (int i = 0; i < radix; i++)
            {
                offsets[i] = sum;
                sum += counts[i];
            }
            return offsets;
        }

        private void swap(ref int[] a_list, int[] offsets, int start, int end, int digit, int radix)
        {
            int i = start;
            int[] next_free = new int[offsets.Length];
            offsets.CopyTo(next_free, 0);
            int cur_block = 0;
            while (cur_block < radix - 1)
            {
                if (i >= start + offsets[cur_block + 1])
                {
                    cur_block++;
                    continue;
                }
                int radix_val = get_radix_val(a_list[i], digit, radix);
                if (radix_val == cur_block)
                {
                    i += 1;
                    continue;
                }
                int swap_to = next_free[radix_val];
                int temp = a_list[i];
                a_list[i] = a_list[swap_to];
                a_list[swap_to] = temp;
                next_free[radix_val] += 1;
            }
        }
        private void american_flag_sort_helper(ref int[] a_list, int start, int end, int digit, int radix)
        {
            int[] offsets = compute_offsets(a_list, start, end, digit, radix);
            swap(ref a_list, offsets, start, end, digit, radix);
            if (digit == 0)
                return;
            for (int i = 0; i < offsets.Length - 1; i++)
                american_flag_sort_helper(ref a_list, offsets[i], offsets[i + 1], digit - 1, radix);
        }
        public void american_flag_sort(int[] a_list, int radix)
        {
            int max_val = a_list.Max();
            int max_digit = (int)(Math.Floor(Math.Log(max_val, radix)));
            american_flag_sort_helper(ref a_list, 0, a_list.Length, max_digit, radix);
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
        internal static void Cloner<T>(this List<T> arr1, Action<T[]> operation) where T : IComparable<T>
        {
            var newarr = arr1.ToArray();
            operation(newarr);
            Clone();
            void Clone()
            {
                arr1.Clear();
                for (int i = 0; i < newarr.Count(); i++)
                {
                    arr1.Add(newarr[i]);
                }
            }
        }
    }
}
