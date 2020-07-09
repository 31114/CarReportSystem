using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem
{
    [Serializable]
    public enum VinylLabel
    {
        DEFAULT,
        SONY,
        東芝EMI,
        EPIC,
        Casablanca,
        Island,
        その他
    }
    class Vinyl
    {
        
        public string Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public VinylLabel Label { get; set; }
        public string Title { get; set; }
        public string Report { get; set; }
        public Image Picture { get; set; }


    }
}
