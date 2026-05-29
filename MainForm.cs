using System.Media;
using System.Web;

namespace TypeVibe2026Form
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void BTNopenfile_Click(object sender, EventArgs e)
        {
            // Lets create an open dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //lets show user a search window
            DialogResult userChoice = openFileDialog.ShowDialog();

            //did our user click ok yet?
            if(userChoice == DialogResult.OK)
            {
                //lets get the file path
                string chosenfilePath = openFileDialog.FileName;

                //lets read the file
                StreamReader streamReader = new StreamReader(chosenfilePath);

                //read the file contents
                string fileContents = streamReader.ReadToEnd();

                //Add the file contents to our editor RTB
                RTBeditor.Text = fileContents;

                //close the stream reader so that the file does not get corrupted
                streamReader.Close();
            }
            
        }

        private void BTNsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // show save window to our user
            DialogResult userChoice = saveFileDialog.ShowDialog();

            // Did our user click ok to confirm a save?
            if (userChoice == DialogResult.OK)
            {
                //lets get the file path
                string saveLocation = saveFileDialog.FileName;

                //lets create a stream writer to write to the file
                StreamWriter streamWriter = new StreamWriter(saveLocation);

                // Save the text from our editor
                streamWriter.Write(RTBeditor.Text);

                //close the stream writer so that the file does not get corrupted
                streamWriter.Close();
            }
        }

        private void BTNmusic_Click(object sender, EventArgs e)
        {

            // locate where our program is living
            string path = Path.Combine(Application.StartupPath, "rainsound.wav");

            // This shows where the path of the music file is located
            MessageBox.Show(path);

            // Create a sound player object
            SoundPlayer player = new SoundPlayer(path);
            player.Play();


            
        }
    }
}
