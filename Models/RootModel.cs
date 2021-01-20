namespace DevOpsPortal.Models
{
    public class RootModel
    {
        public RootModel()
        {
            Status = "Hello!";
        }

        public string Status { get; set; }

        public override string ToString()
        {
            return Status;
        }
    }
}
