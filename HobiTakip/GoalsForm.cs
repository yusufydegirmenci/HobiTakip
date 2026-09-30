using HobiTakip.Models;

namespace HobiTakip
{
    public partial class GoalsForm : Form
    {
        private Database database;
        private Hobby hobby;
        private List<Goal> goals;

        public GoalsForm(Hobby hobby, Database database)
        {
            InitializeComponent();
            this.hobby = hobby;
            this.database = database;
            LoadGoals();
            SetupForm();
        }

        private void SetupForm()
        {
            this.Text = $"Hedefler - {hobby.Name}";
            lblHobbyName.Text = $"Hobi: {hobby.Name}";
            RefreshGoalsList();
        }

        private void LoadGoals()
        {
            goals = database.GetHobbyGoals(hobby.Id);
        }

        private void RefreshGoalsList()
        {
            listGoals.Items.Clear();

            foreach (var goal in goals)
            {
                var item = new ListViewItem(goal.Title);
                item.SubItems.Add(goal.TargetDate.ToString("dd.MM.yyyy"));
                item.SubItems.Add($"{goal.CurrentValue}/{goal.TargetValue} {goal.Unit}");
                item.SubItems.Add($"{goal.ProgressPercentage:F1}%");
                item.SubItems.Add(goal.IsCompleted ? "Tamamlandı" : "Devam Ediyor");
                
                // Renk kodlaması
                if (goal.IsCompleted)
                {
                    item.BackColor = Color.LightGreen;
                }
                else if (goal.TargetDate < DateTime.Now)
                {
                    item.BackColor = Color.LightCoral;
                }
                else if (goal.ProgressPercentage >= 75)
                {
                    item.BackColor = Color.LightBlue;
                }

                item.Tag = goal;
                listGoals.Items.Add(item);
            }

            // İstatistikleri güncelle
            var completedCount = goals.Count(g => g.IsCompleted);
            var activeCount = goals.Count(g => !g.IsCompleted);
            var overdueCount = goals.Count(g => !g.IsCompleted && g.TargetDate < DateTime.Now);

            lblStats.Text = $"Toplam: {goals.Count} | Tamamlanan: {completedCount} | Aktif: {activeCount} | Süresi Geçen: {overdueCount}";
        }

        private void btnAddGoal_Click(object sender, EventArgs e)
        {
            var addGoalForm = new AddGoalForm(hobby, database);
            if (addGoalForm.ShowDialog() == DialogResult.OK)
            {
                LoadGoals();
                RefreshGoalsList();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listGoals_DoubleClick(object sender, EventArgs e)
        {
            if (listGoals.SelectedItems.Count > 0)
            {
                var selectedGoal = (Goal)listGoals.SelectedItems[0].Tag;
                var detailsForm = new GoalDetailsForm(selectedGoal, database);
                if (detailsForm.ShowDialog() == DialogResult.OK)
                {
                    LoadGoals();
                    RefreshGoalsList();
                }
            }
        }

        private void GoalsForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde listeyi yenile
            RefreshGoalsList();
        }
    }
}