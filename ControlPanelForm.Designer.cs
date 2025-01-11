namespace Group7_Rakhmanov_Ohalebo_QGame
{
	partial class ControlPanelForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			designButton = new Button();
			exitButton = new Button();
			playButton = new Button();
			SuspendLayout();
			// 
			// designButton
			// 
			designButton.Image = Properties.Resources.game_design_24;
			designButton.ImageAlign = ContentAlignment.TopCenter;
			designButton.Location = new Point(200, 130);
			designButton.Name = "designButton";
			designButton.Size = new Size(114, 67);
			designButton.TabIndex = 0;
			designButton.Text = "Design";
			designButton.TextAlign = ContentAlignment.BottomCenter;
			designButton.UseVisualStyleBackColor = true;
			designButton.Click += designButton_Click;
			// 
			// exitButton
			// 
			exitButton.Image = Properties.Resources.exit_black_24;
			exitButton.ImageAlign = ContentAlignment.TopCenter;
			exitButton.Location = new Point(306, 243);
			exitButton.Name = "exitButton";
			exitButton.Size = new Size(117, 67);
			exitButton.TabIndex = 1;
			exitButton.Text = "Exit";
			exitButton.TextAlign = ContentAlignment.BottomCenter;
			exitButton.UseVisualStyleBackColor = true;
			exitButton.Click += exitButton_Click;
			// 
			// playButton
			// 
			playButton.Image = Properties.Resources.game_play_24;
			playButton.ImageAlign = ContentAlignment.TopCenter;
			playButton.Location = new Point(418, 130);
			playButton.Name = "playButton";
			playButton.Size = new Size(115, 67);
			playButton.TabIndex = 2;
			playButton.Text = "Play";
			playButton.TextAlign = ContentAlignment.BottomCenter;
			playButton.UseVisualStyleBackColor = true;
			playButton.Click += playButton_Click;
			// 
			// ControlPanelForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(playButton);
			Controls.Add(exitButton);
			Controls.Add(designButton);
			Name = "ControlPanelForm";
			Text = "Group7_Rakhmanov_Ohalebo_QGame";
			ResumeLayout(false);
		}

		#endregion

		private Button designButton;
		private Button exitButton;
		private Button playButton;
	}
}
