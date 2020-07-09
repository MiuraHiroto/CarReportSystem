using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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

            if (cbAuthor.Text == "")
            {
                //メッセージボックスを表示する
                MessageBox.Show("入力してください。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

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
            else if (radioButton3.Checked == true)
            {
                return CarReport.CarMaker.ホンダ;
            }
            else if (radioButton4.Checked == true)
            {
                return CarReport.CarMaker.スバル;
            }
            else if (radioButton5.Checked == true)
            {
                return CarReport.CarMaker.外車;
            }
            else if (radioButton6.Checked == true)
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

        private void btdgvFix_Click(object sender, EventArgs e)
        {
            try
            {
                //変更対象のレコード（オブジェクト）
                CarReport selectedCar = cars[dgvList.CurrentRow.Index];
                selectedCar.Author = cbAuthor.Text;
                selectedCar.Name = cbName.Text;
                selectedCar.Report = TextReport.Text;
                selectedCar.Picture = pbPicture.Image;
                cbAuthor.Text = "";
                cbName.Text = "";
                cbName.Text = "";
                TextReport.Text = "";
                pbPicture.Image = null;
                //データグリッドビューの再描画
                dgvList.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("入力してください。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvList_Click(object sender, EventArgs e)
        {
            CarReport selectedCar = cars[dgvList.CurrentRow.Index];
            textCreatedDate.Value = selectedCar.CreatedDate;
            cbAuthor.Text = selectedCar.Author;
            cbName.Text = selectedCar.Name;
            TextReport.Text = selectedCar.Report;
            pbPicture.Image = selectedCar.Picture;
            switch (selectedCar.Maker)
            {
                case CarReport.CarMaker.DEFAULT:
                    break;
                case CarReport.CarMaker.トヨタ:
                    radioButton1.Checked = true;
                    break;
                case CarReport.CarMaker.日産:
                    radioButton2.Checked = true;
                    break;
                case CarReport.CarMaker.ホンダ:
                    radioButton3.Checked = true;
                    break;
                case CarReport.CarMaker.スバル:
                    radioButton4.Checked = true;
                    break;
                case CarReport.CarMaker.外車:
                    radioButton5.Checked = true;
                    break;
                case CarReport.CarMaker.その他:
                    radioButton6.Checked = true;
                    break;
            }
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
            try
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
            catch (NullReferenceException)
            {
                MessageBox.Show("入力してください。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                //throw;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
        }

        private void btSaveDate_Click(object sender, EventArgs e)
        {
            //セーブファイルダイアログを表示
            if (sfdSaveData.ShowDialog() == DialogResult.OK)
            {

                BinaryFormatter formatter = new BinaryFormatter();

                //ファイルストリームを生成
                using (FileStream fs = new FileStream(sfdSaveData.FileName, FileMode.Create))
                {
                    try
                    {
                        formatter.Serialize(fs, cars);
                    }
                    catch (SerializationException b)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + b.Message);
                        throw;
                    }
                }
            }
        }

        private void btOpenDate_Click(object sender, EventArgs e)
        {
            //オープンファイルダイアログを表示
            if (ofdOpenData.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(ofdOpenData.FileName, FileMode.Open))
                {
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        //逆シリアル化して読み込む
                        cars = (BindingList<CarReport>)formatter.Deserialize(fs);
                        //データグリッドビューに再設定
                        dgvList.DataSource = cars;
                        dgvList_Click(sender, e);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to deserialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }
        } 
    }
}
