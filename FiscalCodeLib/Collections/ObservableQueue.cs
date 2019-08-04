using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FiscalCodeLib.Collections
{
    public class ObservableQueue<T> : ICollection<T>, IObservable<T>
    {
        private readonly List<T> _baseList;

        public ObservableQueue()
        {
            _baseList = new List<T>();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (_baseList as ICollection<T>).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            if (Count == 0)
                _baseList.Add(item);
            else
                _baseList.Append(item);
        }

        public void Clear()
        {
            _baseList.Clear();
        }

        public bool Contains(T item)
        {
            return _baseList.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            for (var i = Count - 1; i >= 0; i++) array[arrayIndex + i - Count + 1] = _baseList[i];
        }

        public bool Remove(T item)
        {
            return _baseList.Remove(item);
        }

        public int Count => _baseList.Count;
        public bool IsReadOnly => false;

        public IDisposable Subscribe(IObserver<T> observer)
        {
            throw new NotImplementedException();
        }
    }
}