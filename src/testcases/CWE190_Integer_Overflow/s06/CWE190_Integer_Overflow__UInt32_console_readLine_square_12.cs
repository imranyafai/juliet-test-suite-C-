/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__UInt32_console_readLine_square_12.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-12.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: console_readLine Read data from the console using readLine
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: square
*    GoodSink: Ensure there will not be an overflow before squaring data
*    BadSink : Square data, which can lead to overflow
* Flow Variant: 12 Control flow: if(IO.StaticReturnsTrueOrFalse())
*
* */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__UInt32_console_readLine_square_12 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        uint data;
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* init data */
            data = 0;
            /* POTENTIAL FLAW: Read data from console with ReadLine*/
            try
            {
                string stringNumber = Console.ReadLine();
                if (stringNumber != null)
                {
                    data = uint.Parse(stringNumber.Trim());
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "Error with stream reading", exceptIO);
            }
            catch (FormatException exceptNumberFormat)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "Error with number parsing", exceptNumberFormat);
            }
        }
        else
        {
            /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
            data = 2;
        }
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* POTENTIAL FLAW: if (data*data) > uint.MaxValue, this will overflow */
            uint result = (uint)(data * data);
            IO.WriteLine("result: " + result);
        }
        else
        {
            /* FIX: Add a check to prevent an overflow from occurring */
            if (Math.Abs((long)data) <= (long)Math.Sqrt(uint.MaxValue))
            {
                uint result = (uint)(data * data);
                IO.WriteLine("result: " + result);
            }
            else
            {
                IO.WriteLine("data value is too large to perform squaring.");
            }
        }
    }
#endif //omitbad
#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink by changing the first "if" so that
     * both branches use the GoodSource */
    private void GoodG2B()
    {
        uint data;
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
            data = 2;
        }
        else
        {
            /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
            data = 2;
        }
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* POTENTIAL FLAW: if (data*data) > uint.MaxValue, this will overflow */
            uint result = (uint)(data * data);
            IO.WriteLine("result: " + result);
        }
        else
        {
            /* POTENTIAL FLAW: if (data*data) > uint.MaxValue, this will overflow */
            uint result = (uint)(data * data);
            IO.WriteLine("result: " + result);
        }
    }

    /* goodB2G() - use badsource and goodsink by changing the second "if" so that
     * both branches use the GoodSink */
    private void GoodB2G()
    {
        uint data;
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* init data */
            data = 0;
            /* POTENTIAL FLAW: Read data from console with ReadLine*/
            try
            {
                string stringNumber = Console.ReadLine();
                if (stringNumber != null)
                {
                    data = uint.Parse(stringNumber.Trim());
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "Error with stream reading", exceptIO);
            }
            catch (FormatException exceptNumberFormat)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "Error with number parsing", exceptNumberFormat);
            }
        }
        else
        {
            /* init data */
            data = 0;
            /* POTENTIAL FLAW: Read data from console with ReadLine*/
            try
            {
                string stringNumber = Console.ReadLine();
                if (stringNumber != null)
                {
                    data = uint.Parse(stringNumber.Trim());
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "Error with stream reading", exceptIO);
            }
            catch (FormatException exceptNumberFormat)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "Error with number parsing", exceptNumberFormat);
            }
        }
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* FIX: Add a check to prevent an overflow from occurring */
            if (Math.Abs((long)data) <= (long)Math.Sqrt(uint.MaxValue))
            {
                uint result = (uint)(data * data);
                IO.WriteLine("result: " + result);
            }
            else
            {
                IO.WriteLine("data value is too large to perform squaring.");
            }
        }
        else
        {
            /* FIX: Add a check to prevent an overflow from occurring */
            if (Math.Abs((long)data) <= (long)Math.Sqrt(uint.MaxValue))
            {
                uint result = (uint)(data * data);
                IO.WriteLine("result: " + result);
            }
            else
            {
                IO.WriteLine("data value is too large to perform squaring.");
            }
        }
    }

    public override void Good()

    {
        GoodG2B();
        GoodB2G();
    }
#endif //omitgood
}
}
