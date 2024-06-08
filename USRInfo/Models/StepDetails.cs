namespace USRInfo.Models
{
    public class StepDetails
    {
        public string id { get; set; }
        public DateTime created { get; set; }
        public DateTime executed { get; set; }
        public int index { get; set; }
        public string stepStatus { get; set; }
        public bool isSupport { get; set; }
        public string description { get; set; }
        public bool requireSupportInput { get; set; }
        public string requestInfo { get; set; }
        public string responseInfo { get; set; }
        public object ackResponseInfo { get; set; }
        public bool isCancellable { get; set; }
    }
}
