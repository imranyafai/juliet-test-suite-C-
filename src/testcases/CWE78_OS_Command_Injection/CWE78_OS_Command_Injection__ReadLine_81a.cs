/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE78_OS_Command_Injection__ReadLine_81a.cs
Label Definition File: CWE78_OS_Command_Injection.label.xml
Template File: sources-sink-81a.tmpl.cs
*/
/*
 * @description
 * CWE: 78 OS Command Injection
 * BadSource: ReadLine Read data from the console using ReadLine()
 * GoodSource: A hardcoded string
 * Sinks: exec
 *    BadSink : dynamic command execution with Runtime.getRuntime().exec()
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE78_OS_Command_Injection
{

class CWE78_OS_Command_Injection__ReadLine_81a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        data = ""; /* Initialize data */
        {
            /* read user input from console with ReadLine */
            try
            {
                /* POTENTIAL FLAW: Read data from the console using ReadLine */
                data = Console.ReadLine();
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
            }
        }
        CWE78_OS_Command_Injection__ReadLine_81_base baseObject = new CWE78_OS_Command_Injection__ReadLine_81_bad();
        baseObject.Action(data );
    }
#endif //omitbad
#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B()
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
        CWE78_OS_Command_Injection__ReadLine_81_base baseObject = new CWE78_OS_Command_Injection__ReadLine_81_goodG2B();
        baseObject.Action(data );
    }
#endif //omitgood
}
}
