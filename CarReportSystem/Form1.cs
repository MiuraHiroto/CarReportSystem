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
           //dgvList.DataSource = cars;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202001DataSet.CerReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。



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
            if (rbToyota.Checked == true)
            {
                return CarReport.CarMaker.トヨタ;
            }
            else if (rbNissan.Checked == true)
            {
                return CarReport.CarMaker.日産;
            }
            else if (rbHonda.Checked == true)
            {
                return CarReport.CarMaker.ホンダ;
            }
            else if (rbSubaru.Checked == true)
            {
                return CarReport.CarMaker.スバル;
            }
            else if (rbGaisya.Checked == true)
            {
                return CarReport.CarMaker.外車;
            }
            else if (rbSonota.Checked == true)
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
            dgvList.CurrentRow.Cells[2].Value = cbAuthor.Text;

            //データベースの反映
            this.Validate();
            this.cerReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202001DataSet);


            #region 前の処理
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
            #endregion
        }

        private void dgvList_Click(object sender, EventArgs e)
        {
            try
            {
                //選択したレコード（行）のインデックスで指定した項目を取り出す。
                textCreatedDate.Value = (DateTime)dgvList.CurrentRow.Cells[1].Value;
                //編集者
                cbAuthor.Text = dgvList.CurrentRow.Cells[2].Value.ToString();
                       
                cbName.Text = dgvList.CurrentRow.Cells[4].Value.ToString();
                TextReport.Text = dgvList.CurrentRow.Cells[5].Value.ToString();
                pbPicture.Image = ByteArrayToImage((byte[])dgvList.CurrentRow.Cells[6].Value);

               
                
            }
            catch(InvalidCastException)//画像がDBに登録されてない時
            {
                pbPicture.Image = null;
            }
            catch(Exception ex)//上記以外のデータを全て拾う
            {
                MessageBox.Show(ex.Message);
            }
            var Maker = dgvList.CurrentRow.Cells[3].Value.ToString();
            switch (Maker)
            {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "外車":
                    rbGaisya.Checked = true;
                    break;
                case "その他":
                    rbSonota.Checked = true;
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
            #region 前回の処理
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
            #endregion

            
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
            #region 前回の処理
            //オープンファイルダイアログを表示
            /*if (ofdOpenData.ShowDialog() == DialogResult.OK)
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
            }*/
            #endregion
        }

        private void btOpenDate_Click_1(object sender, EventArgs e)
        {
            this.cerReportTableAdapter.Fill(this.infosys202001DataSet.CerReport);

        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] byteData)
        {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(byteData);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] byteData = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return byteData;
        }

        private void btSearchExe_Click(object sender, EventArgs e)
        {
            this.cerReportTableAdapter.FillByCarName(this.infosys202001DataSet.CerReport, tbSearchCarName.Text);
            this.cerReportTableAdapter.FillByAndSearchButton(this.infosys202001DataSet.CerReport, tbSearchCarDateTime.Text, tbSearchCarMaker.Text, tbSearchCarName.Text);
            this.cerReportTableAdapter.FillByOrSearchButton(this.infosys202001DataSet.CerReport, tbSearchCarDateTime.Text, tbSearchCarAuthor.Text, tbSearchCarMaker.Text, tbSearchCarName.Text);
            //ラジオボタン処理
            if (rbAND.Checked == true)
            {
                this.cerReportTableAdapter.FillByAndSearchButton
                    (infosys202001DataSet.CerReport, tbSearchCarDateTime.Text, tbSearchCarMaker.Text, tbSearchCarName.Text);
            }
            else if (rbOR.Checked == true)
            {
                this.cerReportTableAdapter.FillByOrSearchButton
                    (infosys202001DataSet.CerReport, tbSearchCarDateTime.Text, tbSearchCarAuthor.Text, tbSearchCarMaker.Text, tbSearchCarName.Text);
            }


        }
    }
}
