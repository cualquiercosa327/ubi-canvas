using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class TouchSpringMoveBase : CSerializable {
		[Serialize("elastic")] public bool elastic;
		[Serialize("reverse")] public bool reverse;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(elastic), boolAsByte: true);
				SerializeField(s, nameof(reverse), boolAsByte: true);
			} else {
				SerializeField(s, nameof(elastic));
				SerializeField(s, nameof(reverse));
			}
		}
		public override uint? ClassCRC => 0xE0D1D3C5;
	}
}

