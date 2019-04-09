﻿using UbiArt.Animation;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class SubAnim_Template {
		public AnimTrack anim;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (name != null && isFirstLoad) {
				MapLoader l = MapLoader.Loader;
				l.Load(name, (extS) => {
					if (l.anm.ContainsKey(name.stringID)) {
						anim = l.anm[name.stringID];
					} else {
						extS.Serialize(ref anim);
						l.anm[name.stringID] = anim;
						l.print("Read:" + extS.Position + " - Length:" + extS.Length + " - " + (extS.Position == extS.Length ? "good!" : "bad!"));
					}
				});
			}
		}
	}
}
