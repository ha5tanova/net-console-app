using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class TestIsEvenNumber
    {
        [Fact]
        public void TestIsEvenNumber1()
        {

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
