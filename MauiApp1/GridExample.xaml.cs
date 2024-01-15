namespace MauiApp1;


public partial class GridExample : ContentPage
{
	int x;
	public GridExample()
	{
		InitializeComponent();

	}
	private void Print(object sender, EventArgs e)
	{
		a1.Text += sender.GetType();

	}

    private void a1_Clicked(object sender, EventArgs e)
    {
        Button btn= (Button)sender;

    }

    private void a2_Clicked(object sender, EventArgs e)
    {

    }

    private void a3_Clicked(object sender, EventArgs e)
    {

    }

    private void Minus_Clicked(object sender, EventArgs e)
    {

    }
}