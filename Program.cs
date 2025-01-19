using System.Diagnostics;
using sorting_algorithms;

Stopwatch stopWatch = new Stopwatch();

TimeSpan ts = stopWatch.Elapsed;


string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",ts.Hours, ts.Minutes, ts.Seconds,ts.Milliseconds / 10);







Random rand = new Random();

List<int> numberlist = new List<int>();

for (int i = 0; i <= 999; i++)
{
    numberlist.Add(rand.Next(10000));
}

stopWatch.Start();


Algorithms.Bubblesort(numberlist);

Thread.Sleep(10000);

stopWatch.Stop();


foreach (int number in numberlist)
{
    Console.WriteLine(number);
}
Console.WriteLine("RunTime " + elapsedTime);
