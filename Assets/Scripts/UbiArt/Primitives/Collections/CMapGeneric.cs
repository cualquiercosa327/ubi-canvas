﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	[SerializeEmbed]
	public class CMapGeneric<TKey,TValue> : IDictionary<TKey,Generic<TValue>>, ICSerializable, IObjectContainer where TValue : CSerializable {
		Dictionary<TKey, Generic<TValue>> container = new Dictionary<TKey, Generic<TValue>>();


		public void Serialize(CSerializerObject s, string name) {
			uint count = (uint)Count;
			s.Serialize<uint>(ref count, name: name);
			List<KeyValuePair<TKey, Generic<TValue>>> copy = new Dictionary<TKey, Generic<TValue>>(container).ToList();
			//copy.Sort(
			container.Clear();
			for (int i = 0; i < count; i++) {
				TKey key = default;
				Generic<TValue> val = new Generic<TValue>();
				if (i < copy.Count) {
					key = copy[i].Key;
					val = copy[i].Value;
				}
				if (s.ArrayEntryStart(name: name, index: i)) {
					val.SerializeClassName(s);
					s.Serialize(ref key, name: "KEY");
					val.serializeClassName = false;
					s.Serialize(ref val, name: "VAL");
					val.serializeClassName = true;
					s.ArrayEntryStop();
				}
				Add(key, val);
			}
		}

		#region Dictionary interface
		public Generic<TValue> this[TKey key] { get => ((IDictionary<TKey, Generic<TValue>>)container)[key]; set => ((IDictionary<TKey, Generic<TValue>>)container)[key] = value; }

		public ICollection<TKey> Keys => ((IDictionary<TKey, Generic<TValue>>)container).Keys;

		public ICollection<Generic<TValue>> Values => ((IDictionary<TKey, Generic<TValue>>)container).Values;

		public int Count => ((IDictionary<TKey, Generic<TValue>>)container).Count;

		public bool IsReadOnly => ((IDictionary<TKey, Generic<TValue>>)container).IsReadOnly;

		public void Add(TKey key, Generic<TValue> value) {
			((IDictionary<TKey, Generic<TValue>>)container).Add(key, value);
		}

		public void Add(KeyValuePair<TKey, Generic<TValue>> item) {
			((IDictionary<TKey, Generic<TValue>>)container).Add(item);
		}

		public void Clear() {
			((IDictionary<TKey, Generic<TValue>>)container).Clear();
		}

		public bool Contains(KeyValuePair<TKey, Generic<TValue>> item) {
			return ((IDictionary<TKey, Generic<TValue>>)container).Contains(item);
		}

		public bool ContainsKey(TKey key) {
			return ((IDictionary<TKey, Generic<TValue>>)container).ContainsKey(key);
		}

		public void CopyTo(KeyValuePair<TKey, Generic<TValue>>[] array, int arrayIndex) {
			((IDictionary<TKey, Generic<TValue>>)container).CopyTo(array, arrayIndex);
		}

		public IEnumerator<KeyValuePair<TKey, Generic<TValue>>> GetEnumerator() {
			return ((IDictionary<TKey, Generic<TValue>>)container).GetEnumerator();
		}

		public bool Remove(TKey key) {
			return ((IDictionary<TKey, Generic<TValue>>)container).Remove(key);
		}

		public bool Remove(KeyValuePair<TKey, Generic<TValue>> item) {
			return ((IDictionary<TKey, Generic<TValue>>)container).Remove(item);
		}

		public bool TryGetValue(TKey key, out Generic<TValue> value) {
			return ((IDictionary<TKey, Generic<TValue>>)container).TryGetValue(key, out value);
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return ((IDictionary<TKey, Generic<TValue>>)container).GetEnumerator();
		}
		#endregion
	}
}
