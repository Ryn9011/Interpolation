

using AlgorithmAssessment;

IFormatter<string, Dictionary<string, string>> formatter = new Formatter(); 

string input = "Hello [[name]], you are [age] years old";

var values = new Dictionary<string, string> 
{
    { "name", "Ryan Jennings" },
    { "age", "John Smith" }
};

var output = formatter.FormatInput(input, values);

System.Console.WriteLine(output);