using mshtml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using adsClicke.Common;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace adsClicke
{
    public partial class Form1 : Form
    {
        private string fileName = "addClick.ini";
        private string logfileName = "addClick.log";
        private string datafileName = "addClick.dat";
        private logOperate logOp = new logOperate();
        private IniFile iniFile;
        private visistConfig g_visistConfig = new visistConfig ();
        private List<addrConfig> list_addrInfo = new List<addrConfig>();
        private BinaryFormatter bf = new BinaryFormatter();
        private Timer scanTimer=new Timer ();
        private List<tag_BrowserInfo> list_wbInfo = new List<tag_BrowserInfo>();
        private bool bol_pause = true;
        public Form1()
        {
            InitializeComponent();
            Inital();
        }
        delegate void dosth();
        
        private void Inital()
        {

            #region test
            //if (true)
            //{
            //    DepthInfo df = new DepthInfo();
            //    df.actionSpan = 32;
            //    df.depth = 6;
            //    df.list_links = new List<LinkInfo>();
            //    LinkInfo lf1 = new LinkInfo();
            //    lf1.depth = 1;
            //    lf1.href = "http://www.baidu.com";
            //    df.list_links.Add(lf1);
            //    df.maxWndCount = 1;
            //    df.prefix = "sfds";

            //    g_visistConfig.maxWndCount = 5;
            //    g_visistConfig.actionSpan = 123;
            //    FileStream fs = new FileStream("data.dat", FileMode.Create);
            //    bf.Serialize(fs, df);
            //    fs.Close();

            //    DepthInfo visistConfig = new DepthInfo();
            //    FileStream fsr = new FileStream("data.dat", FileMode.Open);
            //    visistConfig=(DepthInfo)bf.Deserialize(fsr);
            //    logOp.writeLog(logfileName, "Read actionSpan failed!");
            //    return;
            //}
            #endregion

            //string jsonParas1 = string.Format("{\"startDate\":\"{0}\"", "2015", "2016", "11");// http://www.aikeya020.com/?id

            btn_alterAddr.Enabled = false;
            btn_delAddr.Enabled = false;
            btn_delDepth.Enabled = false;
            btn_alterDepth.Enabled = false;

            dgv_depthInfo.EditMode = DataGridViewEditMode.EditOnEnter;
            RefreshAddrInfo();
            dgv_addrInfo.MultiSelect = false;
            dgv_addrInfo.SelectionChanged += Dgv_addrInfo_SelectionChanged;
            dgv_depthInfo.SelectionChanged += Dgv_depthInfo_SelectionChanged;
            iniFile = new IniFile(AppDomain.CurrentDomain.BaseDirectory+"\\"+fileName);
            uint ts = 0;
            #region inital vars
            if (!uint.TryParse(iniFile.IniReadValue(g_visistConfig.GetType().Name, GVARS.sactionSpan), out ts))
            {
                logOp.writeLog(logfileName, "Read actionSpan failed!");
                return;
            }
            else
            {
                if (ts < GVARS.minActionSpan) { logOp.writeLog(logfileName, "Read actionSpan is illegal!(min:" + GVARS.minActionSpan + ")"); ts=GVARS.minActionSpan; }
                g_visistConfig.actionSpan = ts;
            }

            if (!uint.TryParse(iniFile.IniReadValue(g_visistConfig.GetType().Name, GVARS.smaxWndCount), out ts))
            {
                logOp.writeLog(logfileName, "Read maxWndCount failed!");
                return;
            }
            else
            {
                if (ts > GVARS.maxWndCount) { logOp.writeLog(logfileName, "Read maxWndCount is illegal!(max: " + GVARS.maxWndCount + ")"); ts=GVARS.maxWndCount; }
                g_visistConfig.maxWndCount = ts;
            }

            if (!uint.TryParse(iniFile.IniReadValue(g_visistConfig.GetType().Name, GVARS.smaxDepth), out ts))
            {
                logOp.writeLog(logfileName, "Read maxDepth failed!");
                return;
            }
            else
            {
                if (ts > GVARS.maxDepth) { logOp.writeLog(logfileName, "Read maxDepth is illegal!(max: " + GVARS.smaxDepth + ")"); ts = GVARS.maxDepth; }
                g_visistConfig.maxDepth = ts;
            }

            bool sw = GVARS.showWnd;
            if (!bool.TryParse(iniFile.IniReadValue(g_visistConfig.GetType().Name, GVARS.sshowWnd), out sw))
            {
                logOp.writeLog(logfileName, "Read showWnd failed!");
                return;
            }
            else
                g_visistConfig.showWnd = sw;
            #endregion
            cb_showWnd.Checked = g_visistConfig.showWnd;
            setSaftyVal(nud_acTimeSpan, g_visistConfig.actionSpan);
            setSaftyVal(nud_maxDepth, g_visistConfig.maxDepth);
            setSaftyVal(nud_maxWndCount, g_visistConfig.maxWndCount);
            //https://www.so.com/s?a=index&src=lm&ls=s387a6cc792&q=澳洲移民新政策&lmsid=b39deb7877cd3fe6&lm_extend=ctype:4

            //webBrowser wb = new webBrowser(new Uri("https://www.so.com/s?a=index&src=lm&ls=s387a6cc792&q=澳洲移民新政策&lmsid=b39deb7877cd3fe6&lm_extend=ctype:4"), list_addrInfo[0].addrModel.guid, "https://e.tf.360.cn/search/eclk?", 3);

            int depthIndex = list_addrInfo[0].list_depthInfo.FindIndex(q=>q.depthModel.depth==1);
            webBrowser wb = new webBrowser(new Uri(list_addrInfo[0].addrModel.href), list_addrInfo[0].addrModel.guid, list_addrInfo[0].list_depthInfo[depthIndex].depthModel.prefix, list_addrInfo[0].list_depthInfo[depthIndex].depthModel.depth);
            wb.Show(this);
            

            if (scanTimer == null)
                scanTimer = new Timer();
            if (list_wbInfo == null)
                list_wbInfo = new List<tag_BrowserInfo>();
            scanTimer.Interval =(int)g_visistConfig.actionSpan;
            scanTimer.Tick += ScanTimer_Tick;        
            
            scanTimer.Start();

        }

        private void ScanTimer_Tick(object sender, EventArgs e)
        {
            if (!bol_pause)
            {
                scanAddr();
            }
        }

        private void setSaftyVal(NumericUpDown nud,uint val)
        {
            if (val < nud.Minimum) { nud.Value = nud.Minimum; return; }
            else if (val > nud.Maximum) { nud.Value = nud.Maximum; return; }
            nud.Value = val;
        }
        private void Dgv_depthInfo_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView loc_dgv = (DataGridView)sender;
            
            if (loc_dgv.SelectedRows.Count <= 0)
            {
                btn_delDepth.Enabled = false;
                btn_alterDepth.Enabled = false;
                return;
            }
            btn_delDepth.Enabled = true;
            btn_alterDepth.Enabled = true;
        }

        private void Dgv_addrInfo_SelectionChanged(object sender, EventArgs e)
        {
            RefreshDepth();
        }

        public void RefreshDepth()
        {
            dgv_depthInfo.DataSource = null;
            if (dgv_addrInfo.SelectedRows.Count <= 0)
            {
                btn_alterAddr.Enabled = false;
                btn_delAddr.Enabled = false;
                return;
            }
            addrConfig locAddrConfig = list_addrInfo.First(q => q.addrModel.guid == (Guid.Parse(dgv_addrInfo.SelectedRows[0].Cells[GVARS.addrKey].Value.ToString())));
            if (locAddrConfig.list_depthInfo != null && locAddrConfig.list_depthInfo.Count > 0)
                dgv_depthInfo.DataSource =
                (from q in locAddrConfig.list_depthInfo.AsEnumerable()
                 select new DepthModel
                 {
                     prefix = q.depthModel.prefix,
                     depth = q.depthModel.depth,
                     maxActionSpan = q.depthModel.maxActionSpan,
                     maxWndCount = q.depthModel.maxWndCount,
                     minActionSpan = q.depthModel.minActionSpan
                 }
                 ).ToList();
            for (int i = 0; i < dgv_depthInfo.Rows.Count; i++)
                dgv_depthInfo.Rows[i].ReadOnly = true;
            btn_alterAddr.Enabled = true;
            btn_delAddr.Enabled = true;
        }
        public void RefreshAddrInfo()
        {
            FileStream fsr;
            if (!File.Exists(datafileName))
            {
                File.Create(datafileName).Close();
                logOp.writeLog(logfileName, "Data file created.");
                fsr = new FileStream(datafileName, FileMode.Open);
                bf.Serialize(fsr, list_addrInfo);
                fsr.Close();
            }
            fsr = new FileStream(datafileName, FileMode.Open);

            if (fsr.Length <= 0 || fsr == null)
            {
                logOp.writeLog(logfileName, "Read data failed!");
                return;
            }

            list_addrInfo = (List<addrConfig>)bf.Deserialize(fsr);
            fsr.Close();
            dgv_addrInfo.DataSource = (from q in list_addrInfo.AsEnumerable()
                                       select new 
                                       {
                                           guid = q.addrModel.guid,
                                           地址 = q.addrModel.href,
                                           最大深度 = q.addrModel.maxDepth,
                                           最大窗口数 = q.addrModel.maxWndCount,
                                           名称 = q.addrModel.name,
                                           备注 = q.addrModel.notice,
                                           权值 = q.addrModel.priority

                                       }).ToList();
            
            dgv_addrInfo.Columns["guid"].Visible = false;
        }
        public void addAddr(addrConfig model)
        {
            if (model.addrModel.guid != null)
            {
                if (list_addrInfo.Count > 0&&list_addrInfo.Exists(q=> q.addrModel.guid == model.addrModel.guid))
                        throw new Exception("The addr has already existed.");
                if (model.list_depthInfo == null) model.list_depthInfo = new List<DepthInfo>();
                
                list_addrInfo.Add(model);
                saveAddrInfo();
                RefreshAddrInfo();
                logOp.writeLog(logfileName, "New address added.");
                logOp.writeLog(logfileName, model.addrModel.guid.ToString());
                logOp.writeLog(logfileName, model.addrModel.href);
            }
            else throw new Exception("Guid is null.");
        }
        public void alterAddr(addrConfig model)
        {
            if (list_addrInfo.Count > 0)
            {
                if (model.addrModel.guid != Guid.Empty&&list_addrInfo.Exists(q=>q.addrModel.guid==model.addrModel.guid))
                {
                    addrConfig loc_model = list_addrInfo.First(q => q.addrModel.guid == model.addrModel.guid);
                    list_addrInfo.Remove(loc_model);
                    if (model.list_depthInfo == null) model.list_depthInfo = new List<DepthInfo>();

                    list_addrInfo.Add(model);
                    saveAddrInfo();
                    RefreshAddrInfo();
                    logOp.writeLog(logfileName, "Alter address added.");
                    logOp.writeLog(logfileName, model.addrModel.guid.ToString());
                    logOp.writeLog(logfileName, model.addrModel.href);
                }
                else throw new Exception("Guid is empty or the item is not exists (ALTER).");
            }
            else throw new Exception("No members.");
        }
        public void delAddr(addrConfig model)
        {
            if (model.addrModel.guid != Guid.Empty&&list_addrInfo.Exists(q=>q.addrModel.guid==model.addrModel.guid))
            {
                addrConfig loc_model = list_addrInfo.First(q => q.addrModel.guid == model.addrModel.guid);
                list_addrInfo.Remove(loc_model);
                saveAddrInfo();
                RefreshAddrInfo();
                logOp.writeLog(logfileName, "Delete address.");
                logOp.writeLog(logfileName, model.addrModel.guid.ToString());
                logOp.writeLog(logfileName, model.addrModel.href);
            }
            else throw new Exception("Guid is null or the item is not exists (DEL).");
        }
        private void saveAddrInfo()
        {
            FileStream fsr;
            if (!File.Exists(datafileName))
            {
                File.Create(datafileName).Close();
                logOp.writeLog(logfileName, "Data file created.");
            }
            fsr = new FileStream(datafileName, FileMode.Open);
            
            bf.Serialize(fsr, list_addrInfo);
            fsr.Close();
            
            fsr = new FileStream(datafileName, FileMode.Open);

            if (fsr.Length <= 0 || fsr == null)
            {
                logOp.writeLog(logfileName, "Read data failed!");
                fsr.Close();
                return;
            }

            list_addrInfo = (List<addrConfig>)bf.Deserialize(fsr);
            fsr.Close();
        }
        private void Navigate(WebBrowser wb)
        {
            String address = "http://blog.itful.com/";//wb.Url.ToString();
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                wb.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }
        private void btn_addAddr_Click(object sender, EventArgs e)
        {
            addAddr loc_addF = new adsClicke.addAddr();
            loc_addF.ShowDialog(this);
        }
        private void btn_alterAddr_Click(object sender, EventArgs e)
        {
            if (dgv_addrInfo.SelectedRows.Count > 0)
                if (list_addrInfo.Exists(q => q.addrModel.guid.ToString() == dgv_addrInfo.SelectedRows[0].Cells[GVARS.addrKey].Value.ToString()))
                {
                    addAddr loc_addF = new adsClicke.addAddr(list_addrInfo.First(q => q.addrModel.guid.ToString() == dgv_addrInfo.SelectedRows[0].Cells[GVARS.addrKey].Value.ToString()));
                    loc_addF.ShowDialog(this);
                }
                else MessageBox.Show("Not find this addrss Info.","Notice");
        }
        private void btn_delAddr_Click(object sender, EventArgs e)
        {

        }
        public void addDepth(Guid guid,DepthModel model)
        {
            if (list_addrInfo.Count > 0 && list_addrInfo.Exists(q => q.addrModel.guid == guid))
            {
                addrConfig loc_addrConfig = list_addrInfo.First(q => q.addrModel.guid == guid);
                DepthModel loc_depthModel = loc_addrConfig.list_depthInfo.OrderBy(q => q.depthModel.depth).Last().depthModel;
                model.depth = loc_depthModel.depth + 1;
                DepthInfo depthInfo = new DepthInfo();
                depthInfo.depthModel = model;
                depthInfo.list_links = new List<LinkInfo>();
                list_addrInfo[list_addrInfo.FindIndex(q => q.addrModel.guid == guid)].list_depthInfo.Add(depthInfo);
                saveAddrInfo();
                RefreshDepth();
            }
        }
        public void alterDepth(Guid guid, DepthModel model)
        {
            addrConfig loc_addrConfig;
            if (list_addrInfo.Count > 0 && list_addrInfo.Exists(q => q.addrModel.guid == guid))
            {
                loc_addrConfig = list_addrInfo.First(q => q.addrModel.guid == guid);
                if (loc_addrConfig.list_depthInfo != null && loc_addrConfig.list_depthInfo.Count>0 && loc_addrConfig.list_depthInfo.Exists(q => q.depthModel.depth == model.depth))
                {
                    DepthInfo loc_depthInfo = loc_addrConfig.list_depthInfo.First(q => q.depthModel.depth == model.depth);

                    DepthInfo depthInfo = new DepthInfo();
                    depthInfo.depthModel = model;
                    depthInfo.list_links = new List<LinkInfo>();
                    int index = list_addrInfo.FindIndex(q => q.addrModel.guid == guid);
                    list_addrInfo[index].list_depthInfo.Remove(loc_depthInfo);
                    list_addrInfo[index].list_depthInfo.Add(depthInfo);
                    saveAddrInfo();
                    RefreshDepth();
                }
                else
                {
                    if (list_addrInfo.Count > 0 && list_addrInfo.Exists(q => q.addrModel.guid == guid))
                    {
                        loc_addrConfig = list_addrInfo.First(q => q.addrModel.guid == guid);
                        int index = list_addrInfo.IndexOf(loc_addrConfig);
                        if (loc_addrConfig.list_depthInfo == null)
                        {
                            loc_addrConfig.list_depthInfo = new List<DepthInfo>();
                        }
                         
                        DepthModel loc_depthModel;// = loc_addrConfig.list_depthInfo.OrderBy(q => q.depthModel.depth).Last().depthModel;

                        if (loc_addrConfig.list_depthInfo.Count>0)
                        {
                            loc_depthModel = loc_addrConfig.list_depthInfo.OrderBy(q => q.depthModel.depth).Last().depthModel;
                            model.depth = loc_depthModel.depth + 1;
                        }
                        else 
                            model.depth = 1;

                        DepthInfo depthInfo = new DepthInfo();
                        depthInfo.depthModel = model;
                        depthInfo.list_links = new List<LinkInfo>();                     
                        if (loc_addrConfig.list_depthInfo == null)
                        {
                            loc_addrConfig.list_depthInfo.Add(depthInfo);
                            list_addrInfo.RemoveAt(index);
                            list_addrInfo.Insert(index,loc_addrConfig);
                        }
                        list_addrInfo[index].list_depthInfo.Add(depthInfo);
                        saveAddrInfo();
                        RefreshDepth();
                    }
                }
            }
        }
        private void btn_alterDepth_Click(object sender, EventArgs e)
        {
            if (dgv_addrInfo.SelectedRows.Count > 0)
            {
                addrConfig loc_addr=
                    list_addrInfo.First(q => q.addrModel.guid.ToString() == dgv_addrInfo.SelectedRows[0].Cells[GVARS.addrKey].Value.ToString());
                (new editDepth(loc_addr.addrModel.guid,loc_addr.list_depthInfo.Find(q=>q.depthModel.depth.ToString()==dgv_depthInfo.SelectedRows[0].Cells[GVARS.depthKey].Value.ToString()).depthModel)).ShowDialog(this);
            }
            return;
            Button loc_btn = (Button)sender;

            if (dgv_depthInfo.SelectedRows.Count <= 0)
                return;
            dgv_depthInfo.SelectedRows[0].ReadOnly = false;
        }
        private void btn_addDepth_Click(object sender, EventArgs e)
        {
            if (dgv_addrInfo.SelectedRows.Count > 0)
                (new editDepth(list_addrInfo.First(q=>q.addrModel.guid.ToString()== dgv_addrInfo.SelectedRows[0].Cells[GVARS.addrKey].Value.ToString()).addrModel.guid)).ShowDialog(this);
        }
        private void btn_delDepth_Click(object sender, EventArgs e)
        {

        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (dgv_addrInfo.SelectedRows.Count <= 0||!list_addrInfo.Exists(q=>q.addrModel.guid.ToString()==dgv_addrInfo.SelectedRows[0].Cells[GVARS.addrKey].Value.ToString()))
                return;
            addrConfig loc_addConfig = 
            loc_addConfig = list_addrInfo.First(q => q.addrModel.guid.ToString() == dgv_addrInfo.SelectedRows[0].Cells[GVARS.addrKey].Value.ToString());
            list_addrInfo.Remove(loc_addConfig);
            loc_addConfig.list_depthInfo = (List<DepthInfo>)dgv_depthInfo.DataSource;
            RefreshAddrInfo();

        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string sectionName = g_visistConfig.GetType().Name;
            //foreach(var item in g_visistConfig.GetType().GetProperties())
            iniFile.IniWriteValue(sectionName, GVARS.smaxWndCount,nud_maxWndCount.Value.ToString());
            iniFile.IniWriteValue(sectionName, GVARS.smaxDepth, nud_maxDepth.Value.ToString());
            iniFile.IniWriteValue(sectionName, GVARS.sactionSpan, nud_acTimeSpan.Value.ToString());
            iniFile.IniWriteValue(sectionName, GVARS.sshowWnd, cb_showWnd.Checked.ToString());
        }
        private void scanAddr()
        {
            for (int i = 0; i < list_wbInfo.Count(); i++)
                if (
                    list_wbInfo[i].startDate.AddSeconds(list_wbInfo[i].lastDate) < DateTime.Now&&
                    !list_wbInfo.Exists(q=>q.preGuid==list_wbInfo[i].webForm.cur_Guid&&
                    !list_addrInfo.Find(p=>p.addrModel.guid==list_wbInfo[i].webForm.addrGuid).list_depthInfo.Find(p => p.depthModel.depth == list_wbInfo[i].webForm.depth).list_links.Exists(w=>w.visited==0&&w.parent_Guid==list_wbInfo[i].webForm.cur_Guid)
                    )
                    )
                {
                    addrConfig loc_addr = list_addrInfo.Find(p => p.addrModel.guid == list_wbInfo[i].webForm.addrGuid);
                    var loc_links = loc_addr.list_depthInfo.Find(q => q.depthModel.depth == list_wbInfo[i].webForm.depth).list_links.Where(p=>p.parent_Guid== list_wbInfo[i].webForm.cur_Guid);
                    Console.WriteLine("closed url:"+ list_wbInfo[i].webForm.uri.ToString()+" "+"");
                    list_wbInfo[i].webForm.Close();
                    list_wbInfo.RemoveAt(i);
                }
            Random rand = new Random();
            int nextDepthId=-1;//13829617088
            for (int i=0;i<list_addrInfo.Count();i++)
            {
                if (!list_addrInfo[i].actived) continue;

                for (int j=0;j<list_addrInfo[i].list_depthInfo.Count();j++)
                {
                    tag_BrowserInfo wbInfo;
                    if (list_wbInfo.Count(q => q.webForm.depth == list_addrInfo[i].list_depthInfo[j].depthModel.depth) >= list_addrInfo[i].list_depthInfo[j].depthModel.maxWndCount)
                        continue;
                    for (int k=0;k<list_addrInfo[i].list_depthInfo[j].list_links.Count();k++)
                    {
                        if (list_wbInfo.Count()>=g_visistConfig.maxWndCount||list_addrInfo[i].list_depthInfo[j].list_links[k].visited == 1 || list_addrInfo[i].list_depthInfo[j].list_links[k].visitDate > DateTime.Now|| list_wbInfo.Count(q => q.webForm.depth == list_addrInfo[i].list_depthInfo[j].depthModel.depth) >= list_addrInfo[i].list_depthInfo[j].depthModel.maxWndCount)
                            continue;                      
                        wbInfo = new tag_BrowserInfo();
                        nextDepthId = list_addrInfo[i].list_depthInfo.FindIndex(q=>q.depthModel.depth==(list_addrInfo[i].list_depthInfo[j].depthModel.depth+1));
                        if(nextDepthId>=0)
                        wbInfo.webForm = new webBrowser(new Uri(list_addrInfo[i].list_depthInfo[j].list_links[k].href), list_addrInfo[i].addrModel.guid, list_addrInfo[i].list_depthInfo[nextDepthId].depthModel.prefix, list_addrInfo[i].list_depthInfo[nextDepthId].depthModel.depth);
                        else
                            wbInfo.webForm = new webBrowser(new Uri(list_addrInfo[i].list_depthInfo[j].list_links[k].href), list_addrInfo[i].addrModel.guid, list_addrInfo[i].list_depthInfo[j].depthModel.prefix, list_addrInfo[i].list_depthInfo[j].depthModel.depth);
                        wbInfo.startDate = DateTime.Now;
                        wbInfo.preGuid = list_addrInfo[i].list_depthInfo[j].list_links[k].parent_Guid;
                        wbInfo.lastDate = (ulong)(list_addrInfo[i].list_depthInfo[j].depthModel.minLastTime + rand.Next() % (list_addrInfo[i].list_depthInfo[j].depthModel.maxLastTime - list_addrInfo[i].list_depthInfo[j].depthModel.minLastTime));
                        list_wbInfo.Add(wbInfo);
                        list_addrInfo[i].list_depthInfo[j].list_links[k].visited = 1;
                        Console.WriteLine("visited:" + list_addrInfo[i].list_depthInfo[j].list_links.Count(q => q.visited == 1));
                        Console.WriteLine("not visit:" + list_addrInfo[i].list_depthInfo[j].list_links.Count(q => q.visited == 0));
                        if (g_visistConfig.showWnd)
                            wbInfo.webForm.Show(this);
                        return;
                    }
                }
            }
        }
        public void browserCompleted(Guid addrGuid,int depth,List<LinkInfo> list_links)
        {
            //List<LinkInfo> loc_adas = list_links.AsEnumerable().Where(q=>q.href.StartsWith("http://www.so.com/s?src=")).ToList();
            //return;
            if (addrGuid != Guid.Empty && list_addrInfo != null && list_addrInfo.Count > 0)
            {
                if (list_addrInfo.Exists(q => q.addrModel.guid == addrGuid))
                {
                    addrConfig loc_addrConfig = list_addrInfo.Find(q => q.addrModel.guid == addrGuid);
                    int addrIndex = list_addrInfo.FindIndex(q => q.addrModel.guid == addrGuid);
                    if (list_addrInfo[addrIndex].list_depthInfo == null || list_addrInfo[addrIndex].list_depthInfo.Count() <= 0 || !list_addrInfo[addrIndex].list_depthInfo.Exists(q => q.depthModel.depth == depth))
                    {
                        logOp.writeLog(logfileName, "Depth info error.Guid:" + addrGuid.ToString());
                        throw new Exception("Depth info error.");
                    }

                    int depthIndex = list_addrInfo[addrIndex].list_depthInfo.FindIndex(q => q.depthModel.depth == depth);

                    if (list_addrInfo[addrIndex].list_depthInfo[depthIndex].list_links == null)
                    {
                        DepthInfo loc_depthInfo = list_addrInfo[addrIndex].list_depthInfo[depthIndex];
                        loc_depthInfo.list_links = new List<LinkInfo>();
                        list_addrInfo[addrIndex].list_depthInfo.RemoveAt(depthIndex);
                        list_addrInfo[addrIndex].list_depthInfo.Insert(depthIndex, loc_depthInfo);
                    }
                    //list_addrInfo[addrIndex].list_depthInfo[depthIndex].list_links.Clear();

                    Random rand = new Random();
                    if(list_links.Count()>0)
                        list_links[0].visitDate =
                            DateTime.
                            Now.
                            AddSeconds(list_addrInfo[addrIndex].list_depthInfo[depthIndex].depthModel.minActionSpan
                            +
                            rand.Next() % (list_addrInfo[addrIndex].list_depthInfo[depthIndex].depthModel.maxActionSpan - list_addrInfo[addrIndex].list_depthInfo[depthIndex].depthModel.minActionSpan));

                    for (int i=1;i<list_links.Count();i++)
                        list_links[i].visitDate =
                            list_links[i-1].visitDate.
                            AddSeconds(list_addrInfo[addrIndex].list_depthInfo[depthIndex].depthModel.minActionSpan
                            +
                            rand.Next()% (list_addrInfo[addrIndex].list_depthInfo[depthIndex].depthModel.maxActionSpan- list_addrInfo[addrIndex].list_depthInfo[depthIndex].depthModel.minActionSpan));
                    if(list_addrInfo[addrIndex].list_depthInfo[depthIndex].depthModel.visitTimesLimit> list_addrInfo[addrIndex].list_depthInfo[depthIndex].list_links.Count())
                    if (list_addrInfo[addrIndex].list_depthInfo[depthIndex].depthModel.maxWndCount >= list_links.Count)
                    {
                        foreach(LinkInfo item in list_links)
                            if(!list_addrInfo[addrIndex].list_depthInfo[depthIndex].list_links.Exists(q => q.href == item.href))
                                list_addrInfo[addrIndex].list_depthInfo[depthIndex].list_links.Insert(0, item); //list_links;
                    }
                    else if (list_links.Count() > 0 && list_addrInfo[addrIndex].list_depthInfo.Count() >= depth)
                    {
                        LinkInfo linkInfo;
                        for (int i = 0; i < list_addrInfo[addrIndex].list_depthInfo[depthIndex].depthModel.maxWndCount&& list_addrInfo[addrIndex].list_depthInfo[depthIndex].depthModel.visitTimesLimit > list_addrInfo[addrIndex].list_depthInfo[depthIndex].list_links.Count(); i++)
                        {
                            linkInfo = list_links[rand.Next() % list_links.Count()];
                            if (!list_addrInfo[addrIndex].list_depthInfo[depthIndex].list_links.Exists(q => q.href == linkInfo.href))
                                list_addrInfo[addrIndex].list_depthInfo[depthIndex].list_links.Add(linkInfo);

                            list_links.Remove(linkInfo);
                        }
                    }
                }
            }
        }

        private void btn_startWork_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = true;
            bol_pause = !bol_pause;
            btn_startWork.Text = bol_pause ? "启动" : "暂停";
            btn.Enabled = true;
        }
    }
}
