using System.Text;
using Projects;

namespace Roles
{
    public class ConstructionWorker : IProjectParticipant
    {
        private Project _project;
        public ConstructionWorker(Project project)
        {
            _project = project;
        }

        public Project PerformDuties()
        {
            string thisRoleName = "Construction Worker";
            
            StringBuilder sb = new();

            string[] thingsTheConstructionWorkerDoes = {
                "am looking at the blueprints",
                "am reading the jobs list",
                "am thinking about what work there is to do",
                "am grabbing my tools and getting to work"
            };

            foreach (string thingToDo in thingsTheConstructionWorkerDoes)
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