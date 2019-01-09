using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Advertisement.Application.Helpers
{
    public static class TypeFinder
    {
        private const string AssemblySkipLoadingPattern = "^Elmah|^FluentValidation|^System|^mscorlib|^Microsoft|^AjaxControlToolkit|^Antlr3|^Kendo|^Ionic.Zip|^CaptchaMvc|^Autofac|^StructureMap|^Ninject|^Unity|^Ioniz.Zip|^Owin|^AutoMapper|^Castle|^ComponentArt|^CppCodeProvider|^DotNetOpenAuth|^EntityFramework|^EPPlus|^FluentValidation|^ImageResizer|^itextsharp|^log4net|^MaxMind|^MbUnit|^MiniProfiler|^Mono.Math|^MvcContrib|^Newtonsoft|^NHibernate|^nunit|^Org.Mentalis|^PerlRegex|^QuickGraph|^Recaptcha|^Remotion|^RestSharp|^Rhino|^Telerik|^Iesi|^TestDriven|^TestFu|^UserAgentStringLibrary|^VJSharpCodeProvider|^WebActivator|^WebDev|^WebGrease";
        private const string AssemblyRestrictToLoadingPattern = ".*";

        private static bool Matches(string assemblyFullName)
        {
            return !Matches(assemblyFullName, AssemblySkipLoadingPattern)
                   && Matches(assemblyFullName, AssemblyRestrictToLoadingPattern);
        }

        private static bool Matches(string assemblyFullName, string pattern)
        {
            return Regex.IsMatch(assemblyFullName, pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);
        }

        public static IEnumerable<T> GetAllInstancesOf<T>()
        {
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .Where(assembly => Matches(assembly.FullName))
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => typeof(T).IsAssignableFrom(type) &&
                               !type.IsAbstract &&
                               !type.IsInterface &&
                               type.IsClass);

            return types.Select(task => (T)Activator.CreateInstance(task));
        }

        public static IEnumerable<T> GetAllInheritancesOf<T>() where T : class
        {
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .Where(assembly => Matches(assembly.FullName))
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => type.BaseType != null &&
                               type.BaseType == typeof(T) &&
                               type.IsSubclassOf(typeof(T)) &&
                               !type.IsAbstract &&
                               type.IsClass);

            return types.Select(type => (T)Activator.CreateInstance(type));
        }

        public static IEnumerable<Type> GetAllInheritanceTypesOf<T>() where T : class
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .Where(assembly => Matches(assembly.FullName))
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => type.BaseType != null &&
                               type.BaseType == typeof(T) &&
                               type.IsSubclassOf(typeof(T)) &&
                               !type.IsAbstract &&
                               type.IsClass);
        }

        public static IEnumerable<Type> GetAllInheritanceTypesOf<T>(Type excludeType) where T : class
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .Where(assembly => Matches(assembly.FullName))
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => type != excludeType &&
                               type.BaseType != null &&
                               type.BaseType == typeof(T) &&
                               type.IsSubclassOf(typeof(T)) &&
                               !type.IsAbstract &&
                               type.IsClass);
        }

        public static IEnumerable<Type> GetAllGenericTypesOf(Type genericType)
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .Where(assembly => Matches(assembly.FullName))
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => !string.IsNullOrEmpty(type.Namespace))
                .Where(type => type.BaseType != null &&
                               type.BaseType.IsGenericType &&
                               type.BaseType.GetGenericTypeDefinition() == genericType);
        }

        public static IEnumerable<Type> GetAllGenericTypesOf(Type genericType, Type excludeType)
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .Where(assembly => Matches(assembly.FullName))
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => !string.IsNullOrEmpty(type.Namespace))
                .Where(type => type != excludeType &&
                               type.BaseType != null &&
                               type.BaseType.IsGenericType &&
                               type.BaseType.GetGenericTypeDefinition() == genericType);
        }

        public static Assembly GetAssembly(string assemblyName)
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .SingleOrDefault(assembly => assembly.GetName().Name == assemblyName);
        }

        public static IEnumerable<Assembly> GetAllAssemblies()
        {
            return AppDomain.CurrentDomain.GetAssemblies();
        }
    }
}