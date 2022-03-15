using System;
// you can also use other imports, for example:
using System.Collections.Generic;
using System.Linq;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        string b = "";
        while(N >= 1){
            b = N%2 + b;
            Console.WriteLine("b is now " + b);
            if(N == 1){
                break;
            }
            
            N= N/2;
            
        }
        int counter = 0;
        int setStart = 0;
        List<int> gapLengths = new List<int>();
        gapLengths.Add(counter);
        for(int i=0; i<b.Length; i++){
            if(b[i]=='1' && setStart == 0){
                setStart = 1;
                counter=0;
                
            }
            else if(b[i]=='1' && setStart == 1){
                gapLengths.Add(counter);
                counter=0;
               
            }
            else {
                counter++;
            }
            Console.WriteLine("i is "+i+" and counter is "+counter+" and index "+ i+ " is "+b[i]+ " and setStart is "+setStart);
        }
        return gapLengths.Max();
    }
}
