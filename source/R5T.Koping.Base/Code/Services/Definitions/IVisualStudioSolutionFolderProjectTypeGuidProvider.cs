using System;using R5T.T0064;


namespace R5T.Koping
{[ServiceDefinitionMarker]
    /// <summary>
    /// Solution files can group projects in solution folders (for example "_Dependencies").
    /// These solution folders are treated as projects by Visual Studio (they have a project reference, just like any other project in the solution file), but with the particular property of being able to have nested projects mapped to them.
    /// This service provides the project type GUID value that indicates a project is a solution folder.
    /// </summary>
    public interface IVisualStudioSolutionFolderProjectTypeGuidProvider:IServiceDefinition
    {
        Guid GetVisualStudioSolutionFolderProjectTypeGuid();
    }
}
