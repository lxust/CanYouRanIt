using CanYouRunIt;
namespace CanYouRunIt
{
    public partial class Form1 : Form
    {
        List<Game> games = new List<Game>()
        {
            new Game() { Name = "PVP", CPU = 1.7, Memory = 10, OpMemory = 4, VidioMemory = 6 },
            new Game() { Name = "GoRun", VidioMemory=1, Memory = 12, OpMemory = 2, CPU = 2 },
            new Game() { Name = "Rust", VidioMemory=2, Memory = 40, OpMemory = 8, CPU = 3 },
            new Game() { Name = "Minecraft", VidioMemory=8, Memory = 10, OpMemory = 4, CPU = 1.7 },
            new Game() { Name = "ARK", VidioMemory=8, Memory = 340, OpMemory = 16, CPU = 5 }
        };
          
        public Form1()
        {
            InitializeComponent();
            FillDGV(games);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbOpMemory.Text) && !string.IsNullOrEmpty(tbMemory.Text) && !string.IsNullOrEmpty(tbVidioMemory.Text) && !string.IsNullOrEmpty(tbCPU.Text))
            {
                int OpMemory = Convert.ToInt32(tbOpMemory.Text);
                int VidioMemory = Convert.ToInt32(tbVidioMemory.Text);
                double CPU = Convert.ToInt32(tbCPU.Text);
                int Memory = Convert.ToInt32(tbMemory.Text);

                var list = Find(OpMemory, VidioMemory, CPU, Memory);
                FillDGV(list);
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
                FillDGV(games);
            }

            

            
        }

        private List<Game> Find(int OpMemory, int VidioMemory,double CPU, int Memory)
        {
            List<Game> FindGames = games.Where(x => x.OpMemory <= OpMemory && Memory >= x.Memory && CPU >= x.CPU && VidioMemory >= x.VidioMemory).ToList();

            return FindGames;

        }

        private void FillDGV(List<Game> findedGames)
        {
            dataGridView1.Rows.Clear();
            foreach (Game game in findedGames)
            {
                dataGridView1.Rows.Add(game.Name, game.OpMemory, game.Memory, game.CPU, game.VidioMemory);
            }
        }
    }
}