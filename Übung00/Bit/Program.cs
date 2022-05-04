using System;

/*
    x & y & z,
    (x | y) & z,
    ~(x ^ y) und
    ~(x ^ y) & byte.MaxValue
*/

/*
1.) Dezimalsystem (Basis 10) 243 = 2 * 10^2 + 4 * 10^1 + 3*10^0
2.) Binärsystem (Basis 2) -> 0 und 1 mögliche Ziffern 1001 = 1 * 2^3 + 1*2^0 = 9
    -> (1011 0110) 8 Bit = 1 Byte
    -> max. Zahl in einem Byte: (1111 1111) = 255 
3.) Hexadezimalsystem (Basis 16)
    -> trennen Binäredarstellung in 2 4er Blöcke
    -> pro Block 16 verschiedene Zustände möglich (0000, 0001, 0010, 0011, ..., 1111)
    -> 16 Ziffern nötig: 0...9 A = 10 ... F = 15
    -> FF = 255 
*/


namespace Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0b0001_0001, y=0b1000_1000, z=0b1111;
            //0b steht für binär -> danach nur 0 und 1 möglich 
            // int entspricht 4 Byte = 32 Bit 
            //d.h. die vorderen nicht angegebenen Bits sind 0 

            //hexadezimale Ausgabe
            //{0:x8} 
            //   x steht für hexadezimale Ausgabe
            //    8 -> fülle Zahl von links mit Nullen auf 8 Stellen auf
            Console.WriteLine("x = 0x{0:x8}", x);
            Console.WriteLine("y = 0x{0:x8}", y);
            Console.WriteLine("z = 0x{0:x8}", z);

            //x & y & z,

            /*
                bitweises UND 

                & | 0  1
                ---------
                0 | 0  0
                1 | 0  1

                    00010001
                &   10001000
                -------------
                    00000000
                &   00001111
                -------------
                    00000000
            */

            //interferiert automatisch als Datentyp für b1 bool 
            var b1 = x & y & z;
            Console.WriteLine("x & y & z = {0:x8}", b1);

            //(x | y) & z

            /* 
                bitweise ODER

                | | 0  1
                ---------
                0 | 0  1
                1 | 1  1

                    00010001
                |   10001000
                -------------
                    10011001
                &   00001111
                -------------
                    00001001
            */

            var b2 = (x | y) & z;
            Console.WriteLine("(x|y) & z = 0x{0:x8}", b2);


            //~(x ^ y)

            /* 
                binäre Negation ~
                XOR entweder oder ^

                ^ | 0  1
                ---------
                0 | 0  1
                1 | 1  0

                                    00010001
                                ^   10001000
                                --------------
                                ~   10011001
                                --------------
        11111111_11111111_1111 1111_01100110

                Achtung: Die vorderen 3 bytes, also 24 Bit sind 0 und werden bei ~ auf 1 gekippt

            */

            var b3 = ~(x ^y);
            Console.WriteLine("~(x^y) = 0x{0:x8}", b3);


            //~(x ^ y) & byte.MaxValue

            /* 
                  11111111_11111111_11111111_01100110
                & 00000000_00000000_00000000_11111111  -> in einem Byte max. darstellbare Zahl 11111111
                --------------------------------------
                  00000000_00000000_00000000_01100110

                  "Fehler" der durch ~ gemacht wird, wird durch & mit byte.MaxValue ausgeglichen

            */

            var b4 = ~(x^y) & byte.MaxValue;
            Console.WriteLine("~(x^y) & byte.MaxValue = 0x{0:x8}", b4);


            // x aus y
            // y entsteht aus x durch shiften von x um 3 Stellen nach links
            var shiftedX = x << 3;
            //Ausgabe in Binärerform erfolgt über Convert.ToString(y, 2)
            //Convert.ToString("auszugebende Variable", "Basis")                             
            Console.WriteLine($"y = 0b{Convert.ToString(y, 2)}");
            Console.WriteLine($"shiftedX = 0b{Convert.ToString(shiftedX, 2)}");

        }
    }
}
