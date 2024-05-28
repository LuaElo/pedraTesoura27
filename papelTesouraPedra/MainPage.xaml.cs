namespace papelTesouraPedra
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            // 0 é pedra, 1 é papel e 2 é tesoura
      
            int jogoTes = new Random().Next(3);
            if (jogoTes == 1)
            {
                stone.Source = "papel.jpg";
            }
            if (jogoTes == 0)
            {
                stone.Source = "pedra.jpg";
            }
            if (jogoTes == 2)
            {
                stone.Source = "tesoura.jpg";
            }
            string selectedSide = Convert.ToString(escolha.SelectedItem);

            if (jogoTes == 0 && selectedSide == "Pedra")
            {
                ResulLabel.Text = "Parabens, você ganhou";
            }
            if (jogoTes == 1 && selectedSide == "Pedra")
            {
                ResulLabel.Text = "Que pena, você perdeu";
            }
            if (jogoTes == 2 && selectedSide == "Pedra")
            {
                ResulLabel.Text = "Que pena, você perdeu";
            }

            if (jogoTes == 1 && selectedSide == "Papel")
            {
                ResulLabel.Text = "Parabens, você ganhou";
            }
            if (jogoTes == 0 && selectedSide == "Papel")
            {
                ResulLabel.Text = "Que pena, você perdeu";
            }
            if (jogoTes == 2 && selectedSide == "Papel")
            {
                ResulLabel.Text = "Que pena, você perdeu";
            }

            if (jogoTes == 2 && selectedSide == "Tesoura")
            {
                ResulLabel.Text = "Parabens, você ganhou";
            }
            if (jogoTes == 0 && selectedSide == "Tesoura")
            {
                ResulLabel.Text = "Que pena, você perdeu";
            }
            if (jogoTes == 1 && selectedSide == "Tesoura")
            {
                ResulLabel.Text = "Que pena, você perdeu";
            }
        }
    }

}
