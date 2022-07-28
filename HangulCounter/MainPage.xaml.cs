using System.Globalization;
using HangulCounter.Models;
using Humanizer;

namespace HangulCounter;

public partial class MainPage : ContentPage
{
    private string count;

    public string Count
    {
        get => count; set
        {
            count = value;
            OnPropertyChanged();
        }
    }

    private string counter;

    public string Counter
    {
        get => counter; set
        {
            counter = value;
            OnPropertyChanged();
        }
    }

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        
        var colNeeded = AppModel.Counters.Count / 4;
        var row = 0;
        var col = 0;
        foreach (var item in AppModel.Counters)
        {
            var b = new RadioButton { Content = item.Icon, Value = item };//ControlTemplate = ((ControlTemplate)App.Current.Resources["ButtonRadio"])
            b.CheckedChanged += OnCounters_Changed;
            CountersContainer.Add(
                b
            , col, row);
            
            row++;

            if(row > 3)
            {
                row = 0;
                col++;
            }

            CountersContainer.ColumnDefinitions = GetColDefs(col+1);
        }
    }

    private void OnCounters_Changed(object sender, CheckedChangedEventArgs e)
    {
        RadioButton r = (RadioButton)sender;
        Counter = ((Counter)r.Value).LabelKorean;
    }

    private ColumnDefinitionCollection GetColDefs(int col)
    {
        var coll = new ColumnDefinitionCollection();
        for (int i = 0; i < col; i++)
        {
            coll.Add(new ColumnDefinition(GridLength.Star));
        }

        return coll;
    }

    void Number_Clicked(System.Object sender, System.EventArgs e)
    {
        Count += (sender as Button).Text;
    }

    void Clear_Clicked(System.Object sender, System.EventArgs e)
    {
        Count = "";
    }

    void OnCounters_Clicked(System.Object sender, System.EventArgs e)
    {
        Button btn = sender as Button;
        //var counter = AppModel.Counters.Find(x => x.Icon == btn.ImageSource);
        Counter = btn.CommandParameter.ToString();
    }

    void Play_Clicked(System.Object sender, System.EventArgs e)
    {
    }

    string countDigits = "";
    void Announce_Clicked(System.Object sender, System.EventArgs e)
    {
        // convert numbers to korean
        countDigits = count;
        Count = Int32.Parse(count).ToWords(new CultureInfo("ko-KR"));
    }
} 