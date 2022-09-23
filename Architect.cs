using System.Text;
using Projects;

namespace Roles
{
    public class Architect : IProjectParticipant
    {
        private Project _project;
        public Architect(Project project)
        {
            _project = project;
        }

        public Project PerformDuties()
        {
            string thisRoleName = "Architect";
            
            StringBuilder sb = new();

            string[] thingsTheArchitectDoes = {
                "am thinking about what building to make",
                "am doing research",
                "am making sketches",
                "am talking with drafters",
                "am creating blueprints",
                "am editing blueprints",
                "am approving blueprints",
                "sending blueprints to the construction company Project Manager"
            };

            foreach (string thingToDo in thingsTheArchitectDoes)
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