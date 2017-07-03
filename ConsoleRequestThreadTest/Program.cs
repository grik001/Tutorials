using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleRequestThreadTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = Task.Run(async () =>
            {
                do
                {
                    Random r = new Random();
                    var delay = r.Next(1000, 2000);

                    await Task.Delay(delay);

                    WebClient client = new WebClient();
                    var guid = Guid.NewGuid().ToString();
                    var response = client.DownloadString("http://localhost:55863/api/Values/Get1?token=" + guid);
                    Console.WriteLine("GET1:" + response + " Delay:" + delay);
                } while (true);
            });

            var t2 = Task.Run(async () =>
            {
                do
                {
                    Random r = new Random();
                    var delay = r.Next(1000, 5000);

                    await Task.Delay(delay);

                    WebClient client = new WebClient();
                    var response = client.DownloadString("http://localhost:55863/api/Values/Get2");
                    Console.WriteLine("GET2:" + response + " Delay:" + delay);
                } while (true);
            });

            var t3 = Task.Run(async () =>
            {
                do
                {
                    Random r = new Random();
                    await Task.Delay(1000);
                    
                    Console.WriteLine($"ThreadID for Task3:{Thread.CurrentThread.ManagedThreadId}");
                } while (true);
            });

            new Thread(() => {
                do
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"ThreadID for ThreadLoop:{Thread.CurrentThread.ManagedThreadId}");
                } while (true);
            }).Start();

            Task.WaitAll(new Task[] { t1, t2, t3 });
        }
    }
}
