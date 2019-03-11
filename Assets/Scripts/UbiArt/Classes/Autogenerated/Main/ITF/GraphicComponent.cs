using UnityEngine;

namespace UbiArt.ITF {
	public partial class GraphicComponent : ActorComponent {
		[Serialize("ColorFactor"                  )] public Color ColorFactor;
		[Serialize("ColorFog"                     )] public Color ColorFog;
		[Serialize("PrimitiveParameters"          )] public GFXPrimitiveParam PrimitiveParameters;
		[Serialize("colorComputerTagId"           )] public uint colorComputerTagId;
		[Serialize("renderInTarget"               )] public bool renderInTarget;
		[Serialize("disableLight"                 )] public int disableLight;
		[Serialize("disableShadow"                )] public int disableShadow;
		[Serialize("depthOffset"                  )] public float depthOffset;
		[Serialize("AlphaInit"                    )] public float AlphaInit;
		[Serialize("highlightFrontLightBrightness")] public float highlightFrontLightBrightness;
		[Serialize("highlightOutlineColor"        )] public Color highlightOutlineColor;
		[Serialize("highlightOutlineWidth"        )] public float highlightOutlineWidth;
		[Serialize("ColorFog_Red"                 )] public float ColorFog_Red;
		[Serialize("ColorFog_Green"               )] public float ColorFog_Green;
		[Serialize("ColorFog_Blu"                 )] public float ColorFog_Blu;
		[Serialize("fogfactor"                    )] public float fogfactor;
		[Serialize("disableLight"                 )] public bool disableLight;
		[Serialize("useStaticFog"                 )] public bool useStaticFog;
		[Serialize("renderInReflection"           )] public bool renderInReflection;
		[Serialize("disableShadow"                )] public bool disableShadow;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(ColorFog_Red));
					SerializeField(s, nameof(ColorFog_Green));
					SerializeField(s, nameof(ColorFog_Blu));
					SerializeField(s, nameof(fogfactor));
					SerializeField(s, nameof(ColorFactor));
					SerializeField(s, nameof(ColorFog));
					SerializeField(s, nameof(colorComputerTagId));
					SerializeField(s, nameof(renderInTarget));
					SerializeField(s, nameof(disableLight));
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default | SerializeFlags.Flags8)) {
					SerializeField(s, nameof(ColorFactor));
					SerializeField(s, nameof(ColorFog));
					SerializeField(s, nameof(useStaticFog));
					SerializeField(s, nameof(renderInReflection));
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(PrimitiveParameters));
					SerializeField(s, nameof(colorComputerTagId));
					SerializeField(s, nameof(renderInTarget));
					SerializeField(s, nameof(disableLight));
					SerializeField(s, nameof(disableShadow));
					SerializeField(s, nameof(depthOffset));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default | SerializeFlags.Flags8)) {
					SerializeField(s, nameof(ColorFactor));
					SerializeField(s, nameof(ColorFog));
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(PrimitiveParameters));
					SerializeField(s, nameof(colorComputerTagId));
					SerializeField(s, nameof(renderInTarget));
					SerializeField(s, nameof(disableLight));
					SerializeField(s, nameof(disableShadow));
					SerializeField(s, nameof(depthOffset));
					SerializeField(s, nameof(AlphaInit));
					SerializeField(s, nameof(highlightFrontLightBrightness));
					SerializeField(s, nameof(highlightOutlineColor));
					SerializeField(s, nameof(highlightOutlineWidth));
				}
			}
		}
		public override uint? ClassCRC => 0x804757FE;
	}
}

