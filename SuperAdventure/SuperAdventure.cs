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
            _player = new Player();
            //assigning the values to the properties of the _player object
            _player.CurrentHitPoints = 10;
            _player.MaximumHitPoints = 10;
            _player.Gold = 20;
            _player.ExperiencePoints = 0;
            _player.Level = 1;
            //setting the labels .text values on the UI to the _player values with .ToString to convert numbers to strings
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }
    }
}
