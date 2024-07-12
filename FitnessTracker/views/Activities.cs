using FitnessTracker.utils;
using System.Windows.Forms;


namespace FitnessTracker.views
{
    public partial class Activities : Form
    {
        public Activities()
        {
            InitializeComponent();
        }

        private void Btn_running_Click(object sender, System.EventArgs e)
        {
            LinkForm.Replace(new RunningActivity(this), panel_activities);
        }

        private void Btn_yoga_Click(object sender, System.EventArgs e)
        {
            LinkForm.Replace(new YogaActivity(this), panel_activities);
        }

        private void Btn_biking_Click(object sender, System.EventArgs e)
        {
            LinkForm.Replace(new BikingActivity(this), panel_activities);
        }

        private void Activities_Load(object sender, System.EventArgs e)
        {
            LinkForm.Replace(new RunningActivity(this), panel_activities);
        }

        private void Btn_swimming_Click(object sender, System.EventArgs e)
        {
            LinkForm.Replace(new SwimmingActivity(this), panel_activities);
        }
        private void Btn_jump_rope_Click(object sender, System.EventArgs e)
        {
            LinkForm.Replace(new JumpingRopeActivity(this), panel_activities);
        }
        private void Btn_walking_Click(object sender, System.EventArgs e)
        {
            LinkForm.Replace(new WalkingActivity(this), panel_activities);
        }
        private void Btn_back_Click(object sender, System.EventArgs e)
        {
            LinkForm.Link(this, new Dashboard());
        }


    }
}
