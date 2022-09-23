using Roles;

namespace Projects
{
    public class Project
    {
        public IProjectParticipant[] Participants;
        public List<string> TranscriptOfThingsParticipantsHaveSaidAboutTheProject;

        public Project(params Type[] participantTypes)
        {
            TranscriptOfThingsParticipantsHaveSaidAboutTheProject = new List<string>();
            List<IProjectParticipant> participantsList = new();
            
            foreach (Type participantType in participantTypes) {
                
                IProjectParticipant participant = (IProjectParticipant)Activator.CreateInstance(participantType, this);
                
                _ = participant ?? throw new ArgumentException("Participant object instance couldn't be created.");

                participantsList.Add(participant);
                
            }
            Participants = participantsList.ToArray();
        }

        public void CommenceProject() {
            foreach (var participant in Participants)
            {
                participant.PerformDuties();
            }
        }

        public void AddToTranscript(string dialog) {
            TranscriptOfThingsParticipantsHaveSaidAboutTheProject.Add(dialog);
        }

        public string GetTranscriptText() {
            string text = string.Empty;

            foreach (string transcriptItem in TranscriptOfThingsParticipantsHaveSaidAboutTheProject) {
                text += transcriptItem;
            }

            return text;
        }
    }
}