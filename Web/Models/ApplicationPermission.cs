namespace Web.Models {
    public class ApplicationPermission {
        public int ApplicationPermissionID { get; set; }
        public Application Application { get; set; }
        public string Permission { get; set; }
    }
}