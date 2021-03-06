using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_147_sub_742AC0 : CSerializable {
		[Serialize("bufferWantedSize"  )] public int bufferWantedSize;
		[Serialize("bufferQuerySize"   )] public int bufferQuerySize;
		[Serialize("spawnItemsByFrame" )] public int spawnItemsByFrame;
		[Serialize("playerCardMenuName")] public StringID playerCardMenuName;
		[Serialize("invitationIconPath")] public Path invitationIconPath;
		[Serialize("costumeIconPath"   )] public Path costumeIconPath;
		[Serialize("statusIconPath"    )] public Path statusIconPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bufferWantedSize));
			SerializeField(s, nameof(bufferQuerySize));
			SerializeField(s, nameof(spawnItemsByFrame));
			SerializeField(s, nameof(playerCardMenuName));
			SerializeField(s, nameof(invitationIconPath));
			SerializeField(s, nameof(costumeIconPath));
			SerializeField(s, nameof(statusIconPath));
		}
		public override uint? ClassCRC => 0x6400F258;
	}
}

