using System;

namespace BuckeyeStore
{
    public class product

    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string brand { get; set; }
        public review review { get; set; }
        public AggregateException aggregateRating { get; set; }
        public list<offer> offers { get; set; }
        public string sku { get; set; }

    }

    public class list<T>
    {
    }

    public class offer
    {
    }

    public class review
    {
        public int id { get; set; }
        public string body { get; set; }
        public Rating rating { get; set; }

    }

    public class Rating
    {
    }

    public void addreview(review review)
    {
        this.Review = review;
    }
}
