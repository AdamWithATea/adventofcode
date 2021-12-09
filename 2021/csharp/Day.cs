namespace AdventOfCode
{
  abstract class Day
  {
    public virtual void Main(string filepath)
    ///Most days seem to be fine with an array of strings but Main
    /// can be overridden on days when another data type is better
    {
      string[] file = File.ReadAllLines(filepath);
      List<string> input = new List<string>(file);

      Part1(input);
      Part2(input);
    }

    public abstract void Part1(List<string> input);

    public abstract void Part2(List<string> input);

    public string CheckAnswer(int result, int expected)
    ///To be used after a puzzle is solved to ensure any future changes
    /// don't break the existing functionality (because apparently I find
    /// it impossible to let sleeping code lie).
    {
      string outcome;

      if (result == expected)
        {outcome = "PASS";}
      else{outcome = $"FAIL (Expected {expected})";}

      return outcome;
    }
  }
}