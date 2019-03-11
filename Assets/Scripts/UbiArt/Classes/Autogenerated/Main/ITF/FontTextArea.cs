using UnityEngine;

namespace UbiArt.ITF {
	public partial class FontTextArea : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public partial class FontSet : CSerializable {
			[Serialize("default"      )] public Path _default;
			[Serialize("japanese"     )] public Path japanese;
			[Serialize("korean"       )] public Path korean;
			[Serialize("tradChinese"  )] public Path tradChinese;
			[Serialize("simpleChinese")] public Path simpleChinese;
			[Serialize("russian"      )] public Path russian;
			[Serialize("arabic"       )] public Path arabic;
			[Serialize("thai"         )] public Path thai;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(_default));
				SerializeField(s, nameof(japanese));
				SerializeField(s, nameof(korean));
				SerializeField(s, nameof(tradChinese));
				SerializeField(s, nameof(simpleChinese));
				SerializeField(s, nameof(russian));
				SerializeField(s, nameof(arabic));
				SerializeField(s, nameof(thai));
			}
		}
		public partial class Style : CSerializable {
			[Serialize("fontSet"         )] public FontTextArea.FontSet fontSet;
			[Serialize("fontSize"        )] public float fontSize;
			[Serialize("color"           )] public Color color;
			[Serialize("shadowOffset"    )] public Vector2 shadowOffset;
			[Serialize("shadowColor"     )] public Color shadowColor;
			[Serialize("lineSpacing"     )] public float lineSpacing;
			[Serialize("paragraphSpacing")] public float paragraphSpacing;
			[Serialize("anchor"          )] public AREA_ANCHOR anchor;
			[Serialize("hAlignment"      )] public FONT_ALIGN hAlignment;
			[Serialize("vAlignment"      )] public FONT vAlignment;
			[Serialize("useGradient"     )] public bool useGradient;
			[Serialize("gradientSize"    )] public float gradientSize;
			[Serialize("gradientOffset"  )] public float gradientOffset;
			[Serialize("gradientColor"   )] public Color gradientColor;
			[Serialize("charSpacing"     )] public float charSpacing;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(fontSet));
				SerializeField(s, nameof(fontSize));
				SerializeField(s, nameof(color));
				SerializeField(s, nameof(shadowOffset));
				SerializeField(s, nameof(shadowColor));
				SerializeField(s, nameof(lineSpacing));
				SerializeField(s, nameof(paragraphSpacing));
				SerializeField(s, nameof(anchor));
				SerializeField(s, nameof(hAlignment));
				SerializeField(s, nameof(vAlignment));
				SerializeField(s, nameof(useGradient));
				SerializeField(s, nameof(gradientSize));
				SerializeField(s, nameof(gradientOffset));
				SerializeField(s, nameof(gradientColor));
				SerializeField(s, nameof(charSpacing));
			}
			public enum AREA_ANCHOR {
				[Serialize("AREA_ANCHOR_TOP_LEFT"     )] TOP_LEFT = 0,
				[Serialize("AREA_ANCHOR_MIDDLE_CENTER")] MIDDLE_CENTER = 1,
				[Serialize("AREA_ANCHOR_MIDDLE_LEFT"  )] MIDDLE_LEFT = 2,
				[Serialize("AREA_ANCHOR_MIDDLE_RIGHT" )] MIDDLE_RIGHT = 3,
				[Serialize("AREA_ANCHOR_TOP_CENTER"   )] TOP_CENTER = 4,
				[Serialize("AREA_ANCHOR_TOP_RIGHT"    )] TOP_RIGHT = 5,
				[Serialize("AREA_ANCHOR_BOTTOM_CENTER")] BOTTOM_CENTER = 6,
				[Serialize("AREA_ANCHOR_BOTTOM_LEFT"  )] BOTTOM_LEFT = 7,
				[Serialize("AREA_ANCHOR_BOTTOM_RIGHT" )] BOTTOM_RIGHT = 8,
			}
			public enum FONT_ALIGN {
				[Serialize("FONT_ALIGN_NONE"   )] NONE = -1,
				[Serialize("FONT_ALIGN_LEFT"   )] LEFT = 0,
				[Serialize("FONT_ALIGN_CENTER" )] CENTER = 1,
				[Serialize("FONT_ALIGN_RIGHT"  )] RIGHT = 2,
				[Serialize("FONT_ALIGN_JUSTIFY")] JUSTIFY = 3,
			}
			public enum FONT {
				[Serialize("FONT_ALIGN_NONE"   )] ALIGN_NONE = -1,
				[Serialize("FONT_VALIGN_TOP"   )] VALIGN_TOP = 0,
				[Serialize("FONT_VALIGN_MIDDLE")] VALIGN_MIDDLE = 1,
				[Serialize("FONT_VALIGN_BOTTOM")] VALIGN_BOTTOM = 2,
			}
		}
	}
}

