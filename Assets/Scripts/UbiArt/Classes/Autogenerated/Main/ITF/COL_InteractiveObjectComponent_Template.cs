using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_InteractiveObjectComponent_Template : CSerializable {
		[Serialize("interactButtonYOffset"          )] public float interactButtonYOffset;
		[Serialize("interactButtonZOffsetFromAurora")] public float interactButtonZOffsetFromAurora;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(interactButtonYOffset));
			SerializeField(s, nameof(interactButtonZOffsetFromAurora));
		}
		public override uint? ClassCRC => 0x854530D6;
	}
}

