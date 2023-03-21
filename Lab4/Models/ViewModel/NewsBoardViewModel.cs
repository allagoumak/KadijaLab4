namespace Lab4.Models.ViewModel
{
    public class NewsBoardViewModel
    {
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<NewsBoard> NewsBoards { get; set; }

        public IEnumerable<Subscription> Subscriptions { get; set; }
    }
}
