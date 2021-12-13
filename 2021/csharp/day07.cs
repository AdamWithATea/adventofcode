namespace AdventOfCode
{
    class Day07 : Day
    {
        //Main is overriden today because this input file is divided by commas,
        // meaning this Split() works better than the usual ReadAllLines()
        public override void Main(string filepath){
            string[] file = File.ReadAllText(filepath).Split(',');
            List<string> input = new List<string>(file);

            Part1(input);
            Part2(input);
            
        }
        public override void Part1(List<string> crabStrings)
        {
            List<int> crabs = ConvertPositionsToInt(crabStrings);
            int leastFuel = LeastFuelUsage(crabs, 0);
            int answer = 336120;
            string outcome = CheckAnswer(leastFuel, answer);
            System.Console.WriteLine($"Day 7-1: {leastFuel} {outcome}");
        }

        public override void Part2(List<string> crabStrings)
        {
            List<int> crabs = ConvertPositionsToInt(crabStrings);
            int leastFuel = LeastFuelUsage(crabs, 1);
            int answer = 96864235;
            string outcome = CheckAnswer(leastFuel, answer);
            System.Console.WriteLine($"Day 7-2: {leastFuel} {outcome}");
        }

        private static List<int> ConvertPositionsToInt(List<string> crabStrings){
            List<int> crabs = new List<int>();
            foreach (string crab in crabStrings)
                {crabs.Add(Convert.ToInt32(crab));}
            return crabs;
        }

        private static int LeastFuelUsage (List<int> crabs, int costIncrement){
            List<int> fuelUsage = new List<int>();            
            crabs.Sort();
            int highestCrab = crabs[crabs.Count-1], lowestCrab = crabs[0];
            for (int position = lowestCrab; position <= highestCrab; position++){
                int totalFuelUsed = 0;
                foreach (int crab in crabs){
                    int distanceMoved = 0, fuelPerMove = 1;
                    if (crab > position) {distanceMoved += crab-position;}
                    else {distanceMoved += position-crab;}
                    for (int move = 1; move <= distanceMoved; move++){
                        totalFuelUsed += fuelPerMove;
                        fuelPerMove += costIncrement;
                    }
                }
                fuelUsage.Add(totalFuelUsed);
            }
            fuelUsage.Sort();

            return fuelUsage[0];
        }
    }
}