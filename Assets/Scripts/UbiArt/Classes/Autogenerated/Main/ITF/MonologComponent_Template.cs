using UnityEngine;

namespace UbiArt.ITF {
	public partial class MonologComponent_Template : DialogBaseComponent_Template {
		[Serialize("textDataList")] public CList<MonologComponent_Template.TextData> textDataList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(textDataList));
		}
		public partial class TextData : CSerializable {
			[Serialize("textName" )] public StringID textName;
			[Serialize("locId"    )] public LocalisationId locId;
			[Serialize("debugText")] public string debugText;
			[Serialize("mood"     )] public uint mood;
			[Serialize("sizeText" )] public float sizeText;
			[Serialize("offset"   )] public Vector2 offset;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(textName));
				SerializeField(s, nameof(locId));
				SerializeField(s, nameof(debugText));
				SerializeField(s, nameof(mood));
				SerializeField(s, nameof(sizeText));
				SerializeField(s, nameof(offset));
			}
		}
		public override uint? ClassCRC => 0x0F29342C;
	}
}

