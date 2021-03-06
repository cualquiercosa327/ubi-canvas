using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.COL)]
	public partial class Unknown_RL_6_sub_38AFF0 : SoundCommand {
		[Serialize("buslist")] public CList<StringID> buslist;
		[Serialize("pitch"  )] public float pitch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(buslist));
			SerializeField(s, nameof(pitch));
		}
		public override uint? ClassCRC => 0xC5569A5C;
	}
}

