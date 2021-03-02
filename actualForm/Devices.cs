namespace actualForm
{
    public class Devices
    {
        public Devices()
        {
            if(remark == null)
            {
                remark = "-";
                return;
            }
            
        }
        public string name { get; set; }

        public string type { get; set; }
        public string status { get; set; }
        public string remark { get; set; }


    }
}