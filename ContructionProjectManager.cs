using System.Text;
using Projects;

namespace Roles
{
    public class ConstructionProjectManager : IProjectParticipant
    {
        private Project _project;
        public ConstructionProjectManager(Project project)
        {
            _project = project;
        }

        public Project PerformDuties()
        {
            string thisRoleName = "Construction Project Manager";
            
            StringBuilder sb = new();

            string[] thingsTheProjectManagerDoes = {
                "am looking at the blueprints",
                "am thinking about what work there is to do",
                "am creating a schedule and job list"
            };

            foreach (string thingToDo in thingsTheProjectManagerDoes)
            {
                sb.Append($"The {thisRoleName} says: ");
                sb.AppendLine(SayDoingThing(thingToDo));   
            }

            _project.AddToTranscript(sb.ToString());

            return _project;
        }

        private string SayDoingThing(string sentencePredicate) {
            return $"I {sentencePredicate}.";
        }
    }
}