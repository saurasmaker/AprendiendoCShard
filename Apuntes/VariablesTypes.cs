using System;
using System.Collections.Generic;
using System.Text;

namespace AprendiendoCSharp.Apuntes
{
    class VariablesTypes
    {
        //Simple
        sbyte a = 0; //Number from -128 to 127. Signed 8 bits. System.SByte
        byte b = 0; //Number from 0 to 255. Unsigned 8 bits. System.Byte
        short c = 0; //Number from -32768 to 32767. Signed 16 bits. System.Int16
        ushort d = 0; //Number from 0 to 65535. Unsigned 16 bits. System.UInt16
        int e = 0; //Number from -2147483648 to 2147483647. Signed 32 bits. System.Int32	
        uint f = 0; //Number from 0 to 4294967295. Unsigned 32 bits. System.UInt32
        long g = 0; //Number from -9223372036854775808 to 9223372036854775807. Signed 64 bits. System.Int64
        ulong h = 0; //Number from 0 to 18446744073709551615. Unsigned 64 bits. System.UInt64

        float i = 0.0f; //Number from (±1,5 x 10-45) to (±3,4 x 1038). System.Single
        double j = 0.0d; //Number from (±5,0 × 10−324) to (±1,7 × 10308). System.Double
        decimal k = 0.0m; //Number from (±1,0 x 10-28) to (±7,9228 x 1028). System.Decimal

        char l = '\x0000'; //Character unicode from U+0000 to U+FFFF. Character 16 bits. System.Char
        bool m = false; //Boolean. System.Boolean


        //Complex
        object n = new object(); //It is the base class for all other types, including simple built-in types.
        string o = "test"; //Una secuencia de caracteres Unicode.
        dynamic p = "any type of variable"; //It is a variable that will be adapted depending on the type of data that you want to store in it throughout the execution
    }
}
