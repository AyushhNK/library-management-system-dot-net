namespace library_management_system_dot_net.Models;

public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int PublishedYear { get; set; }
        public int Amount { get; set; }
        public string Description {get; set;}
        public int Price {get; set;}
    }
