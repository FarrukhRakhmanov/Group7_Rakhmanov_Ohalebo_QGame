/* ControlPanelForm.cs
 * Form to load design or play sub forms of a Q-Game
 * 
 * Revision History
 * Farrukh Rakhmanov, Valentine Ohalebo, 10.22.2024: Created
 */

namespace Group7_Rakhmanov_Ohalebo_QGame
{
	public partial class ControlPanelForm : Form
	{
		public ControlPanelForm()
		{
			InitializeComponent();
		}

		private void designButton_Click(object sender, EventArgs e)
		{
			//create a new instance of the DesignerForm
			DesignerForm designerForm = new DesignerForm();

			//show the DesignerForm
			designerForm.Show();
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			//close the application
			Application.Exit();
		}

		private void playButton_Click(object sender, EventArgs e)
		{
            //create a new instance of the DesignerForm
            PlayForm playForm = new PlayForm();

            //show the DesignerForm
            playForm.Show();
        }
	}
}
