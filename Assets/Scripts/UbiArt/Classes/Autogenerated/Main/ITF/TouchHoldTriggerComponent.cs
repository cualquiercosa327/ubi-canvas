using UnityEngine;

namespace UbiArt.ITF {
	public partial class TouchHoldTriggerComponent : ActorComponent {
		[Serialize("onHoldEvent"               )] public EventSender onHoldEvent;
		[Serialize("onReleaseEvent"            )] public EventSender onReleaseEvent;
		[Serialize("minTimeBeforeHoldEventSend")] public float minTimeBeforeHoldEventSend;
		[Serialize("useTapGauge"               )] public byte useTapGauge;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(onHoldEvent));
					SerializeField(s, nameof(onReleaseEvent));
					SerializeField(s, nameof(useTapGauge));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(onHoldEvent));
					SerializeField(s, nameof(onReleaseEvent));
					SerializeField(s, nameof(minTimeBeforeHoldEventSend));
				}
			}
		}
		public override uint? ClassCRC => 0xD18D6A31;
	}
}

