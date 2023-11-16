Console.WriteLine("Hello, World!");
var leetEasy = new LeetEasy();
var stringManager = new StringManager();
var arrayManager = new ArrayManager();


leetEasy.Works();
// stringManager.Works();
// arrayManager.Works();

// var result = stringManager.Interpret("(al)G(al)()()G");
// var optimized =  stringManager.InterpretOptimal("(al)G(al)()()G");

// var result = stringManager.EqualFrequency("aazz");

// var result = stringManager.TypedOutString("abb#c", "#abcd########abc");

stringManager.TwoPointerWeight(15, new List<int> { 1, 2, 3, 8, 9 });

var nums = new int[] { 1, 2, 3, 1, 1, 3 };
var result = arrayManager.NumIdenticalPairs(nums);

string stop = "stop";
