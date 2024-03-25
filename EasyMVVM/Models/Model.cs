using System.Collections.ObjectModel;

namespace EasyMVVM.Models;

public class Model
{
    public ObservableCollection<string> Data { get; set; } = new ObservableCollection<string>();
    public ObservableCollection<string> GetData()
    {
        this.Data.Add("First Entry");
        this.Data.Add("Second Entry");
        this.Data.Add("Third Entry");
        return this.Data;
    }
}
