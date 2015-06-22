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
using System.Data.Linq;
using System.Data.SqlClient;
using System.Text;

public partial class usercontrol_topimage : System.Web.UI.UserControl
{
    //private string _callBackStatus;
    //static int room = 1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {

        }
        //if (Session["UserName"] != null)
        //{
        //    imgchat.Visible = true;
        //    pnlchat.Visible = true;
        //    //string user1 = Convert.ToString(Session["UserName"]);
        //    LinqChatDataContext db = new LinqChatDataContext();

        //    var user = (from u in db.Users
        //                where u.Username == Convert.ToString(Session["UserName"])
        //                select u).SingleOrDefault();

        //    if (user != null)
        //    {
        //        Session["ChatUserID"] = user.UserID;
        //        Session["ChatUsername"] = user.Username;
        //    }

        //}
        //else
        //{
        //    imgchat.Visible = false;
        //    pnlchat.Visible = false;
        //}
    }

    //        private void GetRoomInformation()
    //        {
    //            // get the room information from the database
    //            // we're going to set this up so that we can use
    //            // many rooms if we want to
    //            LinqChatDataContext db = new LinqChatDataContext();
    //            var room = (from r in db.Rooms
    //                        where r.RoomID == 1
    //                        select r).SingleOrDefault();
    //            //lblRoomId.Text = room.RoomID.ToString();
    //            lblRoomName.Text = room.Name;
    //        }

    //        protected void BtnSend_Click(object sender, EventArgs e)
    //        {
    //            if (txtMessage.Text.Length > 0)
    //            {
    //                this.InsertMessage(null);
    //                this.GetMessages("chat");
    //                txtMessage.Text = String.Empty;
    //                ScriptManager1.SetFocus(txtMessage.ClientID);
    //            }
    //        }

    //        protected void Timer1_OnTick(object sender, EventArgs e)
    //        {
    //            this.GetLoggedInUsers();
    //            this.GetMessages("chat");

    //            if ((string)Session["IsChatroomInFocus"] == null)
    //                ScriptManager1.SetFocus(txtMessage);
    //        }

    //        /// <summary>
    //        /// This will insert the passed text to the message table in the database
    //        /// </summary>
    //        private void InsertMessage(string text)
    //        {
    //            if (Session["UserName"] != null)
    //            {
    //            LinqChatDataContext db = new LinqChatDataContext();

    //            Message message = new Message();
    //            message.RoomID = room;
    //            message.UserID = Convert.ToInt32(Session["ChatUserID"]);

    //            if (String.IsNullOrEmpty(text))
    //            {
    //                message.Text = txtMessage.Text.Replace("<", "");
    //            }
    //            else
    //            {
    //                message.Text = text;
    //            }

    //            message.Color = "gray";
    //            message.ToUserID = (from u in db.Users
    //                                where u.UserID == Convert.ToInt32(Session["ChatUserID"])
    //                                select u.Firstname).SingleOrDefault();
    //            message.TimeStamp = DateTime.Now;
    //            message.Login_Status = 1;
    //            db.Messages.InsertOnSubmit(message);
    //            db.SubmitChanges();
    //                }
    //        }

    //        private void GetLoggedInUsers()
    //        {
    //            if (Session["UserName"] != null)
    //            {
    //                LinqChatDataContext db = new LinqChatDataContext();

    //                // let's check if this authenticated user exist in the
    //                // LoggedInUser table (means user is logged-in to this room)
    //                var user = (from u in db.LoggedInUsers
    //                            where u.UserID == Convert.ToInt32(Session["ChatUserID"])
    //                            && u.RoomID == 1
    //                            select u).SingleOrDefault();

    //                // if user does not exist in the LoggedInUser table
    //                // then let's add/insert the user to the table
    //                if (user == null)
    //                {
    //                    LoggedInUser loggedInUser = new LoggedInUser();
    //                    loggedInUser.UserID = Convert.ToInt32(Session["ChatUserID"]);
    //                    loggedInUser.RoomID = room;
    //                    db.LoggedInUsers.InsertOnSubmit(loggedInUser);
    //                    db.SubmitChanges();
    //                }

    //                string userIcon;
    //                StringBuilder sb = new StringBuilder();

    //                // get all logged in users to this room
    //                var loggedInUsers = from l in db.LoggedInUsers
    //                                    where l.RoomID == 1
    //                                    select l;

    //                // list all logged in chat users in the user list
    //                foreach (var loggedInUser in loggedInUsers)
    //                {
    //                    // show user icon based on sex
    //                    if (loggedInUser.User.Sex.ToString().ToLower() == "m")
    //                        userIcon = "<img src='Images/manIcon.gif' style='vertical-align:middle' alt=''>  ";
    //                    else
    //                        userIcon = "<img src='Images/womanIcon.gif' style='vertical-align:middle' alt=''>  ";

    //                    if (loggedInUser.User.Username != (string)Session["ChatUsername"])
    //                        sb.Append(userIcon + "<a href=#>" + loggedInUser.User.Username + "</a><br>");
    //                    else
    //                        sb.Append(userIcon + "<b>" + loggedInUser.User.Username + "</b><br>");
    //                }

    //                // holds the names of the users shown in the chatroom
    //                //litUsers.Text = sb.ToString();
    //            }
    //        }

    //        /// <summary>
    //        /// Get the last 20 messages for this room
    //        /// </summary>
    //        private void GetMessages(string text)
    //        {
    //            if (Session["UserName"] != null)
    //            {
    //                LinqChatDataContext db = new LinqChatDataContext();
    //                switch (text)
    //                {
    //                    case "chat":
    //                        var messages = (from m in db.Messages
    //                                        where m.RoomID == 1 && m.Login_Status == 1
    //                                        orderby m.TimeStamp descending
    //                                        select m).Take(20).OrderBy(m => m.TimeStamp);
    //                        if (messages != null)
    //                        {
    //                            StringBuilder sb = new StringBuilder();
    //                            int ctr = 0;    // toggle counter for alternating color

    //                            foreach (var message in messages)
    //                            {
    //                                // alternate background color on messages
    //                                if (ctr == 0)
    //                                {
    //                                    sb.Append("<div style='padding: 10px;'>");
    //                                    ctr = 1;
    //                                }
    //                                else
    //                                {
    //                                    sb.Append("<div style='background-color: #EFEFEF; padding: 10px;'>");
    //                                    ctr = 0;
    //                                }

    //                                if (message.User.Sex.ToString().ToLower() == "m")
    //                                    sb.Append("<img src='Images/manIcon.gif' style='vertical-align:middle' alt=''>  " + message.User.Username.ToString() + " : " + message.Text + "</div>");
    //                                else
    //                                    sb.Append("<img src='Images/womanIcon.gif' style='vertical-align:middle' alt=''>  " + message.User.Username.ToString() + " : " + message.Text + "</div>");
    //                            }

    //                            litMessages.Text = sb.ToString();
    //                        }
    //                        break;
    //                    case "History":
    //                        var history_messages = (from m in db.Messages
    //                                                where m.RoomID == 1
    //                                                orderby m.TimeStamp descending
    //                                                select m).Take(10).OrderBy(m => m.TimeStamp);
    //                        if (history_messages != null)
    //                        {
    //                            StringBuilder sb = new StringBuilder();
    //                            int ctr = 0;    // toggle counter for alternating color

    //                            foreach (var message in history_messages)
    //                            {
    //                                // alternate background color on messages
    //                                if (ctr == 0)
    //                                {
    //                                    sb.Append("<div style='padding: 10px;'>");
    //                                    ctr = 1;
    //                                }
    //                                else
    //                                {
    //                                    sb.Append("<div style='background-color: #EFEFEF; padding: 10px;'>");
    //                                    ctr = 0;
    //                                }

    //                                if (message.User.Sex.ToString().ToLower() == "m")
    //                                    sb.Append("<img src='Images/manIcon.gif' style='vertical-align:middle' alt=''>  " + message.User.Username.ToString() + " : " + message.Text + "</div>");
    //                                else
    //                                    sb.Append("<img src='Images/womanIcon.gif' style='vertical-align:middle' alt=''>  " + message.User.Username.ToString() + " : " + message.Text + "</div>");
    //                            }

    //                            litMessages.Text = sb.ToString();
    //                        }
    //                        break;
    //                    default:
    //                        var start_message = (from m in db.Messages
    //                                             where m.RoomID == 1 && m.Login_Status == 1
    //                                             orderby m.TimeStamp descending
    //                                             select m).Take(1).OrderBy(m => m.TimeStamp);
    //                        if (start_message != null)
    //                        {
    //                            StringBuilder sb = new StringBuilder();
    //                            int ctr = 0;    // toggle counter for alternating color

    //                            foreach (var message in start_message)
    //                            {
    //                                // alternate background color on messages
    //                                if (ctr == 0)
    //                                {
    //                                    sb.Append("<div style='padding: 10px;'>");
    //                                    ctr = 1;
    //                                }
    //                                else
    //                                {
    //                                    sb.Append("<div style='background-color: #EFEFEF; padding: 10px;'>");
    //                                    ctr = 0;
    //                                }

    //                                if (message.User.Sex.ToString().ToLower() == "m")
    //                                    sb.Append("<img src='Images/manIcon.gif' style='vertical-align:middle' alt=''>  " + message.User.Username.ToString() + " : " + message.Text + "</div>");
    //                                else
    //                                    sb.Append("<img src='Images/womanIcon.gif' style='vertical-align:middle' alt=''>  " + message.User.Username.ToString() + " : " + message.Text + "</div>");
    //                            }

    //                            litMessages.Text = sb.ToString();
    //                        }
    //                        break;
    //                }
    //            }

    //        }

    //        protected void BtnLogOut_Click(object sender, EventArgs e)
    //        {
    //            if (Session["UserName"] != null)
    //            {
    //                // log out the user by deleting from the LoggedInUser table
    //                LinqChatDataContext db = new LinqChatDataContext();
    //                var loggedInUser = (from l in db.LoggedInUsers
    //                                    where l.UserID == Convert.ToInt32(Session["ChatUserID"])
    //                                    && l.RoomID == 1
    //                                    select l).SingleOrDefault();
    //                db.LoggedInUsers.DeleteOnSubmit(loggedInUser);
    //                db.SubmitChanges();

    //                // insert a message that this user has logged out
    //                this.InsertMessage("Just logged out! " + DateTime.Now.ToString());
    //                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LinqChatConnectionString"].ToString());
    //                con.Open();
    //                SqlCommand cmd = new SqlCommand("reset_status", con);
    //                cmd.CommandType = CommandType.StoredProcedure;
    //                cmd.Parameters.AddWithValue("@count", 1);
    //                cmd.ExecuteNonQuery();
    //                con.Close();
    //                // clean the session
    //                Session.RemoveAll();
    //                Session.Abandon();

    //                // redirect the user to the login page
    //                //Response.Redirect("Chat.aspx");
    //            }
    //        }

    //        #region ICallbackEventHandler Members

    //        string System.Web.UI.ICallbackEventHandler.GetCallbackResult()
    //        {
    //            return _callBackStatus;
    //        }

    //        void System.Web.UI.ICallbackEventHandler.RaiseCallbackEvent(string eventArgument)
    //        {
    //            _callBackStatus = "failed";

    //            // log out the user by deleting from the LoggedInUser table
    //            LinqChatDataContext db = new LinqChatDataContext();

    //            var loggedInUser = (from l in db.LoggedInUsers
    //                                where l.UserID == Convert.ToInt32(Session["ChatUserID"])
    //                                && l.RoomID == 1
    //                                select l).SingleOrDefault();

    //            db.LoggedInUsers.DeleteOnSubmit(loggedInUser);
    //            db.SubmitChanges();

    //            // insert a message that this user has logged out
    //            this.InsertMessage("Just logged out! " + DateTime.Now.ToString());

    //            _callBackStatus = "success";
    //        }

    //        #endregion
    //        protected void his_Click(object sender, EventArgs e)
    //        {
    //            GetMessages("History");
    //        }
    //        protected void imgchat_Click(object sender, ImageClickEventArgs e)
    //        {
    //            if (!IsPostBack)
    //            {
    //                // for simplity's sake we're going to assume that a
    //                // roomId was passed in the query string and that
    //                // it is an integer
    //                // note: in reality you would check if the roomId is empty
    //                // and is an integer

    //                string roomId = Convert.ToString(room);
    //                //lblRoomId.Text = roomId;

    //                this.GetRoomInformation();
    //                this.GetLoggedInUsers();
    //                this.InsertMessage(ConfigurationManager.AppSettings["ChatLoggedInText"] + " " + DateTime.Now.ToString());
    //                this.GetMessages("start");

    //                // create a call back reference so we can log-out user when user closes the browser
    //                string callBackReference = Page.ClientScript.GetCallbackEventReference(this, "arg", "LogOutUser", "");
    //                string logOutUserCallBackScript = "function LogOutUserCallBack(arg, context) { " + callBackReference + "; }";
    //                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "LogOutUserCallBack", logOutUserCallBackScript, true);
    //            }
    //        }
    //}
    protected void btnTwitter_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("https://twitter.com/justcalluz");
    }
}
