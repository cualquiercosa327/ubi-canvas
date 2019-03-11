using UnityEngine;

namespace UbiArt.ITF {
	public partial class StaticMeshVertexComponent : GraphicComponent {
		[Serialize("staticMeshElements")] public CList<StaticMeshElement> staticMeshElements;
		[Serialize("sortedMeshElements")] public CArray<uint> sortedMeshElements;
		[Serialize("material"          )] public GFXMaterialSerializable material;
		[Serialize("localAABB"         )] public AABB localAABB;
		[Serialize("mergeRange"        )] public float mergeRange;
		[Serialize("friseGroupPath"    )] public ObjectPath friseGroupPath;
		[Serialize("forceMatrixUpdate" )] public bool forceMatrixUpdate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(staticMeshElements));
				SerializeField(s, nameof(sortedMeshElements));
				SerializeField(s, nameof(material));
				SerializeField(s, nameof(localAABB));
				SerializeField(s, nameof(mergeRange));
				SerializeField(s, nameof(friseGroupPath));
				SerializeField(s, nameof(forceMatrixUpdate));
			} else {
				SerializeField(s, nameof(staticMeshElements));
				SerializeField(s, nameof(sortedMeshElements));
				SerializeField(s, nameof(material));
				SerializeField(s, nameof(localAABB));
				SerializeField(s, nameof(mergeRange));
				SerializeField(s, nameof(friseGroupPath));
			}
		}
		public override uint? ClassCRC => 0x2A83720E;
	}
}

