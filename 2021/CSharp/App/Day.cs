using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AdventOfCode;

public abstract class Day{
    public virtual void Main(int day, bool useExampleFile){
        Part1(BuildFilePath(day, useExampleFile));
        Part2(BuildFilePath(day, useExampleFile));
    }
    public string BuildFilePath(int day, bool useExampleFile){
        using IHost host = Host.CreateDefaultBuilder().Build();
        IConfiguration settings = host.Services.GetRequiredService<IConfiguration>();
        
        string rootPath = settings.GetValue<string>("Environment:Root:Linux");
        if (settings.GetValue<string>("Environment:Platform") == "Windows"){
            // Get the Windows Root from appsettings.json and translate any environment variables it contains, e.g. %UserProfile%
            rootPath = Environment.ExpandEnvironmentVariables(settings.GetValue<string>("Environment:Root:Windows"));
        }
        
        string exampleFolder = "", fileName = "";
        if (useExampleFile == true) { exampleFolder = "Examples/"; }
        if (day < 10) { fileName = $"Day0{day}"; }
        else { fileName = $"Day{day}"; }

        string filepath = $"{rootPath}InputFiles/{exampleFolder}{fileName}.txt";
        return filepath;
    }
    //Enforce existence of Part1() and Part2() in child classes so Main() can always call them:
    public abstract Int64 Part1(string filepath); 
    public abstract Int64 Part2(string filepath);
}