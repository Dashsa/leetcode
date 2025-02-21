using static LinkedListManager;

Console.WriteLine("Hello, World!");
var leetEasy = new LeetEasy();
var stringManager = new StringManager();
var arrayManager = new ArrayManager();
var AlgoManager = new AlgoManager();
var nodeManager = new NodeManager();
var resursionManager = new RecursionManager();
var linkedListManager = new LinkedListManager();


int[][] intervals = new[] { new[] { 1, 3 }, new[] { 2, 6 }, new[] { 8, 10 }, new[] { 15, 18 } };



// foreach (int[] pair in data) {
//     foreach (int number in pair) {
//         Console.Write(number + " ");
//     }
//     Console.WriteLine();
// }

var goo = new List<int> { 25, 34, 1, 5, 6, 8, 10 };
var pQueue = new PriorityQueue<int, int>();
foreach (var i in goo)
{
    pQueue.Enqueue(i, i);
}




var inputInt = 123;
var respo = leetEasy.Reverse(inputInt);


var s = "rwohu";
var t = "rwuoh";

var res = 0;

for (var i = 0; i < s.Length; i++)
{
    var sVal = s.IndexOf(s[i]);
    var tVal = t.IndexOf(s[i]);

    res += Math.Abs(sVal - tVal);
    //sVal += (int)s[i];
    //tVal += (int)t[i];

    //if (sVal > tVal)
    //{
    //    res += sVal - tVal;
    //}
    //else if (sVal < tVal)
    //{
    //    res += tVal - sVal;
    //}


}



var foo = Math.Abs(res);

string sss = "abc";



//while(rr > 0){

//var temp = rr % 10;
//rr = rr / 10;
//s.Enqueue(temp);
//}

//while(s.Count > 0){
//    Console.WriteLine($"num: {s.Dequeue()}");
//}

//var inputsss = " sa   ";
//var sfixed = inputsss.Replace("\n", "").Replace("\r", "").Trim();

//string sss = "stop";


//var k = 2;
//var nums = new int[] { 1, 2, 3, 6, 2, 4, 9, 8 };

//var sorted = new List<int>(nums);
//sorted.Sort();


//var result = new int[k];
//foreach (int i in nums)
//{

//    if (i > result[0])
//    {
//        if(i > result[1]){
//            var t = result[1];
//            result[1] = i;
//            result[0] = t;
//        }else{
//            result[0] = i;
//        }
//    }
//}

//string g = "sss";



// Input: n = 19
// Output: true
// Explanation:
// 1^2 + 9^2 = 82
// 8^2 + 2^2 = 68
// 6^2 + 8^2 = 100
// 1^2 + 0^2 + 0^2 = 1




// int number = 19;

// while (number > 0)
// {
//   var tempNum  = number % 10;


//   number = number / 10;
// }



//var inpu = "A man, a plan, a canal: Panama";
//var fff = stringManager.IsPalindrome(inpu);

//var input1 = new ListNode(1, new ListNode(2, new ListNode(4)));
//var input2 = new ListNode(1, new ListNode(3, new ListNode(4)));
//var response = linkedListManager.MergeTwoLists(input1, input2);


var input = new int[] { 1, 2, 4, 6 };
var n = input.Length;
var prefix = new int[n];
var suffix = new int[n];
var output = new int[n];
prefix[0] = 1;
suffix[n - 1] = 1;



for (var i = 1; i < n; i++)
{
    prefix[i] = prefix[i - 1] * input[i - 1];
}

for (var i = n - 2; i > 0; i--)
{
    suffix[i] = suffix[i + 1] * input[i + 1];
}

for (var i = 0; i < n; i++)
{
    output[i] = prefix[i] + suffix[i];
}

string stops = "stop";

//leetEasy.Works();
// stringManager.Works();
// arrayManager.Works();

// var result = stringManager.Interpret("(al)G(al)()()G");
// var optimized =  stringManager.InterpretOptimal("(al)G(al)()()G");

// var result = stringManager.EqualFrequency("aazz");

// var result = stringManager.TypedOutString("abb#c", "#abcd########abc");

// stringManager.TwoPointerWeight(15, new List<int> { 1, 2, 3, 8, 9 });

// var nums = new int[] { 1, 2, 3, 1, 1, 3 };
// var nums = new int[] { 1, 1, 1, 1 };
//   var resulwwt = arrayManager.NumIdenticalPairs(nums);

// var searchInput = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// var isFound = AlgoManager.BinarySearch(searchInput, 8);

// var input = new int[] { 3, 3 };// { 3, 2, 2, 3 };// {0,1,2,2,3,0,4,2 };
// var result = arrayManager.RemoveElement(input, 5);
//var result = arrayManager.TwoSum(input, 11);

// var input = new int[] { 3, 1, 7, 2 };
// var result = arrayManager.PlusOne(input);

//var foo = nodeManager.TestTrees();

// var input = new string[] { "leet", "code" };
// var result = arrayManager.FindWordsContaining(input, 'e');

// var input = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
// var result = arrayManager.RemoveDuplicates(input);
// var input = new int[] { 1, 2, 2 };
//var result = leetEasy.ContainsNearbyDuplicate(input, 1);

// var result = leetEasy.BuyChoco(input, 3);
// var result = stringManager.DefangIPaddr("1.1.1.1");

//var foo = resursionManager.Fibonacci(8);

// var s = "hello";
// var result = leetEasy.ScoreOfString(s);
// var haystack = "mississippi";
// var needle = "issipi";
// var result = stringManager.StrStr(haystack, needle);


//  arrayManager.Works();

// var tree = new Node();
// tree = tree.CreateExampleTree(tree);

// var bfs = new BreadthFirstSearch();
// var result = bfs.BFS(tree, 9);

//var input = new int[] { -1, 0, 3, 5, 9, 12 };
//var res = leetEasy.Search(input, 0);

string stop = "stop";
