namespace signalRD1Smart.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Sender{ get; set; }
        public string Content { get; set; }
        public DateTime DateTime { get; set; }= DateTime.Now;

    }
}
