﻿using Aceto.XA.Foundation.SitecoreExtensions.Methods;
using Glass.Mapper.IoC;
using Glass.Mapper.Maps;
using System;
using System.Reflection;

namespace Aceto.XA.Foundation.ORM.Extensions
{
    public static class MapsConfigFactoryExtension
    {
        public static void AddFluentMaps(this IConfigFactory<IGlassMap> mapsConfigFactory, params string[] assemblyFilters)
        {
            var assemblies = GetAssemblies.GetByFilter(assemblyFilters);

            AddFluentMaps(mapsConfigFactory, assemblies);
        }

        public static void AddFluentMaps(this IConfigFactory<IGlassMap> mapsConfigFactory, params Assembly[] assemblies)
        {
            var mappings = GetTypes.GetTypesImplementing<IGlassMap>(assemblies);

            foreach (var map in mappings)
            {
                mapsConfigFactory.Add(() => Activator.CreateInstance(map) as IGlassMap);
            }
        }
    }
}