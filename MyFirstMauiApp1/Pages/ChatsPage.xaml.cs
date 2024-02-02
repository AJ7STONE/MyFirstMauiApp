using MyFirstMauiApp1.Models;
using System.Collections.ObjectModel;

namespace MyFirstMauiApp1.Pages;

public partial class ChatsPage : ContentPage
{

	ObservableCollection<ChatModel> Chats;

    public ChatsPage() => InitializeComponent();

}