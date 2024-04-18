using YodaApp.Views;

namespace YodaApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("YodaAnswerPage", typeof(YodaAnswerPage));
            //Routing.RegisterRoute("YodaQuestionPage", typeof(YodaQuestionPage));
        }
    }
}
