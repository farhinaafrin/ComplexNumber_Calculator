
   
class ComplexNumber
    {
         

        private double FirstNumber = 0;
        
        private double SecondNumber = 0;

        public ComplexNumber (double firstNumber, double secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }
        public static ComplexNumber operator +(ComplexNumber firstComplexNumber, ComplexNumber secondComplexNumber ){
             ComplexNumber newComplexNumber  = new ComplexNumber(firstComplexNumber.FirstNumber +secondComplexNumber.FirstNumber, firstComplexNumber.SecondNumber+secondComplexNumber.SecondNumber); 
            return newComplexNumber;
        }
         
         public static ComplexNumber operator -(ComplexNumber firstComplexNumber, ComplexNumber secondComplexNumber ){
             ComplexNumber newComplexNumber  = new ComplexNumber(firstComplexNumber.FirstNumber -secondComplexNumber.FirstNumber, firstComplexNumber.SecondNumber-secondComplexNumber.SecondNumber); 
            return newComplexNumber;
        }

         public static ComplexNumber operator *(ComplexNumber firstComplexNumber, ComplexNumber secondComplexNumber ){
             ComplexNumber newComplexNumber  = new ComplexNumber(firstComplexNumber.FirstNumber *secondComplexNumber.FirstNumber, firstComplexNumber.SecondNumber*secondComplexNumber.SecondNumber); 
            return newComplexNumber;
        }
         public static ComplexNumber operator /(ComplexNumber firstComplexNumber, ComplexNumber secondComplexNumber ){
             ComplexNumber newComplexNumber  = new ComplexNumber(firstComplexNumber.FirstNumber /secondComplexNumber.FirstNumber, firstComplexNumber.SecondNumber/secondComplexNumber.SecondNumber); 
            return newComplexNumber;
        }


        public override string  ToString()
        {
 	         return String.Format("{0},{1}i", FirstNumber, SecondNumber);
             

        }
    }
