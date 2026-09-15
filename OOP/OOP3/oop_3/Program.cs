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

        #region Q2
            // a) Purpose of sealed on a class
                // Prevents any other class from inheriting from this class

            // b) Difference between sealed class and sealed method
                // sealed class: closes the whole class from being inherited
                // sealed method: closes only one specific method from being overridden again, the rest of the class can still be inherited normally

            // c) Can a sealed method be overridden?
                // No. sealed stops the overriding chain at that point,
                // so the implementation becomes final and can't be changed by any further derived classes
        #endregion
    }
}
