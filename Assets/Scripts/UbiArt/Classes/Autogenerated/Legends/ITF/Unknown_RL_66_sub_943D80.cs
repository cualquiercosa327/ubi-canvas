using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.COL)]
	public partial class Unknown_RL_66_sub_943D80 : CSerializable {
		[Serialize("leafs")] public Placeholder leafs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(leafs));
		}
		public override uint? ClassCRC => 0x7B7FC5BA;
	}
}

