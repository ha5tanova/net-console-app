using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace TestProject1
{
    
    public class CheckIsEvenNumber
    {
        [Fact]
        public void TestIsEvenNumber() {
            CheckIsEvenNumber checkIsEvenNumber = new CheckIsEvenNumber();
            int num = 10;
            bool IsEven = checkIsEvenNumber.IsEven(num);
            Assert.True(IsEven);

            CheckIsEvenNumber checkIsEvenNumber1 = new CheckIsEvenNumber();
            int checkNumberWithFalied = 9;
            bool IsEvenWithFalied = checkIsEvenNumber1.IsEven(checkNumberWithFalied);
            Assert.True(IsEvenWithFalied);

            CheckIsEvenNumber checkIsEvenNumber2 = new CheckIsEvenNumber();
            int numNegative = -100;
            bool IsEven_Negative = checkIsEvenNumber2.IsEven(numNegative);
            Assert.True(IsEven_Negative);

            CheckIsEvenNumber checkIsEvenNumber3 = new CheckIsEvenNumber();
            int numNegativeNotEven = -45;
            bool IsNotEven_Negative = checkIsEvenNumber3.IsEven(numNegativeNotEven);
            Assert.True(IsNotEven_Negative);

        }


        public bool IsEven(int num)
        {

            return num % 2 == 0;
        }
    }
}
