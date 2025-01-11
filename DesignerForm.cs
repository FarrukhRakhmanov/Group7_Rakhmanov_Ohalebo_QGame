/* DesignerForm.cs
 * Form to design a game grid for the Q-Game
 * 
 * Revision History
 * Farrukh Rakhmanov, Valentine Ohalebo, 10.22.2024: Created
 */

using Group7_Rakhmanov_Ohalebo_QGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Resources;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group7_Rakhmanov_Ohalebo_QGame
{
	enum GridType
	{
		Empty,
		Wall,
		RedDoor,
		GreenDoor,
		BlueDoor,
		RedBox,
		GreenBox,
		BlueBox
	}

	public partial class DesignerForm : Form
	{
		#region Global variables
		// Constants for grid positioning and size
		private const int INIT_TOP = 30;
		private const int INIT_LEFT = 50;
		private const int WIDTH = 40;
		private const int HEIGHT = 40;
		private const int VGAP = 0;
		private const int HGAP = 0;
		#endregion


		// Declare images for the grid
		private Bitmap wall;
		private Bitmap whiteBlock;
		private Bitmap redDoor;
		private Bitmap redBox;
		private Bitmap greenDoor;
		private Bitmap greenBox;
		private Bitmap blueDoor;
		private Bitmap blueBox;
		private Bitmap currentImage;

		public int numberOfRows;
		public int numberOfColumns;
		public bool isButtonSelected = false;
		public System.Windows.Forms.Button newSelectedButton;
		public System.Windows.Forms.Button currentButton;


		public bool isGenerated = false;
		GridType gridType = GridType.Empty;
		public string[,] gridToSave;

		public DesignerForm()
		{
			InitializeComponent();
			rowComboBox.SelectedIndex = 0;
			columnComboBox.SelectedIndex = 0;

			try
			{
				// Load images from embedded resources 
				using (var ms = new MemoryStream(Resources.wall_1024))
				{
					wall = new Bitmap(ms);
				}
				using (var ms = new MemoryStream(Resources.green_block_1024))
				{
					greenBox = new Bitmap(ms);
				}
				using (var ms = new MemoryStream(Resources.green_door_1024))
				{
					greenDoor = new Bitmap(ms);
				}
				using (var ms = new MemoryStream(Resources.red_block_1024))
				{
					redBox = new Bitmap(ms);
				}
				using (var ms = new MemoryStream(Resources.red_door_1024))
				{
					redDoor = new Bitmap(ms);
				}
				using (var ms = new MemoryStream(Resources.blue_block_1024))
				{
					blueBox = new Bitmap(ms);
				}
				using (var ms = new MemoryStream(Resources.blue_door_1024))
				{
					blueDoor = new Bitmap(ms);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			toolTipPopup.SetToolTip(noneButton, "Empty");
			toolTipPopup.SetToolTip(wallButton, "Wall");
			toolTipPopup.SetToolTip(redDoorButton, "Red Door");
			toolTipPopup.SetToolTip(greenDoorButton, "Green Door");
			toolTipPopup.SetToolTip(blueDoorButton, "Blue Door");
			toolTipPopup.SetToolTip(redBoxButton, "Red Box");
			toolTipPopup.SetToolTip(greenBoxButton, "Green Box");
			toolTipPopup.SetToolTip(blueBoxButton, "Blue Box");

		}
		private void generateButton_Click(object sender, EventArgs e)
		{
			if (!isGenerated)
			{
				GenerateGrid();
				isGenerated = true;
			}
			else
			{
				if (DialogResult.Yes == MessageBox.Show("Do you want to abandon the current level and start a new one?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
				{
					GenerateGrid();
				}
			}
		}
		private void B_Click(object sender, EventArgs e)
		{
			PictureBox pictureBox = (PictureBox)sender;

			//Check if the pictureBox exists
			if (pictureBox != null)
			{
				if (isButtonSelected)
				{
					pictureBox.Image = currentImage;
					pictureBox.Name = gridType.ToString();
					toolTipPopup.SetToolTip(pictureBox, gridType.ToString());
				}
				else
				{
					toolTipPopup.SetToolTip(pictureBox, "Select an item");
				}
			}
		}
		private void saveButton_Click(object sender, EventArgs e)
		{
			if (isGenerated)
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog
				{
					Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
					Title = "Save level file"
				};

				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					Serialize();
					// Create a new instance of the StreamWriter class
					using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
					{
						writer.WriteLine(numberOfRows.ToString() + ";" + numberOfColumns.ToString());
						// Loop through each PictureBox control in the mainPanel
						for (int i = 0; i < gridToSave.GetLength(0); i++)
						{
							StringBuilder sb = new StringBuilder();
							for (int j = 0; j < gridToSave.GetLength(1); j++)
							{
								sb.Append(gridToSave[i, j].ToString() + ";");
							}
							writer.WriteLine(sb);
						}
					}
					int numberOfDoors = 0;
					int numberOfBoxes = 0;
					int numberOfWalls = 0;

                    for (int i = 0; i < numberOfRows; i++)
					{
						for (int j = 0; j < numberOfColumns; j++)
						{
							if (gridToSave[i, j] == "Wall")
							{
								numberOfWalls++;
							}
							else if (gridToSave[i, j] == "RedDoor" || gridToSave[i, j] == "GreenDoor" || gridToSave[i, j] == "BlueDoor")
							{
								numberOfDoors++;
							}
							else if (gridToSave[i, j] == "RedBox" || gridToSave[i, j] == "GreenBox" || gridToSave[i, j] == "BlueBox")
							{
								numberOfBoxes++;
							}
						}
					}

					MessageBox.Show("Level saved successfully!\nNumber of walls: " + numberOfWalls + "\nNumber of doors: " + numberOfDoors + "\nNumber of boxes: " + numberOfBoxes);
					ClearDesignPanel();
				}
			}
			else
			{
				MessageBox.Show("No game grid to save");
			}
		}
		private void loadButton_Click(object sender, EventArgs e)
		{
			try
			{
				bool isLoaded = false;
				if (!isGenerated)
				{
					isLoaded = true;
					isGenerated = true;

				}
				else
				{
					if (DialogResult.Yes == MessageBox.Show("Do you want to abandon the current level and load a saved game?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
					{
						isLoaded = true;
					}
				}
				if (isLoaded)
				{
					OpenFileDialog openFileDialog = new OpenFileDialog
					{
						Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
						Title = "Open level file"
					};

					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						if (!string.IsNullOrEmpty(openFileDialog.FileName))
						{
							Deserialize(openFileDialog.FileName);
							currentImage = null;
							if (currentButton != null)
							{
								currentButton.BackColor = Color.White;
							}
						}
						else
						{
							MessageBox.Show("Selected file does not contain any game load.");
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void exitButton_Click(object sender, EventArgs e)
		{
			//close the DesignerForm
			this.Close();
		}
		private void noneButton_MouseClick(object sender, MouseEventArgs e)
		{
			AssignButton(sender);
		}
		private void wallButton_MouseClick(object sender, MouseEventArgs e)
		{
			AssignButton(sender);
		}
		private void redDoorButton_MouseClick(object sender, MouseEventArgs e)
		{
			AssignButton(sender);
		}
		private void greenDoorButton_MouseClick(object sender, MouseEventArgs e)
		{
			AssignButton(sender);
		}
		private void blueDoorButton_MouseClick(object sender, MouseEventArgs e)
		{
			AssignButton(sender);
		}
		private void redBoxButton_MouseClick(object sender, MouseEventArgs e)
		{
			AssignButton(sender);
		}
		private void greenBoxButton_MouseClick(object sender, MouseEventArgs e)
		{
			AssignButton(sender);
		}
		private void blueBoxButton_MouseClick(object sender, MouseEventArgs e)
		{
			AssignButton(sender);
		}

		/// <summary>
		/// A method to assign name, image and gridType based on the selected button
		/// </summary>
		private void AssignButton(Object sender)
		{
			newSelectedButton = (System.Windows.Forms.Button)sender;
			if (currentButton != null)
			{
				currentButton.BackColor = Color.White;
			}

			currentButton = newSelectedButton;
			currentButton.BackColor = Color.LightSkyBlue;
			isButtonSelected = true;
			switch (currentButton.Name)
			{
				case "noneButton":
					currentImage = whiteBlock;
					gridType = GridType.Empty;
					break;
				case "wallButton":
					currentImage = wall;
					gridType = GridType.Wall;
					break;
				case "redDoorButton":
					currentImage = redDoor;
					gridType = GridType.RedDoor;
					break;
				case "greenDoorButton":
					currentImage = greenDoor;
					gridType = GridType.GreenDoor;
					break;
				case "blueDoorButton":
					currentImage = blueDoor;
					gridType = GridType.BlueDoor;
					break;
				case "redBoxButton":
					currentImage = redBox;
					gridType = GridType.RedBox;
					break;
				case "greenBoxButton":
					currentImage = greenBox;
					gridType = GridType.GreenBox;
					break;
				case "blueBoxButton":
					currentImage = blueBox;
					gridType = GridType.BlueBox;
					break;
			}

		}

		/// <summary>
		/// A method to generate a grid of PictureBox controls
		/// </summary>
		private void GenerateGrid()
		{
			try
			{
				mainPanel.Controls.Clear(); // Clear any previous grid
				isButtonSelected = false;
				int x = INIT_LEFT;  // Starting X position for the grid
				int y = INIT_TOP;   // Starting Y position for the grid

				numberOfColumns = Convert.ToInt32(columnComboBox.SelectedItem);
				numberOfRows = Convert.ToInt32(rowComboBox.SelectedItem);

				gridToSave = new string[numberOfRows, numberOfColumns];



				// Loop through the grid rows and columns to create PictureBox controls
				for (int i = 0; i < numberOfRows; i++)
				{
					for (int j = 0; j < numberOfColumns; j++)
					{
						PictureBox pictureBox = new PictureBox
						{
							Left = x,                      // Set left position
							Top = y,                       // Set top position
							Width = WIDTH,                 // Set width
							Height = HEIGHT,               // Set height
							BackColor = Color.White,       // Set background color
							SizeMode = PictureBoxSizeMode.StretchImage, // Set image size mode
							Name = "Empty",
							BorderStyle = BorderStyle.Fixed3D
						};
						mainPanel.Controls.Add(pictureBox);  // Add PictureBox to panel
						toolTipPopup.SetToolTip(pictureBox, pictureBox.Name);
						pictureBox.Click += B_Click; // Set up click event for each PictureBox

						x += WIDTH + HGAP;  // Move to the next column
					}
					x = INIT_LEFT;          // Reset X position for new row
					y += HEIGHT + VGAP;     // Move to the next row
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// A method to serialize the grid to a text file
		/// </summary>
		private void Serialize()
		{
			for (int i = 0; i < numberOfRows; i++)
			{
				for (int j = 0; j < numberOfColumns; j++)
				{
					gridToSave[i, j] = mainPanel.Controls[i * numberOfColumns + j].Name;
				}
			}
		}

		/// <summary>
		/// A method to deserialize the grid from a text file
		/// </summary>
		/// <param name="fileName"></param>
		private void Deserialize(string fileName)
		{
			try
			{
				string[] lines = File.ReadAllLines(fileName);
				string[] size = lines[0].Split(';');
				numberOfRows = Convert.ToInt32(size[0]);
				numberOfColumns = Convert.ToInt32(size[1]);
				gridToSave = new string[numberOfRows, numberOfColumns];

				mainPanel.Controls.Clear(); // Clear any previous grid

				int x = INIT_LEFT;  // Starting X position for the grid
				int y = INIT_TOP;   // Starting Y position for the grid

				// Loop through the grid rows and columns to create PictureBox controls
				for (int i = 0; i < numberOfRows; i++)
				{
					string[] cells = lines[i + 1].Split(';');
					for (int j = 0; j < numberOfColumns; j++)
					{
						PictureBox pictureBox = new PictureBox
						{
							Left = x,                      // Set left position
							Top = y,                       // Set top position
							Width = WIDTH,                 // Set width
							Height = HEIGHT,               // Set height
							BackColor = Color.White,       // Set background color
							SizeMode = PictureBoxSizeMode.StretchImage, // Set image size mode
							Name = string.IsNullOrWhiteSpace(cells[j]) ? "Empty" : cells[j]
						};
						pictureBox.BorderStyle = BorderStyle.Fixed3D; // Set border style
						toolTipPopup.SetToolTip(pictureBox, cells[j]);
						mainPanel.Controls.Add(pictureBox);  // Add PictureBox to panel

						pictureBox.Click += B_Click; // Set up click event for each PictureBox

						x += WIDTH + HGAP;  // Move to the next column
						gridToSave[i, j] = cells[j];
						switch (cells[j])
						{
							case "Wall":
								pictureBox.Image = wall;
								break;
							case "RedDoor":
								pictureBox.Image = redDoor;
								break;
							case "GreenDoor":
								pictureBox.Image = greenDoor;
								break;
							case "BlueDoor":
								pictureBox.Image = blueDoor;
								break;
							case "RedBox":
								pictureBox.Image = redBox;
								break;
							case "GreenBox":
								pictureBox.Image = greenBox;
								break;
							case "BlueBox":
								pictureBox.Image = blueBox;
								break;
							default:
								pictureBox.Image = whiteBlock;
								break;
						}
					}
					x = INIT_LEFT;          // Reset X position for new row
					y += HEIGHT + VGAP;
				}
				isButtonSelected = false;
			}
			catch (Exception)
			{
				MessageBox.Show("Game load file is empty or has invalid format");
			}
		}

		/// <summary>
		/// A method to clear the design panel
		/// </summary>
		private void ClearDesignPanel()
		{
			mainPanel.Controls.Clear();
			isGenerated = false;
			isButtonSelected = false;
			currentButton.BackColor = Color.White;
		}
	}
}