/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE643_Xpath_Injection__File_54b.cs
Label Definition File: CWE643_Xpath_Injection.label.xml
Template File: sources-sinks-54b.tmpl.cs
*/
/*
 * @description
 * CWE: 643 Xpath Injection
 * BadSource: File Read data from file (named data.txt)
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: validate input through SecurityElement.Escape
 *    BadSink : user input is used without validate
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.Runtime.InteropServices;
using System.Xml.XPath;

namespace testcases.CWE643_Xpath_Injection
{
class CWE643_Xpath_Injection__File_54b
{
#if (!OMITBAD)
    public static void BadSink(string data )
    {
        CWE643_Xpath_Injection__File_54c.BadSink(data );
    }
#endif

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(string data )
    {
        CWE643_Xpath_Injection__File_54c.GoodG2BSink(data );
    }

    /* goodB2G() - use badsource and goodsink */
    public static void GoodB2GSink(string data )
    {
        CWE643_Xpath_Injection__File_54c.GoodB2GSink(data );
    }
#endif
}
}
