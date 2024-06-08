namespace USRInfo.Models
{
    public class Status
    {
        public int id { get; set; }
        public string requestReference { get; set; }
        public string customerReference { get; set; }
        public DateTime timeStamp { get; set; }
        public string requestType { get; set; }
        public string status { get; set; }
    }
}
