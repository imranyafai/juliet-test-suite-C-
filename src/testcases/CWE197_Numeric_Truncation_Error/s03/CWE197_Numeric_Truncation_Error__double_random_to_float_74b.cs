/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__double_random_to_float_74b.cs
Label Definition File: CWE197_Numeric_Truncation_Error__double.label.xml
Template File: sources-sink-74b.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: random Set data to a random value
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_float
 *    BadSink : Convert data to a float
 * Flow Variant: 74 Data flow: data passed in a Dictionary from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{
class CWE197_Numeric_Truncation_Error__double_random_to_float_74b
{
#if (!OMITBAD)
    public static void BadSink(Dictionary<int,double> dataDictionary )
    {
        double data = dataDictionary[2];
        {
            /* POTENTIAL FLAW: Convert data to a float, possibly causing a truncation error */
            IO.WriteLine((float)data);
        }
    }
#endif

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(Dictionary<int,double> dataDictionary )
    {
        double data = dataDictionary[2];
        {
            /* POTENTIAL FLAW: Convert data to a float, possibly causing a truncation error */
            IO.WriteLine((float)data);
        }
    }
#endif
}
}
