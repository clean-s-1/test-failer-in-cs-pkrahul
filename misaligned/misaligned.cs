using System;
using System.Diagnostics;

namespace MisalignedSpace {
    class Misaligned {
        static string[] majorColors = {"White", "Red", "Black", "Yellow", "Violet"};
        static string[] minorColors = {"Blue", "Orange", "Green", "Brown", "Slate"};
        static int printColorMap() {
            int i = 0, j = 0;
            for(i = 0; i < majorColors.Length; i++) {
                for(j = 0; j < minorColors.Length; j++) {
                    Console.WriteLine("{0} | {1} | {2}", i * 5 + j + 1, majorColors[i], minorColors[j]);
                }
            }
            return i * j;
        }
        static void Main(string[] args) {
            int result = printColorMap();
            Debug.Assert(result == 25);
            Console.WriteLine("All is well (maybe!)");
        }
    }
}
