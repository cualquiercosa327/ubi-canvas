using UnityEngine;

namespace UbiArt.ITF {
	public partial class SaveNotificationComponent : ActorComponent {
		[Serialize("saveReasons")] public CList<uint> saveReasons;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
			} else {
				SerializeField(s, nameof(saveReasons));
			}
		}
		public override uint? ClassCRC => 0xF66490C1;
	}
}

