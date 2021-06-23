using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Uts_web2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                CustomValidator1.Validate();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            

            if (Page.IsValid == true)
            {
                message.Text = "Hello " + username.Text + " ! ";
                message.Text = message.Text + " <br/> You have successfuly Registered with the following details.";
                ShowUserName.Text = username.Text;
                ShowEmail.Text = EmailID.Text;

                ShowUserNameLabel.Text = "User Name";
                ShowEmailIDLabel.Text = "Email ID";
                ShowGenderLabel.Text = "Gender";
                ShowCourseLabel.Text = "Courses";
                username.Text = "";
                EmailID.Text = "";
                
                ShowCourses.Text += course.SelectedItem.Text.ToString();
                ShowGender.Text += rdGender.SelectedItem.Text.ToString();
            }
            else
            {
                Label7.Text = "Required field is empty!";
            }
        }
        
        
        }  
    }

    
