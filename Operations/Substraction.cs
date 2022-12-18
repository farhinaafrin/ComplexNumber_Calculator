
    public class Substraction : AbstractOperation
{
    public override T Operators<T>(T left, T right)
    {

        dynamic leftnumbers = left;
        dynamic rightnumbers = right;

        return leftnumbers - rightnumbers;


    }
}

