using System.Diagnostics;
using sorting_algorithms;

var timer = new Stopwatch();

Random rand = new Random();

List<int> numberlist = new List<int>();


int length = 10000000;

for (int i = 0; i <= length-1; i++)
{
    numberlist.Add(rand.Next(length));
}



timer.Start();

Algorithms.Quicksort(numberlist,0,numberlist.Count-1);


//Algorithms.Selectionsort(numberlist);


timer.Stop();

Console.WriteLine("Execution Time: {0} ms", timer.ElapsedMilliseconds);


timer.Start();

//Algorithms.Insertionsort(numberlist);

timer.Stop();



Console.WriteLine("Execution Time: {0} ms", timer.ElapsedMilliseconds);



/*
foreach (int number in numberlist)
{
    Console.WriteLine(number);
}
*/


