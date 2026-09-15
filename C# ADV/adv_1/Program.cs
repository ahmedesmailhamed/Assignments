namespace adv_1;

class Program
{
    static void Main(string[] args)
    {
        #region Q1
            // a) What is a Generic Class?
                // A class that can work with different data types using a type parameter such as <T>

            // b) Why use Generics?
                // To write reusable and type-safe code without repeating the same code for different data types
        #endregion

        #region Q2
            // A Generic Container class with Add and Get methods
            class Container<T>
            {
                private T value;
                public void Add(T item)
                {
                    value = item;
                }

                public T Get()
                {
                    return value;
                }
            }
        #endregion

        #region Q3
            // a) What are Multiple Type Parameters?
                // Using more than one type parameter in a generic class or method

            // b) Write Pair<TKey, TValue>
            class Pair<TKey, TValue>
            {
                public TKey Key { get; set; }
                public TValue Value { get; set; }

                public Pair(TKey key, TValue value)
                {
                    Key = key;
                    Value = value;
                }
            }
        #endregion

        #region Q4
            // a) What is a Generic Method?
                // A method that uses a type parameter so it can work with different data types

            // b) Write Swap<T> method
            static void Swap<T>(ref T a, ref T b)
            {
                T temp = a;
                a = b;
                b = temp;
            }
        #endregion

    }
}
