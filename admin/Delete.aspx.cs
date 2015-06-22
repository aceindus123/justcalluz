using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class Delete : System.Web.UI.Page
{
    #region Get Connection String
    //private string GetConnectionString()
    //{
    //    return System.Configuration.ConfigurationManager.ConnectionStrings[@"data source=ACEINDUS\SQLEXPRESS;initial catalog=SampleDB;persist security info=true;integrated security=true;"].ConnectionString;
    //}
    #endregion

    #region Bind GridView
    private void BindGridView()
    {
        DataTable dt = new DataTable();
        SqlConnection connection = new SqlConnection("Password=Mnhbs@123;Persist Security Info=True;User ID=jcalluz;Initial Catalog=jcalluz;Data Source=jcalluz.db.8035572.hostedresource.com");
        try
        {
            connection.Open();
            string sqlStatement = "SELECT * FROM data";
            SqlCommand cmd = new SqlCommand(sqlStatement, connection);
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);

            sqlDa.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
        catch (System.Data.SqlClient.SqlException ex)
        {
            string msg = "Fetch Error:";
            msg += ex.Message;
            throw new Exception(msg);
        }
        finally
        {
            connection.Close();
        }
    }
    #endregion

    #region Insert New or Update Record
    private void UpdateOrAddNewRecord(string id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, string city, string compdet, bool isUpdate)
    {
        SqlConnection connection = new SqlConnection("Password=Mnhbs@123;Persist Security Info=True;User ID=jcalluz;Initial Catalog=jcalluz;Data Source=jcalluz.db.8035572.hostedresource.com");
        string sqlStatement = string.Empty;

        if (!isUpdate)
        {
            sqlStatement = "INSERT INTO data" +
                            "(cname,cat,area,ph,mob,addr,state,conper,email,city,compdet)" +
                            "VALUES (@cname,@cat,@area,@ph,@mob,@addr,@state,@conper,@email,@city,@compdet)";
        }
        else
        {
            sqlStatement = "UPDATE data " +
                           "SET  cname = @cname, cat = @cat, area = @area, ph = @ph, mob = @mob, addr = @addr, state = @state, conper = @conper, email = @email, city = @city, compdet = @compdet " +
                           "WHERE id = @id";
        }

        try
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(sqlStatement, connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@cname", cname);
            cmd.Parameters.AddWithValue("@cat", cat);
            cmd.Parameters.AddWithValue("@area", area);
            cmd.Parameters.AddWithValue("@ph", ph);
            cmd.Parameters.AddWithValue("@mob", mob);
            cmd.Parameters.AddWithValue("@addr", addr);
            cmd.Parameters.AddWithValue("@state", state);
            cmd.Parameters.AddWithValue("@conper", conper);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@compdet", compdet);
            //cmd.Parameters.AddWithValue("@optim", optim);


            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            connection.Close();
        }
        catch (System.Data.SqlClient.SqlException ex)
        {
            string msg = "Insert/Update Error:";
            msg += ex.Message;
            throw new Exception(msg);

        }
        finally
        {
            connection.Close();
        }
    }
    #endregion

    #region Delete Record
    private void DeleteRecord(string ID)
    {
        SqlConnection connection = new SqlConnection("Password=Mnhbs@123;Persist Security Info=True;User ID=jcalluz;Initial Catalog=jcalluz;Data Source=jcalluz.db.8035572.hostedresource.com");
        string sqlStatement = "DELETE FROM data WHERE id = @id";
        try
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(sqlStatement, connection);
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
        }
        catch (System.Data.SqlClient.SqlException ex)
        {
            string msg = "Deletion Error:";
            msg += ex.Message;
            throw new Exception(msg);

        }
        finally
        {
            connection.Close();
        }
    }
    #endregion


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindGridView();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        UpdateOrAddNewRecord(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text, TextBox12.Text, false);
        //Re Bind GridView to reflect changes made
        BindGridView();

    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex; // turn to edit mode
        BindGridView(); // Rebind GridView to show the data in edit mode

    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1; //swicth back to default mode
        BindGridView(); // Rebind GridView to show the data in default mode

    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        //Accessing Edited values from the GridView
        string id = GridView1.Rows[e.RowIndex].Cells[0].Text; //ID
        string cname = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text; //CompanyNmae
        string cat = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text; //Category
        string area = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text; //Area
        string ph = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text; //Phone
        string mob = ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text; //mobile
        string addr = ((TextBox)GridView1.Rows[e.RowIndex].Cells[6].Controls[0]).Text; //Address
        string state = ((TextBox)GridView1.Rows[e.RowIndex].Cells[7].Controls[0]).Text; //State
        string conper = ((TextBox)GridView1.Rows[e.RowIndex].Cells[8].Controls[0]).Text; //contactperson
        string email = ((TextBox)GridView1.Rows[e.RowIndex].Cells[9].Controls[0]).Text; //email
        string city = ((TextBox)GridView1.Rows[e.RowIndex].Cells[10].Controls[0]).Text; //city
        string compdet = ((TextBox)GridView1.Rows[e.RowIndex].Cells[11].Controls[0]).Text; //comp
        //string optim = ((TextBox)GridView1.Rows[e.RowIndex].Cells[10].Controls[0]).Text; //Operationaltiming

        UpdateOrAddNewRecord(id, cname, cat, area, ph, mob, addr, state, conper, email, city, compdet, true); // call update method
        GridView1.EditIndex = -1;
        BindGridView(); // Rebind GridView to reflect changes made

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string id = GridView1.Rows[e.RowIndex].Cells[0].Text; //get the id of the selected row
        DeleteRecord(id);//call delete method
        BindGridView();//rebind grid to reflect changes made
    }
}