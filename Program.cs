using System.Diagnostics;
using System.Globalization;
using Microsoft.VisualBasic;
using sorting_algorithms;

var timer = new Stopwatch();

Random rand = new Random();

Console.Write("Size of list: ");

int length = int.Parse(Console.ReadLine());

List<int> numberlist = new List<int>();

for (int i = 0; i <= length-1; i++)
{
    numberlist.Add(rand.Next(length));
}


void MeasureExecutionTime(Action<List<int>> Algorithms, string algorithmName, List<int> numberlist)
{
    List<int> listCopy = new List<int>(numberlist);
    
    timer.Start();
    Algorithms(listCopy);
    timer.Stop();
    
    Console.WriteLine("Execution Time {0}: {1} ms", algorithmName, timer.Elapsed.TotalMilliseconds);
    timer.Reset();
}

MeasureExecutionTime(Algorithms.Bubblesort, "Bubblesort", numberlist);
MeasureExecutionTime(Algorithms.Selectionsort, "Selectionsort", numberlist);
MeasureExecutionTime(Algorithms.Insertionsort, "Insertionsort", numberlist);



List<int> Mergesortlist = new List<int>(numberlist);
timer.Start();
Mergesortlist = Algorithms.Mergesort(Mergesortlist);
timer.Stop();
Console.WriteLine("Execution Time Mergesort: {0} ms", timer.Elapsed.TotalMilliseconds);
timer.Reset();

List<int> quickSortList = new List<int>(numberlist);
timer.Start();
Algorithms.Quicksort(quickSortList,0,quickSortList.Count-1);
timer.Stop();
Console.WriteLine("Execution Time Quicksort: {0} ms", timer.Elapsed.TotalMilliseconds);
timer.Reset();

