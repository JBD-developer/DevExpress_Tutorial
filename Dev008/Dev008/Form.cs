using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

using ZXing;
using ZXing.Common;
using OpenCvSharp;
using OpenCvSharp.Extensions;

using DevExpress.XtraEditors;

namespace Dev008
{
    public partial class Form : XtraForm
    {
        private VideoCapture _video;
        private Mat _mFrame = new Mat();
        private Mat _mView = new Mat();
        private HttpClient _httpclient = new HttpClient();

        private bool _bisServer = false;
        private bool _bisPower = false;
        private bool _bisFrame = false;

        private Bitmap _bitmap;
        private string _sCameraAddr = string.Empty;

        private Task _taskFrame = null;

        private NetworkStream _CameraStream;
        private NetworkStream _RfidStream;
        private TcpClient _CameraClient;
        private TcpClient _RfidClient;

        private TcpListener _listener;

        private CancellationTokenSource _serverCanceltoken = null;
        private CancellationTokenSource _powerCanceltoken = null;
        private CancellationTokenSource _frameCanceltoken = null;

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
            _video = new VideoCapture();
        }

        /// <summary>
        /// Form closed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Closed(object sender, FormClosedEventArgs e)
        {

        }

        /// <summary>
        /// Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            switch (((SimpleButton)sender).Name)
            {
                case "btnStart":
                    #region Start

                    LF_RFIDServerOpen();

                    #endregion
                    break;

                case "btnStop":
                    #region Stop

                    LF_RFIDServerOpen();

                    #endregion
                    break;

                case "btnOn":

                    #region Camera Power ON

                    LF_CameraPowerOn();

                    #endregion
                    break;
                case "btnOff":
                    #region Camera Power OFF

                    LF_CameraPowerOff();

                    #endregion

                    break;
                case "btnLoad":

                    #region Frame Load

                    LF_FrameLoad();

                    btnLoad.Enabled = false;
                    btnUnload.Enabled = true;

                    #endregion

                    break;
                case "btnUnload":

                    #region Frame UnLoad

                    LF_FrameLoad();

                    btnLoad.Enabled = true;
                    btnUnload.Enabled = false;

                    #endregion

                    break;
                case "btnCapture":

                    #region Captuure

                    LF_ImageCapture();

                    #endregion

                    break;
                default:
                    break;
            }
        }

        /// <summary>
        ///  RFID server connection request event 
        /// </summary>
        private async void LF_RFIDServerOpen()
        {
            _serverCanceltoken = new CancellationTokenSource();
            CancellationToken serverToken = _serverCanceltoken.Token;
            try
            {
                if (!_bisServer)
                {
                    var taskServer = Task.Factory.StartNew<object>(LF_RFIDServerRun, serverToken);
                    dynamic serverCheck = await taskServer;

                    if (serverCheck == null)
                    {
                        btnStart.Enabled = false;
                        btnStop.Enabled = true;
                        btnOff.Enabled = true;
                        btnUnload.Enabled = true;
                        btnCapture.Enabled = true;
                    }
                    else
                    {
                    }
                }
                else
                {
                    _serverCanceltoken.Cancel();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        /// <summary>
        /// Run RFID server event
        /// </summary>
        private object LF_RFIDServerRun()
        {
            if (_serverCanceltoken.Token.IsCancellationRequested)
            {
                return null;
            }
            else
            {
                byte[] arrBuff = new byte[512];
                string[] arrResult;
                int bytes = 0;
                string sRFIDAddr = txtRFID.Text;
                int iPort = int.Parse(txtPort.Text);

                _RfidClient = new TcpClient(sRFIDAddr, iPort);
                _RfidStream = _RfidClient.GetStream();

                bytes = _RfidStream.Read(arrBuff, 0, arrBuff.Length);

                if (!_bisServer)
                {
                    while (bytes > 0)
                    {
                        String sResponseData = string.Empty;

                        bytes = _RfidStream.Read(arrBuff, 0, arrBuff.Length);

                        sResponseData = System.Text.Encoding.ASCII.GetString(arrBuff, 0, bytes);

                        char a = Convert.ToChar(0x02);
                        char b = Convert.ToChar(0x0D);
                        char c = Convert.ToChar(0x0A);
                        char d = Convert.ToChar(0x03);

                        char[] delimiterChars = { a, b, c, d };

                        arrResult = sResponseData.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

                        arrResult = DuplicateCheck<String>(arrResult);

                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            for (int i = 0; i < arrResult.Length; i++)
                            {
                                mmeRFID.Text += arrResult[i] + "\r\n";
                            }
                        }));

                        // _bisServer = true;
                        Thread.Sleep(2000);
                    }

                }
            }
            return true;
        }

        /// <summary>
        /// Camera power on request event
        /// </summary>
        private async void LF_CameraPowerOn()
        {
            _powerCanceltoken = new CancellationTokenSource();
            CancellationToken powerToken = _serverCanceltoken.Token;
            try
            {
                var taskPowerOn = Task.Factory.StartNew<bool>(LF_CameraPowerRun, powerToken);
                bool bPowerCheck = await taskPowerOn;
                if (bPowerCheck)
                {

                }
                else
                {

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        /// <summary>
        /// Camera power off request event 
        /// </summary>
        private void LF_CameraPowerOff()
        {
            _powerCanceltoken = new CancellationTokenSource();
            CancellationToken powerToken = _serverCanceltoken.Token;

            try
            {
                _powerCanceltoken.Cancel();
                var taskPowerOn = Task.Factory.StartNew<bool>(LF_CameraPowerRun, powerToken);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        /// <summary>
        /// Run camera event
        /// </summary>
        private bool LF_CameraPowerRun()
        {
            int bytes = 0;
            byte[] buff = new byte[128];
            byte[] bByte;

            IPEndPoint localAddress = new IPEndPoint(IPAddress.Parse(txtPower.Text), 3000);
            _listener = new TcpListener(localAddress);
            String responseData = String.Empty;


            if (_powerCanceltoken.IsCancellationRequested)
            {
                bByte = StringToByte("POWEROFF");

                _bisPower = false;
                _listener.Start();
                _CameraClient = _listener.AcceptTcpClient();
                _CameraStream = _CameraClient.GetStream();
                _CameraStream.Write(bByte, 0, bByte.Length);
                bytes = _CameraStream.Read(buff, 0, buff.Length);

                if (bytes > 0)
                {
                    responseData = System.Text.Encoding.ASCII.GetString(buff, 0, bytes);
                }

                _CameraStream.Close();
                _CameraClient.Close();
                _listener.Stop();

                return false;
            }
            else
            {
                bByte = StringToByte("POWER_ON");
                _bisPower = true;

                _listener.Start();
                _CameraClient = _listener.AcceptTcpClient();
                _CameraStream = _CameraClient.GetStream();
                _CameraStream.Write(bByte, 0, bByte.Length);
                bytes = _CameraStream.Read(buff, 0, buff.Length);

                if (bytes > 0)
                {
                    responseData = System.Text.Encoding.ASCII.GetString(buff, 0, bytes);
                }

                _CameraStream.Close();
                _CameraClient.Close();
                _listener.Stop();


                return true;
            }
        }
        /// <summary>
        /// Request frame load event
        /// </summary>
        private void LF_FrameLoad()
        {
            if (!_bisFrame)
            {
                Invoke(new MethodInvoker(delegate ()
                {

                }));

                _bisFrame = true;
                LF_FrameRun();
            }
            else
            {

            }
        }

        /// <summary>
        /// Run frame event
        /// </summary>
        private async void LF_FrameRun()
        {
            _sCameraAddr = "rtsp://admin:123456@" + txtCamera.Text + "/mpeg4";

            if (_bisFrame)
            {
                Invoke(new MethodInvoker(delegate ()
                {

                }));

                _video.Open(_sCameraAddr);

                _taskFrame = new Task(new Action(LF_FrameDisplayRun));
                _taskFrame.Start();
            }
            else
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    pieStreaming.Image = null;
                }));

                _bisFrame = false;

            }
        }

        /// <summary>
        ///  Show loaded frame image event
        /// </summary>
        private void LF_FrameDisplayRun()
        {
            try
            {
                while (true)
                {
                    _video.Read(_mFrame);

                    if (_mFrame.Size().Width > 0 && _mFrame.Size().Height > 0)
                    {
                        Cv2.Resize(_mFrame, _mView, new OpenCvSharp.Size(800, 450));
                        _bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(_mView);

                        Invoke(new MethodInvoker(delegate ()
                        {
                            pieStreaming.Image = _bitmap;

                        }));
                    }
                    else
                    {
                        _bitmap = null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Save captured image event
        /// </summary>
        private void LF_ImageCapture()
        {
            try
            {
                if (_bisFrame)
                {
                    txtPort.Image = null;
                    string sImageCaptureFile = DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss");
                    Cv2.ImWrite("C:\\" + sImageCaptureFile + ".png", _mFrame);
                    txtPort.Image = BitmapConverter.ToBitmap(_mFrame);
                    LF_Image_QRCode_Decode(_mFrame);
                    Cv2.ImShow("Capture", _mFrame);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        /// <summary>
        /// Decoding QR code from saved captured image 
        /// </summary>
        private void LF_Image_QRCode_Decode(Mat p_image)
        {
            LuminanceSource source;
            source = new BitmapLuminanceSource(BitmapConverter.ToBitmap(p_image));
            BinaryBitmap bitmap = new BinaryBitmap(new HybridBinarizer(source));
            Result result = new MultiFormatReader().decode(bitmap);
            if (result != null)
            {
                string strDecode = result.ToString() + result.BarcodeFormat.ToString();
                mmeQR.Text += strDecode + "\r\n";
            }
            else
            {
                mmeQR.Text += "False" + "\r\n";
            }
        }

        /// <summary>
        /// Convert string to byte array 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private byte[] StringToByte(string str)
        {
            byte[] StrByte = Encoding.UTF8.GetBytes(str);
            return StrByte;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="p_Array"></param>
        /// <returns></returns>
        private T[] DuplicateCheck<T>(T[] p_Array)
        {
            List<T> result = new List<T>();

            for (int i = 0; i < p_Array.Length; i++)
            {
                if (result.Contains(p_Array[i])) continue;
                result.Add(p_Array[i]);
            }
            return result.ToArray();
        }
    }
}