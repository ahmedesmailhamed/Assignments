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

        #region Q2
            // a) What is a Shallow Copy?
                // Creates a new object, but its reference-type members still point to the same original objects

            // b) What is a Deep Copy?
                // Creates a new object AND creates new copies of all its reference-type members too (fully independent)

            // c) What happens to reference-type members in a Shallow Copy?
                // They are shared, both the original and the copy point to the same referenced object

            // d) What happens to reference-type members in a Deep Copy?
                // They are duplicated, the copy has its own separate objects, not linked to the original

            // e) One situation where Deep Copy is safer than Shallow Copy
                // When the object contains a list or another class instance, and you need to modify the copy
                // without affecting the original (e.g., copying a Student object that has a List<Course>)

        #endregion
    }
}
