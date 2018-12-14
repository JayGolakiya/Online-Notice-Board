using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewOnlineNoticeBoard.Models
{
    public class AllNotice
    {
        [Key]
        public int ID { get; set; }
        public CE_Notice CEN { get; set; }
        public IT_Notice ITN { get; set; }
        public EC_Notice ECN { get; set; }
        public CH_Notice CHN { get; set; }
        public MH_Notice MHN { get; set; }
        public IC_Notice ICN { get; set; }
    }
}