﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	public class Link { //: ICSerializable {
		public uint stringID;
		public Link(Reader reader) {
			stringID = reader.ReadUInt32();
		}

		/*public void Serialize(CSerializerObject s, string name) {
			s.Serialize<uint>(ref stringID);
		}*/
	}
}