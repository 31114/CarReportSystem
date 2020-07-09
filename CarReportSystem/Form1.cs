using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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

            //コンボボックスのリストに追加
            setComboBoxMaker(cbTitle.Text, cbAuthor.Text);

            //新規登録したときに、コンボボックスのテキストを削除
            dtpDate.Value = DateTime.Now;
            cbAuthor.Text = null;
            cbTitle.Text = null;
            rtbReport.Text = null;
            pbImage.Image = null;

        }
        //コンボボックスのリスト処理
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
        //ラジオボタンの判定
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
                try
                {
                    //選択した画像をPictureBoxに表示
                    pbImage.Image = Image.FromFile(ofdOpenImage.FileName);
                    pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

                    btImageDelete.Enabled = true;
                }
                catch(Exception)
                {
                    PopupMessage(3);
                }
            }
        }

        private void btImageDelete_Click(object sender, EventArgs e)
        {
            pbImage.Image = null;
        }
        //C H A N G E
        private void btObama_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                PopupMessage(1);
            }
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

        private void btListSave_Click(object sender, EventArgs e)
        {
            if (sfdSave.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(sfdSave.FileName, FileMode.Create))
                {
                    try
                    {
                        formatter.Serialize(fs, Collection);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to serialize.Reason" + se.Message);
                        throw;
                    }
                }
            }
        }

        private void btListOpen_Click(object sender, EventArgs e)
        {
            if (ofdOpenData.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(ofdOpenData.FileName, FileMode.Open))
                {
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();

                        Collection = (BindingList<Vinyl>)formatter.Deserialize(fs);

                        dgvList.DataSource = Collection;
                        dgvList_Click(sender, e);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to Deserialize.Reason" + se.Message);
                        throw;
                    }
                }
            }
        }
        //DataGridViewで選択したものを入力に表示
        private void dgvList_Click(object sender, EventArgs e)
        {
            try
            {
                Vinyl selectedCar = Collection[dgvList.CurrentRow.Index];

                cbTitle.Text = Collection[dgvList.CurrentRow.Index].Title;
                cbAuthor.Text = Collection[dgvList.CurrentRow.Index].Author;
                rtbReport.Text = Collection[dgvList.CurrentRow.Index].Report;
                dtpDate.Value = Collection[dgvList.CurrentRow.Index].CreatedDate;
                pbImage.Image = Collection[dgvList.CurrentRow.Index].Picture;
                //if(Collection[dgvList.CurrentRow.Index].Label == ) { }
            }
            catch (Exception)
            {
                PopupMessage(1);
            }
        }
        //エラーメッセージ
        private void PopupMessage(int Num)
        {
            switch (Num)
            {
                case 1:
                    {

                        MessageBox.Show("Can't Touch This", "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("不完全な文字列", "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show("不完全なファイル", "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        break;
                    }
            }
        }
    }
}
