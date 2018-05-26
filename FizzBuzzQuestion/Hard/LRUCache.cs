using System;
using System.Collections.Generic;

namespace FizzBuzzQuestion.Hard
{
    /*
        LRUCache cache = new LRUCache(2);
        cache.put(1, 1);
        cache.put(2, 2);
        cache.get(1);       // returns 1
        cache.put(3, 3);    // evicts key 2
        cache.get(2);       // returns -1 (not found)
        cache.put(4, 4);    // evicts key 1
        cache.get(1);       // returns -1 (not found)
        cache.get(3);       // returns 3
        cache.get(4);       // returns 4

        Could you do both operations in O(1) time complexity?
    */
    public class LRUCache
    {
        private readonly int _maxCap;
        private readonly LinkedList<Tuple<int, int>> _lruQueue;
        private readonly IDictionary<int, LinkedListNode<Tuple<int, int>>> _storage;
        
        public LRUCache(int capacity) 
        {
            _maxCap = capacity;
            _lruQueue = new LinkedList<Tuple<int, int>>();
            _storage = new Dictionary<int, LinkedListNode<Tuple<int, int>>>();
        }
        
        public int Get(int key) 
        {
            if (!_storage.TryGetValue(key, out LinkedListNode<Tuple<int, int>> cache)) { return -1; }

            Touch(cache);
            return cache.Value.Item2;
        }
        
        public void Put(int key, int value) 
        {
            // incase, key already exist
            if (_storage.TryGetValue(key, out LinkedListNode<Tuple<int, int>> cache))
            {
                cache.Value = new Tuple<int, int>(key, value);
                Touch(cache);
                return;
            }

            // when cache is full
            EvictIfNeeded();

            // then add new one
            cache = new LinkedListNode<Tuple<int, int>>(new Tuple<int, int>(key, value));
            _storage.Add(key, cache);
            _lruQueue.AddFirst(cache);
        }
        
        private void EvictIfNeeded()
        {   
            if (_maxCap != _storage.Count) { return; }
            
            var last = _lruQueue.Last;
            _storage.Remove(last.Value.Item1);
            _lruQueue.RemoveLast();
        }
        
        private void Touch(LinkedListNode<Tuple<int, int>> cache)
        {
            // always rearrange queue
            _lruQueue.Remove(cache);
            _lruQueue.AddFirst(cache);
        }
    }
}