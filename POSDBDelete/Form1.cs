using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSDBDelete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void DBDELETE(string _BRCODE, string _WKDATE, string _POSNO, string _GROUPNO, string _VNO)
        {
            // ---> DB 연결하기
            SqlConnection conn = new SqlConnection();

            try
            {
                // DB 접속 정보
                string dbConnectString = "Server=*;"
                                       + "database=*;"
                                       + "uid=yppos;"
                                       + "pwd=*;";
                // DB 접속 정보 입력
                conn.ConnectionString = dbConnectString;
                // DB 연결
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("DB 연결 오류 발생\r\n" + e);
            }
            // <--- DB 연결하기

            SqlCommand sqlComm = new SqlCommand();

            // 쿼리문
            String SQL = string.Empty;

            // 쿼리문 실행 결과 영향 받은 행의 수
            int PTBOOKCLUBPOINT_NEW_NUM = 0;
            int PTCARD_damo_NUM = 0;
            int PTCASH_NEW_NUM = 0;
            int PTCASHBILL_NEW_NUM = 0;
            int PTCOUPON_NUM = 0;
            int PTDETAIL_NUM = 0;
            int PTLIB_NUM = 0;
            int PTLIB_NEW_NUM = 0;
            int PTLPOINT_NEW_NUM = 0;
            int PTMCULTURELAND_NEW_NUM = 0;
            int PTMHAPPYMONEY_NEW_NUM = 0;
            int PTOCB_NUM = 0;
            int PTSETTLE_NUM = 0;
            int PTSTOCK_NUM = 0;

            try
            {
                // PTBOOKCLUBPOINT_NEW 테이블 삭제
                SQL = "DELETE FROM *.[dbo].[PTBOOKCLUBPOINT_NEW] WHERE BRCODE = @BRCODE AND WKDATE = @WKDATE AND POSNO = @POSNO AND GROUPNO = @GROUPNO AND VNO in (@VNO)";
                sqlComm = new SqlCommand(SQL, conn);
                sqlComm.Parameters.Add("@BRCODE", SqlDbType.Char).Value = _BRCODE;
                sqlComm.Parameters.Add("@WKDATE", SqlDbType.Char).Value = _WKDATE;
                sqlComm.Parameters.Add("@POSNO", SqlDbType.Int).Value = _POSNO;
                sqlComm.Parameters.Add("@GROUPNO", SqlDbType.Int).Value = _GROUPNO;
                sqlComm.Parameters.Add("@VNO", SqlDbType.Int).Value = _VNO;
                PTBOOKCLUBPOINT_NEW_NUM = sqlComm.ExecuteNonQuery();

                // PTCARD_damo 테이블 삭제
                SQL = "DELETE FROM *.[dbo].[PTCARD_damo] WHERE BRCODE = @BRCODE AND WKDATE = @WKDATE AND POSNO = @POSNO AND GROUPNO = @GROUPNO AND VNO in (@VNO)";
                sqlComm = new SqlCommand(SQL, conn);
                sqlComm.Parameters.Add("@BRCODE", SqlDbType.Char).Value = _BRCODE;
                sqlComm.Parameters.Add("@WKDATE", SqlDbType.Char).Value = _WKDATE;
                sqlComm.Parameters.Add("@POSNO", SqlDbType.Int).Value = _POSNO;
                sqlComm.Parameters.Add("@GROUPNO", SqlDbType.Int).Value = _GROUPNO;
                sqlComm.Parameters.Add("@VNO", SqlDbType.Int).Value = _VNO;
                PTCARD_damo_NUM = sqlComm.ExecuteNonQuery();

                // PTCASH_NEW 테이블 삭제
                SQL = "DELETE FROM *.[dbo].[PTCASH_NEW] WHERE BRCODE = @BRCODE AND WKDATE = @WKDATE AND POSNO = @POSNO AND GROUPNO = @GROUPNO AND VNO in (@VNO)";
                sqlComm = new SqlCommand(SQL, conn);
                sqlComm.Parameters.Add("@BRCODE", SqlDbType.Char).Value = _BRCODE;
                sqlComm.Parameters.Add("@WKDATE", SqlDbType.Char).Value = _WKDATE;
                sqlComm.Parameters.Add("@POSNO", SqlDbType.Int).Value = _POSNO;
                sqlComm.Parameters.Add("@GROUPNO", SqlDbType.Int).Value = _GROUPNO;
                sqlComm.Parameters.Add("@VNO", SqlDbType.Int).Value = _VNO;
                PTCASH_NEW_NUM = sqlComm.ExecuteNonQuery();

                // PTCASHBILL_NEW 테이블 삭제
                SQL = "DELETE FROM *.[dbo].[PTCASHBILL_NEW] WHERE BRCODE = @BRCODE AND WKDATE = @WKDATE AND POSNO = @POSNO AND GROUPNO = @GROUPNO AND VNO in (@VNO)";
                sqlComm = new SqlCommand(SQL, conn);
                sqlComm.Parameters.Add("@BRCODE", SqlDbType.Char).Value = _BRCODE;
                sqlComm.Parameters.Add("@WKDATE", SqlDbType.Char).Value = _WKDATE;
                sqlComm.Parameters.Add("@POSNO", SqlDbType.Int).Value = _POSNO;
                sqlComm.Parameters.Add("@GROUPNO", SqlDbType.Int).Value = _GROUPNO;
                sqlComm.Parameters.Add("@VNO", SqlDbType.Int).Value = _VNO;
                PTCASHBILL_NEW_NUM = sqlComm.ExecuteNonQuery();

                // PTCOUPON 테이블 삭제
                SQL = "DELETE FROM *.[dbo].[PTCOUPON] WHERE BRCODE = @BRCODE AND WKDATE = @WKDATE AND POSNO = @POSNO AND GROUPNO = @GROUPNO AND VNO in (@VNO)";
                sqlComm = new SqlCommand(SQL, conn);
                sqlComm.Parameters.Add("@BRCODE", SqlDbType.Char).Value = _BRCODE;
                sqlComm.Parameters.Add("@WKDATE", SqlDbType.Char).Value = _WKDATE;
                sqlComm.Parameters.Add("@POSNO", SqlDbType.Int).Value = _POSNO;
                sqlComm.Parameters.Add("@GROUPNO", SqlDbType.Int).Value = _GROUPNO;
                sqlComm.Parameters.Add("@VNO", SqlDbType.Int).Value = _VNO;
                PTCOUPON_NUM = sqlComm.ExecuteNonQuery();

                // PTDETAIL 테이블 삭제
                SQL = "DELETE FROM *.[dbo].[PTDETAIL] WHERE BRCODE = @BRCODE AND WKDATE = @WKDATE AND POSNO = @POSNO AND GROUPNO = @GROUPNO AND VNO in (@VNO)";
                sqlComm = new SqlCommand(SQL, conn);
                sqlComm.Parameters.Add("@BRCODE", SqlDbType.Char).Value = _BRCODE;
                sqlComm.Parameters.Add("@WKDATE", SqlDbType.Char).Value = _WKDATE;
                sqlComm.Parameters.Add("@POSNO", SqlDbType.Int).Value = _POSNO;
                sqlComm.Parameters.Add("@GROUPNO", SqlDbType.Int).Value = _GROUPNO;
                sqlComm.Parameters.Add("@VNO", SqlDbType.Int).Value = _VNO;
                PTDETAIL_NUM = sqlComm.ExecuteNonQuery();

                // PTLIB 테이블 삭제
                SQL = "DELETE FROM *.[dbo].[PTLIB] WHERE BRCODE = @BRCODE AND WKDATE = @WKDATE AND POSNO = @POSNO AND GROUPNO = @GROUPNO AND VNO in (@VNO)";
                sqlComm = new SqlCommand(SQL, conn);
                sqlComm.Parameters.Add("@BRCODE", SqlDbType.Char).Value = _BRCODE;
                sqlComm.Parameters.Add("@WKDATE", SqlDbType.Char).Value = _WKDATE;
                sqlComm.Parameters.Add("@POSNO", SqlDbType.Int).Value = _POSNO;
                sqlComm.Parameters.Add("@GROUPNO", SqlDbType.Int).Value = _GROUPNO;
                sqlComm.Parameters.Add("@VNO", SqlDbType.Int).Value = _VNO;
                PTLIB_NUM = sqlComm.ExecuteNonQuery();

                // PTLIB_NEW 테이블 삭제
                SQL = "DELETE FROM *.[dbo].[PTLIB_NEW] WHERE BRCODE = @BRCODE AND WKDATE = @WKDATE AND POSNO = @POSNO AND GROUPNO = @GROUPNO AND VNO in (@VNO)";
                sqlComm = new SqlCommand(SQL, conn);
                sqlComm.Parameters.Add("@BRCODE", SqlDbType.Char).Value = _BRCODE;
                sqlComm.Parameters.Add("@WKDATE", SqlDbType.Char).Value = _WKDATE;
                sqlComm.Parameters.Add("@POSNO", SqlDbType.Int).Value = _POSNO;
                sqlComm.Parameters.Add("@GROUPNO", SqlDbType.Int).Value = _GROUPNO;
                sqlComm.Parameters.Add("@VNO", SqlDbType.Int).Value = _VNO;
                PTLIB_NEW_NUM = sqlComm.ExecuteNonQuery();

                // PTLPOINT_NEW 테이블 삭제
                SQL = "DELETE FROM *.[dbo].[PTLPOINT_NEW] WHERE BRCODE = @BRCODE AND WKDATE = @WKDATE AND POSNO = @POSNO AND GROUPNO = @GROUPNO AND VNO in (@VNO)";
                sqlComm = new SqlCommand(SQL, conn);
                sqlComm.Parameters.Add("@BRCODE", SqlDbType.Char).Value = _BRCODE;
                sqlComm.Parameters.Add("@WKDATE", SqlDbType.Char).Value = _WKDATE;
                sqlComm.Parameters.Add("@POSNO", SqlDbType.Int).Value = _POSNO;
                sqlComm.Parameters.Add("@GROUPNO", SqlDbType.Int).Value = _GROUPNO;
                sqlComm.Parameters.Add("@VNO", SqlDbType.Int).Value = _VNO;
                PTLPOINT_NEW_NUM = sqlComm.ExecuteNonQuery();

                // PTMCULTURELAND_NEW 테이블 삭제
                SQL = "DELETE FROM *.[dbo].[PTMCULTURELAND_NEW] WHERE BRCODE = @BRCODE AND WKDATE = @WKDATE AND POSNO = @POSNO AND GROUPNO = @GROUPNO AND VNO in (@VNO)";
                sqlComm = new SqlCommand(SQL, conn);
                sqlComm.Parameters.Add("@BRCODE", SqlDbType.Char).Value = _BRCODE;
                sqlComm.Parameters.Add("@WKDATE", SqlDbType.Char).Value = _WKDATE;
                sqlComm.Parameters.Add("@POSNO", SqlDbType.Int).Value = _POSNO;
                sqlComm.Parameters.Add("@GROUPNO", SqlDbType.Int).Value = _GROUPNO;
                sqlComm.Parameters.Add("@VNO", SqlDbType.Int).Value = _VNO;
                PTMCULTURELAND_NEW_NUM = sqlComm.ExecuteNonQuery();

                // PTMHAPPYMONEY_NEW 테이블 삭제
                SQL = "DELETE FROM *.[dbo].[PTMHAPPYMONEY_NEW] WHERE BRCODE = @BRCODE AND WKDATE = @WKDATE AND POSNO = @POSNO AND GROUPNO = @GROUPNO AND VNO in (@VNO)";
                sqlComm = new SqlCommand(SQL, conn);
                sqlComm.Parameters.Add("@BRCODE", SqlDbType.Char).Value = _BRCODE;
                sqlComm.Parameters.Add("@WKDATE", SqlDbType.Char).Value = _WKDATE;
                sqlComm.Parameters.Add("@POSNO", SqlDbType.Int).Value = _POSNO;
                sqlComm.Parameters.Add("@GROUPNO", SqlDbType.Int).Value = _GROUPNO;
                sqlComm.Parameters.Add("@VNO", SqlDbType.Int).Value = _VNO;
                PTMHAPPYMONEY_NEW_NUM = sqlComm.ExecuteNonQuery();

                // PTOCB 테이블 삭제
                SQL = "DELETE FROM *.[dbo].[PTOCB] WHERE BRCODE = @BRCODE AND WKDATE = @WKDATE AND POSNO = @POSNO AND GROUPNO = @GROUPNO AND VNO in (@VNO)";
                sqlComm = new SqlCommand(SQL, conn);
                sqlComm.Parameters.Add("@BRCODE", SqlDbType.Char).Value = _BRCODE;
                sqlComm.Parameters.Add("@WKDATE", SqlDbType.Char).Value = _WKDATE;
                sqlComm.Parameters.Add("@POSNO", SqlDbType.Int).Value = _POSNO;
                sqlComm.Parameters.Add("@GROUPNO", SqlDbType.Int).Value = _GROUPNO;
                sqlComm.Parameters.Add("@VNO", SqlDbType.Int).Value = _VNO;
                PTOCB_NUM = sqlComm.ExecuteNonQuery();

                // PTSETTLE 테이블 삭제
                SQL = "DELETE FROM *.[dbo].[PTSETTLE] WHERE BRCODE = @BRCODE AND WKDATE = @WKDATE AND POSNO = @POSNO AND GROUPNO = @GROUPNO AND VNO in (@VNO)";
                sqlComm = new SqlCommand(SQL, conn);
                sqlComm.Parameters.Add("@BRCODE", SqlDbType.Char).Value = _BRCODE;
                sqlComm.Parameters.Add("@WKDATE", SqlDbType.Char).Value = _WKDATE;
                sqlComm.Parameters.Add("@POSNO", SqlDbType.Int).Value = _POSNO;
                sqlComm.Parameters.Add("@GROUPNO", SqlDbType.Int).Value = _GROUPNO;
                sqlComm.Parameters.Add("@VNO", SqlDbType.Int).Value = _VNO;
                PTSETTLE_NUM = sqlComm.ExecuteNonQuery();

                // PTSTOCK 테이블 삭제
                SQL = "DELETE FROM *.[dbo].[PTSTOCK] WHERE BRCODE = @BRCODE AND WKDATE = @WKDATE AND POSNO = @POSNO AND GROUPNO = @GROUPNO AND VNO in (@VNO)";
                sqlComm = new SqlCommand(SQL, conn);
                sqlComm.Parameters.Add("@BRCODE", SqlDbType.Char).Value = _BRCODE;
                sqlComm.Parameters.Add("@WKDATE", SqlDbType.Char).Value = _WKDATE;
                sqlComm.Parameters.Add("@POSNO", SqlDbType.Int).Value = _POSNO;
                sqlComm.Parameters.Add("@GROUPNO", SqlDbType.Int).Value = _GROUPNO;
                sqlComm.Parameters.Add("@VNO", SqlDbType.Int).Value = _VNO;
                PTSTOCK_NUM = sqlComm.ExecuteNonQuery();

                // 메시지박스로 삭제 결과 출력
                MessageBox.Show(string.Format("삭제 결과\r\n"
                                            + "- PTBOOKCLUBPOINT_NEW 테이블 삭제 : {0} 건\r\n"
                                            + "- PTCARD_damo 테이블 삭제 : {1} 건\r\n"
                                            + "- PTCASH_NEW 테이블 삭제 : {2} 건\r\n"
                                            + "- PTCASHBILL_NEW 테이블 삭제 : {3} 건\r\n"
                                            + "- PTCOUPON 테이블 삭제 : {4} 건\r\n"
                                            + "- PTDETAIL 테이블 삭제 : {5} 건\r\n"
                                            + "- PTLIB 테이블 삭제 : {6} 건\r\n"
                                            + "- PTLIB_NEW 테이블 삭제 : {7} 건\r\n"
                                            + "- PTLPOINT_NEW 테이블 삭제 : {8} 건\r\n"
                                            + "- PTMCULTURELAND_NEW 테이블 삭제 : {9} 건\r\n"
                                            + "- PTMHAPPYMONEY_NEW 테이블 삭제 : {10} 건\r\n"
                                            + "- PTOCB 테이블 삭제 : {11} 건\r\n"
                                            + "- PTSETTLE 테이블 삭제 : {12} 건\r\n"
                                            + "- PTSTOCK 테이블 삭제 : {13} 건",
                                            PTBOOKCLUBPOINT_NEW_NUM, PTCARD_damo_NUM, PTCASH_NEW_NUM, PTCASHBILL_NEW_NUM, PTCOUPON_NUM, PTDETAIL_NUM, PTLIB_NUM,
                                            PTLIB_NEW_NUM, PTLPOINT_NEW_NUM, PTMCULTURELAND_NEW_NUM, PTMHAPPYMONEY_NEW_NUM, PTOCB_NUM, PTSETTLE_NUM, PTSTOCK_NUM));
            }
            catch (Exception e)
            {
                MessageBox.Show("SQL 쿼리 실행 중 오류 발생\r\n" + e);
            }
        }

        private void btDELETE_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) // 조건으로 삭제
            {
                if (tbBRCODE.TextLength == 0 || tbWKDATE.TextLength == 0 || tbPOSNO.TextLength == 0 || tbGROUPNO.TextLength == 0 || tbVNO.TextLength == 0 ||
                    tbBRCODE.TextLength != 4 || tbWKDATE.TextLength != 10 || tbPOSNO.TextLength > 2 || tbGROUPNO.TextLength != 1 || tbVNO.TextLength > 5)
                {
                    MessageBox.Show("조건값이 올바르지 않음");
                }
                else
                {
                    DBDELETE(tbBRCODE.Text, tbWKDATE.Text, tbPOSNO.Text, tbGROUPNO.Text, tbVNO.Text);
                }
            }
            else if (radioButton2.Checked == true) // 영수증 번호로 삭제
            {
                if (tbRCT.TextLength != 18)
                {
                    MessageBox.Show("영수증 번호가 올바르지 않음");
                }
                else
                {
                    // 영수증 번호 예시 : 370020123114100304
                    string BRCODE = tbRCT.Text.Substring(0, 4);
                    string WKDATE = "20" + tbRCT.Text.Substring(4, 2) + "." + tbRCT.Text.Substring(6, 2) + "." + tbRCT.Text.Substring(8, 2);
                    string POSNO = tbRCT.Text.Substring(10, 2);
                    string GROUPNO = tbRCT.Text.Substring(12, 1);
                    string VNO = tbRCT.Text.Substring(13, 5);
                    int iVNO = Int16.Parse(VNO); // 0으로 LeftPadding된 VNO 5자리를 0 제거한 문자열로 바꾸기 위해 Int 변환 거친다
                    VNO = iVNO.ToString();

                    DBDELETE(BRCODE, WKDATE, POSNO, GROUPNO, VNO);
                }
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            // 조건으로 삭제 라디오 버튼 선택시 영수증 번호로 삭제 비활성화
            tbBRCODE.Enabled = true;
            tbWKDATE.Enabled = true;
            tbPOSNO.Enabled = true;
            tbGROUPNO.Enabled = true;
            tbVNO.Enabled = true;

            tbRCT.Enabled = false;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            // 영수증 번호로 삭제 라디오 버튼 선택시 조건으로 삭제 비활성화
            tbBRCODE.Enabled = false;
            tbWKDATE.Enabled = false;
            tbPOSNO.Enabled = false;
            tbGROUPNO.Enabled = false;
            tbVNO.Enabled = false;

            tbRCT.Enabled = true;
        }
    }
}
