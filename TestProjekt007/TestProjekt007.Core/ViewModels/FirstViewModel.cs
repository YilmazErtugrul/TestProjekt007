using MvvmCross.Core.ViewModels;

namespace TestProjekt007.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        string hello = "Hello Uptodata professional f2";
        string h = "h";
        string bla = "bla";
        public string Hello
        {
            get { return hello; }
            set { SetProperty(ref hello, value); }
        }
    }
}
