using FitnessTracker.models.interfaces;
using FitnessTracker.utils;
using System.Windows.Forms;


namespace FitnessTracker.views
{
    public partial class Activities : Form
    {
        /*  readonly GoalController goalController = new GoalController();*/
        readonly private IGoal currentGoal;

        public Activities()
        {
            InitializeComponent();
            /* currentGoal = goalController.GetCurrentGoal();
             Console.WriteLine(currentGoal.GoalCalories);*/
        }

        private void Btn_running_Click(object sender, System.EventArgs e)
        {
            LinkForm.Replace(new RunningActivity(this), panel_activities);
        }

        private void Btn_yoga_Click(object sender, System.EventArgs e)
        {
            LinkForm.Replace(new YogaActivity(), panel_activities);
        }

        private void Activities_Load(object sender, System.EventArgs e)
        {
            LinkForm.Replace(new RunningActivity(this), panel_activities);
        }

        private void Btn_back_Click(object sender, System.EventArgs e)
        {
            LinkForm.Link(this, new Dashboard());
        }
    }
}
