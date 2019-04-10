﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimBone::serialize
	public class AnimBone : ICSerializable {
		public Link key;
		public StringID tag;
		public byte unk2;
		public CList<Link> links; // links to AnimPatchPoint?
		public Link parentKey;

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize(ref key);
			s.Serialize(ref tag);
			s.Serialize(ref unk2);
			s.Serialize(ref links);
			s.Serialize(ref parentKey);
		}
		/*
		Example:
		108075A0 0A22DD9C 03 00000000 00000000
		108075D0 BC787C92 07 00000000 108075A0
		10807600 DA17A9B5 07 00000000 108075A0
		10807630 66E8124F 07 00000000 108075A0
		10807660 FA6BABDA 07 00000000 108075A0
		10807690 5D711B23 07 00000000 108075A0
		108076C0 7F7DD3B5 07 00000000 108076F0
		108076F0 A1219A1C 07 00000000 108075A0
		10807720 C5B82F5F 07 00000000 10807630
		10807750 80B53F55 07 00000000 108075A0
		10807780 0117AC92 07 00000000 108076C0
		108077B0 71315DD5 07 00000000 108076C0
		108077E0 BFDC7CCA 07 00000000 108075A0
		*/
	}
}
