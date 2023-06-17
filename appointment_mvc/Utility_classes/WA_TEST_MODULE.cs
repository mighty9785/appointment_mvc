using System;
using System.Net;
using System.Text;

public class WA_TEST_MODULE
{
    public static string WA_Mob, WA_MSG, WA_KEY, WA_Instance, WA_Image;
    public static string MAIL_ID, MAIL_SUB;

    public static void WAMSG()
    {
        HttpWebRequest WebRequest;

        string instance_id = WA_Instance;
        string token = WA_KEY;
        string mobile_number = WA_Mob;
        string ultramsgApiUrl = "https://app.nationalbulksms.com/api/send-text.php?";
        
        WebRequest = (HttpWebRequest)HttpWebRequest.Create(ultramsgApiUrl);

        WA_KEY = "b7bb5cecab0f94922762b271ffec8f04db5437ce";
        WA_Instance = "U4MBhWGZxQuitP1";
        string MyWA_MSG = WA_MSG;
        MyWA_MSG += Environment.NewLine + Environment.NewLine + "{Powered By AUTOVYN-ERP}";

        MyWA_MSG = MyWA_MSG.Replace("\"", "").Replace("'", "").Replace("&", "-").Trim();
        string postdata = "number=" + WA_Mob + "&msg=" + MyWA_MSG + WA_Image + "&apikey=" + WA_KEY + "&instance=" + WA_Instance;

        UTF8Encoding enc = new UTF8Encoding();
        byte[] postdatabytes = enc.GetBytes(postdata);
        WebRequest.Method = "POST";
        WebRequest.ContentType = "application/x-www-form-urlencoded";
        WebRequest.GetRequestStream().Write(postdatabytes, 0, postdatabytes.Length);
        var response = (HttpWebResponse)WebRequest.GetResponse();
        var responseStream = response.GetResponseStream();
        var reader = new System.IO.StreamReader(responseStream);
        Console.WriteLine(reader.ReadToEnd());

        // CON.TSql("Insert into WA_HST values (1,'" & WA_Mob & "','" & MyWA_MSG & "'," & DbPath.Log_code & "," & QueryDate(Now.ToString("dd/MM/yy")) & "," & Now.ToString("HH.mm") & ")")
        // CON.TSql("Update WA_HST set WA_ACNTID="&  &" where

        //if (MAIL_ID != "") EMAILSENDER("", MAIL_SUB, MAIL_ID,,, WA_MSG)
    }
}
