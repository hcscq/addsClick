using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adsClicke
{
    public partial class addAddr : Form
    {
        private addrConfig model;
        public addAddr(addrConfig m=new addrConfig())
        {
            InitializeComponent();
            model = m;
            Inital();
        }
        private void Inital()
        {
            //btn_save.Enabled = false;
            tb_addr.Text = model.addrModel.href;
            tb_name.Text = model.addrModel.name;
            tb_notice.Text = model.addrModel.notice;
            if (model.addrModel.maxDepth < nud_maxDepth.Minimum)
                model.addrModel.maxDepth = (uint)nud_maxDepth.Minimum;
            else if (model.addrModel.maxDepth > nud_maxDepth.Maximum)
                model.addrModel.maxDepth = (uint)nud_maxDepth.Maximum;
            nud_maxDepth.Value = model.addrModel.maxDepth;

            if (model.addrModel.maxWndCount < nud_maxWndCount.Minimum)
                model.addrModel.maxWndCount = (uint)nud_maxWndCount.Minimum;
            else if (model.addrModel.maxWndCount > nud_maxWndCount.Maximum)
                model.addrModel.maxWndCount = (uint)nud_maxWndCount.Maximum;
            nud_maxWndCount.Value = model.addrModel.maxWndCount;

            if (model.addrModel.priority < nud_priority.Minimum)
                model.addrModel.priority = (uint)nud_priority.Minimum;
            else if (model.addrModel.priority > nud_priority.Maximum)
                model.addrModel.priority = (uint)nud_priority.Maximum;
            nud_priority.Value = model.addrModel.priority;
            cb_active.Checked = model.actived;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!Uri.IsWellFormedUriString(tb_addr.Text.Trim(), UriKind.Absolute))
            {
                MessageBox.Show("请输入正确的URL地址!","提示");
                return;
            }
            model.addrModel.href = tb_addr.Text.Trim();
            model.addrModel.maxDepth = (uint)nud_maxDepth.Value;
            model.addrModel.maxWndCount = (uint)nud_maxWndCount.Value;
            model.addrModel.name = tb_name.Text.Trim();
            model.addrModel.notice = tb_notice.Text.Trim();
            model.addrModel.priority = (uint)nud_priority.Value;
            model.addrModel.leastVisitTS = (uint)nud_visitTS.Value;
            model.actived = cb_active.Checked;
            if (model.addrModel.guid == Guid.Empty)
            {
                model.addrModel.guid = Guid.NewGuid();
                model.list_depthInfo = new List<DepthInfo>();
                DepthInfo depthInfo = new DepthInfo();
                depthInfo.depthModel.minActionSpan = 2;
                depthInfo.depthModel.maxActionSpan = 10;
                depthInfo.depthModel.depth = 1;
                depthInfo.depthModel.maxWndCount = 1;
                depthInfo.depthModel.prefix = model.addrModel.href;
                depthInfo.list_links = new List<LinkInfo>();
                model.list_depthInfo.Add(depthInfo);
                ((Form1)this.Owner).addAddr(model);
                MessageBox.Show("添加成功!", "提示");
                Close();
            }
            else {
                ((Form1)this.Owner).alterAddr(model);
                MessageBox.Show("修改成功!", "提示");
                Close();
            }
        }
    }
}
