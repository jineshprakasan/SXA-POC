using Sitecore.Data;

namespace Aceto.XA.Feature.Navigation
{
    public struct Templates
    {
        public struct Navigation
        {
            public static readonly ID ID = new ID("{499C7954-69BD-4561-8A25-598EC02A0419}");
            public struct Fields
            {
                public static readonly ID Title = new ID("{6D1C719D-C0E7-41DC-A415-6892D3003312}");
                public static readonly ID Url = new ID("{DA2DFA79-743F-4AC8-A7AE-D809F9C60801}");
            }
        }
        public struct NavigationList
        {
            public static readonly ID ID = new ID("{53D53C3D-684B-4DC4-9341-18C9F3CFA4C1}");
        }
        public struct IsNavigable
        {
            public static readonly ID ID = new ID("{0EADA11A-020F-4491-B501-B55A6A2C1512}");
            public struct Fields
            {
                public static readonly ID IsNavItem = new ID("{44C73AA6-8D84-41B4-9C6A-A0BF1C3C6B91}");
            }

        }
        public struct SubNav
        {
            public static readonly ID ID = new ID("{CA4BC172-7E30-4193-A91D-028EBF251D6D}");
            public struct Fields
            {
                public static readonly ID Title = new ID("{B4C0A45E-C3A0-448A-B00E-FE18A328DFF2}");
                public static readonly ID Icon = new ID("{6B646500-4BE4-4583-BAB0-C9D00CAE9B07}");
                public static readonly ID ActiveIcon = new ID("{4BEB9E25-CEAB-43CF-A4F4-374149945293}");
            }
        }
    }
}