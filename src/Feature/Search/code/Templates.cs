using Sitecore.Data;

namespace Aceto.XA.Feature.Search
{
    public struct Templates
    {
        public struct GlobalSearch
        {
            public static readonly ID ID = ID.Parse("{0FA24554-6AF3-40AE-8498-3A3674D2634C}");
            public struct Fields
            {
                public static ID TextBoxText = new ID("{71CA1A51-DFA7-4EC7-9169-ABC096F760AA}");
            }
        }
    }
}