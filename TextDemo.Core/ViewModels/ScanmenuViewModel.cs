//Roslin Punnoose- n9319751

using MvvmCross.Core.ViewModels;

namespace ScreenshotDemo.Core.ViewModels
{
	public class ScanmenuViewModel
		: MvxViewModel
	{
		private string _name =" Scan Menu ";
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
	}

}