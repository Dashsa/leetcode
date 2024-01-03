Console.WriteLine ("Hello, World!");
var leetEasy = new LeetEasy ();
var stringManager = new StringManager ();
var arrayManager = new ArrayManager ();
var AlgoManager = new AlgoManager ();
var nodeManager = new NodeManager ();

leetEasy.Works ();
// stringManager.Works();
// arrayManager.Works();

// var result = stringManager.Interpret("(al)G(al)()()G");
// var optimized =  stringManager.InterpretOptimal("(al)G(al)()()G");

// var result = stringManager.EqualFrequency("aazz");

// var result = stringManager.TypedOutString("abb#c", "#abcd########abc");

stringManager.TwoPointerWeight (15, new List<int> { 1, 2, 3, 8, 9 });

// var nums = new int[] { 1, 2, 3, 1, 1, 3 };
// var result = arrayManager.NumIdenticalPairs(nums);

// var searchInput = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// var isFound = AlgoManager.BinarySearch(searchInput, 8);

//var input = new int[] { 3, 1, 7, 2, 9 };// { 3, 2, 2, 3 };// {0,1,2,2,3,0,4,2 };
// var result = arrayManager.RemoveElement(input, 1);
//var result = arrayManager.TwoSum(input, 11);

// var input = new int[] { 9};
// var result = arrayManager.PlusOne(input);

//var foo = nodeManager.TestTrees();

// var input = new string[] { "leet", "code" };
// var result = arrayManager.FindWordsContaining(input, 'e');

// var input = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
// var result = arrayManager.RemoveDuplicates(input);
// var input = new int[] { 1,2,3,1 };
// var result = leetEasy.ContainsNearbyDuplicate(input, 3);

// var result = leetEasy.BuyChoco(input, 3);

// var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
// var m = 3;
// var nums2 = new int[] { 2, 5, 6 };
// var n = 3;
// arrayManager.Merge (nums1, m, nums2, n);

var input = new int[] { 2, 1, 4 };
var result = arrayManager.MaxProfit (input);
string stop = "stop";