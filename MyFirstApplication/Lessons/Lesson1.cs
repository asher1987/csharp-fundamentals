namespace MyFirstApplication;

/*
 This class goes over Value Types. Signed integrals include negative numbers.
  signed integral numbers do not include negative numbers. 
 */
internal class Lesson1
{
    // Integral Signed

    // sbyte range -128 to 127
    sbyte mySByte = 2;

    public void SByteMinMax()
    {
        Console.WriteLine(SByte.MinValue);
        Console.WriteLine(SByte.MaxValue);
    }

    // short range -32,768 to 32,767
    short myShort = 6;

    public void ShortMinMax()
    {
        Console.WriteLine(Int16.MinValue);
        Console.WriteLine(Int16.MaxValue);
    }

    // int range -2,147,483,648 to 2,147,483,647
    int myInt = 25685;

    public void IntMinMax()
    {
        Console.WriteLine(Int32.MinValue);
        Console.WriteLine(Int32.MaxValue);
    }

    // long range -9,223,372,036,854,775,808 to
    // 9,223,372,036,854,775,807
    long myLong = 123456789L;

    public void LongMinMax()
    {
        Console.WriteLine(Int64.MinValue);
        Console.WriteLine(Int64.MaxValue);
    }

    // Integral Unsigned

    // byte range 0 - 255
    byte myByte = 4;

    public void ByteMinMax()
    {
        Console.WriteLine(Byte.MinValue);
        Console.WriteLine(Byte.MaxValue);
    }

    // ushort range 0 - 65,535
    ushort myUShort = 42;

    public void UShortMinMax()
    {
        Console.WriteLine(UInt16.MinValue);
        Console.WriteLine(UInt16.MaxValue);
    }

    // uint range 0 -4,294,967,295
    // uint requires a suffix after the number 'U'
    uint myUInt = 4532U;

    public void UIntMinMax()
    {
        Console.WriteLine(UInt32.MinValue);
        Console.WriteLine(UInt32.MaxValue);
    }

    // ulong range 0 - 18,446,744,073,709,551,615
    // ulong requires a suffix of an 'L' after the number
    ulong myULong = 948372UL;

    public void ULongMinMax()
    {
        Console.WriteLine(UInt64.MinValue);
        Console.WriteLine(UInt64.MaxValue);
    }

    // Floating point numbers referred to as real numbers
    // used to define a 32-bit floating point(decimal variable)
    // float range is 3.4E +/-38
    // it will require a suffix of 'F'
    float myFloat = -123.6589F;

    public void FloatMinMax()
    {
        Console.WriteLine(Single.MinValue);
        Console.WriteLine(Single.MaxValue);
    }

    // double range 1.7E +/- 308
    // double range has an optional suffix of 'D'
    double MyDouble = 12.34D;

    public void DoubleMinMan()
    {
        Console.WriteLine(Double.MinValue);
        Console.WriteLine(Double.MaxValue);
    }

    // decimal range is -7.9228E+24 to 7.9228E+24
    // This one will require a suffix of 'M;
    decimal MyDecimal = 13.23M;

    public void DecimalMinMax()
    {
        Console.WriteLine(Decimal.MinValue);
        Console.WriteLine(Decimal.MaxValue);
    }

}