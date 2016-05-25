using MediaFoundation;
using MediaFoundation.Core.Interfaces;
using MediaFoundation.Internals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopoViewer.Descriptions
{
    public class AttributeInfo<TIAttribute>
        where TIAttribute : class, IMFAttributes
    {
        public Attribute[] Attributes { get; private set; }

        public AttributeInfo(Attributes<TIAttribute> attribs)
        {
            Contract.RequiresNotNull(attribs, "attribs");

            int cnt = attribs.Count;
            Attribute[] attrs = new Attribute[cnt];
            for (int i = 0; i < cnt; i++)
            {
                MFAttribute key = attribs.GetKeyByIndex(i);
                MFAttributeType type = attribs.GetItemType(key);
                object value = DBNull.Value;
                switch (type)
                {
                    case MFAttributeType.Blob:
                        int size = attribs.GetBlobSize(key);
                        if (size < 2000000)
                            value = attribs.GetBlob(key);
                        break;
                    case MFAttributeType.Double:
                        value = attribs.GetDouble(key);
                        break;
                    case MFAttributeType.Guid:
                        value = attribs.GetGuid(key);
                        break;
                    case MFAttributeType.String:
                        value = attribs.GetString(key);
                        break;
                    case MFAttributeType.Uint32:
                        value = attribs.GetInt32(key);
                        break;
                    case MFAttributeType.Uint64:
                        value = attribs.GetInt64(key);
                        break;
                    case MFAttributeType.IUnknown:
                    case MFAttributeType.None:
                    default:
                        break;
                }
                attrs[i] = new Attribute(key, type, value);
            }

            this.Attributes = attrs;
        }

        public struct Attribute
        {
            public Guid Key { get; private set; }
            public MFAttributeType Type { get; private set; }
            public object Value { get; private set; }

            public Attribute(Guid key, MFAttributeType type, object value)
                : this()
            {
                this.Key = key;
                this.Type = type;
                this.Value = value;
            }

            public override string ToString()
            {
                return String.Format("{0} ({1}): {2}", GuidMapper.Current.GetName(this.Key) ?? this.Key.ToString(), this.Type, this.Value);
            }
        }
    }
}
