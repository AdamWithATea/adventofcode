using Xunit;
using AdventOfCode;

namespace tests;
public class InputTests{
    [Fact]
    public void Day01Test(){
        Day01 day01 = new Day01();
        Assert.Equal(1791, day01.Part1(day01.BuildFilePath(01, false)));
        Assert.Equal(1822, day01.Part2(day01.BuildFilePath(01, false)));
    }
    [Fact]
    public void Day02Test(){
        Day02 day02 = new Day02();
        Assert.Equal(1989014, day02.Part1(day02.BuildFilePath(02, false)));
        Assert.Equal(2006917119, day02.Part2(day02.BuildFilePath(02, false)));
    }
    [Fact]
    public void Day03Test(){
        Day03 day03 = new Day03();
        Assert.Equal(3912944, day03.Part1(day03.BuildFilePath(03, false)));
        Assert.Equal(4996233, day03.Part2(day03.BuildFilePath(03, false)));
    }
    [Fact]
    public void Day04Test(){
        Day04 day04 = new Day04();
        Assert.Equal(33462, day04.Part1(day04.BuildFilePath(04, false)));
        Assert.Equal(30070, day04.Part2(day04.BuildFilePath(04, false)));
    }
    [Fact]
    public void Day05Test(){
        Day05 day05 = new Day05();
        Assert.Equal(6841, day05.Part1(day05.BuildFilePath(05, false)));
        Assert.Equal(19258, day05.Part2(day05.BuildFilePath(05, false)));
    }
    [Fact]
    public void Day06Test(){
        Day06 day06 = new Day06();
        Assert.Equal(385391, day06.Part1(day06.BuildFilePath(06, false)));
        Assert.Equal(1728611055389, day06.Part2(day06.BuildFilePath(06, false)));
    }
    [Fact]
    public void Day07Test(){
        Day07 day07 = new Day07();
        Assert.Equal(336120, day07.Part1(day07.BuildFilePath(07, false)));
        Assert.Equal(96864235, day07.Part2(day07.BuildFilePath(07, false)));
    }
    [Fact]
    public void Day08Test(){
        Day08 day08 = new Day08();
        Assert.Equal(321, day08.Part1(day08.BuildFilePath(08, false)));
        Assert.Equal(1028926, day08.Part2(day08.BuildFilePath(08, false)));
    }
}