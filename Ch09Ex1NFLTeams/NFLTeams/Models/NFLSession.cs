using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace NFLTeams.Models
{
    public class NFLSession
    {
        private const string TeamsKey = "myteams";
        private const string CountKey = "teamcount";
        private const string ConfKey = "conf";
        private const string DivKey = "div";
        private const string NameKey = "defaultName"; //Create a new string for the name

        private ISession session { get; set; }
        public NFLSession(ISession session) {
            this.session = session;
        }

        public void SetMyTeams(List<Team> teams) {
            session.SetObject(TeamsKey, teams);
            session.SetInt32(CountKey, teams.Count);
        }
        public List<Team> GetMyTeams() =>
            session.GetObject<List<Team>>(TeamsKey) ?? new List<Team>();
        public int? GetMyTeamCount() => session.GetInt32(CountKey);
        //Setting the name
        public void SetName(string userName = "user name") 
        {
            session.SetString(NameKey, userName);
        }
        public string GetName() => session.GetString(NameKey); //Call

        public void SetActiveConf(string conference) =>
            session.SetString(ConfKey, conference);
        public string GetActiveConf() => session.GetString(ConfKey);

        public void SetActiveDiv(string division) =>
            session.SetString(DivKey, division);
        public string GetActiveDiv() => session.GetString(DivKey);

        public void RemoveMyTeams() {
            session.Remove(TeamsKey);
            session.Remove(CountKey);
        }
    }
}
