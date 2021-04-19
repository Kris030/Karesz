using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Karesz {
	internal abstract class View {

		protected readonly MainForm parent;

		protected internal Panel panel;
		protected internal bool loaded;

		public View(MainForm parent) => this.parent = parent;

		internal abstract void Init();
		internal abstract void OnLoad();

	}
}