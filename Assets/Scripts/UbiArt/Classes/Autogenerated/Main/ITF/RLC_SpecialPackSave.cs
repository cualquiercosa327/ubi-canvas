using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_SpecialPackSave : CSerializable {
		[Serialize("lastTimeShownInShop")] public online.DateTime lastTimeShownInShop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(lastTimeShownInShop));
		}
	}
}

