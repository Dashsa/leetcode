Console.WriteLine("Hello, World!");
var leetEasy = new LeetEasy();
var stringManager = new StringManager();
var arrayManager = new ArrayManager();
var AlgoManager = new AlgoManager();

leetEasy.Works();
// stringManager.Works();
// arrayManager.Works();

// var result = stringManager.Interpret("(al)G(al)()()G");
// var optimized =  stringManager.InterpretOptimal("(al)G(al)()()G");

// var result = stringManager.EqualFrequency("aazz");

// var result = stringManager.TypedOutString("abb#c", "#abcd########abc");

stringManager.TwoPointerWeight(15, new List<int> { 1, 2, 3, 8, 9 });

// var nums = new int[] { 1, 2, 3, 1, 1, 3 };
// var result = arrayManager.NumIdenticalPairs(nums);

// var searchInput = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// var isFound = AlgoManager.BinarySearch(searchInput, 8);

var input = new int[] { 3, 1, 7, 2, 9 };// { 3, 2, 2, 3 };// {0,1,2,2,3,0,4,2 };
// var result = arrayManager.RemoveElement(input, 1);
var result = arrayManager.TwoSum(input, 11);
string stop = "stop";
