using System.Diagnostics;
using sorting_algorithms;

var timer = new Stopwatch();

Random rand = new Random();

List<int> numberlist = new List<int>();


int length = 10000;

for (int i = 0; i <= length-1; i++)
{
    numberlist.Add(rand.Next(length));
}







List<int> quickSortList = new List<int>(numberlist);

timer.Start();

Algorithms.Quicksort(quickSortList,0,numberlist.Count-1);

timer.Stop();

Console.WriteLine("Execution Time: {0} ms", timer.Elapsed.TotalMilliseconds);


timer.Reset();

List<int> Selectionsortlist = new List<int>(numberlist);

timer.Start();
Algorithms.Selectionsort(Selectionsortlist);
timer.Stop();

Console.WriteLine("Execution Time: {0} ms", timer.Elapsed.TotalMilliseconds);
timer.Reset();

List<int> Mergesortlist = new List<int>(numberlist);

timer.Start();

Algorithms.Mergesort(Mergesortlist);

timer.Stop();
timer.Reset();

Console.WriteLine("Execution Time: {0} ms", timer.Elapsed.TotalMilliseconds);


foreach (int number in Mergesortlist)
{
    Console.WriteLine(number);
}



