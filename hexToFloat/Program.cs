using System;

namespace hexToFloat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexString = "FF-23-AD-A3";
            byte[] byteArray = HexStringToByteArray(hexString);
            int intVal = BitConverter.ToInt16(byteArray, 0);

            Console.WriteLine("Hexadecimal String -> {0}", hexString);
            Console.WriteLine("Byte Array -> {0}", PrettyPrint(byteArray)); 
            Console.WriteLine("Integer -> {0}", (intVal));
            Console.ReadKey();
        }
        public static byte[] HexStringToByteArray(string hexString)
        {
            hexString = hexString.Replace("-", "");
            byte[] result = new byte[hexString.Length / 2];

            for (int i = 0; i < hexString.Length; i += 2)
            {
                result[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
            }

            return result; 
        }

        static string PrettyPrint(byte[] byteArray)
        {
            return string.Join(" ", byteArray);
        }
    }
    
}
