/*************************************
PROJECT NAME        : DevExpress 
PROJECT INFORMATION : Using Camera Control  
CREATE DATE         : 2021-09-24
WRITER              : J 
MODIFIER            : 
MODIFY DATE         : 
**************************************/
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

using OpenCvSharp;
using OpenCvSharp.Extensions;

using DevExpress.Data.Camera;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Camera;
using DevExpress.XtraEditors.Controls;

using ZXing;
using ZXing.Common;

namespace Dev014
{
    public partial class Form : DevExpress.XtraEditors.XtraForm
    {
        private List<CameraDeviceInfo> _listDeviceInfo;
        private List<string> _listCamera;
        private CameraDeviceInfo _info;
        private Task _taskCheckQR;
        private Mat _mCapture;
        private CancellationTokenSource _cancelTokenSource;
        private CancellationToken _qrDecodeToken;

        private bool _bDecodeFinish = false;


        public Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form load event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Load(object sender, EventArgs e)
        {
            _listCamera = new List<string>();
            _listDeviceInfo = CameraControl.GetDevices();

            if (_listDeviceInfo != null && _listDeviceInfo.Count > 0)
            {
                foreach (CameraDeviceInfo deviceInfo in _listDeviceInfo)
                {
                    CameraDevice device = CameraControl.GetDevice(deviceInfo);

                    ImageComboBoxItem item = new ImageComboBoxItem();
                    
                    _listCamera.Add(device.Name);
                }
            }
        }

        /// <summary>
        /// Form closing event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (_taskCheckQR != null && _taskCheckQR.Status == TaskStatus.Running)
                {
                    LF_QRDecodeCheck_Stop();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.StackTrace);

            }
        }

        /// <summary>
        /// Button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Cllick(object sender, EventArgs e)
        {
            switch (((SimpleButton)sender).Name)
            {
                case "btnCamera":
                    MessageBox.Show("Login");
                    LF_QRDecodeCheck_Stop();
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Radio button change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LF_Radio_CameraChange(object sender, EventArgs e)
        {
            try
            {
                string sName = string.Empty;

                if (radioGroup.SelectedIndex == 1)
                {
                    cameraControl1.Visible = true;
                    imageComboBoxEdit1.Visible = true;

                    _info = CameraControl.GetDevices().Find(X => X.Name.Contains(_listCamera[0]));
                    _cancelTokenSource = new CancellationTokenSource();
                    _qrDecodeToken = new CancellationToken();
                    _qrDecodeToken = _cancelTokenSource.Token;
                    cameraControl1.Start(CameraControl.GetDevice(_info));

                    _taskCheckQR = new Task(() => LF_QRDecodeCheck(_qrDecodeToken));
                    _taskCheckQR.Start();
                }
                else
                {
                    cameraControl1.Visible = false;
                    imageComboBoxEdit1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// ComboBox index change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LF_CameraIndex_Change(object sender, EventArgs e)
        {
            //Microsoft Camera Front 
            //Microsoft Camera Rear 
            try
            {
                if (imageComboBoxEdit1.SelectedIndex == 0)
                {
                    _info = CameraControl.GetDevices().Find(X => X.Name.Contains(imageComboBoxEdit1.SelectedText));
                }
                else 
                {
                    _info = CameraControl.GetDevices().Find(X => X.Name.Contains(imageComboBoxEdit1.SelectedText));
                }
                cameraControl1.Start(CameraControl.GetDevice(_info));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Changed toggle switch event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LF_Camera_Change_Toggle(object sender, EventArgs e)
        {
            try
            {
                if (toggleSwitch1.EditValue.ToString() == "True")
                {
                    _info = CameraControl.GetDevices().Find(X => X.Name.Contains(_listCamera[1]));
                }
                else
                {
                    _info = CameraControl.GetDevices().Find(X => X.Name.Contains(_listCamera[0]));
                }
                cameraControl1.Start(CameraControl.GetDevice(_info));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Check QRDecode event 
        /// </summary>
        /// <param name="p_Token"></param>
        private void LF_QRDecodeCheck(CancellationToken p_Token)
        {
            bool bDecodeCheck = false;
            try
            {
                p_Token.ThrowIfCancellationRequested();

                while (_bDecodeFinish == false)
                {
                    Bitmap bitmap = cameraControl1.TakeSnapshot();
                    _mCapture = OpenCvSharp.Extensions.BitmapConverter.ToMat(bitmap);
                    QRCodeDetector decoder = new QRCodeDetector();
                    Point2f[] point;
                    bDecodeCheck = decoder.Detect(_mCapture, out point);
                    Console.WriteLine(bDecodeCheck);

                    if (p_Token.IsCancellationRequested)
                    {
                        return;
                    }
                    if (bDecodeCheck)
                    {
                        LF_QRDecode(_mCapture);
                    }
                }
            }
            catch (AccessViolationException access)
            {
                Console.WriteLine(access.StackTrace);
                Console.WriteLine(access.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// QRDecode event
        /// </summary>
        /// <param name="p_bitmap"></param>
        private void LF_QRDecode(Mat p_bitmap)
        {
            try
            {
                LuminanceSource source;
                source = new BitmapLuminanceSource(BitmapConverter.ToBitmap(p_bitmap));
                BinaryBitmap binaryBitmap = new BinaryBitmap(new HybridBinarizer(source));
                string sSeparator = "\n";
                Result result = new MultiFormatReader().decode(binaryBitmap);
                if (result != null)
                {
                    string sDecode = result.ToString();
                    int iIndex = sDecode.IndexOf(sSeparator);
                    string sId = sDecode.Substring(0, iIndex);
                    string sPwd = sDecode.Substring(iIndex + 1);
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        txtID.Text = sId;
                        txtPwd.Text = sPwd;
                        btnCamera.PerformClick();
                    }));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Stop QRDecode 
        /// </summary>
        private void LF_QRDecodeCheck_Stop()
        {
            try
            {
                if (_taskCheckQR != null && _taskCheckQR.Status == TaskStatus.Running)
                {
                    _cancelTokenSource.Cancel();
                    cameraControl1.Visible = false;
                    toggleSwitch1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }
    }
}