using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Example
{
    class ExceptionFilterExample
    {
        public void Run()
        {
            try
            {
                ThrowExceptionA();
                //ThrowExceptionB();
                //ThrowExceptionC();
            }
            // when(Test(ex.Message))에서 false가 반환되면 catch가 발생되지 않음
            // 
            // 특정 조건을 통하여 Exception 발생을 건너뛸수있다?
            catch (Exception ex) when(Test(ex.Message))
            {
                WriteLine("Exception Message에 A,B,C 라는 단어가 포함되어 있지 않다.");
            }
        }

        private bool Test(string exceptionMessage)
        {
            if(exceptionMessage.Contains("A"))
            {
                WriteLine("A 포함");
                return false;
            }
            else if (exceptionMessage.Contains("B"))
            {
                WriteLine("B 포함");
                return false;
            }
            else
            {
                WriteLine("C 포함");
                return true;
            }
        }

        private void ThrowExceptionA()
        {
            throw new Exception("TEST_A");
        }

        private void ThrowExceptionB()
        {
            throw new Exception("TEST_B");
        }

        private void ThrowExceptionC()
        {
            throw new Exception("TEST_C");
        }
    }
}
