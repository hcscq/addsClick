using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adsClicke
{
    [Serializable]
    public class LinkInfo
    {
        public string href { get; set; }
        public string tag { get; set; }
        //public int depth { get; set; }
        public string innerText { get; set; }
        public int visited { get; set; }
        public DateTime visitDate { get; set; }
        public Guid parent_Guid { get; set; }
    }
    [Serializable]
    public struct DepthInfo
    {
        //public string prefix { get; set; }
        public List<LinkInfo> list_links { get; set; }
        public DepthModel depthModel;
        //public uint depth { get; set; }
        //public uint maxWndCount { get; set; }
        //public uint minActionSpan { get; set; }
        //public uint maxActionSpan { get; set; }


    }
    [Serializable]
    public struct visistConfig
    {
        public uint actionSpan { get; set; }
        public uint maxWndCount { get; set; }
        public uint maxDepth { get; set; }
        public bool showWnd { get; set; }
    }
    [Serializable]
    public struct addrConfig
    {
        //public Guid guid { get; set; }
        //public string href { get; set; }
        //public uint maxDepth { get; set; }
        //public string name { get; set; }
        //public string notice { get; set; }
        //public uint priority { get; set; }
        //public uint maxWndCount { get; set; }
        public bool actived { get; set; }
        public addrModel addrModel;
        public List<DepthInfo> list_depthInfo{ get; set; }
    }
    [Serializable]
    public struct addrModel
    {
        public Guid guid { get; set; }
        public string href { get; set; }
        public uint maxDepth { get; set; }
        public string name { get; set; }
        public string notice { get; set; }
        public uint priority { get; set; }
        public uint maxWndCount { get; set; }
        public uint leastVisitTS { get; set; }
        public DateTime lastVisitDate { get; set; }
    }
    [Serializable]
    public struct DepthModel
    {
        public string prefix { get; set; }
        public uint depth { get; set; }
        public uint maxWndCount { get; set; }
        public uint minActionSpan { get; set; }
        public uint maxActionSpan { get; set; }
        public uint minLastTime { get; set; }
        public uint maxLastTime { get; set; }
        public uint visitTimesLimit { get; set; }

    }
    public struct tag_BrowserInfo
    {
        public webBrowser webForm;
        public DateTime startDate;
        public ulong lastDate;
        public Guid preGuid;
    }
    class GVARS
    {
        public const string sactionSpan = "actionSpan";
        public const string smaxWndCount = "maxWndCount";
        public const string smaxDepth = "maxDepth";
        public const string sshowWnd = "showWnd";

        public const string addrKey = "guid";
        public const string depthKey = "depth";
        public const uint minActionSpan = 2;//maxWndCount
        public const uint maxWndCount = 10;//maxWndCount
        public const uint maxDepth = 10;//maxWndCount
        public const bool showWnd = false;
    }
}
