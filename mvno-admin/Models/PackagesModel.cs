using System.Web.Security;
using Telerik.SvgIcons;

namespace mvno_admin.Models
{
    public class Packages
    {
        public Packages(long packageId, string packageDescription, string currentStateType, long orderCount, string provider, string author, string revisionDatetime, string ivrDescription)
        {
            this.packageId = packageId;
            this.packageDescription = packageDescription;
            this.currentStateType = currentStateType;
            this.orderCount = orderCount;
            this.provider = provider;
            this.author = author;
            this.revisionDatetime = revisionDatetime;
            this.ivrDescription = ivrDescription;
        }
        public long packageId { get; set; }
        public string packageDescription { get; set; }
        public string currentStateType { get; set; }
        public long orderCount { get; set; }
        public string provider { get; set; }
        public string author { get; set; }
        public string revisionDatetime { get; set; }
        public string ivrDescription { get; set; }
    }
}