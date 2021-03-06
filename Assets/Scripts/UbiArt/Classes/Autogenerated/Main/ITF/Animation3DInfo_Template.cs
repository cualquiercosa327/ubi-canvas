using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class Animation3DInfo_Template : CSerializable {
		[Serialize("friendlyName"   )] public StringID friendlyName;
		[Serialize("name"           )] public Path name;
		[Serialize("playRate"       )] public float playRate;
		[Serialize("loop"           )] public bool loop;
		[Serialize("reverse"        )] public bool reverse;
		[Serialize("procedural"     )] public bool procedural;
		[Serialize("sync"           )] public bool sync;
		[Serialize("syncRatio"      )] public float syncRatio;
		[Serialize("allowSyncOffset")] public bool allowSyncOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(friendlyName));
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(playRate));
			SerializeField(s, nameof(loop));
			SerializeField(s, nameof(reverse));
			SerializeField(s, nameof(procedural));
			SerializeField(s, nameof(sync));
			SerializeField(s, nameof(syncRatio));
			SerializeField(s, nameof(allowSyncOffset));
		}
	}
}

