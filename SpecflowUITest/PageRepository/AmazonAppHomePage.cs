using SeleniumWrapper;

namespace PageRepository
{
    public class AmazonAppHomePage
    {
        SeleniumHelper seleniumHelper = new SeleniumHelper();
        public string SearchBox
        {
            get
            {
                return "//*[@id=\"twotabsearchtextbox\"]";
            }
        }

        public void LaunchAppAndSearchAnItem(string appUrl, string searchItem)
        {
            seleniumHelper.LaunchApp(appUrl);
            seleniumHelper.EnterText(searchItem, SearchBox);
        }

        public void QuitApp()
        {
            seleniumHelper.Quit();
        }
    }
}