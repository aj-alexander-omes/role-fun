using Projects;
using Roles;

//
// Way One
//

/*

Project project = new();

Architect architect = new(project);

project = architect.PerformDuties();

ConstructionProjectManager pm = new(project);

project = pm.PerformDuties();

ConstructionWorker worker = new(project);

project = worker.PerformDuties();

Console.WriteLine(project.GetTranscriptText());

*/


//
// Way Two
//

Type[] participantTypes = {
    typeof(Architect),
    typeof(ConstructionProjectManager),
    typeof(ConstructionWorker)
};

Project project = new(participantTypes);

project.CommenceProject();

Console.WriteLine(project.GetTranscriptText());

Console.Write("Press any key to end...");
Console.ReadKey();