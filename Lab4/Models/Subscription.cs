using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab4.Models

{
    public class Subscription
    {
        //KA NOTE TO SELF figure out why Subscription table has an extra column named ClientId1
        //client forgeing key
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClientId { get; set; }

        //newsboard fogien key
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string NewsBoardId { get; set; }

        //
        public Client Client { get; set; }
        public NewsBoard NewsBoard { get; set; }

       
    }
}
