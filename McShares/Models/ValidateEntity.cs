using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace McShares.Models
{
    public class ValidateEntity
    {
        public static string ValidateShareEntity(RequestDoc requestDoc)
        {
            string error = string.Empty;
            try
            {
                foreach (var item in requestDoc.Doc_Data.DataItem_Customers)
                {
                    if (item.Customer_Type.Equals("Individual"))
                    {
                        if (string.IsNullOrEmpty(item.Date_Of_Birth))
                        {
                            error = "Empty Date Of Birth";
                        }
                        else
                        {
                            DateTime bday = DateTime.ParseExact(item.Date_Of_Birth, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            DateTime today = DateTime.Today;
                            int age = today.Year - bday.Year;
                            if (age < 18)
                            {
                                error = "Customer must be at least 18 years old!";
                            }
                        }                        
                    }

                    int num_shares;
                    bool num_shares_parsedSuccessfully = int.TryParse(item.Shares_Details.Num_Shares, out num_shares);

                    if (!num_shares_parsedSuccessfully || num_shares <= 0)
                    {
                        error = "Number of shares must be an integer and greater than 0!";
                    }

                    decimal share_price;
                    bool share_price_parsedSuccessfully = decimal.TryParse(item.Shares_Details.Share_Price, out share_price);

                    if (!share_price_parsedSuccessfully || share_price <= 0 || Decimal.Round(share_price, 2) != share_price)
                    {
                        error = "Share_Price must be a number greater than 0 up to two decimal places";
                    }
                }

                using (McShareModel mcShareModel = new McShareModel())
                {
                    Error dbError = new Error() { DateOccurred = DateTime.Today, Message = error };
                    mcShareModel.Errors.Add(dbError);
                    mcShareModel.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return error;
        }
    }
}