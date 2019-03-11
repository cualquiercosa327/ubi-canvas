using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventLoadMap : Event {
		[Serialize("map")] public PathRef map;
		[Serialize("map")] public Path map;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(map));
			} else {
				SerializeField(s, nameof(map));
			}
		}
		public override uint? ClassCRC => 0xA4A0B6EB;
	}
}

