using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace OnlineQuiz
    {
    public partial class Questions : System.Web.UI.Page
        {
        ASP_NET_QuizEntities3 QuizEntity = new ASP_NET_QuizEntities3();
        protected void Page_Load(object sender, EventArgs e)
            {
            if(!Page.IsPostBack)
                {
                var listOfQuestions = QuizEntity.Questions;

                Repeater1.DataSource=listOfQuestions.ToList();
                Repeater1.DataBind();
                
                }
            
            }
        
        protected void btnSubmitAnswer_Click(object sender, EventArgs e)
            {
            var listOfQuestions = QuizEntity.Questions;
            int points = GetScore(listOfQuestions);
            int userId = int.Parse(Request.QueryString["Id"]);

            Game game = new Game();
            game.UserId=userId;
            QuizEntity.Games.Add(game);
            QuizEntity.SaveChanges();

            Round round = new Round();
            round.GameId=game.GameId;
            round.Points=points;
            round.Date=DateTime.Now;
            QuizEntity.Rounds.Add(round);
            QuizEntity.SaveChanges();

            GetScore1(Repeater1);
            
            }

        public int GetScore1(Repeater r)
        {
        var answerList = GetAnswers();
        int score = 0;
        int i = 0;

            
        var qList = QuizEntity.Questions.Where(x => x.Question1!=null);
        List<Question> questionList= new List<Question>();
            foreach (var item in qList)
	        {
		        questionList.Add(item);
                questionList.Add(item);
                questionList.Add(item);
            }

        foreach(RepeaterItem rptr in Repeater1.Items)
            {
            Label lblOne = (Label)rptr.FindControl("Label1");
            Label lblTwo = (Label)rptr.FindControl("Label2");
            Label lblThree = (Label)rptr.FindControl("Label3");

            string a1 = answerList[i].ToString();
            string a2 = answerList[i+1].ToString();
            string a3 = answerList[i+2].ToString();

            
                if(questionList[i].Answer1.Value == true && a1=="True")
                    {
                    score+=1;
                    lblOne.Text=" Rätt";

                    }
                else if(questionList[i].Answer1.Value == false && a1=="True")
                    {
                    score-=1;
                    lblOne.Text=" Fel";
                    }
                if(questionList[i+1].Answer2.Value == true && a2=="True")
                    {
                    score+=1;
                    lblTwo.Text = " Rätt";
                    }
                else if(questionList[i+1].Answer2.Value == false && a2=="True")
                    {
                    score-=1;
                    lblTwo.Text = " Fel";
                    }
                if(questionList[i+2].Answer3.Value == true && a3=="True")
                    {
                    score+=1;
                    lblThree.Text = " Rätt";
                    }
                else if(questionList[i+2].Answer3.Value == false && a3=="True")
                    {
                    score-=1;
                    lblThree.Text = " Fel";
                    }
                
            
            i+=3;
            }
        return score;
        }
        public int GetScore(IEnumerable<Question> e)
            {
            var answerList = GetAnswers();
            int score=0;
            int i =0;
            
            foreach(var item in e)
                {
                string a1 = answerList[i].ToString();
                string a2 = answerList[i+1].ToString();
                string a3 = answerList[i+2].ToString();

                if(item.Answer1.Value == true && a1=="True")
                    {
                    score+=1;
                    
                    }
                else if(item.Answer1.Value == false && a1=="True")
                    {
                    score-=1;

                    }
                if(item.Answer2.Value == true && a2=="True")
                    {
                    score+=1;
                    }
                else if(item.Answer2.Value == false && a2=="True")
                    {
                    score-=1;
                    }
                if(item.Answer3.Value == true && a3=="True")
                    {
                    score+=1;
                    }
                else if(item.Answer3.Value == false && a3=="True")
                    {
                    score-=1;
                    }
                i+=3;
                }
            return score;
            }
        public List<String> GetAnswers() 
            {
            List<String> listOfAnswers=new List<string>();
            foreach(RepeaterItem aItem in Repeater1.Items)
                {

                HtmlInputCheckBox MyCheckBox1 = (HtmlInputCheckBox)aItem.FindControl("CheckBox1");
                HtmlInputCheckBox MyCheckBox2 = (HtmlInputCheckBox)aItem.FindControl("CheckBox2");
                HtmlInputCheckBox MyCheckBox3 = (HtmlInputCheckBox)aItem.FindControl("CheckBox3");

                if(MyCheckBox1.Checked)
                    {
                    listOfAnswers.Add("True");
                    }
                else
                    {
                    listOfAnswers.Add("False");
                    }
                if(MyCheckBox2.Checked)
                    {
                    listOfAnswers.Add("True");
                    }
                else
                    {
                    listOfAnswers.Add("False");
                    }
                if(MyCheckBox3.Checked)
                    {
                    listOfAnswers.Add("True");
                    }
                else
                    {
                    listOfAnswers.Add("False");
                    }

                }
            return listOfAnswers;
            }

        protected void showScore_Click(object sender, EventArgs e)
            {
            int userId = int.Parse(Request.QueryString["Id"]);
            Response.Redirect(String.Format("Resultat.aspx?points={0}&userId={1}",
                Server.UrlEncode(GetScore1(Repeater1).ToString()), Server.UrlEncode(userId.ToString())));
            }

        }
    }