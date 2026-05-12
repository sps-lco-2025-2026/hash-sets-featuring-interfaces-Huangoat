using System.Diagnostics.CodeAnalysis;

namespace HashSet.Lib
{
    public interface IHashSet<T> 
        where T : SPSStudent, IEquatable<T>
    {
        T Add(T value);
        bool IsPresent(T value);
        void Rebalance();
        void Add(T item)
        {
            
        }
    }

    public interface SPSStudent : IEquatable<SPSStudent>
    {
        string Name { get; }
        string Year { get; }
        string Tutor { get; }

        public string ToString()
        {
            return $"{Name} {Year} {Tutor}, HashCode: {GetHashCode()}";
        }
        public string GetHashCodeString()
        {
            return GetHashCode().ToString();
        }   
    }

}


