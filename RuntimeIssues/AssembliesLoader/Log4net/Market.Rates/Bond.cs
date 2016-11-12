using log4net;

namespace Market.Rates
{
    public class Bond
    {
        private static readonly ILog _logger = LogManager.GetLogger(typeof(Bond));

        decimal Price { get; set; }
        decimal Coupon { get; set; }
    }
}
