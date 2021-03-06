using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class SoundBusControllerComponent_Template : CSerializable {
		[Serialize("busData")] public Placeholder busData;
		[Serialize("inputs" )] public Placeholder inputs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(busData));
			SerializeField(s, nameof(inputs));
		}
		public override uint? ClassCRC => 0x84212367;
	}
}

