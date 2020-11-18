/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__double_File_to_short_71a.cs
Label Definition File: CWE197_Numeric_Truncation_Error__double.label.xml
Template File: sources-sink-71a.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: File Read data from file (named c:\data.txt)
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_short
 *    BadSink : Convert data to a short
 * Flow Variant: 71 Data flow: data passed as an Object reference argument from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__double_File_to_short_71a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        double data;
        data = double.MinValue; /* Initialize data */
        {
            File.Create("data.txt").Close();
            StreamReader sr = null;
            try
            {
                /* read string from file into data */
                sr = new StreamReader("data.txt");
                /* FLAW: Read data from a file */
                /* This will be reading the first "line" of the file, which
                 * could be very long if there are little or no newlines in the file */
                string stringNumber = sr.ReadLine();
                if (stringNumber != null) /* avoid NPD incidental warnings */
                {
                    try
                    {
                        data = double.Parse(stringNumber.Trim());
                    }
                    catch (FormatException exceptNumberFormat)
                    {
                        IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception parsing data from string");
                    }
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
            }
            finally
            {
                /* Close stream reading objects */
                try
                {
                    if (sr != null)
                    {
                        sr.Close();
                    }
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error closing StreamReader");
                }
            }
        }
        CWE197_Numeric_Truncation_Error__double_File_to_short_71b.BadSink((Object)data  );
    }
#endif //omitbad
#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B()
    {
        double data;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        data = 2;
        CWE197_Numeric_Truncation_Error__double_File_to_short_71b.GoodG2BSink((Object)data  );
    }
#endif //omitgood
}
}
