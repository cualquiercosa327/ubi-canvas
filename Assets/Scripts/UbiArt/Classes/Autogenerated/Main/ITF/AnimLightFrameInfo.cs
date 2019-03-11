using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimLightFrameInfo : CSerializable {
		[Serialize("subAnimFrameInfo")] public SubAnimFrameInfo subAnimFrameInfo;
		[Serialize("weight"          )] public float weight;
		[Serialize("usePatches"      )] public bool usePatches;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(subAnimFrameInfo));
			SerializeField(s, nameof(weight));
			SerializeField(s, nameof(usePatches));
		}
	}
}

