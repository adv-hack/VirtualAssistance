using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class GeneratedRuntimeType
    {
        /// <summary>
        ///     Gets the declaration name for a runtime type.
        /// </summary>
        public static String GetTypeName(Type type)
        {
            return GeneratedRuntimeType.GetTypeName(type, false);
        }

        /// <summary>
        ///     Gets the declaration name for a runtime type.
        /// </summary>
        public static String GetTypeName(Type type, Boolean stripModel)
        {
            String typeName = type.Name;
            if (type.IsGenericType)
                typeName = typeName.Split('`').First() + "<" + String.Join(", ", type.GetGenericArguments().Select(GetTypeName)) + ">";

            // Prefix the type with its namespace and suffix array types with square brackets
            if (type.IsGenericParameter)
                typeName = type.Name;
            else
                typeName = type.Namespace + "." + (stripModel && typeName.EndsWith("Model") ? typeName.Substring(1, typeName.Length - 6) : typeName);

            if (type.IsArray && !typeName.EndsWith("[]"))
                typeName += "[]";

            return typeName;
        }

        /// <summary>
        ///     Maps a concrete type to its interface.
        /// </summary>
        /// <param name="type">
        ///     The runtime type to be mapped
        /// </param>
        /// <returns>
        ///     The interface to which the type is mapped.
        /// </returns>
        public static String MapTypeName(GeneratedInjectorInterface injector, Type type)
        {
            return GeneratedRuntimeType.MapTypeName(injector.RuntimeType, type);
        }

        /// <summary>
        ///     Maps a concrete type to its interface.
        /// </summary>
        /// <param name="type">
        ///     The runtime type to be mapped
        /// </param>
        /// <returns>
        ///     The interface to which the type is mapped.
        /// </returns>
        public static String MapTypeName(GeneratedInjectorClass injector, Type type)
        {
            return GeneratedRuntimeType.MapTypeName(injector.RuntimeType, type);
        }

        /// <summary>
        ///     Maps a concrete type to its interface.
        /// </summary>
        /// <param name="type">
        ///     The runtime type to be mapped
        /// </param>
        /// <returns>
        ///     The interface to which the type is mapped.
        /// </returns>
        public static String MapTypeName(GeneratedEncapsulatorClass injector, Type type)
        {
            return GeneratedRuntimeType.MapTypeName(injector.RuntimeModel, type);
        }
        
        /// <summary>
        ///     Gets the declaration name for a runtime type.
        /// </summary>
        private static String GetTypeName(Type injectedType, Type type)
        {
            // Get the true name of the type
            String typeName = type.Name;
            if (type.GetGenericArguments().Length != 0)
                typeName = typeName.Split('`').First() + "<" + String.Join(", ", type.GetGenericArguments().Select(gen => GeneratedRuntimeType.MapTypeName(injectedType, gen))) + ">";

            // Prefix the type with its namespace and suffix array types with square brackets
            if (type.IsGenericParameter)
                typeName = type.Name;
            else
                typeName = type.Namespace + "." + typeName;

            if (type.IsArray && !typeName.EndsWith("[]"))
                typeName += "[]";

            return typeName;
        }

        /// <summary>
        ///     Maps a concrete type to its interface.
        /// </summary>
        /// <param name="type">
        ///     The type that is being injected.
        /// </param>
        /// <param name="type">
        ///     The runtime type to be mapped
        /// </param>
        /// <returns>
        ///     The interface to which the type is mapped.
        /// </returns>
        private static String MapTypeName(Type injectedType, Type type)
        {
            return GeneratedRuntimeType.GetTypeName(injectedType, GeneratedRuntimeType.MapType(injectedType, type));
        }

        /// <summary>
        ///     Maps a concrete type to its interface.
        /// </summary>
        /// <param name="type">
        ///     The type that is being injected.
        /// </param>
        /// <param name="type">
        ///     The runtime type to be mapped
        /// </param>
        /// <returns>
        ///     The interface to which the type is mapped.
        /// </returns>
        internal static Type MapType(Type injectedType, Type type)
        {
            Boolean covariant = type.Name.Contains("LocalCollection");
            Boolean isFactory = injectedType.Name.Contains("Factory");

            // Return generic parameters without mapping.
            if (type.IsGenericParameter)
                return type;

            // Return the type name for the type if the type is not part of the injected assmebly.
            if (type.Assembly != injectedType.Assembly)
                return type;

            // Get the interfaces that are defined on the type (not the base types)
            Type[] baseTypes = GeneratedRuntimeType.EnumerateBaseTypes(type).ToArray();
            Type[] baseIface = baseTypes.SelectMany(b => b.GetInterfaces()).ToArray();
            Type[] typeIface = type.GetInterfaces().Except(baseIface).ToArray();

            // Return the first interface, excluding inferred interfaces.
            Type[] inference = typeIface.SelectMany(i => i.GetInterfaces()).ToArray();
            Type[] exclusion = typeIface.Except(baseIface).ToArray();
            return exclusion.FirstOrDefault() ?? type;
        }
        
        /// <summary>
        ///     Enumerates all types in the inheritence chain.
        /// </summary>
        internal static IEnumerable<Type> EnumerateBaseTypes(Type runtimeType)
        {
            if (runtimeType.BaseType != null)
            {
                yield return runtimeType.BaseType;
                foreach (Type type in GeneratedRuntimeType.EnumerateBaseTypes(runtimeType.BaseType))
                    yield return type;
            }
        }
    }
}
