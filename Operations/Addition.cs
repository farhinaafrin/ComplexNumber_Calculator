
    public class Addition : AbstractOperation
{
    public override T Operators<T>(T left, T right)
    {

        dynamic leftnumbers = left;
        dynamic rightnumbers = right;

        return leftnumbers + rightnumbers;


    }
}

