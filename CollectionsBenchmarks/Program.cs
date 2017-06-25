using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CollectionsBenchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            HashSet<string> hash = new HashSet<string>();
            SortedList<string, string> sortedList = new SortedList<string, string>();
            SortedDictionary<string, string> sortedDictionary = new SortedDictionary<string, string>();
            ArrayList arrayList = new ArrayList();

            for (int i = 0; i < 3000000; i++)
            {
                var g = Guid.NewGuid().ToString();
                list.Add(g);

            }
            list = list.OrderBy(x => x).ToList();

            hash = new HashSet<string>(list);
            dictionary = list.ToDictionary(x => x, x => x);
            sortedList = new SortedList<string,string>(dictionary);
            sortedDictionary = new SortedDictionary<string, string>(dictionary);
            arrayList.AddRange(list);


            Random r = new Random();
            var valueToLocateIndex = r.Next(0, 200000);
            var value = list[valueToLocateIndex];

            Stopwatch watch = new Stopwatch();

            watch.Start();
            var builtInBinarySearchPosition = list.BinarySearch(value);
            watch.Stop();
            Console.WriteLine($"builtInBinarySearchPosition : {builtInBinarySearchPosition} : {watch.ElapsedTicks}ticks");

            watch.Reset();

            watch.Start();
            var customBinarySearchPostition = BinarySearch(list, value);
            watch.Stop();
            Console.WriteLine($"customBinarySearchPostition : {customBinarySearchPostition} : {watch.ElapsedTicks}ticks");

            watch.Reset();

            watch.Start();
            var customBinarySearchFakePostition = BinarySearch(list, Guid.NewGuid().ToString());
            watch.Stop();
            Console.WriteLine($"customBinarySearchFakePostition : {customBinarySearchFakePostition} : {watch.ElapsedTicks}ticks");

            watch.Reset();

            watch.Start();
            var firstOrDefault = list.FirstOrDefault(x => x == value);
            watch.Stop();
            Console.WriteLine($"firstOrDefault : {watch.ElapsedTicks}ticks");

            watch.Reset();

            watch.Start();
            var singleOrDefault = list.SingleOrDefault(x => x == value);
            watch.Stop();
            Console.WriteLine($"singleOrDefault : {watch.ElapsedTicks}ticks");

            watch.Reset();

            watch.Start();
            var find = list.Find(x => x == value);
            watch.Stop();
            Console.WriteLine($"find : {watch.ElapsedTicks}ticks");

            watch.Reset();

            watch.Start();
            var containsKey = dictionary.ContainsKey(value);
            watch.Stop();
            Console.WriteLine($"containsKey : {watch.ElapsedTicks}ticks");

            watch.Reset();

            watch.Start();
            var hashContains = hash.Contains(value);
            watch.Stop();
            Console.WriteLine($"hashContains : {watch.ElapsedTicks}ticks");

            watch.Reset();

            watch.Start();
            var sortedListContainsKey = sortedList.ContainsKey(value);
            watch.Stop();
            Console.WriteLine($"sortedListContainsKey : {watch.ElapsedTicks}ticks");

            watch.Reset();

            watch.Start();
            var sortedDictionaryContainsKey = sortedDictionary.ContainsKey(value);
            watch.Stop();
            Console.WriteLine($"sortedDictionaryContainsKey : {watch.ElapsedTicks}ticks");

            watch.Reset();

            watch.Start();
            var arrayListIndexOf = arrayList.IndexOf(value);
            watch.Stop();
            Console.WriteLine($"arrayListIndexOf : {arrayListIndexOf} : {watch.ElapsedTicks}ticks");

            watch.Reset();

            watch.Start();
            var arrayListContains = arrayList.Contains(value);
            watch.Stop();
            Console.WriteLine($"arrayListContains : {arrayListIndexOf} : {watch.ElapsedTicks}ticks");

            watch.Reset();

            watch.Start();
            foreach (var l in list)
            {

            }
            watch.Stop();
            Console.WriteLine($"listForeach : {watch.ElapsedTicks}ticks");

            watch.Reset();

            watch.Start();
            for (int i = 0; i < list.Count; i++)
            {

            }
            watch.Stop();
            Console.WriteLine($"listForLoop : {watch.ElapsedTicks}ticks");

            Console.Read();
        }

        static int BinarySearch(List<string> collection, string searchValue)
        {
            int min = 0;
            int max = collection.Count();

            while (min <= max)
            {
                var pos = (min + max) / 2;
                var value = collection[pos];

                if (string.Compare(value, searchValue) < 0)
                {
                    min = pos + 1;
                }
                else if (string.Compare(value, searchValue) > 0)
                {
                    max = pos - 1;
                }
                else if (value == searchValue)
                {
                    return pos;
                }
            }

            return -1;
        }
    }
}
