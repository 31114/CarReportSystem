using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {
        BindingList<Vinyl> Collection = new BindingList<Vinyl>();
        public Form1()
        {
            InitializeComponent();
            dgvList.DataSource = Collection;
        }

        private void btListAdd_Click(object sender, EventArgs e)
        {
            Vinyl obj = new Vinyl
            {
                Title = cbTitle.Text,
                Author = cbAuthor.Text,
                Label = RadioDetection(),
                Report = rtbReport.Text,
                CreatedDate = dtpDate.Value,
                Picture = pbImage.Image
            };
            Collection.Insert(0, obj);

            dtpDate.Value = DateTime.Now;
            cbAuthor.Text = null;
            cbTitle.Text = null;
            rtbReport.Text = null;
            pbImage.Image = null;

            setComboBoxMaker(cbTitle.Text, cbAuthor.Text);
        }
        private void setComboBoxMaker(string title, string author)
        {
            if (!cbTitle.Items.Contains(title))
            {
                cbTitle.Items.Add(title);
            }

            if (!cbAuthor.Items.Contains(author))
            {
                cbAuthor.Items.Add(author);
            }
        }
        private VinylLabel RadioDetection()
        {
            if (rbSony.Checked)
            {
                return VinylLabel.SONY;
            }
            else if (rbToshiba.Checked)
            {
                return VinylLabel.東芝EMI;
            }
            else if (rbEpic.Checked)
            {
                return VinylLabel.EPIC;
            }
            else if (rbCasablanca.Checked)
            {
                return VinylLabel.Casablanca;
            }
            else if(rbIsland.Checked)
            {
                return VinylLabel.Island;
            }
            else if(rbOther.Checked)
            {
                return VinylLabel.その他;
            }
            return default;
        }

        private void btImageOpen_Click(object sender, EventArgs e)
        {

            if (ofdOpenImage.ShowDialog() == DialogResult.OK)
            {
                //選択した画像をPictureBoxに表示
                pbImage.Image = Image.FromFile(ofdOpenImage.FileName);
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

                btImageDelete.Enabled = true;
            }
        }

        private void btImageDelete_Click(object sender, EventArgs e)
        {
            pbImage.Image = null;
        }

        private void btObama_Click(object sender, EventArgs e)
        {
            Vinyl selectedCar = Collection[dgvList.CurrentRow.Index];

            Collection[dgvList.CurrentRow.Index].Title = cbTitle.Text;
            Collection[dgvList.CurrentRow.Index].Author = cbAuthor.Text;
            Collection[dgvList.CurrentRow.Index].Report = rtbReport.Text;
            Collection[dgvList.CurrentRow.Index].Picture = pbImage.Image;
            Collection[dgvList.CurrentRow.Index].CreatedDate = dtpDate.Value;
            Collection[dgvList.CurrentRow.Index].Label = RadioDetection();

            dgvList.Refresh();

        }

        private void btListDelete_Click(object sender, EventArgs e)
        {
            if(Collection.Count == 0)
            {

            }
            else
            {
                Vinyl selectedCar = Collection[dgvList.CurrentRow.Index];

                Collection.Remove(Collection[dgvList.CurrentRow.Index]);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
