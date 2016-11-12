using log4net;

namespace Market.Equities
{
    public class Stock
    {
        private static readonly ILog _logger = LogManager.GetLogger(typeof(Stock));

        public decimal Price { get; set; }
    }
}
