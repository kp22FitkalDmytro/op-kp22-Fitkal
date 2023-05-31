using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_2
{
    public class HashTable<KItem, VItem>
    {
        private int initialCapacity;
        private List<KeyValuePair<KItem, VItem>>[] buckets;

        public HashTable()
        {
            initialCapacity = 10;
            buckets = new List<KeyValuePair<KItem, VItem>>[initialCapacity];
        }

        public HashTable(int initialCapacity)
        {
            this.initialCapacity = initialCapacity;
            buckets = new List<KeyValuePair<KItem, VItem>>[initialCapacity];
        }

        public void Add(KItem key, VItem value)
        {
            int bucketIndex = GetBucketIndex(key);

            if (buckets[bucketIndex] == null)
            {
                buckets[bucketIndex] = new List<KeyValuePair<KItem, VItem>>();
            }


            buckets[bucketIndex].Add(new KeyValuePair<KItem, VItem>(key, value));
        }

        public void Remove(KItem key)
        {
            int bucketIndex = GetBucketIndex(key);

            if (buckets[bucketIndex] != null)
            {
                foreach (KeyValuePair<KItem, VItem> pair in buckets[bucketIndex])
                {
                    if (pair.Key.Equals(key))
                    {
                        buckets[bucketIndex].Remove(pair);
                        return;
                    }
                }
            }
        }

        public VItem Get(KItem key)
        {
            int bucketIndex = GetBucketIndex(key);

            if (buckets[bucketIndex] != null)
            {
                foreach (KeyValuePair<KItem, VItem> pair in buckets[bucketIndex])
                {
                    if (pair.Key.Equals(key))
                    {
                        return pair.Value;
                    }
                }
            }

            return default(VItem);
        }

        public bool Contains(KItem key)
        {
            foreach (List<KeyValuePair<KItem, VItem>> bucket in buckets)
            {
                if (bucket != null)
                {
                    foreach (KeyValuePair<KItem, VItem> pair in bucket)
                    {
                        if (pair.Key.Equals(key))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public void Clear()
        {
            for (int i = 0; i < initialCapacity; i++)
            {
                buckets[i] = null;
            }
        }

        public int Size()
        {
            int count = 0;

            foreach (List<KeyValuePair<KItem, VItem>> bucket in buckets)
            {
                if (bucket != null)
                {
                    count += bucket.Count;
                }
            }

            return count;
        }

        private int GetBucketIndex(KItem key)
        {
            return Math.Abs(key.GetHashCode()) % initialCapacity;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            HashTable<string, bool> dictionary = new HashTable<string, bool>();

            // додати слова
            dictionary.Add("apple", true);
            dictionary.Add("banana", true);
            dictionary.Add("cat", true);
            // ще додати

            
            Console.WriteLine("Enter a word to check its spelling (or type 'quit' to exit):");

            string word;
            while ((word = Console.ReadLine()) != "quit")
            {
                if (dictionary.Contains(word))
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("WrongSpelling");
                }

                Console.WriteLine("Enter a word to check its spelling (or type 'quit' to exit):");
            }
        }
    }
}
