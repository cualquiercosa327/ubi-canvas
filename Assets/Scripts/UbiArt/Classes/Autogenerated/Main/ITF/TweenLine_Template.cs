using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class TweenLine_Template : TweenTranslation_Template {
		[Serialize("movement"  )] public Vector3 movement;
		[Serialize("CosinusOnX")] public bool CosinusOnX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(movement));
			} else {
				SerializeField(s, nameof(movement));
				SerializeField(s, nameof(CosinusOnX));
			}
		}
		public override uint? ClassCRC => 0x6A97A07E;
	}
}

