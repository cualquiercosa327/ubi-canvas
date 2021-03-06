using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_FromChallengeComponent : ActorComponent {
		[Serialize("filter"     )] public CList<string> filter;
		[Serialize("filterOrder")] public CList<CList<string>> filterOrder;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(filter));
				SerializeField(s, nameof(filterOrder));
			} else {
				SerializeField(s, nameof(filter));
			}
		}
		public override uint? ClassCRC => 0xDB452847;
	}
}

