namespace AdventOfCode;
class Day08 : Day{
    public override void Part1(List<string> input){
        int uniqueSegments = 0;

        foreach (string line in input){
            var (display, displayDigits) = DecipherOutputs(line);
            foreach (int digit in displayDigits){
                if (digit == 1 | digit == 4 | digit == 7 | digit == 8)
                    {uniqueSegments++;}
            }
        }
        int answer = 321;
        string outcome = CheckAnswer(uniqueSegments, answer);
        System.Console.WriteLine($"Day 8-1: {uniqueSegments} {outcome}");
    }
    public override void Part2(List<string> input){
        int displayTotal = 0;
        foreach (string line in input){
            var (display, displayDigits) = DecipherOutputs(line);
            displayTotal += display;
        }
        int answer = 1028926;
        string outcome = CheckAnswer(displayTotal, answer);
        System.Console.WriteLine($"Day 8-2: {displayTotal} {outcome}");
    }
    static (int display, List<int> displayDigits) DecipherOutputs(string line){
        var (patterns, outputs) = SplitLine(line);
        string[,] cypher = CreateCypher(patterns);
        List<int> displayDigits = new List<int>();

        foreach (string output in outputs){
            for (int index = 0; index < 10; index++){
                int requiredIntersect = 0;
                if (output.Length > cypher[index, 1].Length) {requiredIntersect = output.Length;}
                else {requiredIntersect = cypher[index, 1].Length;}
                if (output.Intersect(cypher[index, 1]).Count() == requiredIntersect) {displayDigits.Add(index);}
            }
        }
        string mergedDigits = new string("");
        foreach (int digit in displayDigits) {mergedDigits = mergedDigits + digit;}
        int display = Convert.ToInt32(mergedDigits);
        return (display, displayDigits);
    }
    static (List<string> patterns, List<string> outputs) SplitLine(string line){
        string[] splitLine = line.Split(" | ");
        List<string> patterns = new List<string>(splitLine[0].Split(' '));
        List<string> outputs = new List<string>(splitLine[1].Split(' '));
        return (patterns, outputs);
    }
    static string[,] CreateCypher(List<string> patterns){
        string[,] cypher = new string[10, 2];
        //Start by finding the digits with unique length and adding them to the cypher
        foreach (string digit in patterns){
            switch (digit.Length){
                case 2: //One
                    cypher[1, 0] = "1";
                    cypher[1, 1] = digit;
                    break;
                case 3: //Seven
                    cypher[7, 0] = "7";
                    cypher[7, 1] = digit;
                    break;
                case 4: //Four
                    cypher[4, 0] = "4";
                    cypher[4, 1] = digit;
                    break;
                case 7: //Eight
                    cypher[8, 0] = "8";
                    cypher[8, 1] = digit;
                    break;
            }
        }
        //Next compare the 5- and 6-character digit strings to One and Four, as the unique number
        // of segments they share can be used to match the remaining strings to numbers
        foreach (string digit in patterns){
            switch (digit.Length){
                case 5:
                    if (digit.Intersect(cypher[4, 1]).Count() == 2)
                        {cypher[2, 0] = "2"; cypher[2, 1] = digit;}
                    else if (digit.Intersect(cypher[1, 1]).Count() == 2)
                        {cypher[3, 0] = "3"; cypher[3, 1] = digit;}
                    else {cypher[5, 0] = "5"; cypher[5, 1] = digit;}
                    break;
                case 6:
                    if (digit.Intersect(cypher[4, 1]).Count() == 4)
                        {cypher[9, 0] = "9"; cypher[9, 1] = digit;}
                    else if (digit.Intersect(cypher[1, 1]).Count() == 1)
                        {cypher[6, 0] = "6"; cypher[6, 1] = digit;}
                    else {cypher[0, 0] = "0"; cypher[0, 1] = digit;}
                    break;
            }
        }
        return cypher;
    }
}