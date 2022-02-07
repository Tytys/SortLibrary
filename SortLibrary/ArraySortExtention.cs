using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SortLibrary
{
    public static class ArraySortExtention
    {
        public static int[] QuickSort(this int[] arr)
        {
            var less = new List<int>();
            var pivotlist = new List<int>();
            var more = new List<int>();

            if(arr.Length < 1)
            {
                return arr;
            }
            else
            {
                int pivot = arr[0];
                foreach(var i in arr)
                {
                    if(i < pivot)
                    {
                        less.Add(i);
                    }
                    else if(i > pivot)
                    {
                        more.Add(i);
                    }
                    else
                    {
                        pivotlist.Add(i);
                    }
                }
                less = less.QuickSort();
                more = more.QuickSort();
                var nwarr = new int[less.Count + more.Count];
                less.CopyTo(nwarr, 0);
                more.CopyTo(nwarr, less.Count);
                var newarr = new int[nwarr.Length + pivotlist.Count];
                nwarr.CopyTo(newarr, 0);
                pivotlist.CopyTo(newarr, nwarr.Length);
                return newarr;
            }
        }
        public static List<int> QuickSort(this List<int> arr)
        {
            var less = new List<int>();
            var pivotlist = new List<int>();
            var more = new List<int>();

            if (arr.Count < 1)
            {
                return arr;
            }
            else
            {
                int pivot = arr[0];
                foreach (var i in arr)
                {
                    if (i < pivot)
                    {
                        less.Add(i);
                    }
                    else if (i > pivot)
                    {
                        more.Add(i);
                    }
                    else
                    {
                        pivotlist.Add(i);
                    }
                }
                less = less.QuickSort();
                more = more.QuickSort();
                var nwarr = new int[less.Count + more.Count];
                less.CopyTo(nwarr, 0);
                more.CopyTo(nwarr, less.Count);
                var newarr = new int[nwarr.Length + pivotlist.Count];
                nwarr.CopyTo(newarr, 0);
                pivotlist.CopyTo(newarr, nwarr.Length);
                return newarr.ToList();
            }
        }
        public static double[] QuickSort(this double[] arr)
        {
            var less = new List<double>();
            var pivotlist = new List<double>();
            var more = new List<double>();

            if (arr.Length < 1)
            {
                return arr;
            }
            else
            {
                double pivot = arr[0];
                foreach (var i in arr)
                {
                    if (i < pivot)
                    {
                        less.Add(i);
                    }
                    else if (i > pivot)
                    {
                        more.Add(i);
                    }
                    else
                    {
                        pivotlist.Add(i);
                    }
                }
                less = less.QuickSort();
                more = more.QuickSort();
                var nwarr = new double[less.Count + more.Count];
                less.CopyTo(nwarr, 0);
                more.CopyTo(nwarr, less.Count);
                var newarr = new double[nwarr.Length + pivotlist.Count];
                nwarr.CopyTo(newarr, 0);
                pivotlist.CopyTo(newarr, nwarr.Length);
                return newarr;
            }
        }
        public static List<double> QuickSort(this List<double> arr)
        {
            var less = new List<double>();
            var pivotlist = new List<double>();
            var more = new List<double>();

            if (arr.Count < 1)
            {
                return arr;
            }
            else
            {
                double pivot = arr[0];
                foreach (var i in arr)
                {
                    if (i < pivot)
                    {
                        less.Add(i);
                    }
                    else if (i > pivot)
                    {
                        more.Add(i);
                    }
                    else
                    {
                        pivotlist.Add(i);
                    }
                }
                less = less.QuickSort();
                more = more.QuickSort();
                var nwarr = new double[less.Count + more.Count];
                less.CopyTo(nwarr, 0);
                more.CopyTo(nwarr, less.Count);
                var newarr = new double[nwarr.Length + pivotlist.Count];
                nwarr.CopyTo(newarr, 0);
                pivotlist.CopyTo(newarr, nwarr.Length);
                return newarr.ToList();
            }
        }
        public static float[] QuickSort(this float[] arr)
        {
            var less = new List<float>();
            var pivotlist = new List<float>();
            var more = new List<float>();

            if (arr.Length < 1)
            {
                return arr;
            }
            else
            {
                float pivot = arr[0];
                foreach (int i in arr)
                {
                    if (i < pivot)
                    {
                        less.Add(i);
                    }
                    else if (i > pivot)
                    {
                        more.Add(i);
                    }
                    else
                    {
                        pivotlist.Add(i);
                    }
                }
                less = less.QuickSort();
                more = more.QuickSort();
                var nwarr = new float[less.Count + more.Count];
                less.CopyTo(nwarr, 0);
                more.CopyTo(nwarr, less.Count);
                var newarr = new float[nwarr.Length + pivotlist.Count];
                nwarr.CopyTo(newarr, 0);
                pivotlist.CopyTo(newarr, nwarr.Length);
                return newarr;
            }
        }
        public static List<float> QuickSort(this List<float> arr)
        {
            var less = new List<float>();
            var pivotlist = new List<float>();
            var more = new List<float>();

            if (arr.Count < 1)
            {
                return arr;
            }
            else
            {
                float pivot = arr[0];
                foreach (var i in arr)
                {
                    if (i < pivot)
                    {
                        less.Add(i);
                    }
                    else if (i > pivot)
                    {
                        more.Add(i);
                    }
                    else
                    {
                        pivotlist.Add(i);
                    }
                }
                less = less.QuickSort();
                more = more.QuickSort();
                var nwarr = new float[less.Count + more.Count];
                less.CopyTo(nwarr, 0);
                more.CopyTo(nwarr, less.Count);
                var newarr = new float[nwarr.Length + pivotlist.Count];
                nwarr.CopyTo(newarr, 0);
                pivotlist.CopyTo(newarr, nwarr.Length);
                return newarr.ToList();
            }
        }
        public static byte[] QuickSort(this byte[] arr)
        {
            var less = new List<byte>();
            var pivotlist = new List<byte>();
            var more = new List<byte>();

            if (arr.Length < 1)
            {
                return arr;
            }
            else
            {
                byte pivot = arr[0];
                foreach (var i in arr)
                {
                    if (i < pivot)
                    {
                        less.Add(i);
                    }
                    else if (i > pivot)
                    {
                        more.Add(i);
                    }
                    else
                    {
                        pivotlist.Add(i);
                    }
                }
                less = less.QuickSort();
                more = more.QuickSort();
                var nwarr = new byte[less.Count + more.Count];
                less.CopyTo(nwarr, 0);
                more.CopyTo(nwarr, less.Count);
                var newarr = new byte[nwarr.Length + pivotlist.Count];
                nwarr.CopyTo(newarr, 0);
                pivotlist.CopyTo(newarr, nwarr.Length);
                return newarr;
            }
        }
        public static List<byte> QuickSort(this List<byte> arr)
        {
            var less = new List<byte>();
            var pivotlist = new List<byte>();
            var more = new List<byte>();

            if (arr.Count < 1)
            {
                return arr;
            }
            else
            {
                float pivot = arr[0];
                foreach (var i in arr)
                {
                    if (i < pivot)
                    {
                        less.Add(i);
                    }
                    else if (i > pivot)
                    {
                        more.Add(i);
                    }
                    else
                    {
                        pivotlist.Add(i);
                    }
                }
                less = less.QuickSort();
                more = more.QuickSort();
                var nwarr = new byte[less.Count + more.Count];
                less.CopyTo(nwarr, 0);
                more.CopyTo(nwarr, less.Count);
                var newarr = new byte[nwarr.Length + pivotlist.Count];
                nwarr.CopyTo(newarr, 0);
                pivotlist.CopyTo(newarr, nwarr.Length);
                return newarr.ToList();
            }
        }

        public static int[] MergeInsertionSort(this int[] arr)
        {
            (int, int) group;
            Random rnd = new Random();
            if(arr.Length % 2 == 0)
            {
                int val1 = arr[rnd.Next(0, arr.Length)];
                int val2 = arr[rnd.Next(0, arr.Length)];
                if (val1 != val2)
                {
                    group = (val1, val2);
                }
            }
        }
    }
}
