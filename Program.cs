class Program
    {
        

        static void Main(string[] args)
         {  

            string  user_operator= System .Console.ReadLine();

             
            ComplexNumber  firstComplexNumber = new ComplexNumber (8, 10);
            ComplexNumber  secondComplexNumber = new ComplexNumber (-3, -100);
         
            FactoryCLass factoryCLass = new FactoryCLass();

            AbstractOperation getOperator = factoryCLass.GetOperation(user_operator);
            ComplexNumber newComplexNumber = getOperator.Operators(firstComplexNumber, secondComplexNumber);
        
            System. Console.WriteLine($"({firstComplexNumber}){user_operator}({secondComplexNumber}) = ({newComplexNumber})");

   }
    }