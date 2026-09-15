namespace OOP_5;

class Program
{
    static void Main(string[] args)
    {
        #region Q1
            // a) What happens when you assign one object variable to another?
                // Both variables end up pointing to the same object in memory (reference is copied, not the object itself)

            // b) Does assigning one object to another create a new object?
                // No It just copies the reference so both variables refer to the same object.
                // Changing one will affect the other since they point to the same data.

            // c) Difference between copying an object and copying its reference
                // Copying an object: creates a new, independent object with its own memory (data duplicated)
                // Copying a reference: just copies the "address", both variables still point to one shared object

        #endregion
    }
}
