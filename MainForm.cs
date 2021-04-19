using Karesz.Views;
using System.Windows.Forms;

namespace Karesz {

	public partial class MainForm : Form {

		internal readonly EditorView editorView;
		internal readonly OptionsView optionsView;
		internal readonly MainMenuView mainMenuView;

		private View currentView;
		public MainForm() {

			editorView = new EditorView(this);
			optionsView = new OptionsView(this);
			mainMenuView = new MainMenuView(this);

			InitializeComponent();
			SwapView(currentView = mainMenuView);
		}

		internal void SwapView(View v) {
			Controls.Remove(currentView.panel);
			currentView = v;

			if (!v.loaded) {
				v.Init();
				v.loaded = true;
			}

			v.OnLoad();
			Controls.Add(v.panel);
			Refresh();
		}

	}
}
