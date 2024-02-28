using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DuAnLamQuen
{
    public partial class Hello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //khởi tạo ki nạp lần đầu
            }
            else // if (!IsPostBack) // xử lý khi postback
            {
                string hoTen = txtHoTen.Text;
                string gt = ddlGT.SelectedValue == "true" ? "Anh" : "Chị";
                lbChao.Text = $"Chào {gt} <b> {hoTen} </b> đến vói ASP.NET";
            }
        }

        protected void btnGui_Click(object sender, EventArgs e)
        {
            //string hoten = txtHoTen.Text; // lấy họ tên từ client
            ////phản hồi kết quả về client
            //lbChao.Text = "Chào bạn: <b>" + hoten + "</b> đến với ASP.NET";
        }


    }
}