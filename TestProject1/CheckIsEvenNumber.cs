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
        }

        


        public bool IsEven(int num)
        {

            return num % 2 == 0;
        }
    }
}
