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

public partial class usercontrols_boxes3 : System.Web.UI.UserControl
{
    InsertData obj = new InsertData();
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["cat"] = TextBox2.Text;
        Session["area"] = TextBox3.Text;
        Session["cname"] = TextBox2.Text;
        Session["value"] = TextBox2.Text;
        Session["city"] = TextBox1.Text;

        Panel1.Visible = false;
        pnlAtoZ.Visible = false;
        pnlcities.Visible = false;
        pnlA.Visible = false;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = false;

        dlpopcities.Visible = true;
        DataSet ds25 = new DataSet();
        ds25 = obj.bindpopcities();
        dlpopcities.DataSource = ds25;
        dlpopcities.DataBind();

        dlcitiesA.Visible = true;
        DataSet ds1 = new DataSet();
        ds1 = obj.bindA();
        DataView dtView = ds1.Tables[0].DefaultView;
        dtView.Sort = "A ASC";
        dlcitiesA.DataSource = dtView;
        dlcitiesA.DataBind();

        dlcitiesB.Visible = true;
        DataSet ds2 = new DataSet();
        ds2 = obj.bindB();
        DataView dtView1 = ds2.Tables[0].DefaultView;
        dtView1.Sort = "B ASC";
        dlcitiesB.DataSource = dtView1;
        dlcitiesB.DataBind();

        dlcitiesC.Visible = true;
        DataSet ds3 = new DataSet();
        ds3 = obj.bindC();
        DataView dtView2 = ds3.Tables[0].DefaultView;
        dtView2.Sort = "C ASC";
        dlcitiesC.DataSource = dtView2;
        dlcitiesC.DataBind();

        dlcitiesD.Visible = true;
        DataSet ds4 = new DataSet();
        ds4 = obj.bindD();
        DataView dtView3 = ds4.Tables[0].DefaultView;
        dtView3.Sort = "D ASC";
        dlcitiesD.DataSource = dtView3;
        dlcitiesD.DataBind();

        dlcitiesE.Visible = true;
        DataSet ds5 = new DataSet();
        ds5 = obj.bindE();
        DataView dtView4 = ds5.Tables[0].DefaultView;
        dtView4.Sort = "E ASC";
        dlcitiesE.DataSource = dtView4;
        dlcitiesE.DataBind();

        dlcitiesF.Visible = true;
        DataSet ds6 = new DataSet();
        ds6 = obj.bindF();
        DataView dtView5 = ds6.Tables[0].DefaultView;
        dtView5.Sort = "F ASC";
        dlcitiesF.DataSource = dtView5;
        dlcitiesF.DataBind();

        dlcitiesG.Visible = true;
        DataSet ds7 = new DataSet();
        ds7 = obj.bindG();
        DataView dtView6 = ds7.Tables[0].DefaultView;
        dtView6.Sort = "G ASC";
        dlcitiesG.DataSource = dtView6;
        dlcitiesG.DataBind();

        dlcitiesH.Visible = true;
        DataSet ds8 = new DataSet();
        ds8 = obj.bindH();
        DataView dtView7 = ds8.Tables[0].DefaultView;
        dtView7.Sort = "H ASC";
        dlcitiesH.DataSource = dtView7;
        dlcitiesH.DataBind();

        dlcitiesI.Visible = true;
        DataSet ds9 = new DataSet();
        ds9 = obj.bindI();
        DataView dtView8 = ds9.Tables[0].DefaultView;
        dtView8.Sort = "I ASC";
        dlcitiesI.DataSource = dtView8;
        dlcitiesI.DataBind();

        dlcitiesJ.Visible = true;
        DataSet ds10 = new DataSet();
        ds10 = obj.bindJ();
        DataView dtView9 = ds10.Tables[0].DefaultView;
        dtView9.Sort = "J ASC";
        dlcitiesJ.DataSource = dtView9;
        dlcitiesJ.DataBind();

        dlcitiesK.Visible = true;
        DataSet ds11 = new DataSet();
        ds11 = obj.bindK();
        DataView dtView10 = ds11.Tables[0].DefaultView;
        dtView10.Sort = "K ASC";
        dlcitiesK.DataSource = dtView10;
        dlcitiesK.DataBind();

