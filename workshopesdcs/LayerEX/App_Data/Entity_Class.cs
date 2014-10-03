using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LayerEX.App_Data
{
    class Entity_Class
    {
    }

    class Movie
    {
        int videocode, totalstock, numberrented;

        public int Numberrented
        {
            get { return numberrented; }
            set { numberrented = value; }
        }

        public int Totalstock
        {
            get { return totalstock; }
            set { totalstock = value; }
        }

        public int Videocode
        {
            get { return videocode; }
            set { videocode = value; }
        }
        string movietitle, movietype, rating, producer, director, media;

        public string Media
        {
            get { return media; }
            set { media = value; }
        }

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        public string Producer
        {
            get { return producer; }
            set { producer = value; }
        }

        public string Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public string Movietype
        {
            get { return movietype; }
            set { movietype = value; }
        }

        public string Movietitle
        {
            get { return movietitle; }
            set { movietitle = value; }
        }
        double rentalprice;

        public double Rentalprice
        {
            get { return rentalprice; }
            set { rentalprice = value; }
        }
    }

    class Customer
    {
        string customerid, customername, membercategory, address, postalcode, phonenumber, countrycode;

        public string Countrycode
        {
            get { return countrycode; }
            set { countrycode = value; }
        }

        public string Phonenumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }

        public string Postalcode
        {
            get { return postalcode; }
            set { postalcode = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Membercategory
        {
            get { return membercategory; }
            set { membercategory = value; }
        }

        public string Customername
        {
            get { return customername; }
            set { customername = value; }
        }

        public string Customerid
        {
            get { return customerid; }
            set { customerid = value; }
        }

    }

    class IssueTran
    {
        int videocode;

        public int Videocode
        {
            get { return videocode; }
            set { videocode = value; }
        }
        string customerid, rentalstatus, remarks;

        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }

        public string Rentalstatus
        {
            get { return rentalstatus; }
            set { rentalstatus = value; }
        }

        public string Customerid
        {
            get { return customerid; }
            set { customerid = value; }
        }
        DateTime dateissue, datedue, dateactualreturn;

        public DateTime Dateactualreturn
        {
            get { return dateactualreturn; }
            set { dateactualreturn = value; }
        }

        public DateTime Datedue
        {
            get { return datedue; }
            set { datedue = value; }
        }

        public DateTime Dateissue
        {
            get { return dateissue; }
            set { dateissue = value; }
        }
    }
}
