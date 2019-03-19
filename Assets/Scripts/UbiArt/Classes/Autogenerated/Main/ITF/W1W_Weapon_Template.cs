using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Weapon_Template : W1W_InteractiveGenComponent_Template {
		[Serialize("float__0"   )] public float float__0;
		[Serialize("Vector2__1" )] public Vector2 Vector2__1;
		[Serialize("StringID__2")] public StringID StringID__2;
		[Serialize("StringID__3")] public StringID StringID__3;
		[Serialize("StringID__4")] public StringID StringID__4;
		[Serialize("StringID__5")] public StringID StringID__5;
		[Serialize("StringID__6")] public StringID StringID__6;
		[Serialize("StringID__7")] public StringID StringID__7;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(float__0));
			SerializeField(s, nameof(Vector2__1));
			SerializeField(s, nameof(StringID__2));
			SerializeField(s, nameof(StringID__3));
			SerializeField(s, nameof(StringID__4));
			SerializeField(s, nameof(StringID__5));
			SerializeField(s, nameof(StringID__6));
			SerializeField(s, nameof(StringID__7));
		}
		public override uint? ClassCRC => 0x851414A2;
	}
}

