using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class TestIsEvenNumber2
    {
        [Fact]
        public void TestIsEvenNumber0()
        {

            CheckIsEvenNumber checkIsEvenNumber0 = new CheckIsEvenNumber();
            int num = 0;
            bool IsEven_Null = checkIsEvenNumber0.IsEven(num);
            Assert.True(IsEven_Null);
;
        }

        public bool IsEven(int num)
        {

            return num % 2 == 0;
        }
    }
}
