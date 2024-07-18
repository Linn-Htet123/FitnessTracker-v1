using FitnessTracker.utils;  // Importing the LinkForm utility from FitnessTracker.utils namespace
using System.Windows.Forms;

namespace FitnessTracker.views
{
    public partial class Activities : Form
    {
        public Activities()
        {
            InitializeComponent();
        }

        // Method to handle the click event for the "Running" button
        private void Btn_running_Click(object sender, System.EventArgs e)
        {
            // Replace the content of panel_activities with a new instance of RunningActivity form
            LinkForm.Replace(new RunningActivity(this), panel_activities);
        }

        // Method to handle the click event for the "Yoga" button
        private void Btn_yoga_Click(object sender, System.EventArgs e)
        {
            // Replace the content of panel_activities with a new instance of YogaActivity form
            LinkForm.Replace(new YogaActivity(this), panel_activities);
        }

        // Method to handle the click event for the "Biking" button
        private void Btn_biking_Click(object sender, System.EventArgs e)
        {
            // Replace the content of panel_activities with a new instance of BikingActivity form
            LinkForm.Replace(new BikingActivity(this), panel_activities);
        }

        // Method called when the Activities form is loaded
        private void Activities_Load(object sender, System.EventArgs e)
        {
            // Load the RunningActivity form by default when Activities form is loaded
            LinkForm.Replace(new RunningActivity(this), panel_activities);
        }

        // Method to handle the click event for the "Swimming" button
        private void Btn_swimming_Click(object sender, System.EventArgs e)
        {
            // Replace the content of panel_activities with a new instance of SwimmingActivity form
            LinkForm.Replace(new SwimmingActivity(this), panel_activities);
        }

        // Method to handle the click event for the "Jump Rope" button
        private void Btn_jump_rope_Click(object sender, System.EventArgs e)
        {
            // Replace the content of panel_activities with a new instance of JumpingRopeActivity form
            LinkForm.Replace(new JumpingRopeActivity(this), panel_activities);
        }

        // Method to handle the click event for the "Walking" button
        private void Btn_walking_Click(object sender, System.EventArgs e)
        {
            // Replace the content of panel_activities with a new instance of WalkingActivity form
            LinkForm.Replace(new WalkingActivity(this), panel_activities);
        }

        // Method to handle the click event for the "Back" button
        private void Btn_back_Click(object sender, System.EventArgs e)
        {
            // Navigate back to the Dashboard form
            LinkForm.Link(this, new Dashboard());
        }
    }
}
