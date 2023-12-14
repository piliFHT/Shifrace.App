using System.Text;

namespace Shifrace;

public partial class MainPage : ContentPage
{
    Random random = new();
	int key = 420;
    int sifrace = 0;
	string text = "";
	
	//Console.WriteLine($"(char)i)");


	public MainPage()
	{
		InitializeComponent();
	}

	public void Shifrace()
	{
        
        input.Text.ToCharArray();
		byte[] ascii = ASCIIEncoding.UTF8.GetBytes(input.Text);
        for (sifrace = 0;sifrace < ascii.Length; sifrace++)
		{
            int shifr = (char)ascii[sifrace];
            shifrace.Text += $"{(char)(shifr + key)}";
		}
	}

	private void Deshifrace()
	{
        shifrace.Text.ToCharArray();
        byte[] ascii = ASCIIEncoding.UTF8.GetBytes(shifrace.Text);
        for (sifrace = 0; sifrace < ascii.Length; sifrace++)
		{
            int shifr = (char)ascii[sifrace];
            input.Text += $"{(char)(shifr - key)}";
		}
	}

    private void SifraceBtn_Clicked(object sender, EventArgs e)
    {
		Shifrace();
    }

    private void DesifraceBtn_Clicked(object sender, EventArgs e)
    {
		Deshifrace();
    }

    private void Delete_Clicked(object sender, EventArgs e)
    {
		input.Text = string.Empty;
		shifrace.Text = string.Empty;
    }
}

