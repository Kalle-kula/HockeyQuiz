using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineQuiz
    {
    public partial class Resultat : System.Web.UI.Page
        {
        ASP_NET_QuizEntities3 QuizEntity = new ASP_NET_QuizEntities3();
        protected void Page_Load(object sender, EventArgs e)
            {

            }
        public double GetTotalAverage()
            {
            double i = 0;
            var avg = from r in
                          (from r in QuizEntity.Rounds
                           select new
                           {
                               r.Points,
                               Dummy = "x"
                           })
                      group r by new { r.Dummy } into g
                      select new
                      {
                          Column1 = (double?)g.Average(p => p.Points)
                      };
            foreach(var item in avg)
                {
                i=item.Column1.Value;
                }
            return i;
            }

        public double GetAverage(int uid)
            {
            double i = 0;
            var avg = from r in
                          (from r in QuizEntity.Rounds
                           where
                           r.Game.User.UserId == uid
                           select new
                           {
                               r.Points,
                               Dummy = "x"
                           })
                      group r by new { r.Dummy } into g
                      select new { Column1 = (double?)g.Average(p => p.Points) };

            foreach(var item in avg)
                {
                i=item.Column1.Value;
                }

            return i;
            }
        protected void lblScore_Load(object o, EventArgs e)
            {
                
                lblScore.Text=String.Format("Din poäng denna runda: {0}", Request.QueryString["points"]);
            }
        protected void lblYourAverage_Load(object o, EventArgs e) 
            {
               int uid = int.Parse(Request.QueryString["userId"]);
               lblYourAverage.Text=String.Format("Din medelpoäng är: {0:0.0}", GetAverage(uid));
            }
        protected void lblTotalAverage_Load(object o, EventArgs e) 
            {
                lblTotalAverage.Text=String.Format("Den totala medelpoängen är: {0:0.0}", GetTotalAverage());
            }
        }
    }