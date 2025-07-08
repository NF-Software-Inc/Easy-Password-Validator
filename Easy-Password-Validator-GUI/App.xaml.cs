namespace Easy_Password_Validator_GUI
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
		}

		/// <inheritdoc />
		protected override Window CreateWindow(IActivationState? activationState)
		{
			return new Window(new MainPage()) { Title = "Easy Password Validator GUI" };
		}
	}
}
