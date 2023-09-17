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
            int checkNumber = 10;
            //bool IsEven = checkIsEvenNumber.Equals(checkNumber);
            bool IsEven = checkIsEvenNumber.CheckIsEven(checkNumber);

            Assert.True(IsEven);

            int checkNumberWithFalied = 9;
            //bool IsEvenWithFalied = checkIsEvenNumber.(checkNumberWithFalied);

            //Assert.True(IsEvenWithFalied);
        }
    }
}
