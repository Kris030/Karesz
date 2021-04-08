
namespace Karesz {
	partial class MainForm {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mainMenuPanel = new System.Windows.Forms.Panel();
			this.titleCardPanel = new System.Windows.Forms.Panel();
			this.titleCard = new System.Windows.Forms.Label();
			this.mainMenuPanel.SuspendLayout();
			this.titleCardPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenuPanel
			// 
			this.mainMenuPanel.Controls.Add(this.titleCardPanel);
			this.mainMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainMenuPanel.Location = new System.Drawing.Point(0, 0);
			this.mainMenuPanel.Name = "mainMenuPanel";
			this.mainMenuPanel.Size = new System.Drawing.Size(960, 540);
			this.mainMenuPanel.TabIndex = 0;
			// 
			// titleCardPanel
			// 
			this.titleCardPanel.Controls.Add(this.titleCard);
			this.titleCardPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titleCardPanel.Location = new System.Drawing.Point(0, 0);
			this.titleCardPanel.Name = "titleCardPanel";
			this.titleCardPanel.Size = new System.Drawing.Size(960, 100);
			this.titleCardPanel.TabIndex = 0;
			// 
			// titleCard
			// 
			this.titleCard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.titleCard.Font = new System.Drawing.Font("Consolas", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.titleCard.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.titleCard.Location = new System.Drawing.Point(0, 0);
			this.titleCard.Name = "titleCard";
			this.titleCard.Size = new System.Drawing.Size(960, 100);
			this.titleCard.TabIndex = 1;
			this.titleCard.Text = "Karesz";
			this.titleCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(960, 540);
			this.Controls.Add(this.mainMenuPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Karesz";
			this.mainMenuPanel.ResumeLayout(false);
			this.titleCardPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel mainMenuPanel;
		private System.Windows.Forms.Panel titleCardPanel;
		private System.Windows.Forms.Label titleCard;
	}
}

