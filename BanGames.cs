using QueryBuilderStarter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder_Lab3
{
    public class BannedGame : IClassModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Series { get; set; }
        public string Country { get; set; }
        public string Details { get; set; }

        public BannedGame(int id, string title, string series, string country, string details)
        {
            Id = id;
            Title = title;
            Series = series;
            Country = country;
            Details = details;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Title}, Series: {Series}, Country: {Country} \nReason: {Details}";
        }

        public BannedGame()
        {
        }
    }
}
