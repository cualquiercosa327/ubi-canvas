using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_396_sub_B04180 : ActorComponent_Template {
		[Serialize("smartLocID"        )] public SmartLocId smartLocID;
		[Serialize("displayDuration"   )] public float displayDuration;
		[Serialize("transitionDuration")] public float transitionDuration;
		[Serialize("nbRebound"         )] public uint nbRebound;
		[Serialize("startOffset"       )] public Vector2 startOffset;
		[Serialize("fastIncreaseTime"  )] public float fastIncreaseTime;
		[Serialize("maxIncreaseTime"   )] public float maxIncreaseTime;
		[Serialize("maxValueRef"       )] public float maxValueRef;
		[Serialize("minIncreaseTime"   )] public float minIncreaseTime;
		[Serialize("minValueRef"       )] public float minValueRef;
		[Serialize("loopingSound"      )] public StringID loopingSound;
		[Serialize("endSound"          )] public StringID endSound;
		[Serialize("tagColorSettings"  )] public CList<Unknown_RL_44131_sub_B029B0> tagColorSettings;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(smartLocID));
			SerializeField(s, nameof(displayDuration));
			SerializeField(s, nameof(transitionDuration));
			SerializeField(s, nameof(nbRebound));
			SerializeField(s, nameof(startOffset));
			SerializeField(s, nameof(fastIncreaseTime));
			SerializeField(s, nameof(maxIncreaseTime));
			SerializeField(s, nameof(maxValueRef));
			SerializeField(s, nameof(minIncreaseTime));
			SerializeField(s, nameof(minValueRef));
			SerializeField(s, nameof(loopingSound));
			SerializeField(s, nameof(endSound));
			SerializeField(s, nameof(tagColorSettings));
		}
		public override uint? ClassCRC => 0x4FDE15AC;

		[Games(GameFlags.RL)] // Only used as part of this class
		public partial class Unknown_RL_44131_sub_B029B0 : CSerializable {
			[Serialize("tag")] public StringID tag;
			[Serialize("textStyle")] public uint textStyle;
			[Serialize("backgroundColor")] public Color backgroundColor;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(tag));
				SerializeField(s, nameof(textStyle));
				SerializeField(s, nameof(backgroundColor));
			}
		}
	}
}

