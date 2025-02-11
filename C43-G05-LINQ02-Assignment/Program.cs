namespace C43_G05_LINQ02_Assignment
{
    internal class Program
    {

        #region LINQ - Restriction Operators


        //static void Main(string[] args)
        //{
        //    var outOfStockProducts = FindOutOfStockProducts();
        //    var inStockExpensiveProducts = FindInStockExpensiveProducts();
        //    var shortNamedDigits = FindShortNamedDigits();

        //    // results
        //    Console.WriteLine("Out of Stock Products:");
        //    outOfStockProducts.ForEach(p => Console.WriteLine(p));

        //    Console.WriteLine("\nIn Stock and Expensive Products:");
        //    inStockExpensiveProducts.ForEach(p => Console.WriteLine(p));

        //    Console.WriteLine("\nDigits with Shorter Names than Values:");
        //    shortNamedDigits.ForEach(d => Console.WriteLine(d));
        //}

        //static List<Product> FindOutOfStockProducts()
        //{
        //    return ListGenerators.ProductList.Where(p => p.UnitsInStock == 0).ToList();
        //}

        //static List<Product> FindInStockExpensiveProducts()
        //{
        //    return ListGenerators.ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M).ToList();
        //}

        //static List<string> FindShortNamedDigits()
        //{
        //    string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        //    return digits.Where((d, index) => d.Length < index).ToList();
        //}

        #endregion

        #region  Element Operators
        //static void Main(string[] args)
        //{
        //    var firstOutOfStockProduct = GetFirstOutOfStockProduct();
        //    var firstExpensiveProduct = GetFirstExpensiveProduct();
        //    var secondNumberGreaterThanFive = GetSecondNumberGreaterThanFive();

        //    // results
        //    Console.WriteLine("First Out of Stock Product:");
        //    Console.WriteLine(firstOutOfStockProduct);

        //    Console.WriteLine("\nFirst Product with Price > 1000:");
        //    Console.WriteLine(firstExpensiveProduct);

        //    Console.WriteLine("\nSecond Number Greater Than 5:");
        //    Console.WriteLine(secondNumberGreaterThanFive);
        //}

        //static Product GetFirstOutOfStockProduct()
        //{
        //    return ListGenerators.ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
        //}

        //static Product GetFirstExpensiveProduct()
        //{
        //    return ListGenerators.ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
        //}

        //static int GetSecondNumberGreaterThanFive()
        //{
        //    int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //    return arr.Where(n => n > 5).Skip(1).FirstOrDefault();
        //}

        #endregion

        #region LINQ - Aggregate Operators

        //static void Main(string[] args)
        //{
        //    var oddNumbersCount = CountOddNumbers();
        //    var customerOrderCounts = GetCustomerOrderCounts();
        //    var categoryProductCounts = GetCategoryProductCounts();
        //    var totalNumbers = GetTotalNumbers();
        //    var totalCharacters = GetTotalCharacters();
        //    var shortestWordLength = GetShortestWordLength();
        //    var longestWordLength = GetLongestWordLength();
        //    var averageWordLength = GetAverageWordLength();
        //    var totalUnitsInStockByCategory = GetTotalUnitsInStockByCategory();
        //    var cheapestPriceByCategory = GetCheapestPriceByCategory();
        //    var productsWithCheapestPriceByCategory = GetProductsWithCheapestPriceByCategory();
        //    var mostExpensivePriceByCategory = GetMostExpensivePriceByCategory();
        //    var productsWithMostExpensivePriceByCategory = GetProductsWithMostExpensivePriceByCategory();
        //    var averagePriceByCategory = GetAveragePriceByCategory();

        //    // results
        //    Console.WriteLine($"Odd Numbers Count: {oddNumbersCount}");
        //    Console.WriteLine("\nCustomer Order Counts:");
        //    customerOrderCounts.ForEach(c => Console.WriteLine($"{c.CustomerName}: {c.OrderCount}"));

        //    Console.WriteLine("\nCategory Product Counts:");
        //    categoryProductCounts.ForEach(c => Console.WriteLine($"{c.Category}: {c.ProductCount}"));

        //    Console.WriteLine($"\nTotal Numbers: {totalNumbers}");
        //    Console.WriteLine($"\nTotal Characters: {totalCharacters}");
        //    Console.WriteLine($"\nShortest Word Length: {shortestWordLength}");
        //    Console.WriteLine($"\nLongest Word Length: {longestWordLength}");
        //    Console.WriteLine($"\nAverage Word Length: {averageWordLength}");

        //    Console.WriteLine("\nTotal Units In Stock By Category:");
        //    totalUnitsInStockByCategory.ForEach(c => Console.WriteLine($"{c.Category}: {c.TotalUnitsInStock}"));

        //    Console.WriteLine("\nCheapest Price By Category:");
        //    cheapestPriceByCategory.ForEach(c => Console.WriteLine($"{c.Category}: {c.CheapestPrice}"));

        //    Console.WriteLine("\nProducts With Cheapest Price By Category:");
        //    productsWithCheapestPriceByCategory.ForEach(c => Console.WriteLine($"{c.Category}: {c.ProductName}"));

        //    Console.WriteLine("\nMost Expensive Price By Category:");
        //    mostExpensivePriceByCategory.ForEach(c => Console.WriteLine($"{c.Category}: {c.MostExpensivePrice}"));

        //    Console.WriteLine("\nProducts With Most Expensive Price By Category:");
        //    productsWithMostExpensivePriceByCategory.ForEach(c => Console.WriteLine($"{c.Category}: {c.ProductName}"));

        //    Console.WriteLine("\nAverage Price By Category:");
        //    averagePriceByCategory.ForEach(c => Console.WriteLine($"{c.Category}: {c.AveragePrice}"));
        //}

        //static int CountOddNumbers()
        //{
        //    int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //    return arr.Count(n => n % 2 != 0);
        //}

        //static List<(string CustomerName, int OrderCount)> GetCustomerOrderCounts()
        //{
        //    return ListGenerators.CustomerList
        //        .Select(c => (c.CustomerName, c.Orders.Length))
        //        .ToList();
        //}

        //static List<(string Category, int ProductCount)> GetCategoryProductCounts()
        //{
        //    return ListGenerators.ProductList
        //        .GroupBy(p => p.Category)
        //        .Select(g => (g.Key, g.Count()))
        //        .ToList();
        //}

        //static int GetTotalNumbers()
        //{
        //    int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //    return arr.Sum();
        //}

        //static int GetTotalCharacters()
        //{
        //    var words = System.IO.File.ReadAllLines("dictionary_english.txt");
        //    return words.Sum(w => w.Length);
        //}

        //static int GetShortestWordLength()
        //{
        //    var words = System.IO.File.ReadAllLines("dictionary_english.txt");
        //    return words.Min(w => w.Length);
        //}

        //static int GetLongestWordLength()
        //{
        //    var words = System.IO.File.ReadAllLines("dictionary_english.txt");
        //    return words.Max(w => w.Length);
        //}

        //static double GetAverageWordLength()
        //{
        //    var words = System.IO.File.ReadAllLines("dictionary_english.txt");
        //    return words.Average(w => w.Length);
        //}

        //static List<(string Category, int TotalUnitsInStock)> GetTotalUnitsInStockByCategory()
        //{
        //    return ListGenerators.ProductList
        //        .GroupBy(p => p.Category)
        //        .Select(g => (g.Key, g.Sum(p => p.UnitsInStock)))
        //        .ToList();
        //}

        //static List<(string Category, decimal CheapestPrice)> GetCheapestPriceByCategory()
        //{
        //    return ListGenerators.ProductList
        //        .GroupBy(p => p.Category)
        //        .Select(g => (g.Key, g.Min(p => p.UnitPrice)))
        //        .ToList();
        //}

        //static List<(string Category, string ProductName)> GetProductsWithCheapestPriceByCategory()
        //{
        //    return ListGenerators.ProductList
        //        .GroupBy(p => p.Category)
        //        .Select(g => (g.Key, g.OrderBy(p => p.UnitPrice).First().ProductName))
        //        .ToList();
        //}

        //static List<(string Category, decimal MostExpensivePrice)> GetMostExpensivePriceByCategory()
        //{
        //    return ListGenerators.ProductList
        //        .GroupBy(p => p.Category)
        //        .Select(g => (g.Key, g.Max(p => p.UnitPrice)))
        //        .ToList();
        //}

        //static List<(string Category, string ProductName)> GetProductsWithMostExpensivePriceByCategory()
        //{
        //    return ListGenerators.ProductList
        //        .GroupBy(p => p.Category)
        //        .Select(g => (g.Key, g.OrderByDescending(p => p.UnitPrice).First().ProductName))
        //        .ToList();
        //}

        //static List<(string Category, decimal AveragePrice)> GetAveragePriceByCategory()
        //{
        //    return ListGenerators.ProductList
        //        .GroupBy(p => p.Category)
        //        .Select(g => (g.Key, g.Average(p => p.UnitPrice)))
        //        .ToList();
        //}

        #endregion

        #region LINQ - Ordering Operators

        //static void Main(string[] args)
        //{
        //    var sortedProductsByName = SortProductsByName();
        //    var caseInsensitiveSortedWords = SortWordsCaseInsensitive(new string[] { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" });
        //    var sortedProductsByStock = SortProductsByStock();
        //    var sortedDigits = SortDigits(new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" });
        //    var sortedWordsByLengthThenCaseInsensitive = SortWordsByLengthThenCaseInsensitive(new string[] { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" });
        //    var sortedProductsByCategoryThenPrice = SortProductsByCategoryThenPrice();
        //    var sortedWordsByLengthThenCaseInsensitiveDesc = SortWordsByLengthThenCaseInsensitiveDesc(new string[] { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" });
        //    var reversedDigitsWithSecondLetterI = ReverseDigitsWithSecondLetterI(new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" });

        //    // results
        //    Console.WriteLine("Sorted Products By Name:");
        //    sortedProductsByName.ForEach(p => Console.WriteLine(p));

        //    Console.WriteLine("\nCase Insensitive Sorted Words:");
        //    caseInsensitiveSortedWords.ForEach(w => Console.WriteLine(w));

        //    Console.WriteLine("\nSorted Products By Stock:");
        //    sortedProductsByStock.ForEach(p => Console.WriteLine(p));

        //    Console.WriteLine("\nSorted Digits:");
        //    sortedDigits.ForEach(d => Console.WriteLine(d));

        //    Console.WriteLine("\nSorted Words By Length Then Case Insensitive:");
        //    sortedWordsByLengthThenCaseInsensitive.ForEach(w => Console.WriteLine(w));

        //    Console.WriteLine("\nSorted Products By Category Then Price:");
        //    sortedProductsByCategoryThenPrice.ForEach(p => Console.WriteLine(p));

        //    Console.WriteLine("\nSorted Words By Length Then Case Insensitive Desc:");
        //    sortedWordsByLengthThenCaseInsensitiveDesc.ForEach(w => Console.WriteLine(w));

        //    Console.WriteLine("\nReversed Digits With Second Letter 'i':");
        //    reversedDigitsWithSecondLetterI.ForEach(d => Console.WriteLine(d));
        //}

        //static List<Product> SortProductsByName()
        //{
        //    return ListGenerators.ProductList.OrderBy(p => p.ProductName).ToList();
        //}

        //static List<string> SortWordsCaseInsensitive(string[] words)
        //{
        //    return words.OrderBy(w => w, StringComparer.OrdinalIgnoreCase).ToList();
        //}

        //static List<Product> SortProductsByStock()
        //{
        //    return ListGenerators.ProductList.OrderByDescending(p => p.UnitsInStock).ToList();
        //}

        //static List<string> SortDigits(string[] digits)
        //{
        //    return digits.OrderBy(d => d.Length).ThenBy(d => d).ToList();
        //}

        //static List<string> SortWordsByLengthThenCaseInsensitive(string[] words)
        //{
        //    return words.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase).ToList();
        //}

        //static List<Product> SortProductsByCategoryThenPrice()
        //{
        //    return ListGenerators.ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice).ToList();
        //}

        //static List<string> SortWordsByLengthThenCaseInsensitiveDesc(string[] words)
        //{
        //    return words.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase).ToList();
        //}

        //static List<string> ReverseDigitsWithSecondLetterI(string[] digits)
        //{
        //    return digits.Where(d => d.Length > 1 && d[1] == 'i').Reverse().ToList();
        //}

        #endregion

        #region LINQ - Transformation Operators

        //static void Main(string[] args)
        //{
        //    var productNames = GetProductNames();
        //    var upperLowerWords = GetUpperLowerWords(new string[] { "aPPLE", "BlUeBeRrY", "cHeRry" });
        //    var productProperties = GetProductProperties();
        //    var matchingPositions = GetMatchingPositions(new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 });
        //    var numberPairs = GetNumberPairs(new int[] { 0, 2, 4, 5, 6, 8, 9 }, new int[] { 1, 3, 5, 7, 8 });
        //    var ordersLessThan500 = GetOrdersLessThan500();
        //    var ordersFrom1998 = GetOrdersFrom1998();

        //    // results
        //    Console.WriteLine("Product Names:");
        //    productNames.ForEach(p => Console.WriteLine(p));

        //    Console.WriteLine("\nUpper and Lower Case Words:");
        //    upperLowerWords.ForEach(w => Console.WriteLine($"Upper: {w.Upper}, Lower: {w.Lower}"));

        //    Console.WriteLine("\nProduct Properties:");
        //    productProperties.ForEach(p => Console.WriteLine($"Name: {p.Name}, Price: {p.Price}, Category: {p.Category}"));

        //    Console.WriteLine("\nMatching Positions:");
        //    matchingPositions.ForEach(m => Console.WriteLine(m));

        //    Console.WriteLine("\nNumber Pairs:");
        //    numberPairs.ForEach(p => Console.WriteLine($"A: {p.A}, B: {p.B}"));

        //    Console.WriteLine("\nOrders Less Than 500:");
        //    ordersLessThan500.ForEach(o => Console.WriteLine(o));

        //    Console.WriteLine("\nOrders From 1998:");
        //    ordersFrom1998.ForEach(o => Console.WriteLine(o));
        //}

        //static List<string> GetProductNames()
        //{
        //    return ListGenerators.ProductList.Select(p => p.ProductName).ToList();
        //}

        //static List<(string Upper, string Lower)> GetUpperLowerWords(string[] words)
        //{
        //    return words.Select(w => (Upper: w.ToUpper(), Lower: w.ToLower())).ToList();
        //}

        //static List<(string Name, decimal Price, string Category)> GetProductProperties()
        //{
        //    return ListGenerators.ProductList.Select(p => (Name: p.ProductName, Price: p.UnitPrice, Category: p.Category)).ToList();
        //}

        //static List<int> GetMatchingPositions(int[] arr)
        //{
        //    return arr.Where((n, index) => n == index).ToList();
        //}

        //static List<(int A, int B)> GetNumberPairs(int[] numbersA, int[] numbersB)
        //{
        //    return (from a in numbersA
        //            from b in numbersB
        //            where a < b
        //            select (A: a, B: b)).ToList();
        //}

        //static List<Order> GetOrdersLessThan500()
        //{
        //    return ListGenerators.CustomerList.SelectMany(c => c.Orders).Where(o => o.Total < 500).ToList();
        //}

        //static List<Order> GetOrdersFrom1998()
        //{
        //    return ListGenerators.CustomerList.SelectMany(c => c.Orders).Where(o => o.OrderDate.Year >= 1998).ToList();
        //}

        #endregion

        #region LINQ - Set Operators

        //static void Main(string[] args)
        //{
        //    var uniqueCategories = GetUniqueCategories();
        //    var uniqueFirstLetters = GetUniqueFirstLetters();
        //    var commonFirstLetters = GetCommonFirstLetters();
        //    var productFirstLettersNotInCustomers = GetProductFirstLettersNotInCustomers();
        //    var lastThreeCharacters = GetLastThreeCharacters();

        //    // results
        //    Console.WriteLine("Unique Categories:");
        //    uniqueCategories.ForEach(c => Console.WriteLine(c));

        //    Console.WriteLine("\nUnique First Letters:");
        //    uniqueFirstLetters.ForEach(l => Console.WriteLine(l));

        //    Console.WriteLine("\nCommon First Letters:");
        //    commonFirstLetters.ForEach(l => Console.WriteLine(l));

        //    Console.WriteLine("\nProduct First Letters Not In Customers:");
        //    productFirstLettersNotInCustomers.ForEach(l => Console.WriteLine(l));

        //    Console.WriteLine("\nLast Three Characters:");
        //    lastThreeCharacters.ForEach(c => Console.WriteLine(c));
        //}

        //static List<string> GetUniqueCategories()
        //{
        //    return ListGenerators.ProductList.Select(p => p.Category).Distinct().ToList();
        //}

        //static List<char> GetUniqueFirstLetters()
        //{
        //    var productFirstLetters = ListGenerators.ProductList.Select(p => p.ProductName[0]);
        //    var customerFirstLetters = ListGenerators.CustomerList.Select(c => c.CustomerName[0]);
        //    return productFirstLetters.Union(customerFirstLetters).Distinct().ToList();
        //}

        //static List<char> GetCommonFirstLetters()
        //{
        //    var productFirstLetters = ListGenerators.ProductList.Select(p => p.ProductName[0]);
        //    var customerFirstLetters = ListGenerators.CustomerList.Select(c => c.CustomerName[0]);
        //    return productFirstLetters.Intersect(customerFirstLetters).ToList();
        //}

        //static List<char> GetProductFirstLettersNotInCustomers()
        //{
        //    var productFirstLetters = ListGenerators.ProductList.Select(p => p.ProductName[0]);
        //    var customerFirstLetters = ListGenerators.CustomerList.Select(c => c.CustomerName[0]);
        //    return productFirstLetters.Except(customerFirstLetters).ToList();
        //}

        //static List<string> GetLastThreeCharacters()
        //{
        //    var productLastThree = ListGenerators.ProductList.Select(p => p.ProductName.Length >= 3 ? p.ProductName.Substring(p.ProductName.Length - 3) : p.ProductName);
        //    var customerLastThree = ListGenerators.CustomerList.Select(c => c.CustomerName.Length >= 3 ? c.CustomerName.Substring(c.CustomerName.Length - 3) : c.CustomerName);
        //    return productLastThree.Concat(customerLastThree).ToList();
        //}

        #endregion

        #region LINQ - Partitioning Operators

        //static void Main(string[] args)
        //{
        //    var first3OrdersFromWashington = GetFirst3OrdersFromWashington();
        //    var allButFirst2OrdersFromWashington = GetAllButFirst2OrdersFromWashington();
        //    var elementsUntilLessThanPosition = GetElementsUntilLessThanPosition(new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 });
        //    var elementsFromFirstDivisibleBy3 = GetElementsFromFirstDivisibleBy3(new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 });
        //    var elementsFromFirstLessThanPosition = GetElementsFromFirstLessThanPosition(new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 });

        //    // results
        //    Console.WriteLine("First 3 Orders From Washington:");
        //    first3OrdersFromWashington.ForEach(o => Console.WriteLine(o));

        //    Console.WriteLine("\nAll But First 2 Orders From Washington:");
        //    allButFirst2OrdersFromWashington.ForEach(o => Console.WriteLine(o));

        //    Console.WriteLine("\nElements Until Less Than Position:");
        //    elementsUntilLessThanPosition.ForEach(e => Console.WriteLine(e));

        //    Console.WriteLine("\nElements From First Divisible By 3:");
        //    elementsFromFirstDivisibleBy3.ForEach(e => Console.WriteLine(e));

        //    Console.WriteLine("\nElements From First Less Than Position:");
        //    elementsFromFirstLessThanPosition.ForEach(e => Console.WriteLine(e));
        //}

        //static List<Order> GetFirst3OrdersFromWashington()
        //{
        //    return ListGenerators.CustomerList
        //        .Where(c => c.Region == "WA")
        //        .SelectMany(c => c.Orders)
        //        .Take(3)
        //        .ToList();
        //}

        //static List<Order> GetAllButFirst2OrdersFromWashington()
        //{
        //    return ListGenerators.CustomerList
        //        .Where(c => c.Region == "WA")
        //        .SelectMany(c => c.Orders)
        //        .Skip(2)
        //        .ToList();
        //}

        //static List<int> GetElementsUntilLessThanPosition(int[] numbers)
        //{
        //    return numbers.TakeWhile((n, index) => n >= index).ToList();
        //}

        //static List<int> GetElementsFromFirstDivisibleBy3(int[] numbers)
        //{
        //    return numbers.SkipWhile(n => n % 3 != 0).ToList();
        //}

        //static List<int> GetElementsFromFirstLessThanPosition(int[] numbers)
        //{
        //    return numbers.SkipWhile((n, index) => n >= index).ToList();
        //}

        #endregion

        #region LINQ - Quantifiers

        //static void Main(string[] args)
        //{
        //    var containsEi = AnyWordContainsEi();
        //    var categoriesWithOutOfStockProducts = GetCategoriesWithOutOfStockProducts();
        //    var categoriesWithAllProductsInStock = GetCategoriesWithAllProductsInStock();

        //    // results
        //    Console.WriteLine($"Any word contains 'ei': {containsEi}");

        //    Console.WriteLine("\nCategories with at least one out of stock product:");
        //    foreach (var category in categoriesWithOutOfStockProducts)
        //    {
        //        Console.WriteLine(category.Key);
        //        foreach (var product in category)
        //        {
        //            Console.WriteLine($"  {product}");
        //        }
        //    }

        //    Console.WriteLine("\nCategories with all products in stock:");
        //    foreach (var category in categoriesWithAllProductsInStock)
        //    {
        //        Console.WriteLine(category.Key);
        //        foreach (var product in category)
        //        {
        //            Console.WriteLine($"  {product}");
        //        }
        //    }
        //}

        //static bool AnyWordContainsEi()
        //{
        //    var words = System.IO.File.ReadAllLines("dictionary_english.txt");
        //    return words.Any(w => w.Contains("ei"));
        //}

        //static IEnumerable<IGrouping<string, Product>> GetCategoriesWithOutOfStockProducts()
        //{
        //    return ListGenerators.ProductList
        //        .Where(p => p.UnitsInStock == 0)
        //        .GroupBy(p => p.Category);
        //}

        //static IEnumerable<IGrouping<string, Product>> GetCategoriesWithAllProductsInStock()
        //{
        //    return ListGenerators.ProductList
        //        .GroupBy(p => p.Category)
        //        .Where(g => g.All(p => p.UnitsInStock > 0));
        //}

        #endregion

        #region MyRegion

        //public static void Main(string[] args)
        //{
        //    List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        //    var numberGroups = numbers.GroupBy(n => n % 5);

        //    foreach (var group in numberGroups)
        //    {
        //        Console.WriteLine($"Remainder: {group.Key}");
        //        foreach (var number in group)
        //        {
        //            Console.Write($"{number} ");
        //        }
        //        Console.WriteLine();
        //    }


        //    try
        //    {
        //        var words = File.ReadAllLines("dictionary_english.txt");  

        //        var wordGroups = words.GroupBy(w => w[0]);

        //        foreach (var group in wordGroups)
        //        {
        //            Console.WriteLine($"Starting Letter: {group.Key}");
        //            Console.WriteLine($"Number of words: {group.Count()}");

        //            Console.WriteLine();
        //        }
        //    }
        //    catch (FileNotFoundException)
        //    {
        //        Console.WriteLine("dictionary_english.txt not found.");
        //    }
        //    catch (IndexOutOfRangeException)
        //    {
        //        Console.WriteLine("The file has empty lines."); 
        //    }


        //    string[] arr = { "from", "salt", "earn", " last", "near", "form" };

        //    var anagramGroups = arr.GroupBy(w => new string(w.Trim().OrderBy(c => c).ToArray()));  

        //    foreach (var group in anagramGroups)
        //    {
        //        Console.WriteLine($"Anagram Group: {group.Key}");
        //        foreach (var word in group)
        //        {
        //            Console.Write($"{word} ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
        #endregion
    }
}
