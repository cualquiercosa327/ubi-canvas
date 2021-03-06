using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class PlayAnimOnWeightChangeComponent : ActorComponent {
		[Serialize("isActive")] public int isActive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(isActive));
			} else {
			}
		}
		public override uint? ClassCRC => 0x8F988441;
	}
}

