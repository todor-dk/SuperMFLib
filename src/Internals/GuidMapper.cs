using MediaFoundation.Misc.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MediaFoundation.Internals
{
    internal class GuidMapper
    {
        public static readonly GuidMapper Current = new GuidMapper(GuidMapper.GetMappings());

        public GuidMapper(Dictionary<Guid, Tuple<Type, string>> mappings)
        {
            this.Mappings = mappings;
        }

        private readonly Dictionary<Guid, Tuple<Type, string>> Mappings;

        private static Dictionary<Guid, Tuple<Type, string>> GetMappings()
        {
            return GuidMapper.GetMappings(typeof(MFError));
        }

        private static Dictionary<Guid, Tuple<Type, string>> GetMappings(Type type)
        {
            Contract.RequiresNotNull(type, "type");

            return GuidMapper.GetMappings(type.Assembly);
        }

        private static Dictionary<Guid, Tuple<Type, string>> GetMappings(Assembly assembly)
        {
            Contract.RequiresNotNull(assembly, "assembly");

            Dictionary<Guid, Tuple<Type, string>> mappings = new Dictionary<Guid, Tuple<Type, string>>();

            BindingFlags flags = BindingFlags.GetField | BindingFlags.Public | BindingFlags.Static;
            foreach (Type type in assembly.GetTypes())
            {
                foreach (FieldInfo field in type.GetFields(flags))
                {
                    if ((field.IsInitOnly || field.IsLiteral) && field.IsStatic && field.IsPublic && (field.FieldType == typeof(Guid)))
                    {
                        Guid guid = (Guid)field.GetValue(null);
                        mappings[guid] = new Tuple<Type, string>(type, field.Name);
                    }
                }
            }

            return mappings;
        }

        public Type GetType(Guid guid)
        {
            Tuple<Type, string> tuple = this.GetTuple(guid);
            if (tuple == null)
                return null;
            return tuple.Item1;
        }

        public string GetName(Guid guid)
        {
            Tuple<Type, string> tuple = this.GetTuple(guid);
            if (tuple == null)
                return null;
            return tuple.Item2;
        }

        private Tuple<Type, string> GetTuple(Guid guid)
        {
            Tuple<Type, string> tuple = null;
            this.Mappings.TryGetValue(guid, out tuple);
            return tuple;
        }
    }
}
