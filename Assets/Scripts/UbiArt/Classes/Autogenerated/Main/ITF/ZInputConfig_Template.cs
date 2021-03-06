using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class ZInputConfig_Template : TemplateObj {
		[Serialize("inputs")] public CArray<Path> inputs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(inputs));
			} else {
			}
		}
		public override uint? ClassCRC => 0x9C26194D;
	}
}

