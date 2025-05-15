namespace MauiHello;

public partial class LaskinPage : ContentPage
{
    string currentEntry = "";
    double firstNumber = 0;
    string operation = "";

    

    public LaskinPage()
	{
		InitializeComponent();
	}

    void OnNumberClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        string number = button.Text;

        if (Display.Text == "0" && number != ".")
            Display.Text = "";

        Display.Text += number;
    }

    void OnOperatorClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        operation = button.Text;

        if (double.TryParse(Display.Text, out firstNumber))
        {
            Display.Text = "";
        }
    }

    void OnEqualClicked(object sender, EventArgs e)
    {
        if (double.TryParse(Display.Text, out double secondNumber))
        {
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber != 0)
                        result = firstNumber / secondNumber;
                    else
                    {
                        Display.Text = "Error";
                        return;
                    }
                    break;
            }

            Display.Text = result.ToString();
        }
    }

    void OnClearClicked(object sender, EventArgs e)
    {
        Display.Text = "0";
        firstNumber = 0;
        operation = "";
    }

    void OnBackspaceClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Display.Text) && Display.Text.Length > 1)
        {
            Display.Text = Display.Text[..^1];
        }
        else
        {
            Display.Text = "0";
        }
    }
}