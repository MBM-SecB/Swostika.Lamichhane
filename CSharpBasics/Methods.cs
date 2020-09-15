using System;
public class MethodTeach
{
    //Simple-method: takes 2 arguments , and returns a value .
    public int Multiply(int firstNum, int secondNum)
    {
        int result = firstNum * secondNum;
        return result;
    }

    public int Multiply(params int[] numbers)
    {
        int product = 1;
        foreach (int num in numbers)
        {
            product = product * num;
        }
        return product;
    }

    //Named-arguements 
    // internal void PrintCustomerDetails(string name, byte age, string address, DateTime dob)
    // {
    //     //using string interpolation 
    //     Console.Write($"Customer Details: {name},{age},{address},{dob}");
    // }
    // //returning multiple value.
    // (int, string) Dosomething(int x)
    // {
    //     //do something on x
    //     return (434, "");
    // }


}
public class MethodTest
{
    void TestMethods()
    {
        MethodTeach methodTeach = new MethodTeach();
        int product = methodTeach.Multiply(11134, 3456);
        product = methodTeach.Multiply(11134, 3456, 111, 2344, 2111);


    }
}