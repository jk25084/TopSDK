using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.ECS.ECS20130110.Response
{
    /// <summary>
    /// CreateSnapshotResponse.
    /// </summary>
    public class CreateSnapshotResponse : AliyunResponse
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// 快照ID
        /// </summary>
        [XmlElement("SnapshotId")]
        public string SnapshotId { get; set; }
    }
}
