namespace OOP_1;

class Program
{
    static void Main(string[] args)
    {
        #region Q1
        //a)
//      DeliveryAddress is a struct, which is a value type.
//      When a DeliveryAddress variable is copied into another variable, a separate copy is created.
//      So, if we modify the copied variable, the original variable will not be affected.

        //b)
        /*
        Customer is a class, which is a reference type.
        When a Customer variable is copied into another variable, both variables refer to the same object.
        Therefore, if one variable modifies the object, the changes will also be visible through the other variable.
        */
         #endregion

         #region Q2
        //a)
        /*
        1. The fields are public, so they can be modified directly from outside the struct.
        2. There is no validation to prevent invalid values.
        3. The internal data is not protected from unwanted changes.
        4. The struct does not properly control how its data is accessed.
        */

        //b)
        /*
        Using private fields and public properties improves encapsulation because:
        1. The fields cannot be accessed directly from outside.
        2. Properties control how the data is read and modified.
        3. Validation can be added inside the properties.
        4. This protects the object's data from invalid values.
        */
        #endregion
    }
}
