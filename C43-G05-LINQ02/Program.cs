using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C43_G05_LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // LINQ is a powerful feature in .NET
            // that allows you to query and manipulate data from different sources
            // using a consistent syntax.It was introduced in C# 3.0 and provides
            // a unified way to work with arrays, lists, XML, databases, and more.


            // -Query Syntax vs Method Syntax
            //// Query syntax (SQL-like)
            //var result = from item in collection
            //where item.Property > 10
            //select item;

            //// Method syntax (Lambda expressions)
            //var result = collection.Where(item => item.Property > 10);


            // -Common LINQ Operations:
            //var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //// Filtering
            //var evenNumbers = numbers.Where(n => n % 2 == 0);

            //// Ordering
            //var ordered = numbers.OrderByDescending(n => n);

            //// Projection
            //var doubled = numbers.Select(n => n * 2);

            //// Aggregation
            //var sum = numbers.Sum();
            //var average = numbers.Average();

            //// Element operations
            //var firstEven = numbers.First(n => n % 2 == 0);
            //var lastOdd = numbers.Last(n => n % 2 != 0);


            // Deferred Execution(Lazy Evaluation): These operations don't actually produce results until you explicitly iterate over the query's results. They build up a query definition but don't process the data source until it's needed. This is more efficient, especially with large datasets, as it avoids unnecessary processing.

            //Immediate Execution(Eager Evaluation): These operations produce results immediately.They iterate over the source sequence and return a new value or perform a side effect.



            //+++++++++++++++++++  breakdown of common LINQ operations and their execution categories:


            //Filtering:

            //Where()(Deferred): Filters a sequence based on a predicate.

            //Take()(Deferred): Returns a specified number of contiguous elements from the start of a sequence.

            //Skip()(Deferred): Bypasses a specified number of elements in a sequence and then returns the remaining elements.

            //TakeWhile()(Deferred): Returns elements from a sequence as long as a specified condition is true, and then skips the remaining elements.

            //SkipWhile()(Deferred): Bypasses elements in a sequence as long as a specified condition is true and then returns the remaining elements.

            //Distinct()(Deferred): Returns distinct elements from a sequence.

            //+++++++++++++++++++

            //Projection(Transforming):

            //Select()(Deferred): Projects each element of a sequence into a new form.

            //SelectMany()(Deferred): Projects each element of a sequence to an IEnumerable<T> and flattens the resulting sequences into one sequence.

            //+++++++++++++++++++

            //Joining:

            //Join()(Deferred): Correlates the elements of two sequences based on matching keys.

            //GroupJoin()(Deferred): Correlates the elements of two sequences based on equality of keys and groups the results.

            //Zip()(Deferred): Combines two sequences by merging the elements based on their positions.

            //+++++++++++++++++++

            //Ordering:

            //OrderBy()(Deferred): Sorts the elements of a sequence in ascending order.

            //OrderByDescending()(Deferred): Sorts the elements of a sequence in descending order.

            //ThenBy()(Deferred): Performs a subsequent ordering of the elements in a sequence in ascending order.

            //ThenByDescending()(Deferred): Performs a subsequent ordering of the elements in a sequence in descending order.

            //Reverse()(Deferred): Reverses the order of the elements in a sequence.

            //+++++++++++++++++++

            //Grouping:

            //GroupBy()(Deferred): Groups the elements of a sequence based on a specified key selector function.

            //+++++++++++++++++++

            //Set Operations:

            //Concat()(Deferred): Concatenates two sequences.
            //Union()(Deferred): Produces the set union of two sequences.

            //Intersect()(Deferred): Produces the set intersection of two sequences.

            //Except()(Deferred): Produces the set difference of two sequences.

            //+++++++++++++++++++

            //Element Operations:

            //First()(Immediate): Returns the first element of a sequence.Throws an exception if the sequence is empty.

            //FirstOrDefault() (Immediate): Returns the first element of a sequence, or a default value if the sequence is empty.

            //Last() (Immediate): Returns the last element of a sequence.Throws an exception if the sequence is empty.

            //LastOrDefault() (Immediate): Returns the last element of a sequence, or a default value if the sequence is empty.

            //Single() (Immediate): Returns the only element of a sequence, and throws an exception if there is not exactly one element in the sequence.

            //SingleOrDefault()(Immediate): Returns the only element of a sequence, or a default value if the sequence is empty; this method throws an exception if there is more than one element in the sequence.

            //ElementAt()(Immediate): Returns the element at a specified index in a sequence.

            //ElementAtOrDefault()(Immediate): Returns the element at a specified index in a sequence or a default value if the index is out of range.

            //DefaultIfEmpty()(Deferred): Returns the elements of the specified sequence or the type parameter's default value in a singleton collection if the sequence is empty.

            //+++++++++++++++++++

            //Quantifiers:

            //Any()(Immediate): Determines whether any element of a sequence satisfies a condition.

            //All()(Immediate): Determines whether all elements of a sequence satisfy a condition.

            //Contains()(Immediate): Determines whether a sequence contains a specified element.

            //+++++++++++++++++++

            //Aggregation:

            //Count()(Immediate): Returns the number of elements in a sequence.

            //LongCount()(Immediate): Returns the number of elements in a sequence as a long.

            //Sum()(Immediate): Computes the sum of a sequence of numeric values.

            //Min()(Immediate): Returns the minimum value in a sequence of values.

            //Max()(Immediate): Returns the maximum value in a sequence of values.

            //Average()(Immediate): Computes the average of a sequence of numeric values.

            //Aggregate()(Immediate): Applies an accumulator function over a sequence.

            //+++++++++++++++++++

            //Conversion:

            //ToArray()(Immediate): Creates an array from a sequence.

            //ToList()(Immediate): Creates a List<T> from a sequence.

            //ToDictionary()(Immediate): Creates a Dictionary<TKey, TValue> from a sequence.

            //ToLookup()(Immediate): Creates a Lookup<TKey, TElement> from a sequence.

            //AsEnumerable()(Deferred): Returns the input typed as IEnumerable<T>.Useful for bringing extension methods back into scope.

            //Cast()(Deferred): Casts the elements of an IEnumerable to the specified type.










            // ++++++++++++++++++++++++++++++++++++++++
            // stack of session progress 
            // ++++++++++++++++++++++++++++++++++++++++

            //10- 2:25:00 ended Zipping operators category - started at 2:21:25
            //9- 2:20:20 ended Quantifiers operators category - started at 2:07:05
            //8- 2:12:30 ended Set operators category - started at 2:07:05
            //7- 2:06:50 ended Generation operators category - started at 2:00:00
            //6- 2:01:32 ended Casting operators category - started at 1:56:05
            //5- 1:55:40 ended Aggregate operators category - started at 1:34:04
            //4- 1:32:50 ended Elements operators category - started at 1:08:03
            //3- 1:07:48 ended ordering operators category - started at 54:05
            //2- 53:30 ended transforamtion operators category - started at 33:30
            //1- 31:35 ended filteration operators category - started at 13:43
            // - 13:40 ended revision of session 1 linq
        }
    }
}
