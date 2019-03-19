using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class TweenAnim_Template : TweenInstruction_Template {
		[Serialize("anim"    )] public StringID anim;
		[Serialize("duration")] public float duration;
		[Serialize("name"    )] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(anim));
			} else {
				SerializeField(s, nameof(anim));
			}
		}
		public override uint? ClassCRC => 0x00785E69;
	}
}

