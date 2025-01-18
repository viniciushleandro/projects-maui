namespace NumeroDaSorte;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnGenerateLuckNumbers(object sender, EventArgs e)
    {
        lblNameApp.IsVisible = false;
        vlLuckNumbers.IsVisible = true;

        var set = GenerateLuckNumbers();

        lblLuckNumber01.Text = set.ElementAt(0).ToString("D2");
        lblLuckNumber02.Text = set.ElementAt(1).ToString("D2");
        lblLuckNumber03.Text = set.ElementAt(2).ToString("D2");
        lblLuckNumber04.Text = set.ElementAt(3).ToString("D2");
        lblLuckNumber05.Text = set.ElementAt(4).ToString("D2");
        lblLuckNumber06.Text = set.ElementAt(5).ToString("D2");
    }

    private SortedSet<int> GenerateLuckNumbers()
    {
        //SortedSet
        var list = new SortedSet<int>();
        while (list.Count < 6)
        {
            var random = new Random();
            var number = random.Next(1, 60);

            list.Add(number);
        }

        return list;
    }
}