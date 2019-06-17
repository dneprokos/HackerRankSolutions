using System;
using System.Text;

namespace HackerRankProblems
{
    public class MyCustomGeneric<T> where T: class 
    {
        public int maxObjectsCount { get; }
        public int currentCount { get; private set; }

        T[] array;

        public MyCustomGeneric(T value)
        {
            array = new T[1];
            currentCount++;
            maxObjectsCount = 1;
            array[0] = value;
            
        }

        public MyCustomGeneric(int maxCount)
        {
            array = new T[maxCount];
            maxObjectsCount = maxCount;
            currentCount++;         
        }

        public MyCustomGeneric(T value, int maxCount)
        {
            array = new T[maxCount];
            array[0] = value;

            maxObjectsCount = maxCount;
            currentCount++;           
        }

        public void Add(T value)
        {
            if (currentCount < maxObjectsCount)
            {
                currentCount++;
                array[currentCount - 1] = value;
            }   
            else
            {
                var exceptionMessage = String.Format($"You cannot add more than maximum number {0} of elements", maxObjectsCount);
                throw new MaximumObjectsException(exceptionMessage);
            }
        }

        public T GetData(int indexNumber)
        {
            return array[indexNumber];
        }

        public System.Type GetDataType()
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
