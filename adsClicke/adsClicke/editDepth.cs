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
    public partial class editDepth : Form
    {
        Guid guid;
        DepthModel model;
        public editDepth(Guid _guid,DepthModel depthModel= new DepthModel())
        {
            InitializeComponent();
            guid = _guid;
            model = depthModel;

            tb_prefix.Text = model.prefix;
            nud_depth.Value = model.depth;
            nud_maxActionSpan.Value = model.maxActionSpan;
            nud_maxWndCount.Value = model.maxWndCount;
            nud_minActionSpan.Value = model.minActionSpan;
            nud_minLastTime.Value = model.minLastTime;
            nud_maxLastTime.Value = model.maxLastTime;
            nud_maxVisitTimes.Value = model.visitTimesLimit;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            model.maxActionSpan = (uint)nud_maxActionSpan.Value;
            model.minActionSpan = (uint)nud_minActionSpan.Value;
            model.maxWndCount = (uint)nud_maxWndCount.Value;
            model.prefix = tb_prefix.Text.Trim();
            model.maxLastTime = (uint)nud_maxLastTime.Value;
            model.minLastTime = (uint)nud_minLastTime.Value;
            model.visitTimesLimit = (uint)nud_maxVisitTimes.Value;
            ((Form1)Owner).alterDepth(guid, model);
            MessageBox.Show("操作成功!", "提示");
            Close();
        }
    }
}
