// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Hello, World!");
var leetEasy = new LeetEasy();
var stringManager = new StringManager();
var arrayManager = new ArrayManager();


leetEasy.Works();
stringManager.Works();
arrayManager.Works();

var result = stringManager.Interpret("(al)G(al)()()G");

string stop = "stop";