        dlcitiesL.Visible = true;
        DataSet ds12 = new DataSet();
        ds12 = obj.bindL();
        DataView dtView11 = ds12.Tables[0].DefaultView;
        dtView11.Sort = "L ASC";
        dlcitiesL.DataSource = dtView11;
        dlcitiesL.DataBind();

        dlcitiesM.Visible = true;
        DataSet ds13 = new DataSet();
        ds13 = obj.bindM();
        DataView dtView12 = ds13.Tables[0].DefaultView;
        dtView12.Sort = "M ASC";
        dlcitiesM.DataSource = dtView12;
        dlcitiesM.DataBind();

        dlcitiesN.Visible = true;
        DataSet ds14 = new DataSet();
        ds14 = obj.bindN();
        DataView dtView13 = ds14.Tables[0].DefaultView;
        dtView13.Sort = "N ASC";
        dlcitiesN.DataSource = dtView13;
        dlcitiesN.DataBind();

        dlcitiesO.Visible = true;
        DataSet ds15 = new DataSet();
        ds15 = obj.bindO();
        DataView dtView14 = ds15.Tables[0].DefaultView;
        dtView14.Sort = "O ASC";
        dlcitiesO.DataSource = dtView14;
        dlcitiesO.DataBind();

        dlcitiesP.Visible = true;
        DataSet ds16 = new DataSet();
        ds16 = obj.bindP();
        DataView dtView15 = ds16.Tables[0].DefaultView;
        dtView15.Sort = "P ASC";
        dlcitiesP.DataSource = dtView15;
        dlcitiesP.DataBind();

        dlcitiesQ.Visible = true;
        DataSet ds17 = new DataSet();
        ds17 = obj.bindQ();
        DataView dtView16 = ds17.Tables[0].DefaultView;
        dtView16.Sort = "Q ASC";
        dlcitiesQ.DataSource = dtView16;
        dlcitiesQ.DataBind();

        dlcitiesR.Visible = true;
        DataSet ds18 = new DataSet();
        ds18 = obj.bindR();
        DataView dtView17 = ds18.Tables[0].DefaultView;
        dtView17.Sort = "R ASC";
        dlcitiesR.DataSource = dtView17;
        dlcitiesR.DataBind();

        dlcitiesS.Visible = true;
        DataSet ds19 = new DataSet();
        ds19 = obj.bindS();
        DataView dtView18 = ds19.Tables[0].DefaultView;
        dtView18.Sort = "S ASC";
        dlcitiesS.DataSource = dtView18;
        dlcitiesS.DataBind();

        dlcitiesT.Visible = true;
        DataSet ds20 = new DataSet();
        ds20 = obj.bindT();
        DataView dtView19 = ds20.Tables[0].DefaultView;
        dtView19.Sort = "T ASC";
        dlcitiesT.DataSource = dtView19;
        dlcitiesT.DataBind();

        dlcitiesU.Visible = true;
        DataSet ds21 = new DataSet();
        ds21 = obj.bindU();
        DataView dtView20 = ds21.Tables[0].DefaultView;
        dtView20.Sort = "U ASC";
        dlcitiesU.DataSource = dtView20;
        dlcitiesU.DataBind();

        dlcitiesV.Visible = true;
        DataSet ds22 = new DataSet();
        ds22 = obj.bindV();
        DataView dtView21 = ds22.Tables[0].DefaultView;
        dtView21.Sort = "V ASC";
        dlcitiesV.DataSource = dtView21;
        dlcitiesV.DataBind();

        dlcitiesW.Visible = true;
        DataSet ds23 = new DataSet();
        ds23 = obj.bindW();
        DataView dtView22 = ds23.Tables[0].DefaultView;
        dtView22.Sort = "W ASC";
        dlcitiesW.DataSource = dtView22;
        dlcitiesW.DataBind();

