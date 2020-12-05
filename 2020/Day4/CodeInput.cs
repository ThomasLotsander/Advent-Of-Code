using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;

namespace _2020.Day4
{
    class CodeInput
    {
        public static List<string> GetPuzzleInput(string path)
        {

            string ln;
            string batchLine = "";
            var lines = new List<string>();

            using StreamReader file = new StreamReader(path);
            while ((ln = file.ReadLine()) != null)
            {
                batchLine += ln + " ";
                if (string.IsNullOrEmpty(ln))
                {
                    lines.Add(batchLine.Trim());
                    batchLine = string.Empty;
                }

            }

            if (!string.IsNullOrEmpty(batchLine))
            {
                lines.Add(batchLine.Trim());
            }

            file.Close();

            return lines;

        }
    }
}
