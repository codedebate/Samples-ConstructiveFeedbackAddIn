using System;
using System.Reflection;

namespace CodeDebate.Samples.ConstructiveFeedback.Api.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}