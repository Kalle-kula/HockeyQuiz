using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineQuiz
    {
    public partial class Default : System.Web.UI.Page
        {
        ASP_NET_QuizEntities3 QuizEntity = new ASP_NET_QuizEntities3();
        
        protected void Page_Load(object sender, EventArgs e)
            {
            
            }

        protected void Enter_Click(object sender, EventArgs e)
            {
            var userList = QuizEntity.Users.Where(u => u.UserId!=null);

            foreach(var item in userList)
                {
                string pwd = item.UserPassword.Trim().ToString();
                int id = item.UserId;
                if(password.Text==pwd && userId.Text==item.UserName)
                    {
                    Response.Redirect("Questions.aspx?Id="+id);
                    }
                }
            }

        protected void btnSubmitQuestion_Click(object sender, EventArgs e)
            {
            Question q = new Question();
            q.Question1=Question.Text;
            q.Multiple1=Multiple1.Text;
            q.Multiple2=Multiple2.Text;
            q.Multiple3=Multiple3.Text;
            q.Answer1=CheckBox1.Checked? true:false;
            q.Answer2=CheckBox2.Checked? true:false;
            q.Answer3=CheckBox3.Checked? true:false;
            QuizEntity.Questions.Add(q);
            QuizEntity.SaveChanges();

            Question.Text="";
            Multiple1.Text="";
            Multiple2.Text="";
            Multiple3.Text="";
            CheckBox1.Checked=false;
            CheckBox2.Checked=false;
            CheckBox3.Checked=false;

            }

        protected void LinkButton1_Click(object sender, EventArgs e)
            {
            User user = new User();
            user.UserName=userId.Text;
            user.UserPassword=password.Text;

            if(user.UserName !=null && user.UserPassword !=null)
                {
                QuizEntity.Users.Add(user);
                QuizEntity.SaveChanges();
                }
            
            userId.Text="";
            password.Text="";
            }

 
        }
    }