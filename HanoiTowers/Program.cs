using System;
using System.Collections.Generic;
using System.Text;

namespace HanoiTowers
{
    class Program
    {
        private static int _nbMove;
        private static readonly Stack<int> _src = new Stack<int>();
        private static readonly Stack<int> _tmp = new Stack<int>();
        private static readonly Stack<int> _dest = new Stack<int>();

        private static void Main()
        {
            int nbDisc = 3; // max value 9

            // add disc to stack
            for (int i = nbDisc; i >= 1; i--)
                _src.Push(i);

            PrintStacks();
            SolveHanoi(nbDisc, _src, _tmp, _dest);
            Console.WriteLine($"Total Moves: {_nbMove}");
            Console.ReadLine();
        }

        private static void SolveHanoi(int nbDisc, Stack<int> source, Stack<int> temp, Stack<int> dest)
        {
            if (nbDisc > 0)
            {
                SolveHanoi(nbDisc - 1, source, dest, temp);
                MoveFromTo(source, dest);
                SolveHanoi(nbDisc - 1, temp, source, dest);
            }
        }

        private static void MoveFromTo(Stack<int> source, Stack<int> dest)
        {
            dest.Push(source.Pop());
            _nbMove++;
            PrintStacks();
        }

        static public void PrintStacks()
        {
            Console.WriteLine($"{PrintStack(_src)} , {PrintStack(_tmp)} , {PrintStack(_dest)} ");
        }

        static public string PrintStack(Stack<int> stack)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (int val in stack)
                sb.Append(val);

            sb.Append("]");
            return sb.ToString();
        }
    }
}