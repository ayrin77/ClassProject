using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace BookRentalComp586.Models
{
    public class IndividualButtonPartial
    {
        public string ButtonType { get; set; }
        public string Action { get; set; }
        public string Glyph { get; set; }
        public string Text { get; set; }

        public int? GenreID { get; set; }
        public int? BookID { get; set; }
        public int? CustomerID { get; set; }
        public int? MembershipTypeID { get; set; }
        public string UserId { get; set; }
        public int? BookRentalId { get; set; }


        public string ActionParameter
        {
            get
            {
                var param = new StringBuilder(@"/");
                if (BookID != null && BookID > 0)
                {
                    param.Append(String.Format("{0}", BookID));
                }//if BookID

                if (GenreID != null && GenreID > 0)
                {
                    param.Append(String.Format("{0}", GenreID));
                }//if GenreID

                if (CustomerID != null && CustomerID > 0)
                {
                    param.Append(String.Format("{0}", CustomerID));
                }//if CustomerID

                if (MembershipTypeID != null && MembershipTypeID > 0)
                {
                    param.Append(String.Format("{0}", MembershipTypeID));
                }//if MembershipTypeID

                if (BookRentalId != null && BookRentalId > 0)
                {
                    param.Append(String.Format("{0}", BookRentalId));
                }//if BookRentalID

                if (UserId != null && UserId.Trim().Length > 0)
                {
                    param.Append(String.Format("{0}", UserId));
                }//if UserId

                return param.ToString();
            }//get
        }
    }
}