using DAL.DtoClasses;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DtoFunctions
{
    public class ProjectsService : IInfo
    {
        List<Project> listProjects = new List<Project>
        {
            new Project{id="1111", name="Backend Project", score=88, durationInDays=35, bugsCount=12,madeDadeline = true },
            new Project{id="2222", name="Backend Project", score=81, durationInDays=15, bugsCount=7,madeDadeline = false },
            new Project{id="3333", name="Backend Project", score=95, durationInDays=20, bugsCount=18,madeDadeline = true },
            new Project{id="4444", name="Backend Project", score=65, durationInDays=40, bugsCount=11,madeDadeline = false },
            new Project{id="5555", name="Design Project", score=69, durationInDays=45, bugsCount=14,madeDadeline = true },
            new Project{id="6666", name="Design Project", score=77, durationInDays=65, bugsCount=30,madeDadeline = false },
            new Project{id="7777", name="Design Project", score=82, durationInDays=70, bugsCount=38,madeDadeline = false },
            new Project{id="8888", name="Fullstack Project", score=98, durationInDays=23, bugsCount=88,madeDadeline = true },
            new Project{id="9999", name="Fullstack Project", score=93, durationInDays=28, bugsCount=12,madeDadeline = false },
            new Project{id="1125", name="Fullstack Project", score=71, durationInDays=52, bugsCount=18,madeDadeline = true },
            new Project{id="1522", name="Fullstack Project", score=84, durationInDays=41, bugsCount=25,madeDadeline = false },
            new Project{id="1589", name="Frontend Project", score=87, durationInDays=23, bugsCount=60,madeDadeline = true },
            new Project{id="158585", name="Frontend Project", score=58, durationInDays=39, bugsCount=30,madeDadeline = true },
            new Project{id="12828", name="Frontend Project", score=91, durationInDays=35, bugsCount=20,madeDadeline = true },
            new Project{id="252525", name="Frontend Project", score=100, durationInDays=47, bugsCount=74,madeDadeline = false },
        };

        public List<Project> GetAllProjects()
        {
            return listProjects;
        }
    }
}
