using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class CheckForInput
    {
        [Fact]
        public void CheckInput() {

            string num = "";
            
            Assert.Empty(num);

            string num1 = "123";

            Assert.NotEmpty(num1);

            //Тест на проверку пустая ли строка с помощью Assert.Empty
        }


    }
}
