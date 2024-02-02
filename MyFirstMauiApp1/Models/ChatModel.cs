namespace MyFirstMauiApp1.Models
{
    public record ChatModel(string whatsapp, string Name, DateTime LastMessageAt, string LastMessage, int UnreadCount)
    {
        public string LastMessageAtDisplay => $"{LastMessageAt:hh:mm}"; 
    }
}
