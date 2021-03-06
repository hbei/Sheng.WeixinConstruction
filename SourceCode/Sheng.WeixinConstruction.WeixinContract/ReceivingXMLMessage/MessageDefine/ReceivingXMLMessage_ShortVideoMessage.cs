﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sheng.WeixinConstruction.WeixinContract
{
    /// <summary>
    /// 视频消息
    /// </summary>
     [XmlRootAttribute("xml")]
    public class ReceivingXMLMessage_ShortVideoMessage : ReceivingXMLMessageBase
    {
        /// <summary>
        /// 视频消息媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        [XmlElement("MediaId")]
        public string MediaId
        {
            get;
            set;
        }

        /// <summary>
        /// 视频消息缩略图的媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        [XmlElement("ThumbMediaId")]
        public string ThumbMediaId
        {
            get;
            set;
        }

        /// <summary>
        /// 接收普通消息时有
        /// </summary>
        [XmlElement("MsgId")]
        public long MsgId
        {
            get;
            set;
        }
    }
}
