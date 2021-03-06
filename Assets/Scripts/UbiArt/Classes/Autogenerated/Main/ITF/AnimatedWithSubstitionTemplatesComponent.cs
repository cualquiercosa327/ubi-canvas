using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class AnimatedWithSubstitionTemplatesComponent : AnimatedComponent {
		[Serialize("AnimSbustitionTemplates")] public CList<AnimatedWithSubstitionTemplatesComponent.AnimSubstsTemplate> AnimSbustitionTemplates;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(AnimSbustitionTemplates));
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class AnimSubst : CSerializable {
			[Serialize("original")] public StringID original;
			[Serialize("final"   )] public StringID final;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(original));
				SerializeField(s, nameof(final));
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class AnimSubstsTemplate : CSerializable {
			[Serialize("substitutedAnimsList")] public CList<AnimatedWithSubstitionTemplatesComponent.AnimSubst> substitutedAnimsList;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(substitutedAnimsList));
			}
		}
		public override uint? ClassCRC => 0x9D1DBAC6;
	}
}

