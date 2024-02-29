using System;

namespace ValoresEspeciais
{
    class Program
    {
        /// <summary>
        /// Criação de valores máximos e mínimos de todos os tipos
        /// e demonstração dos mesmos,
        /// mais os infinitos positivo e negativo e o NaN
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            sbyte sbyte_s = sbyte.MinValue;
            sbyte sbyte_b = sbyte.MaxValue;
            
            short short_s = short.MinValue;
            short short_b = short.MaxValue;
            
            int int_s = int.MinValue;
            int int_b = int.MaxValue;
            
            long long_s = long.MinValue;
            long long_b = long.MaxValue;
            
            byte byte_s = byte.MinValue;
            byte byte_b = byte.MaxValue;
            
            ushort ushort_s = ushort.MinValue;
            ushort ushort_b = ushort.MaxValue;
            
            uint uint_s = uint.MinValue;
            uint uint_b = uint.MaxValue;
            
            ulong ulong_s = ulong.MinValue;
            ulong ulong_b = ulong.MaxValue;
            
            char char_s = char.MinValue;
            char char_b = char.MaxValue;
            
            float float_s = float.MinValue;
            float float_b = float.MaxValue;
            
            double double_s = double.MinValue;
            double double_b = double.MaxValue;
            
            decimal decimal_s = decimal.MinValue;
            decimal decimal_b = decimal.MaxValue;

            Console.WriteLine($"Mínimo sbyte: {sbyte_s}");
            Console.WriteLine($"Máximo sbyte: {sbyte_b}");

            Console.WriteLine($"Mínimo short: {short_s}");
            Console.WriteLine($"Máximo short: {short_b}");
            
            Console.WriteLine($"Mínimo int: {int_s}");
            Console.WriteLine($"Máximo int: {int_b}");

            Console.WriteLine($"Mínimo long: {long_s}");
            Console.WriteLine($"Máximo long: {long_b}");

            Console.WriteLine($"Mínimo byte: {byte_s}");
            Console.WriteLine($"Máximo byte: {byte_b}");

            Console.WriteLine($"Mínimo ushort: {ushort_s}");
            Console.WriteLine($"Máximo ushort: {ushort_b}");

            Console.WriteLine($"Mínimo uint: {uint_s}");
            Console.WriteLine($"Máximo uint: {uint_b}");

            Console.WriteLine($"Mínimo ulong: {ulong_s}");
            Console.WriteLine($"Máximo ulong: {ulong_b}");

            Console.WriteLine($"Mínimo char: {char_s}");
            Console.WriteLine($"Máximo char: {char_b}");

            Console.WriteLine($"Mínimo float: {float_s}");
            Console.WriteLine($"Máximo float: {float_b}");

            Console.WriteLine($"Mínimo double: {double_s}");
            Console.WriteLine($"Máximo double: {double_b}");

            Console.WriteLine($"Mínimo decimal: {decimal_s}");
            Console.WriteLine($"Máximo decimal: {decimal_b}");

            Console.WriteLine($"+∞ = {double.PositiveInfinity}");
            Console.WriteLine($"−∞ = {double.NegativeInfinity}");
            Console.WriteLine($"Not a Number = {float.NaN}");

            Console.WriteLine($"Overflow positivo: {uint_b + 1}");
            Console.WriteLine($"Overflow negativo: {uint_s - 1}");

            Console.WriteLine($"Overflow inalterado: {float_b + 12}");
            Console.WriteLine($"Overflow infinito: {float_b * 2}");

            Console.WriteLine($"Underflow máximo: {float_s == float_s + 0.01}");
            float f1 , f2 ;
            f1 = f2 = 123456789.0f;
            Console.WriteLine($"Underflow soma: {f1 == f2 + 0.0000001f}");
            
            
            
        }
    }
}
