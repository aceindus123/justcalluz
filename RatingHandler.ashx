<%@ WebHandler Language="C#" Class="RatingHandler" %>

using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Configuration;

public class RatingHandler : IHttpHandler
{

public void ProcessRequest(HttpContext context)
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    con.Open();
//SqlCommand cmd = new SqlCommand("insert into Rating_Table(Rating,UserName) values(@rating,@name)", con);
//cmd.Parameters.AddWithValue("@rating", context.Request.Form["rating"]);
//cmd.Parameters.AddWithValue("@name", context.Request.LogonUserIdentity.Name);
//    string sid = Session["Id"];
////cmd.ExecuteNonQuery();
//cmd = new SqlCommand("Select count(rid) as NumberOfUsers,sum(Stars_Rating) as Total from PostReview where id=1", con);
//SqlDataAdapter da = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();
//da.Fill(dt);
//float COUNT = float.Parse(dt.Rows[0]["NumberOfUsers"].ToString());
//float RATING = float.Parse(dt.Rows[0]["Total"].ToString());
//context.Response.ContentType = "text/plain";
//try
//{
//float result = RATING / COUNT;
//context.Response.Write(result.ToString("0.0"));
//}
//catch (Exception ex)
//{
//context.Response.StatusCode = 202;
//context.Response.Write(ex.Message);
//context.Response.Flush();
//context.Response.End();
//}
}
public bool IsReusable
{
get
{
return false;
}
}
}