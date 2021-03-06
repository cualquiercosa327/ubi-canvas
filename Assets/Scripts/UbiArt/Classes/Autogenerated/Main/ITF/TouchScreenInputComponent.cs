using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class TouchScreenInputComponent : ShapeComponent {
		[Serialize("viewName")] public string viewName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RA || Settings.s.isCatchThemAll) {
				SerializeField(s, nameof(viewName));
			}
		}
		public override uint? ClassCRC => 0x8F11DEDF;
	}
}

