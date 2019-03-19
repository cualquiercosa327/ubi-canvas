﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	public class CSerializerObjectBinary : CSerializerObject {
		public Reader reader;


		public CSerializerObjectBinary(Reader reader) {
			this.reader = reader;
		}

		public override Pointer Position => Pointer.Current(reader);

		public override void Serialize(ref object obj, Type type, string name = null) {
			if (Type.GetTypeCode(type) != TypeCode.Object) {
				switch (Type.GetTypeCode(type)) {
					case TypeCode.Boolean: obj = (object)reader.ReadBoolean(); break;
					case TypeCode.Byte: obj = (object)reader.ReadByte(); break;
					case TypeCode.Char: obj = (object)reader.ReadChar(); break;
					case TypeCode.String: obj = (object)reader.ReadString(); break;
					case TypeCode.Single: obj = (object)reader.ReadSingle(); break;
					case TypeCode.Double: obj = (object)reader.ReadDouble(); break;
					case TypeCode.UInt16: obj = (object)reader.ReadUInt16(); break;
					case TypeCode.UInt32: obj = (object)reader.ReadUInt32(); break;
					case TypeCode.UInt64: obj = (object)reader.ReadUInt64(); break;
					case TypeCode.Int16: obj = (object)reader.ReadInt16(); break;
					case TypeCode.Int32: obj = (object)reader.ReadInt32(); break;
					case TypeCode.Int64: obj = (object)reader.ReadInt64(); break;
					default: throw new Exception("Unsupported TypeCode " + Type.GetTypeCode(type));
				}
			} else if (type == typeof(Vector2)) {
				obj = reader.ReadVector2();
			} else if (type == typeof(Vector3)) {
				obj = reader.ReadVector3();
			} else if (type == typeof(Vector4)) {
				obj = reader.ReadVector4();
			} else if (type == typeof(Color)) {
				obj = reader.ReadColor();
			} else {
				var ctor = type.GetConstructor(Type.EmptyTypes);
				obj = ctor.Invoke(new object[] { });
				if (obj is ICSerializable) {
					((ICSerializable)obj).Serialize(this, name);
				}
			}
		}

		public override void Serialize(object containerObj, FieldInfo f, Type type = null, string name = null, int? index = null) {
			object obj = null;
			Serialize(ref obj, type ?? f.FieldType, name: name);
			f.SetValue(containerObj, obj);
		}

		public override void Serialize(object o, FieldInfo f, SerializeAttribute a, Type type = null) {
			if (((a.version & Settings.s.versionFlags) == Settings.s.versionFlags) && (a.flags == SerializeFlags.None || (flags & a.flags) == a.flags)) {
				Serialize(o, f, type: type, name: a.Name);
			}
		}

		public override void Serialize<T>(ref T obj, Type type = null, string name = null, int? index = null) {
			object obj2 = null;
			Serialize(ref obj2, type ?? typeof(T), name: name);
			obj = (T)obj2;
		}
	}
}