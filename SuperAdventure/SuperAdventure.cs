using Engine;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        //class level variable so private, datatype is "Player" to store a Player object and the name is "_player"
        private Player _player;

        public SuperAdventure()
        {
            InitializeComponent();

            //creating the new Player object and assigning it to the _player variable declared above
            _player = new Player(10, 10, 20, 0, 1);

            //setting the labels .text values on the UI to the _player values with .ToString to convert numbers to strings
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();

            //Location object saved to variable "location" with values assigned
            Location location = new Location(1, "Home", "This is your house.");
            location.ID = 1;
            location.Name = "Home";
            location.Description = "This is your house.";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
