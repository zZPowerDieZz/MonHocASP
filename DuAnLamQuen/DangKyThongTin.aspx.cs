using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DuAnLamQuen
{
    public partial class DangKyThongTin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //code khởi tạo dữ liệu cho các điều khiển
            if (!Page.IsPostBack)
            {
                //khởi tạo cho ddlTrinhDo
                ddlTrinhDo.Items.Add(new ListItem("Trung cấp"));
                ddlTrinhDo.Items.Add(new ListItem("Cao đẳng"));
                ddlTrinhDo.Items.Add(new ListItem("Đại học"));


                //khởi tạo cho lstNgheNghiep
                lstNgheNghiep.Items.Add(new ListItem("Giáo viên"));
                lstNgheNghiep.Items.Add(new ListItem("Lập trình viên"));
                lstNgheNghiep.Items.Add(new ListItem("Kỹ sư"));
                lstNgheNghiep.Items.Add(new ListItem("Huấn luyện viên"));

                //khởi tạo cho chkListSoThich
                chkListSoThich.Items.Add(new ListItem("Chơi game"));
                chkListSoThich.Items.Add(new ListItem("Xem phim"));
                chkListSoThich.Items.Add(new ListItem("Du lịch"));
                chkListSoThich.Items.Add(new ListItem("Ăn nhậu"));
                chkListSoThich.Items.Add(new ListItem("Đi cà phê"));

            }
        }

        protected void btGui_Click(object sender, EventArgs e)
        {
            string kq = "";
            kq += "<h2>Thông tin đăng ký của bạn</h2>";
            kq += "<ul>";
            kq += $"<li> Họ tên {txtHoTen.Text}</li>";
            kq += string.Format("<li>Ngày sinh: {0} </li>", txtNgaySinh.Text);
            if(rdNam.Checked)
            {
                kq += $"<li>Giới tính {rdNam.Text}</li>";
            }
            else
            {
                kq += $"<li> Giới tính {rdNu.Text} </li>";
            }
            kq += $"<li>Trình độ {ddlTrinhDo.SelectedItem.Text}</li>";
            kq += $"<li>Nghề nghiệp {lstNgheNghiep.SelectedItem.Text}</li>";
            // xưu lý upload
            if (FHinh.HasFile)
            {
                //lấy về đường dẫn tuyệt đối các thu mục tren sever
                string path = Server.MapPath("~/uploads");
                //sao chep tap tin ttu người dung len server
                FHinh.SaveAs(path + "/" + FHinh.FileName);
                kq += $"<li>Ảnh : <img src='Uploads/{FHinh.FileName}'> </li>";
            }

            string sothich = "";
            foreach (ListItem x in chkListSoThich.Items)
            {
                if (x.Selected)
                {
                    sothich += x.Text + ";";
                }
            }
            kq += $"<li>Sở thích: {sothich}</li>";
            

            kq += "<ul>";
            //b2 tra ket qua ve client
            lbKetQua.Text = kq;

        }
    }
}