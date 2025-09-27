using System;
using MathDLL;

public partial class api : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int a, b, c;
        if (!int.TryParse(Request.Form["numA"], out a) ||
            !int.TryParse(Request.Form["numB"], out b) ||
            !int.TryParse(Request.Form["numC"], out c) ||
            a < 0 || a > 9 || b < 0 || b > 9 || c < 0 || c > 9)
        {
            Response.ContentType = "application/json";
            Response.Write("{\"error\": \"Chỉ nhập chữ số 0-9!\"}");
            Response.End();
            return;
        }

        Calculator calc = new Calculator();
        calc.NumA = a;
        calc.NumB = b;
        calc.NumC = c;
        calc.Calculate();

        Response.ContentType = "application/json";
        Response.Write("{\"sum\": " + calc.Sum + ", \"message\": \"" + calc.Message.Replace("\"", "\\\"") + "\"}");
        Response.End();
    }
}