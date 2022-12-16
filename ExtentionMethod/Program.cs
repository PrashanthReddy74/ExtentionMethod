using System;
using System.Threading;
using System.Threading.Tasks;



namespace Infinite.CSharp.Day16
{
    public class AsyncDemo2
    {
        //Multi Thread
        public void MultiThreadMethod()
        {
            Console.WriteLine("Multi Thread Method Started " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine();
            Console.WriteLine("Multi Thread Method Ends " + Thread.CurrentThread.ManagedThreadId);
        }



        public async void AsyncMethod()
        {
            Console.WriteLine("Async Method Started " + Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(TimeSpan.FromSeconds(2));
            Console.WriteLine();
            Console.WriteLine("Async Method Ends " + Thread.CurrentThread.ManagedThreadId);
        }



        static void Main(string[] args)
        {
            AsyncDemo2 demo2 = new AsyncDemo2();
            //Thread t1 = new Thread(new ThreadStart(demo2.MultiThreadMethod));
            //Console.WriteLine("Main Method Starts");
            //t1.Start();
            //Console.WriteLine("Main Method Ends");



            //Calling Async Method
            Console.WriteLine("Main Method Starts");
            demo2.AsyncMethod();
            Console.WriteLine("Main Method Ends");



            Console.ReadLine();
        }
    }
}