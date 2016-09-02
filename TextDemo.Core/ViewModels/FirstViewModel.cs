using MvvmCross.Core.ViewModels;

namespace TextDemo.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {


        private string _name = "Scan";
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null && value != _name)
                {
                    _name = value;
                    RaisePropertyChanged(() => Name);
                }
            }
        }
                    public System.Windows.Input.ICommand ButtonCommand { get; private set; }

        public FirstViewModel()
        {
            ButtonCommand = new MvxCommand(() =>
            {
               
            });
        }

    }


}
