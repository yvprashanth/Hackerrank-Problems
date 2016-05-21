using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var input = Console.ReadLine();
        int i = 0; 
        while(i < Convert.ToInt32(input)){
            var textInput = Console.ReadLine();
                if (Calc(textInput)) {
					Console.WriteLine ("YES");
				}
				else {
                    Console.WriteLine("NO");
				}            i++;
        }
    }
    
    public static bool Calc(string input){
        Stack<char> result = new Stack<char>();
			List<char> startChars = new List<char>{'{', '(', '['};
			List<char> endChars = new List<char>{'}', ')', ']'};
			Dictionary<char, char> keyValues = new Dictionary<char, char> ();
			keyValues.Add ('{', '}');
			keyValues.Add ('(', ')');
			keyValues.Add ('[', ']');
			for(var i = 0; i < input.Length; i++){
				if(startChars.IndexOf(input[i]) > -1 )
					result.Push(input[i]);
				else if(endChars.Contains(input[i])){
					if(i == 0 || result.Count == 0){
						return false;
					}
					var previousValue = input[i - 1];
					if(keyValues[result.Pop()] != input[i])
						return false;
				}
			}
			return true;
    }
    

}