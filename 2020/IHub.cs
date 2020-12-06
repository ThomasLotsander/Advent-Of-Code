using System;
using System.Collections.Generic;
using System.Text;

namespace _2020
{
    public interface IHub
    {
        void Run();
        string[] GetPuzzleInput();
        string[] GetTestPuzzleInput();
    }
}
