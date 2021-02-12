using System;
using System.Collections.Generic;

namespace SchoolProject
{
    class Service
    {
        public IEnumerable<T> MyWhere<T>(IEnumerable<T> list, Func<T, bool> ptr)
        {
            foreach (T obj in list)
            {
                if (ptr(obj))
                {
                    yield return obj;
                }
            }
        }
        public IEnumerable<TResult> MySelect<T, TResult>(IEnumerable<T> list, Func<T, TResult> func)
        {
            foreach (T obj in list)
            {

                yield return func(obj);
            }
        }

        public IEnumerable<K> MySelectMany<T, TResult, K>(IEnumerable<T> list, Func<T, IEnumerable<TResult>> func, Func<TResult, K> funct)
        {
            foreach (T obj in list)
            {
                foreach (TResult obj1 in func(obj))
                {
                    yield return funct(obj1);
                }
            }
        }

        public bool MyAll<T>(IEnumerable<T> list, Func<T, bool> func)
        {
            foreach (T obj in list)
            {
                if (!func(obj))
                    return false;
            }
            return true;
        }

        public bool MyAny<T>(IEnumerable<T> list, Func<T, bool> func)
        {
            foreach (T obj in list)
            {
                if (func(obj))
                    return true;
            }
            return false;
        }

        public T MyFirst<T>(IEnumerable<T> list)
        {
            IEnumerator<T> ie = list.GetEnumerator();
            ie.MoveNext();
            return ie.Current;
        }

        public T MyFirstOrDefault<T>(IEnumerable<T> list)
        {
            foreach (T obj in list)
            {
                return obj;
            }
            return default;
        }

        public bool MyContains<T>(IEnumerable<T> list, T obj)
        {
            foreach (T i in list)
            {
                if (i.Equals(obj))
                    return true;
            }
            return false;
        }
    }
}
