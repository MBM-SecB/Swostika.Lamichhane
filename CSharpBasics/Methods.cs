public class MethodTeacher
{
    //simple methods:takes 2 arguments and return a value
    public int Multiply(int firstNum, int secondNum)
    {
        int result = firstNum * secondNum;
        return result;
    }

    // Variable numbers of arguments
    public int Multiply(params int[] numbers)
    {
        int product = 1;
        foreach (int num in numbers)
        {
            product = product * num;
        }
        return product;
    }
    public int MinMax(params int[] num)
    {

        return product;
    }

}


public class MethodTester
{
    void TestMethods()
    {
        MethodTeacher s = new MethodTeacher();
        int product = s.Multiply(2, 6);

        product = s.Multiply(4, 5, 6);
    }
}