namespace Lab4.Models
{
    public class Subscription
    {
        //KA NOTE TO SELF figure out why Subscription table has an extra column named ClientId1
        //client forgeing key
        public int ClientId { get; set; }

        //newsboard fogien key
        public string NewsBoardId { get; set; }

        //
        public Client Client { get; set; }
        public NewsBoard NewsBoard { get; set; }
    }
}
