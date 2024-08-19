using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;
using ZXing.Windows.Compatibility; //Thư viện đọc barcode và QRCode

namespace Instagram
{
    public partial class scanQR : UserControl
    {
        public string username_tmp;
        public scanQR()
        {
            InitializeComponent();
        }

        private void openCamBtn_MouseEnter(object sender, EventArgs e)
        {
            openBtn.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\openCamBtn_MouseEnter.png");
        }

        private void openCamBtn_MouseLeave(object sender, EventArgs e)
        {
            openBtn.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\openCamBtn.png");
        }

        private void closeCamBtn_MouseEnter(Object sender, EventArgs e)
        {

            closeBtn.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\closeCamBtn_MouseEnter.png");
        }

        private void closeCamBtn_MouseLeave(Object sender, EventArgs e)
        {

            closeBtn.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\closeCamBtn.png");
        }

        FilterInfoCollection filterInfoCollection; //biến lưu thông tin các thiết bị viedo
        VideoCaptureDevice videoCaptureDevice; //Biến tương tác với thiết bí device

        private void openBtn_Click(object sender, EventArgs e)
        {
            //Khởi tạo thiết bị video, dựa trên thiết bị được chọn từ combobox Camera
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbCamera.SelectedIndex].MonikerString);

            // ĐĂNG KÝ NHẬN SỰ KIỆN FRAME MỚI TỪ CAMERA
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //Nhận frame hình ảnh từ camera
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            //BarcodeReader reader = new BarcodeReader();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap); // Đọc QRCode/ Barcode từ hình ảnh
            if (result != null)
            {
                txtUsername.Invoke(new MethodInvoker(delegate ()
                {
                    username_tmp = result.ToString();
                    txtUsername.Text = username_tmp;
                    txtUsername.Visible = true;
                    openProfileBtn.Visible = true;
                }
                ));
            }
            pbQR.Image = bitmap; // Hiển thị frame hình ảnh lên pictureBox
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.SignalToStop();
                    videoCaptureDevice.WaitForStop();
                    pbQR.Image = null;
                }
            }
        }


        private void scanQR_Load_1(object sender, EventArgs e)
        {
            // LẤY DANH SÁCH TẤT CẢ CÁC THIẾT BỊ VIDEO ĐANG ĐƯỢC KẾT NỐI VỚI MÁY TÍNH
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            // THÊM TÊ CỦA MỖI THIẾT BỊ VÀO DROPDOWN CỦA COMBO BOX CAMERA
            foreach (FilterInfo device in filterInfoCollection)
                cbCamera.Items.Add(device.Name);
            cbCamera.SelectedIndex = 0; // CHỌN THIẾT BỊ CÓ CHỈ SỐ ĐẦU TIÊN TRONG DANH SÁCH
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void openProfileBtn_MouseEnter(object sender, EventArgs e)
        {
            openProfileBtn.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\openProfileBtn_MouseEnter.png");
        }

        private void openProfileBtn_MouseLeave(object sender, EventArgs e)
        {
            openProfileBtn.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\openProfileBtn.png");
        }

        private void openProfileBtn_Click(Object sender, EventArgs e)
        {
            if (userProfile.CheckUserValid(username_tmp))
            {
                userProfile.setUser(username_tmp, false);
                userProfile.Visible = true;
            }
            else
            {
                MessageBox.Show("Mã không hợp lệ hoặc người dùng không tồn tại", "Lỗi");

            }
        }
    }
}
