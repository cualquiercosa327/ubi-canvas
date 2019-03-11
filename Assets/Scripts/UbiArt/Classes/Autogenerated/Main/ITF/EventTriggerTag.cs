using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventTriggerTag : Event {
		[Serialize("tag"   )] public StringID tag;
		[Serialize("value" )] public uint value;
		[Serialize("sender")] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(tag));
				SerializeField(s, nameof(value));
			} else {
				SerializeField(s, nameof(tag));
				SerializeField(s, nameof(value));
			}
		}
		public override uint? ClassCRC => 0x30551100;
	}
}

