public class FactoryCLass
{
    public AbstractOperation GetOperation(string operate)
    {

        var operations = new Dictionary<string, AbstractOperation>(){
         {"+", new Addition()},{"-", new Substraction()},
         {"*", new Multiplication()},{"/", new Division()}
        };
        return operations[operate];

    }
}
