using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexwork_Tracker {
    public class FlexWork : IEquatable<FlexWork>{
        public string Requestor { get; set; }
        public double Hours { get; set; }
        public string Date { get; set; }
        public string Details { get; set; }
        public string Ticket { get; set; }
        public string Category { get; set; }
        public string Site { get; set; }
        public string Comments { get; set; }
        public string Technician { get; set; }

        public FlexWork() {
            Requestor = "";
            Hours = 0.0;
            Date = "";
            Details = "";
            Ticket = "";
            Category = "";
            Site = "";
            Comments = "";
            Technician = "";
        }

        // the logic required to be able to compare CSATs to each other
        public override bool Equals(Object obj) {
            if (obj == null) {
                return false;
            }
            FlexWork objAsCSAT = obj as FlexWork;
            if (objAsCSAT == null) {
                return false;
            } else {
                return Equals(objAsCSAT);
            }
        }

        public override int GetHashCode() {
            return (Requestor + Details + Ticket).GetHashCode();
        }

        public bool Equals(FlexWork other) {
            if (other == null) {
                return false;
            }
            return (this.Requestor.Equals(other.Requestor) && 
                    this.Date.Equals(other.Date) &&
                    this.Details.Equals(other.Details) &&
                    this.Category.Equals(other.Category) &&
                    this.Site.Equals(other.Site)
                    );
        }

        public static bool operator ==(FlexWork lhs, FlexWork rhs) {
            if (object.ReferenceEquals(lhs, null)) {
                return object.ReferenceEquals(rhs, null);
            }
            return lhs.Equals(rhs);
        }

        public static bool operator !=(FlexWork lhs, FlexWork rhs) {
            if (object.ReferenceEquals(lhs, null)) {
                return object.ReferenceEquals(rhs, null);
            }
            return !(lhs.Equals(rhs));
        }
    }
}
