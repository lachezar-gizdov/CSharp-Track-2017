using System;

class ModifyBit
{
    static void Main()
    {
        ulong num = ulong.Parse(Console.ReadLine());
        int bitPosition = int.Parse(Console.ReadLine());
        int bitValue = int.Parse(Console.ReadLine());

        if (bitValue == 1)
        {
            ulong setOne = (ulong)1 << bitPosition;
            ulong foundBitOne = num | setOne;
            Console.WriteLine(foundBitOne);
        }
        else
        {
            ulong setZero = (ulong)~(1 << bitPosition);
            ulong foundBitZero = num & setZero;
            Console.WriteLine(foundBitZero);
        }
    }
}