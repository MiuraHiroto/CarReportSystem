using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {
        BindingList<CarReport> cars = new BindingList<CarReport>();
        public Form1()
        {
            InitializeComponent();
            dgvList.DataSource = cars;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        //データの追加
        private void btdgvAddition_Click(object sender, EventArgs e)
        {
            CarReport carReport = new CarReport()
            {
                CreatedDate = textCreatedDate.Value,
                Author = cbAuthor.Text,
                Maker = RadioButtonsaiko(),
                Name = cbName.Text,
                Report = TextReport.Text,
                Picture = pbPicture.Image,

            };

            //BindingListへ登録
            cars.Insert(0, carReport);

            //次の入力に備えて各項目をクリア
            inputItemAllClear();

            //ボタン　マスクの読み込み
            //itButon();

        }

        private CarReport.CarMaker RadioButtonsaiko()
        {
            if (radioButton1.Checked == true)
            {
                return CarReport.CarMaker.トヨタ;
            }
            else if (radioButton2.Checked == true)
            {
                return CarReport.CarMaker.日産;
            }
            else if (radioButton2.Checked == true)
            {
                return CarReport.CarMaker.ホンダ;
            }
            else if (radioButton2.Checked == true)
            {
                return CarReport.CarMaker.スバル;
            }
            else if (radioButton2.Checked == true)
            {
                return CarReport.CarMaker.外車;
            }
            else if (radioButton2.Checked == true)
            {
                return CarReport.CarMaker.その他;
            }
            else
            {
                return CarReport.CarMaker.DEFAULT;
            }

        }
        
        //クリア
        private void inputItemAllClear()
        {
            //textCreatedDate.Value = "";
             cbAuthor.Text = "";
             
             cbName.Text = "";
             TextReport.Text = "";
             pbPicture.Image = null;


        }

        private void dgvList_Click(object sender, EventArgs e)
        {

            CarReport selectedCar = cars[dgvList.CurrentRow.Index];
            textCreatedDate.Value = selectedCar.CreatedDate;
            cbAuthor.Text = selectedCar.Author;
            //Maker = selectedCar.Maker;
            cbName.Text = selectedCar.Name;
            TextReport.Text = selectedCar.Report;
            pbPicture.Image = selectedCar.Picture;

        }

        private void pbbtOpen_Click(object sender, EventArgs e)
        {
           if (ofdImageOpen.ShowDialog() == DialogResult.OK)
            {
                //選択した画像をピクチャーボックスに表示
                pbPicture.Image = Image.FromFile(ofdImageOpen.FileName);
                //ピクチャーボックスのサイズに画像を調節
                pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        //画像を削除
        private void pbbtDelete_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
        }
        //終了
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btdgvDelete_Click(object sender, EventArgs e)
        {
            CarReport selectedCar = cars[dgvList.CurrentRow.Index];
            //selectedCar.CreatedDate = null;
            selectedCar.Author = "";
            //selectedCar.Maker = null;
            selectedCar.Name = "";
            selectedCar.Report = "";
            selectedCar.Picture = null;
            cbAuthor.Text = "";

            cbName.Text = "";
            TextReport.Text = "";
            pbPicture.Image = null;
            cars.RemoveAt(dgvList.CurrentRow.Index);
            //データグリッドビューの再描画
            dgvList.Refresh();
            
        }
    }
}
