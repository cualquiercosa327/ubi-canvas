﻿using UnityEngine;

namespace UbiArt.ITF {
	public partial class GFXMaterialTexturePathSet {
		public TextureCooked diffuseTex;
		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			MapLoader l = MapLoader.Loader;
			l.Load(diffuse, (extS) => {
				if (l.tex.ContainsKey(diffuse.stringID)) {
					diffuseTex = l.tex[diffuse.stringID];
				} else {
					extS.Serialize(ref diffuseTex);
					l.tex[diffuse.stringID] = diffuseTex;
					l.print("Read:" + extS.Position + " - Length:" + extS.Length + " - " + (extS.Position == extS.Length ? "good!" : "bad!"));
				}
			});
		}
	}
}