        dlcitiesY.Visible = true;
        DataSet ds24 = new DataSet();
        ds24 = obj.bindY();
        DataView dtView23 = ds24.Tables[0].DefaultView;
        dtView23.Sort = "Y ASC";
        dlcitiesY.DataSource = dtView23;
        dlcitiesY.DataBind();

    }
    protected void b1_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        string str = string.Empty;
        str = b.Text;
        TextBox1.Text = str;

        Label10.Text = str + '?';

    }







    protected void A_Click1(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = true;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = false;
    }
    protected void B_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = false;
        pnlB.Visible = true;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = false;
    }
    protected void C_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = false;
        pnlB.Visible = false;
        pnlC.Visible = true;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = false;
    }
    protected void D_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = false;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = true;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = false;
    }

    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = true;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = false;
    }
    protected void E_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = false;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = true;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = false;
    }

    protected void F_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = false;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = true;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = false;

    }
    protected void G_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = false;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = true;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = false;
    }
    protected void H_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = false;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = true;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = false;

    }
    protected void I_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = false;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = true;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = false;

    }
    protected void J_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = false;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = true;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = false;
    }
    protected void K_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = false;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = true;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = false;

    }
    protected void L_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = false;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = true;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = false;
    }
    protected void M_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = false;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = true;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = false;
    }
    protected void N_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = false;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = true;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = false;
    }
    protected void O_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = false;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = true;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = false;
    }
    protected void P_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = false;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = true;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = false;
    }
    protected void Q_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = false;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = true;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = false;

    }
    protected void R_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = false;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = true;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = false;


    }
    protected void S_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = false;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = true;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = false;
    }
    protected void T_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = false;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = true;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = false;
    }
    protected void U_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = false;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = true;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = false;
    }
    protected void V_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = false;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = true;
        pnlW.Visible = false;
        pnlY.Visible = false;
    }
    protected void W_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = false;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = true;
        pnlY.Visible = false;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {

    }
    protected void Y_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = false;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = true;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        if (rb2cat.Checked == true)
        {
            if (TextBox3.Text != "")
            {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection("Password=Mnhbs@123;Persist Security Info=True;User ID=jcalluz;Initial Catalog=jcalluz;Data Source=jcalluz.db.8035572.hostedresource.com");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select id,cname,area,cat,mob from data where city=('" + TextBox1.Text + "')and cat=('" + TextBox2.Text + "')and area=('" + TextBox3.Text + "')", con);
                da.Fill(ds, "data");
                DataList1.DataSource = ds.Tables[0];
                Session["sss"] = ds;
                DataList1.DataBind();
                //string str = "select id,cname,area,cat,mob from data where city=('" + TextBox1.Text + "')and cat=('" + TextBox2.Text + "')and area=('" + TextBox3.Text + "')";
            }
            else
            {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection("Password=Mnhbs@123;Persist Security Info=True;User ID=jcalluz;Initial Catalog=jcalluz;Data Source=jcalluz.db.8035572.hostedresource.com");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select id,cname,area,cat,mob from data where city=('" + TextBox1.Text + "')and cat=('" + TextBox2.Text + "')", con);
                da.Fill(ds, "data");
                Session["sss"] = ds;
                DataList1.DataSource = ds.Tables[0];
                DataList1.DataBind();
                //string str = "select id,cname,area,cat,mob from data where city=('" + TextBox1.Text + "')and cat=('" + TextBox2.Text + "')";
            }

        }
        else
        {
            if (TextBox3.Text != "")
            {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection("Password=Mnhbs@123;Persist Security Info=True;User ID=jcalluz;Initial Catalog=jcalluz;Data Source=jcalluz.db.8035572.hostedresource.com");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select id,cname,area,cat,mob from data where city=('" + TextBox1.Text + "')and cname=('" + TextBox2.Text + "')and area=('" + TextBox3.Text + "')", con);
                da.Fill(ds, "data");
                Session["sss"] = ds;
                DataList1.DataSource = ds.Tables[0];
                DataList1.DataBind();
                //string str = "select id,cname,area,cat,mob from data where city=('" + TextBox1.Text + "')and cname=('" + TextBox2.Text + "')and area=('" + TextBox3.Text + "')";
            }
            else
            {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection("Password=Mnhbs@123;Persist Security Info=True;User ID=jcalluz;Initial Catalog=jcalluz;Data Source=jcalluz.db.8035572.hostedresource.com");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select id,cname,area,cat,mob from data where city=('" + TextBox1.Text + "')and cname=('" + TextBox2.Text + "')", con);
                da.Fill(ds, "data");
                Session["sss"] = ds;
                DataList1.DataSource = ds.Tables[0];

                DataList1.DataBind();
                //string str = "select id,cname,area,cat,mob from data where city=('" + TextBox1.Text + "')and cname=('" + TextBox2.Text + "')";
            }

        }

        if (rb2cat.Checked == true)
        {
            DataSet ds5 = new DataSet();
            SqlConnection con1 = new SqlConnection("Password=Mnhbs@123;Persist Security Info=True;User ID=jcalluz;Initial Catalog=jcalluz;Data Source=jcalluz.db.8035572.hostedresource.com");
            con1.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select cat from subcatageory  where maincat = ('" + TextBox2.Text + "'  ) ", con1);
            da1.Fill(ds5, "subcatageory ");

            Session["aaa"] = ds5;
            dlcat.DataSource = ds5.Tables[0];
            dlcat.DataBind();


            Response.Redirect("linkresults.aspx?cname=" + TextBox2.Text + "&city=" + TextBox1.Text + "");
        }
        else
        {

            DataSet ds5 = new DataSet();
            SqlConnection con1 = new SqlConnection("Password=Mnhbs@123;Persist Security Info=True;User ID=jcalluz;Initial Catalog=jcalluz;Data Source=jcalluz.db.8035572.hostedresource.com");
            con1.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select cat from data where cname= ('" + TextBox2.Text + "' ) ", con1);
            da1.Fill(ds5, "data");

            Session["aaa"] = ds5;
            dlcat.DataSource = ds5.Tables[0];
            dlcat.DataBind();


            Response.Redirect("linkresults.aspx?cname=" + TextBox2.Text + "&city=" + TextBox1.Text + "");

        }
        

    }

    protected void dlcat_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        Session["name"] = e.CommandArgument.ToString();
        string name = "";
        name = e.CommandArgument.ToString();
        Response.Redirect("linkresults.aspx?cname=" + name + "");




    }


    protected void dlcitiesA_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;



    }

    protected void dlcitiesB_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;


    }

    protected void dlcitiesC_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;


    }

    protected void dlcitiesD_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;


    }

    protected void dlcitiesE_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;

    }

    protected void dlcitiesF_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;

    }

    protected void dlcitiesG_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;


    }

    protected void dlcitiesH_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;
    }

    protected void dlcitiesI_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;


    }

    protected void dlcitiesJ_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;


    }

    protected void dlcitiesK_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;

    }

    protected void dlcitiesL_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;

    }

    protected void dlcitiesM_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;

    }

    protected void dlcitiesN_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;

    }

    protected void dlcitiesO_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;

    }

    protected void dlcitiesP_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;

    }

    protected void dlcitiesQ_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;


    }

    protected void dlcitiesR_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;

    }

    protected void dlcitiesS_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;

    }

    protected void dlcitiesT_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;
    }

    protected void dlcitiesU_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;

    }

    protected void dlcitiesV_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;


    }

    protected void dlcitiesW_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;


    }

    protected void dlcitiesY_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;


    }

    protected void dlpopcities_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {

        string name = "";
        name = e.CommandArgument.ToString();
        TextBox1.Text = name;
        Label10.Text = name;


    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Panel1.Visible = true;
        pnlAtoZ.Visible = true;
        pnlcities.Visible = true;
        pnlA.Visible = true;
        pnlB.Visible = false;
        pnlC.Visible = false;
        pnlD.Visible = false;
        pnlE.Visible = false;
        pnlF.Visible = false;
        pnlG.Visible = false;
        pnlH.Visible = false;
        pnlI.Visible = false;
        pnlJ.Visible = false;
        pnlK.Visible = false;
        pnlL.Visible = false;
        pnlM.Visible = false;
        pnlN.Visible = false;
        pnlO.Visible = false;
        pnlP.Visible = false;
        pnlQ.Visible = false;
        pnlR.Visible = false;
        pnlS.Visible = false;
        pnlT.Visible = false;
        pnlU.Visible = false;
        pnlV.Visible = false;
        pnlW.Visible = false;
        pnlY.Visible = false;
    }
}
