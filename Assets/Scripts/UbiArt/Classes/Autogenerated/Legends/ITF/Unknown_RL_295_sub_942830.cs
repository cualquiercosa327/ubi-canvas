using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.COL)]
	public partial class Unknown_RL_295_sub_942830 : MusicTreeNode_Template {
		[Serialize("looping"              )] public int looping;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(looping));
		}
		public override uint? ClassCRC => 0x0D375BB7;
	}
}

