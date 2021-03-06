using JetBrains.Application;
using JetBrains.ReSharper.Psi;
using JetBrains.TextControl;

namespace ReSharperPlugin.TestLinker.Navigation
{
    [ShellFeaturePart]
    public class LinkedTypesContextSearch : LinkedTypesContextSearchBase
    {
        protected override LinkedTypesSearchRequest CreateSearchRequest(ITypeElement type, ITextControl textControl)
        {
            return new LinkedTypesSearchRequest(type, textControl, derivedNamesOnly: false);
        }
    }
}