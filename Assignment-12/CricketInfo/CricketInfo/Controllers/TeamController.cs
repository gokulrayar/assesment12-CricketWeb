using CricketInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CricketInfo.Controllers
{
    public class TeamController : Controller
    {
        static List<Team> listTeam = new List<Team>()
    {
        new Team (){Id =1,Name="India",NOWC=3},
        new Team(){Id = 2,Name = "Aus",NOWC=6},
        new Team (){Id =3,Name="Srilanka",NOWC=1},
    };
        // GET: Team
        public ActionResult Index()
        {
            return View(listTeam );
        }
    }
}