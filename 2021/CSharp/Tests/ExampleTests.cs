using Xunit;
using AdventOfCode;

namespace tests;
public class ExampleTests{
    [Fact]
    public void Day01Test(){
        Day01 day01 = new Day01();
        Assert.Equal(7, day01.Part1(day01.BuildFilePath(01, true)));
        Assert.Equal(5, day01.Part2(day01.BuildFilePath(01, true)));
    }
    [Fact]
    public void Day02Test(){
        Day02 day02 = new Day02();
        Assert.Equal(150, day02.Part1(day02.BuildFilePath(02, true)));
        Assert.Equal(900, day02.Part2(day02.BuildFilePath(02, true)));
    }
    [Fact]
    public void Day03Test(){
        Day03 day03 = new Day03();
        Assert.Equal(198, day03.Part1(day03.BuildFilePath(03, true)));
        Assert.Equal(230, day03.Part2(day03.BuildFilePath(03, true)));
    }
    [Fact]
    public void Day04Test(){
        Day04 day04 = new Day04();
        Assert.Equal(4512, day04.Part1(day04.BuildFilePath(04, true)));
        Assert.Equal(1924, day04.Part2(day04.BuildFilePath(04, true)));
    }
    [Fact]
    public void Day05Test(){
        Day05 day05 = new Day05();
        Assert.Equal(5, day05.Part1(day05.BuildFilePath(05, true)));
        Assert.Equal(12, day05.Part2(day05.BuildFilePath(05, true)));
    }
    [Fact]
    public void Day06Test(){
        Day06 day06 = new Day06();
        Assert.Equal(5934, day06.Part1(day06.BuildFilePath(06, true)));
        Assert.Equal(26984457539, day06.Part2(day06.BuildFilePath(06, true)));
    }
    [Fact]
    public void Day07Test(){
        Day07 day07 = new Day07();
        Assert.Equal(37, day07.Part1(day07.BuildFilePath(07, true)));
        Assert.Equal(168, day07.Part2(day07.BuildFilePath(07, true)));
    }
    [Fact]
    public void Day08Test(){
        Day08 day08 = new Day08();
        Assert.Equal(26, day08.Part1(day08.BuildFilePath(08, true)));
        Assert.Equal(61229, day08.Part2(day08.BuildFilePath(08, true)));
    }
    [Fact]
    public void Day09Test(){
        Day09 day09 = new AdventOfCode.Day09();
        Assert.Equal(15, day09.Part1(day09.BuildFilePath(09, true)));
    }
}