using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_SeasonalEggPack : RLC_DynamicStoreItem {
		[Serialize("Price" )] public uint Price;
		[Serialize("Amount")] public uint Amount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Price));
			SerializeField(s, nameof(Amount));
		}
		public override uint? ClassCRC => 0x27F8F9BF;
	}
}

