using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Puzzles.Tests;

public class InputReader
{
    public async Task<List<string>> GetPuzzleInput(int day)
    {
        string file = $"./Day{day}/input.txt";
        
        using StreamReader streamReader = new StreamReader(file);

        List<string> lines = new List<string>();
        while (!streamReader.EndOfStream)
            lines.Add(await streamReader.ReadLineAsync());

        return lines;
    }
}