using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Unknown_COL_29_sub_9590B0 : CSerializable {
		[Serialize("Trigger")] public SoundGUID Trigger;
		[Serialize("Repeat" )] public float Repeat;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Trigger));
			SerializeField(s, nameof(Repeat));
		}
		public override uint? ClassCRC => 0x83F2FF07;
	}
}

