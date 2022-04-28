using HarshaBank.Entities.Contracts;
using HarshaBank.Exceptions;
namespace HarshaBank.Entities
{
    /// <summary>
    /// Represents a customer of the bank 
    /// </summary>
    public class Customer : ICustomer, ICloneable
    {
        #region Private fields
        private Guid _customerID;
        private long _customerCode;
        private string ?_customerName;
        private string ?_address;
        private string ?_landmark;
        private string ?_city;
        private string ?_country;
        private string ?_mobile;
        #endregion

        #region Public Properties

        /// <summary>
        /// Guid of Customer for Unique Identification
        /// </summary>
        public Guid CustomerID { get => _customerID; set => _customerID = value; }

        /// <summary>
        /// Auto-generated code number of customer
        /// </summary>
        public long CustomerCode
        {
            get => _customerCode;
            set
            {
                // customer code should be positive
                if (value > 0)
                {
                    _customerCode = value;
                }
                else
                {
                    throw new CustomerException("Customer code should be positive only");
                }
            }
        }

        /// <summary>
        /// Name of the Customer
        /// </summary>
        public string? CustomerName
        {
            get => _customerName;
            set
            {
                // customer name should be less than 40 characters
                if (value.Length < 40 && string.IsNullOrEmpty(value) == false)
                {
                    _customerName = value;
                }
                else
                {
                    throw new CustomerException("Customer Name should not be null or less than 40 characters");
                }
            }
        }

        /// <summary>
        /// Address of the Customer
        /// </summary>
        public string? Address { get => _address; set => _address = value; }

        /// <summary>
        /// Landmark of the Customer's address
        /// </summary>
        public string? Landmark { get => _landmark; set => _landmark = value; }

        /// <summary>
        /// City of the Customer
        /// </summary>
        public string? City { get => _city; set => _city = value; }

        /// <summary>
        /// Country of the Customer
        /// </summary>
        public string? Country { get => _country; set => _country = value; }

        /// <summary>
        /// 10-digit Mobile number of the customer
        /// </summary>
        public string? Mobile
        { 
            // mobile number should be 10 digit mobile number
            get => _mobile;
            set
            {
                if (value.Length == 10)
                {
                    _mobile = value;
                }
                else
                {
                    throw new CustomerException("Mobile number should be 10-digit number");
                }
            }
        }
        #endregion

        #region Methods
        public object Clone()
        {
            return new Customer() { CustomerID = this.CustomerID, CustomerCode = this.CustomerCode,
                CustomerName = this.CustomerName, Address = this.Address, Landmark = this.Landmark,
                City = this.City, Country = this.Country, Mobile = this.Mobile}; 
        }
        #endregion
    }
}
