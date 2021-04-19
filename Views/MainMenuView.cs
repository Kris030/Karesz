using System;
using System.Drawing;
using System.Windows.Forms;

namespace Karesz.Views {

	internal class MainMenuView : View {

		public MainMenuView(MainForm parent) : base(parent) { }

		internal override void Init() {

			Font mainMenuButtonFont = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);

			// playButton
			Button playButton = new Button {
				FlatStyle = FlatStyle.Flat,
				Font = mainMenuButtonFont,
				ForeColor = Color.Chartreuse,
				Location = new Point(318, 135),
				Name = "playButton",
				Size = new Size(300, 50),
				TabIndex = 4,
				Text = "Játék",
				UseVisualStyleBackColor = false,
			};
			playButton.Cursor = Cursors.Hand;
			playButton.FlatAppearance.BorderSize = 0;
			playButton.Click += PlayButtonClick;

			// editorButton
			Button editorButton = new Button {
				FlatStyle = FlatStyle.Flat,
				Font = mainMenuButtonFont,
				ForeColor = Color.Yellow,
				Location = new Point(318, 191),
				Name = "editorButton",
				Size = new Size(300, 50),
				TabIndex = 2,
				Text = "Pálya Szerkesztő",
				UseVisualStyleBackColor = false,
			};
			editorButton.Cursor = Cursors.Hand;
			editorButton.FlatAppearance.BorderSize = 0;
			editorButton.Click += (o, s) => parent.SwapView(parent.editorView);

			// optionsButton
			Button optionsButton = new Button {
				FlatStyle = FlatStyle.Flat,
				Font = mainMenuButtonFont,
				ForeColor = Color.Orange,
				Location = new Point(318, 247),
				Name = "optionsButton",
				Size = new Size(300, 50),
				TabIndex = 2,
				Text = "Beállítások",
				UseVisualStyleBackColor = false,
			};
			optionsButton.Cursor = Cursors.Hand;
			optionsButton.FlatAppearance.BorderSize = 0;
			optionsButton.Click += (o, s) => parent.SwapView(parent.optionsView);

			// exitButton
			Button exitButton = new Button {
				FlatStyle = FlatStyle.Flat,
				Font = mainMenuButtonFont,
				ForeColor = Color.Red,
				Location = new Point(318, 303),
				Name = "exitButton",
				Size = new Size(300, 50),
				TabIndex = 3,
				Text = "Kilépés",
				UseVisualStyleBackColor = false,
			};
			exitButton.Cursor = Cursors.Hand;
			exitButton.FlatAppearance.BorderSize = 0;
			exitButton.Click += (o, s) => Application.Exit();

			// buttonsPanel
			Panel buttonsPanel = new Panel {
				Location = new Point(0, 93),
				Name = "buttonsPanel",
				Size = new Size(960, 447),
				TabIndex = 4,
				Anchor = AnchorStyles.None,
			};
			buttonsPanel.Controls.Add(playButton);
			buttonsPanel.Controls.Add(editorButton);
			buttonsPanel.Controls.Add(optionsButton);
			buttonsPanel.Controls.Add(exitButton);
			buttonsPanel.SuspendLayout();
			buttonsPanel.ResumeLayout(false);

			// titleCard
			Label titleCard = new Label {
				Dock = DockStyle.Fill,
				Font = new Font("Consolas", 72, FontStyle.Bold, GraphicsUnit.Point),
				ForeColor = SystemColors.MenuHighlight,
				Location = new Point(0, 0),
				Name = "titleCard",
				Size = new Size(960, 93),
				TabIndex = 1,
				Text = "Karesz",
				TextAlign = ContentAlignment.MiddleCenter
			};

			// titleCardPanel
			Panel titleCardPanel = new Panel {
				Dock = DockStyle.Top,
				Location = new Point(0, 0),
				Name = "titleCardPanel",
				Size = new Size(960, 93),
				TabIndex = 0,
			};
			titleCardPanel.Controls.Add(titleCard);
			titleCardPanel.SuspendLayout();
			titleCardPanel.ResumeLayout(false);

			// panel
			panel = new Panel {
				Dock = DockStyle.Fill,
				Location = new Point(0, 0),
				Name = "mainMenuPanel",
				Size = new Size(960, 540),
				TabIndex = 0,
			};
			panel.Controls.Add(buttonsPanel);
			panel.Controls.Add(titleCardPanel);
			panel.SuspendLayout();
			panel.ResumeLayout(false);

		}

		private void PlayButtonClick(object sender, EventArgs e) {

			//MapSelectForm selector = new MapSelectForm();

			using OpenFileDialog ofd = new();
			DialogResult res = ofd.ShowDialog(parent);



		}

		internal override void OnLoad() {

		}

	}
}
