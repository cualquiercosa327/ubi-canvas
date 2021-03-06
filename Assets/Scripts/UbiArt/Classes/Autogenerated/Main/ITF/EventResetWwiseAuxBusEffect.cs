using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.COL)]
	public partial class EventResetWwiseAuxBusEffect : Event {
		[Serialize("WwiseBusGUID"  )] public StringID WwiseBusGUID;
		[Serialize("WwiseBusSlotID")] public AUDIO_BUS_SLOT WwiseBusSlotID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(WwiseBusGUID));
			SerializeField(s, nameof(WwiseBusSlotID));
		}
		public enum AUDIO_BUS_SLOT {
			[Serialize("AUDIO_BUS_SLOT_0")] Slot0 = 0,
			[Serialize("AUDIO_BUS_SLOT_1")] Slot1 = 1,
			[Serialize("AUDIO_BUS_SLOT_2")] Slot2 = 2,
			[Serialize("AUDIO_BUS_SLOT_3")] Slot3 = 3,
		}
		public override uint? ClassCRC => 0x04A3F513;
	}
}

