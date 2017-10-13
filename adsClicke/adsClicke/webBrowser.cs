using mshtml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adsClicke
{
    public partial class webBrowser : Form
    {
        public Uri uri;
        public Guid addrGuid;
        public uint depth;
        public bool Finished = false;
        List<LinkInfo> list_linkinfo = new List<LinkInfo>();
        private string prefix;
        public Guid cur_Guid;
        public webBrowser(Uri _uri,Guid _addrGuid,string _prefix,uint _depth=1)
        {
            prefix = _prefix;
            addrGuid = _addrGuid;
            depth = _depth;
            uri = _uri;
            cur_Guid = Guid.NewGuid();
            InitializeComponent();
            Inital();
            Console.WriteLine("cur_url:"+_uri.ToString()+" prefix:"+_prefix+" depth:"+_depth);
        }
        private void Inital()
        {

            wb.Url = uri;
            SHDocVw.WebBrowser wb1 = (SHDocVw.WebBrowser)wb.ActiveXInstance;
            wb1.BeforeNavigate2 += Wb1_BeforeNavigate2;
            wb1.NavigateComplete2 += Wb1_NavigateComplete2;
            wb.DocumentCompleted += Wb_DocumentCompleted;
            wb.NewWindow += Wb_NewWindow;         
        }

        private void Wb_NewWindow(object sender, CancelEventArgs e)
        {

            e.Cancel = true;
        }

        private void Wb1_NavigateComplete2(object pDisp, ref object URL)
        {
            IHTMLDocument2 doc = (wb.ActiveXInstance as SHDocVw.WebBrowser).Document as IHTMLDocument2;
            if ( doc.body != null)
            {
                SHDocVw.WebBrowser wb3 = (SHDocVw.WebBrowser)pDisp;
                HTMLDocument doc2 = (HTMLDocument)wb3.Document;
                #region  click A
                //var k = (IHTMLElementCollection)doc2.links.tags("A");
                //var mi = ((IHTMLElement)doc2.links.item(null, 0)).GetType().GetMethod("click");
                //mi.Invoke(((IHTMLElement)doc2.links.item(null, 0)), null);//new object[0]);
                #endregion
                LinkInfo loc_linkInfo;
                foreach (HTMLAnchorElementClass item in doc2.links)
                {
                    //Console.WriteLine(item.href);
                    if (list_linkinfo.Exists(q => q.href.ToLower() == item.href.ToLower())||!item.href.StartsWith(prefix)) continue;
                   
                    loc_linkInfo = new LinkInfo();
                    loc_linkInfo.href = item.href;
                    loc_linkInfo.tag = item.tagName;
                    loc_linkInfo.visited = 0;
                    loc_linkInfo.innerText = item.innerText;
                    loc_linkInfo.parent_Guid = this.cur_Guid;
                    list_linkinfo.Add(loc_linkInfo);
                }
                if (depth == 3)
                    Console.WriteLine("count(3):" + list_linkinfo.Count());
            }           
        }

        private void Wb1_BeforeNavigate2(object pDisp, ref object URL, ref object Flags, ref object TargetFrameName, ref object PostData, ref object Headers, ref bool Cancel)
        {
            string postDataText="";
            if((PostData as byte[])!=null)
             postDataText = System.Text.Encoding.ASCII.GetString(PostData as byte[]);
            string aaa = "";
        }



        private void Wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            #region old Code
            WebBrowser wb = (WebBrowser)sender;
            if (wb.ReadyState != WebBrowserReadyState.Complete) return;

            LinkInfo loc_lf;
            //HtmlElementCollection hec = wb.Document.Links;
            HTMLAnchorElementClass link;
            for (int i = 0; i < wb.Document.Links.Count; i++)
            {
                try {
                    link = (HTMLAnchorElementClass)wb.Document.Links[i].DomElement;
                }
                catch (Exception) { continue; }
                if (list_linkinfo.Exists(p => p.href == link.href)|| !link.href.StartsWith(prefix))
                    continue;
                loc_lf = new LinkInfo();

                loc_lf.tag = link.tagName;
                loc_lf.innerText = link.innerText;
                loc_lf.href = link.href;
                loc_lf.visited = 0;
                loc_lf.parent_Guid = this.cur_Guid;
                list_linkinfo.Add(loc_lf);
            }
            //List<LinkInfo> loc_adas = list_linkinfo.AsEnumerable().Where(q => q.href.StartsWith("http://www.so.com/s?src=")).ToList();
            ////if (loc_adas.Count>0)
            ////wb.DocumentCompleted -= new WebBrowserDocumentCompletedEventHandler(Wb_DocumentCompleted);
            //Console.WriteLine(list_linkinfo.Count().ToString() + "\t");
            //string khk = "";
            #endregion
            //string url = e.Url.ToString();
            int count = list_linkinfo.Count();
            Console.WriteLine(e.Url.ToString()+"\t:"+ list_linkinfo.Count());
            if (depth == 3)
                Console.WriteLine("count(3):" +list_linkinfo.Count());
            ((Form1)Owner).browserCompleted(addrGuid, (int)depth, list_linkinfo);
        }

        private void btn_getCT_Click(object sender, EventArgs e)
        {
            List<LinkInfo> list_linkinfo = new List<LinkInfo>();
            
            if (wb.ReadyState != WebBrowserReadyState.Complete) return;

            LinkInfo loc_lf;
            //HtmlElementCollection hec = wb.Document.Links;
            HTMLAnchorElementClass link;
            for (int i = 0; i < wb.Document.Links.Count; i++)
            {
                link = (HTMLAnchorElementClass)wb.Document.Links[i].DomElement;

                if (list_linkinfo.Exists(p => p.href == link.href))
                    continue;
                loc_lf = new LinkInfo();

                loc_lf.tag = link.tagName;
                loc_lf.innerText = link.innerText;
                loc_lf.href = link.href;
                loc_lf.visited = 0;
                list_linkinfo.Add(loc_lf);
            }
            var ejahi = wb.Document.Window.Frames;
            string outhtml = wb.Document.Body.OuterHtml;
            var windows = wb.Document.Body.GetElementsByTagName("IFRAME");
            //var windows = wb.Document.Window;

            //HtmlWindow real = (mshtml.HTMLIFrameClass)(windows[2].DomElement);
            //wb.Url = new Uri("http://api.so.lianmeng.360.cn/searchthrow/api/ads/throw?ls=s4e6a6cc694&w=635&h=150&inject=1&pos=0&rurl=http%3A%2F%2Fwww.aikeya020.com%2F&pn=0&prt=1462502056889&tit=%E5%87%BA%E5%9B%BD%E7%A7%BB%E6%B0%91%E7%BD%91%20-%20%E5%90%84%E5%9B%BD%E5%87%BA%E5%9B%BD%E7%A7%BB%E6%B0%91%E8%B5%84%E8%AE%AF&pt=1462502056887&cw=1255&dpr=1&jv=1437124819535&inlay=0&link=45&rank=25&imagelink=4&searchlink=15&imagetext=0%2C0");
            //wb.Url = new Uri("http://www.baidu.com");
            var khkn = wb.Document.Body.All;
            var jh = wb.Document.Links;
            foreach (HtmlElement item in jh)
                if (item.OuterHtml!=null && item.OuterHtml.Contains("http://e.tf.360.cn/search/eclk?"))
                    Console.WriteLine(item.OuterHtml);
            List<LinkInfo> loc_adas = list_linkinfo.AsEnumerable().Where(q => q.href.StartsWith("https://e.tf.360.cn/search/eclk?")).ToList();

            HtmlDocument objDoc = wb.Document;
            foreach (HtmlElement element in objDoc.Body.All)
            {
                if (element.TagName.ToLower().Equals("iframe"))
                {
                    foreach (HtmlElement child in element.All)
                    {

                        if (child.OuterText.Contains("http://e.tf.360.cn/search/eclk?"))
                            Console.WriteLine(child.OuterText);

                        string text = child.GetAttribute("type").ToLower();
                        if (text == "radio" || text == "checkbox")
                        {
                            child.SetAttribute("checked", "checked");
                        }
                    }
                }

            }


            if (loc_adas.Count > 0)
                wb.DocumentCompleted -= new WebBrowserDocumentCompletedEventHandler(Wb_DocumentCompleted);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Console.WriteLine("");
            this.wb.Refresh();
        }
    }
}
