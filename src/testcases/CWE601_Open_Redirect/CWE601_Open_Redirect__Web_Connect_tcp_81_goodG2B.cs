/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE601_Open_Redirect__Web_Connect_tcp_81_goodG2B.cs
Label Definition File: CWE601_Open_Redirect__Web.label.xml
Template File: sources-sink-81_goodG2B.tmpl.cs
*/
/*
 * @description
 * CWE: 601 Open Redirect
 * BadSource: Connect_tcp Read data using an outbound tcp connection
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : place redirect string directly into redirect api call
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */
#if (!OMITGOOD)

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE601_Open_Redirect
{
class CWE601_Open_Redirect__Web_Connect_tcp_81_goodG2B : CWE601_Open_Redirect__Web_Connect_tcp_81_base
{

    public override void Action(string data , HttpRequest req, HttpResponse resp)
    {
        if (data != null)
        {
            /* This prevents \r\n (and other chars) and should prevent incidentals such
             * as HTTP Response Splitting and HTTP Header Injection.
             */
            Uri uri;
            try
            {
                uri = new Uri(data);
            }
            catch (UriFormatException exceptURISyntax)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptURISyntax, "Invalid redirect URL");
                resp.Write("Invalid redirect URL");
                return;
            }
            /* POTENTIAL FLAW: redirect is sent verbatim; escape the string to prevent ancillary issues like XSS, Response splitting etc */
            resp.Redirect(data);
            return;
        }
    }
}
}
#endif
