
    public class Multiplication : AbstractOperation
{
    public override T Operators<T>(T left, T right)
    {

        dynamic dleft = left;
        dynamic dright = right;

        return dleft * dright;


    }
}

