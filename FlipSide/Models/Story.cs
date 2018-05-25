using System;
using System.ComponentModel.DataAnnotations;

namespace FlipSide.Models
{
    public class Story
    {
        public int ID { get; set; }
        [DataType(DataType.Date)]
        public DateTime dateRan { get; set; }
        public string slug { get; set; }
        public string summary { get; set; }
        public string link { get; set; }
        public string byline { get; set; }
        public int lean { get; set; }
        public int is_active { get; set; }
        public string topic { get; set; }
    }
}


//SELECT TOP(1000) [id]
//      ,[dateRan]
//      ,[slug]
//      ,[summary]
//      ,[byline]
//      ,[lean]
//FROM[FlipSide].[dbo].[story] 