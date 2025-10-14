namespace WinFormsmedia_tech
{
    public partial class AccueilForm : Form
    {
        public AccueilForm()
        {
            InitializeComponent();

            HeaderControl headerControl = new HeaderControl();
            this.Controls.Add(headerControl);
            headerControl.Dock = DockStyle.Top; // Fixer l'en-tête en haut

            PageArticleController pageArticleController = new PageArticleController();
            pageArticleController.Top = headerControl.Height; // Positionner en dessous de l'en-tête
            pageArticleController.Dock = DockStyle.Fill; // Remplir l'espace restant
            this.Controls.Add(pageArticleController);
            pageArticleController.Dock = DockStyle.Fill; // Remplir l'espace restant
           
         
            this.WindowState = FormWindowState.Maximized; // Ouvrir en plein écran
        
          
            








        }
     







    }
}

