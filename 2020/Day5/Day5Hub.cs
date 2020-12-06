using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _2020.Day5
{
   public class Day5Hub
   {
       List<int> _totalRows;
       List<int> _totalColumns;
        public void Run()
        {
            Console.WriteLine("Day 5!");

            var puzzleInput = CodeInput.GetPuzzleInput("CodeInputFiles/Day5PuzzleInput.txt");
            var testInput = CodeInput.GetTestPuzzleInput();
            
            Puzzle1(puzzleInput);
        }

        private void Puzzle1(string[] puzzleInput)
        {
            Console.WriteLine("Get code 1");

            int highestSeatId = 0;
            foreach (var line in puzzleInput)
            {
                SetUpRows();
                SetUpColumns();
                var rows = line.Take(7);
                var seats = line.Skip(7).Take(3);

                foreach (var row in rows)
                {
                    CalcRow(row);
                }

                foreach (var seat in seats)
                {
                    CalcSeat(seat);
                }

                var rowNr = _totalRows.First();
                var columnNr = _totalColumns.First();
                var seatId = rowNr * 8 + columnNr;
                if (seatId > highestSeatId)
                {
                    highestSeatId = seatId;
                }
                Console.WriteLine(rowNr + " " + columnNr + " " + seatId);
            }

            Console.WriteLine("Highest seatId: " + highestSeatId);
        }

        private void Puzzle2()
        {
            Console.WriteLine("Get code 2");
        }

        private void CalcRow(char c)
        {
            int half = _totalRows.Count / 2;
            switch (c)
            {
                case 'F':
                {
                    _totalRows.RemoveRange(half, half);
                    break;
                }
                case 'B':
                {
                    _totalRows.RemoveRange(0, half);
                    break;
                }
            }
        }

        private void CalcSeat(char c)
        {
            int half = _totalColumns.Count / 2;
            switch (c)
            {
                case 'L':
                {
                    _totalColumns.RemoveRange(half, half);
                    break;
                }
                case 'R':
                {
                    _totalColumns.RemoveRange(0, half);
                    break;
                }
            }
        }

        private void SetUpRows()
        {
            _totalRows = new List<int>();
            for (int i = 0; i < 128; i++)
            {
                _totalRows.Add(i);
            }
        }

        private void SetUpColumns()
        {
            _totalColumns = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                _totalColumns.Add(i);
            }
        }
    }
}
