namespace OF_DL.Entities.Chats
{
    public class Chats
    {
        public List<Chat> list { get; set; }
        public bool hasMore { get; set; }
        public int nextOffset { get; set; }

        public class Chat
        {
            public User withUser { get; set; }
            public int unreadMessagesCount { get; set; }
        }

        public class User
        {
            public int id { get; set; }
        }
    }
}
