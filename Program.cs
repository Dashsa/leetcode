// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Hello, World!");
var leetEasy = new LeetEasy();
var stringManager = new StringManager();
var arrayManager = new ArrayManager();


// leetEasy.Works();
// stringManager.Works();
// arrayManager.Works();

// var result = stringManager.Interpret("(al)G(al)()()G");
// var optimized =  stringManager.InterpretOptimal("(al)G(al)()()G");

var result = stringManager.EqualFrequency("aazz");
string stop = "stop";