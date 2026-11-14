using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ZMotionTest.Models;

/// <summary>
/// IO address, live state and optional output command displayed by the IO page.
/// </summary>
public class DataStatusModel<TAddress> : ObservableObject
{
    private string _name = string.Empty;
    private TAddress _address = default!;
    private bool _status;
    private bool _visibility;
    private ICommand? _command;

    public string Name
    {
        get => _name;
        set => SetProperty(ref _name, value);
    }

    public TAddress Address
    {
        get => _address;
        set => SetProperty(ref _address, value);
    }

    public bool Status
    {
        get => _status;
        set => SetProperty(ref _status, value);
    }

    /// <summary>Whether the output command button is shown.</summary>
    public bool Visibility
    {
        get => _visibility;
        set => SetProperty(ref _visibility, value);
    }

    public ICommand? Command
    {
        get => _command;
        set => SetProperty(ref _command, value);
    }
}
