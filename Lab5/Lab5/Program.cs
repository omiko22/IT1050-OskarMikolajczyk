using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.
            /* Scope - The scope of the method of a class is the entire body of the class. This enables non-static methods of a class to use any
             * of the methods regardless of the order in which they're declared. If the access modifier of a method is declared as private,
             * that method is only scoped to the class in which it is definted. No outside member, other then the class itself, is able to 
             * invoke such method. Similarly if the access modifier of a method is declated as public, then the class that is defining it as well
             * as any other member outside of the class may use such method.
             * The example method scope can be observed by the access modifier at the begning of the example getArea() method. It is 'public'.
             * 
             * Static vs Non-Static - When a class, property or a method is declared as static, it enables those members to be called without
             * creating an object of a class. You do not have to instantiate the class which holds such members, you can simply refer to them 
             * by invoking the name of the class followed by the static member. Non-Static classes, properties and methods which do not
             * contain the word static, require an object reference in order to be able to invoke them. This would require using the "new"
             * keyword to instantiate a new instance of a class which holds these instance memebers.
             * The example method getArea() is an instance method. It does not contain the static keyword.
             *
             * Return type - the return type of the method indicates the type of data this method will return to the caller. Given two double values
             * the method getArea() will return to the caller another double value which can be hashed away in a variable. If a method has a return type
             * than the method implementation has to end with a return statement which has to return the same data type as specified by the 
             * method return type. In the example the return type for the method is 'double' it's right after the public access modifier and before
             * the method name.
             * 
             * Method name - Method name is what uniquely identifies the method inside the class. The name of the method is what is used
             * to invoke the method when wanting to perform some operation. In the example the method name is 'getArea'.
             * 
             * Parameters - the parameters of the method indicate the required values that the caller must pass into the method before it can be onvoked
             * Some parameters may be optional, such parameters may be omitted. We can declare multiple methods with the same name however, if we change
             * the signature of that method, the number of parameters it is supposed to receive we can create overloads for such methods allowing us
             * to have the same name for multiple methods that do similar, but slightly different operations. A method does not have to have any paremeters.
             * The parameters in the getArea() method indicate that you may only pass in two values and these values have to be of type double.
             * The parameters for the getArea() method are the values in between the parentheses indicated by their type and name. In the example
             * that is (double height, double width)
             * 
             * Method Body - The method body specifies the block of code that will be executed once the method is invoked by the caller. Here
             * all of the declared variables are scoped to the method only. The method body in the getArea() example method, beings with the
             * opening of the first curly brace and ends with the second closing curly brace.
             * {
             *  return height * width;
             * }
             * The method body also identifies the code that will be executed when this method is invoked. Methods will only execute the code
             * that is within their method body.
             * 
             * 3. .NET framework offers developers a wide range of methods and tools that can be used to perform varies tasks. A lot of the times
             * tasks such as copying things to the clip board, or change the color of a console application line can be done through invoking
             * .NET framework methods. It makes it easier for developers to perform common tasks for their projects without having to invent
             * their own ways of performing these common tasks. When creating user defined tasks, we are creating methods that help us achieve 
             * certain domain specific logic. Methods also help us break down logic of our application into smaller components that if written
             * correctly can be re-used throughout our application. Key in writing good user-defined methods is to keep them generic to allow
             * for later re-use without having to duplicate your code. More code, means more maintance. Keeping your application lean with
             * generic methods is ideal approach, and leverging .NET framework methods to help you achieve this can make your application really
             * robust and future proof.
             * 
             * 4. Static methods do not have to have a reference to an object in order to invoke them. If a method is declared with the static keywoard
             * then the methos can be invoked by simply declaring the class which defines it (the class does not have to be static) and then invoking
             * the static method directly. If a method is not marked as static, it then needs to have a reference to an object which defines it. This is
             * done when we instantiate a new object by using the new keyword allowing us to have a reference to the class that defines the method.
             * 
             * 5. 
             * 
             * 
             */
        }
    }
}
