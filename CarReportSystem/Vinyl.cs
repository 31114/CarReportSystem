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
    [Serializable]
    class Vinyl
    {
        [System.ComponentModel.DisplayName("歌手")]
        public string Author { get; set; }
        [System.ComponentModel.DisplayName("発売日")]
        public DateTime CreatedDate { get; set; }
        [System.ComponentModel.DisplayName("レーベル")]
        public VinylLabel Label { get; set; }
        [System.ComponentModel.DisplayName("タイトル")]
        public string Title { get; set; }
        public string Report { get; set; }
        [System.ComponentModel.DisplayName("カバー")]
        public Image Picture { get; set; }


    }
}
