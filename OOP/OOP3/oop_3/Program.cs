namespace oop_3;

class Program
{
    static void Main(string[] args)
    {
        #region Q1
            // a) Difference between Overloading and Overriding
                // Overloading: same method name, different parameters, within the same class, resolved at Compile time
                // Overriding: subclass provides a new implementation of a method that exists in the parent, same signature, resolved at Runtime

            // b) Difference between Static Binding and Dynamic Binding
                // Static Binding: resolved at Compile time (used with Overloading, static/private methods)
                // Dynamic Binding: resolved at Runtime based on the actual object type (used with Overriding)

        #endregion
    }
}
