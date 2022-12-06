using System;

namespace HackerRankProblems.Implementations
{
    public class MyCustomGeneric<T> where T: class 
    {
        public int MaxObjectsCount { get; }
        public int CurrentCount { get; private set; }

        private readonly T[] _array;

        public MyCustomGeneric(T value)
        {
            _array = new T[1];
            CurrentCount++;
            MaxObjectsCount = 1;
            _array[0] = value;
            
        }

        public MyCustomGeneric(int maxCount)
        {
            _array = new T[maxCount];
            MaxObjectsCount = maxCount;
            CurrentCount++;         
        }

        public MyCustomGeneric(T value, int maxCount)
        {
            _array = new T[maxCount];
            _array[0] = value;

            MaxObjectsCount = maxCount;
            CurrentCount++;           
        }

        public void Add(T value)
        {
            if (CurrentCount < MaxObjectsCount)
            {
                CurrentCount++;
                _array[CurrentCount - 1] = value;
            }   
            else
            {
                var exceptionMessage = $"You cannot add more than maximum number {MaxObjectsCount} of elements";
                throw new MaximumObjectsException(exceptionMessage);
            }
        }

        public T GetData(int indexNumber)
        {
            return _array[indexNumber];
        }

        public Type GetDataType()
        {
            return typeof(T);
        }

        public MyCustomGeneric<T> CloneObject()
        {
            return (MyCustomGeneric<T>)this.MemberwiseClone();
        }
    }

    public class MaximumObjectsException : Exception
    {
        public MaximumObjectsException(string messsage): base(messsage)
        {

        }
    }
}
