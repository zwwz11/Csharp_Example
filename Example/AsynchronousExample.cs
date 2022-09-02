using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example
{
    class AsynchronousExample
    {
        public void RunWait()
        {
            Write("Program Begin");
            DoAsTask();
            Write("Program End");
            Console.ReadLine();
        }
        public void RunAsync()
        {
            Write("Program Begin");
            DoAsAsync();
            Write("Program End");
            Console.ReadLine();
        }
        private void DoAsTask()
        {
            /*
             * Task.Wait()는 비동기 처리를 진행하는 분기된 스레드가 종료될때까지 메인 스레드도 중지된다.
             * 동기점을 맞추어 사용됨.
             * */
            Write("1 - Starting");
            var t = Task.Factory.StartNew<int>(DoSomethingThatTakesTime);
            Write("2 - Task started");
            t.Wait();
            Write("3 - Task completed with result: " + t.Result);
        }
        private async void DoAsAsync()
        {
            /*
             * await는 비동기 처리를 진행하는 분기된 스레드가 완료되지 않아도 메인스레드는 진행된다
             * 이 때, await이후 스코프는 처리되지 않으며 분기된 스레드의 작업이 끝나면 await로 돌아와 처리를 마무리한다.
             * 그래서 파일 다운로드나, 그 외 별도의 기능을 수행하는 작업을 진행하는데에 있어서 await를 사용하면 될 것 같다.
             * 논블럭용으로 사용됨
             * */
            Write("1 - Starting");
            var t = Task.Factory.StartNew<int>(DoSomethingThatTakesTime);
            Write("2 - Task started");
            var result = await t;
            Write($"3 - Task completed with result : {result}");
        }
        private int DoSomethingThatTakesTime()
        {
            Write("A - Started something");
            Thread.Sleep(1000);
            Write("B - Completed something");
            return 123;
        }
        private void Write(string message)
        {
            Console.WriteLine($"ThreadId : {Thread.CurrentThread.ManagedThreadId} / {message}");
        }
    }
}
