using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.UI;

namespace RemoteConfigDemo.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public MainViewModel()
        {
        }
        
        public override Task Initialize()
        {   
            return base.Initialize();
        }
        
        public IMvxCommand ButtonCommand => new MvxCommand(ButtonClick);

        private void ButtonClick()
        {
            Text = "I clicked the button";
        }

        private string _text = "";

        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        public MvxColor ButtonColour
        {
            get
            {
                return new MvxColor(0, 255, 0);
            }
        }
    }
}