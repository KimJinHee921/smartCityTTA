using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace ClientSocketTest
{
    public partial class Form1 : Form
    {
        Socket client_socket;   //클라이언트 소켓 선언
        bool isConnected;   //참-거짓 값을 이용하여 통신 오류 발생 시 대처
        byte[] bytes = new byte[1024];
        string data;
        int dataLength;
        string logInTime;
        int statusBtn = 1;

        public Form1()
        {
            InitializeComponent();
            isConnected = false;    //통신 시작되면 true
            logInTime = DateTime.Now.ToString("yyyyMMddHHmmss");
            title.Text = "119/로그인요청";
            statusBtn = 1;
            HeadTextRefresh();
            textBox3.Text = "로그인ID" + logInTime + "kor" + "|" + "화재" + "|" + "세부분류명" + "|" + "36.123456" + "|" + "126.12345488"
                            + "|" + "서울 금천구 가산동 17-1 (공공건물)" + "|" + "법정동코드시도" + "|" + logInTime + "|" + "사용자ID" + ";";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                start();
                Thread listen_thread = new Thread(do_receive);
                listen_thread.Start();  //클라이언트 스레드 시작(서버 시작)
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show(ex.ToString());
            }

            try
            {
                if (isConnected == false) return;
                byte[] msg = Encoding.UTF8.GetBytes(textBox1.Text + textBox3.Text + ";");    //UTF8로 인코딩 상대에게 OP : 데이터 + "<eof>" 송신
                int bytesSent = client_socket.Send(msg);    //Send를 이용해서 내용 송신
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		//	listBox1.SelectedIndex = listBox1.Items.Count - 1;
		}

        public void start()
        {
            try
            {
                if (isConnected == true) return;
                client_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);    //소켓 생성
                client_socket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234));
                listBox1.Items.Add(String.Format("소켓 연결되었습니다 ", client_socket.RemoteEndPoint.ToString()));
                isConnected = true;
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
              //  listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
        }

        void do_receive()
        {
            while (isConnected) //무한루프 설정
            {
                try
                {
                    while (true)    //통신이 시작되었을때
                    {
                        byte[] bytes = new byte[1024];
                        int bytesRec = client_socket.Receive(bytes);
                        data += Encoding.UTF8.GetString(bytes, 0, bytesRec);
                        if (data.IndexOf(";") > -1) break;  //<eof>가 있으면 브레이크
                    }
                    CheckForIllegalCrossThreadCalls = false;
                    Invoke((MethodInvoker)delegate  // ? 없으면 크로스스레드 오류 발생 (https://blog.naver.com/spb02293/221671835503 참조)
                        {
                            listBox1.Items.Add(data);
                            listBox1.Items.Add("데이터 수신 완료");
                        }
                    );
                    data = "";
                }
                catch (Exception ex)
                {
                    ex.ToString();
                    MessageBox.Show(ex.ToString());

                    isConnected = false;
                    while (isConnected == false)
                    {
                        start();
                        Thread listen_thread = new Thread(do_receive);
                        listen_thread.Start();
                    }
                }
                finally
                {
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                }
            }
        }

        private void 로그인요청ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            statusBtn = 1;
            textBox1.Clear();
            title.Text = "119/로그인요청";
            HeadTextRefresh();
            textBox3.Text = "로그인ID" + logInTime + "kor" + "|" + "화재" + "|" + "세부분류명" + "|" + "36.123456" + "|" + "126.12345488"
                            + "|" + "서울 금천구 가산동 17-1 (공공건물)" + "|" + "법정동코드시도" + "|" + logInTime + "|" + "사용자ID" + ";";
        }

        private void 관제요청ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            statusBtn = 2;
            textBox1.Clear();
            title.Text = "119/관제요청";
            HeadTextRefresh();
            textBox3.Text = "긴급구조표준접수번호" + "|" + "화재" + "|" + "세부분류명" + "|" + "36.123456" + "|" + "126.12345488"
                            + "|" + "서울 금천구 가산동 17-1 (공공건물)" + "|" + "법정동코드시도" + "|" + logInTime + "|" + "사용자ID" + ";";
        }


        private void 정보변경요청ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            statusBtn = 3;
            textBox1.Clear();
            title.Text = "119/정보변경요청";
            HeadTextRefresh();
            textBox3.Text = "긴급구조표준접수번호" + "|" + "화재" + "|" + "세부분류명" + "|" + "36.123456" + "|" + "126.12345488"
                            + "|" + "서울 금천구 가산동 17-1 (공공건물)" + "|" + "법정동코드시도" + "|" + logInTime + "|" + "사용자ID" + ";";
        }

        private void 관제해제요청ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            statusBtn = 4;
            textBox1.Clear();
            title.Text = "119/관제해제요청";
            HeadTextRefresh();
            textBox3.Text = "긴급구조표준접수번호" + "|" + "화재" + "|" + "세부분류명" + "|" + "36.123456" + "|" + "126.12345488"
                            + "|" + "서울 금천구 가산동 17-1 (공공건물)" + "|" + "법정동코드시도" + "|" + logInTime + "|" + "사용자ID" + ";";
        }

        private void 재난종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            statusBtn = 5;
            textBox1.Clear();
            title.Text = "119/재난종료";
            HeadTextRefresh();
            textBox3.Text = "긴급구조표준접수번호" + "|" + "화재" + "|" + "세부분류명" + "|" + "36.123456" + "|" + "126.12345488"
                            + "|" + "서울 금천구 가산동 17-1 (공공건물)" + "|" + "법정동코드시도" + "|" + logInTime + "|" + "사용자ID" + ";";
        }

        private void 긴급영상요청ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            statusBtn = 6;
            textBox1.Clear();
            title.Text = "112/112긴급영상요청";
            HeadTextRefresh();
            textBox3.Text = "사건번호" + "|" + "사고등급" + "|" + "사고유형" + "|" + "사건번호" + "|" + "126.12345488" + "|" + "36.123456"
                            + "|" + "서울 금천구 가산동 17-1 (공공건물)" + "|" + "지역코드" + "|" + logInTime + "|" + "사용자ID" + ";";
        }

        private void 사건정보수신ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            statusBtn = 7;
            textBox1.Clear();
            title.Text = "사회적약자/사건정보수신";
            HeadTextRefresh();
            textBox3.Text = "발생번호" + "|" + "서비스유형" + "|" + "126.12345488" + "|" + "36.123456"
                            + "|" + "사건지점전체주소" + "|" + "지역코드" + "|" + "Ref_ID" + "|" + "이름"
                            + "|" + "핸드폰번호" + "|" + "출생일" + "|" + "성별" + "|" + "주소(주거지)"
                            + "|" + "보호자이름" + "|" + "보호자 핸드폰" + "|" + logInTime + "|" + "이미지파일"
                            + "|" + "신상정보" + "|" + "특이사항" + "|" + "전송자ID" + "|" + "주소(주거지)"
                            + ";";
        }

        private void logInKeyPress(object sender, EventArgs e)
        {
            textBox1.Clear();
            dataLength = textBox3.Text.Length;
            HeadTextRefresh();
        }

        public void HeadTextRefresh()
        {
            dataLength = textBox3.Text.Length;
            var currentTime = DateTime.Now.ToString("yyyyMMddHHmmss");
            var dataFormat = string.Format("{0:D10}", dataLength);
            var code1 = "";
            var code2 = "";
            var code3 = "";
            if (statusBtn == 1)
            {
                code1 = "99";
                code2 = "99";
                code3 = "119";
            }
            else if (statusBtn == 2)
            {
                code1 = "10";
                code2 = "10";
                code3 = "119";
            }
            else if (statusBtn == 3)
            {
                code1 = "10";
                code2 = "40";
                code3 = "119";
            }
            else if (statusBtn == 4)
            {
                code1 = "10";
                code2 = "50";
                code3 = "119";
            }
            else if (statusBtn == 5)
            {
                code1 = "10";
                code2 = "91";
                code3 = "119";
            }
            else if (statusBtn == 6)
            {
                code1 = "10";
                code2 = "10";
                code3 = "112";
            }
            else if (statusBtn == 7)
            {
                code1 = "10";
                code2 = "10";
                code3 = "WP1";
            }
        
            string[] stringArray = { code1, code2, currentTime, code3, "UCP", currentTime, dataFormat }; 

            for (int i = 0; i < stringArray.Length; i++)
            {
                textBox1.Text += stringArray[i];
            }
        }
    }
}
