using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventFreePrisoner : Event {
		[Serialize("index")] public uint index;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(index));
		}
		public override uint? ClassCRC => 0x7E1CF611;
	}
}

