using System;
using System.Collections.Generic;
using Aliyun.Api.ECS.ECS20140526.Response;
using Top.Api.Util;
using Top.Api;

namespace Aliyun.Api.ECS.ECS20140526.Request
{	
    
    /// <summary>
    /// TOP API: ecs.aliyuncs.com.ModifyDiskAttribute.2014-05-26
    /// </summary>
    public class ModifyDiskAttributeRequest : IAliyunRequest<ModifyDiskAttributeResponse>
    {
        /// <summary>
        /// 删除实例的时候是否删除此磁盘
        /// </summary>
        public Nullable<bool> DeleteWithInstance { get; set; }

        /// <summary>
        /// 磁盘描述，不填则保持原值，默认值为空，[0,256]英文或中文字符，磁盘描述会展示在控制台。不能以http://和https://开头。
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 磁盘ID
        /// </summary>
        public string DiskId { get; set; }

        /// <summary>
        /// 磁盘名称，不填则原值，默认值为空，[0,128]英文或中文字符，磁盘名称会展示在控制台。不能以http://和https://开头。
        /// </summary>
        public string DiskName { get; set; }

    
    	/// <summary>
    	///仅用于渠道商发起API调用时，指定访问的资源拥有者的ID
    	/// </summary>
        public string OwnerId { get; set; }
        
        /// <summary>
    	///仅用于渠道商发起API调用时，指定访问的资源拥有者的账号
    	/// </summary>
    	public string OwnerAccount { get; set; }
    	
    	/// <summary>
    	///API调用者试图通过API调用来访问别人拥有但已经授权给他的资源时，通过使用该参数来声明此次操作涉及到的资源是谁名下的.该参数仅官网用户可用
    	/// </summary>
    	public string ResourceOwnerAccount { get; set; }
    	
        private IDictionary<string, string> otherParameters;

        #region IAliyunRequest Members

        public string GetApiName()
        {
            return "ecs.aliyuncs.com.ModifyDiskAttribute.2014-05-26";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("OwnerId", this.OwnerId);
            parameters.Add("OwnerAccount", this.OwnerAccount);
            parameters.Add("ResourceOwnerAccount", this.ResourceOwnerAccount);
            parameters.Add("DeleteWithInstance", this.DeleteWithInstance);
            parameters.Add("Description", this.Description);
            parameters.Add("DiskId", this.DiskId);
            parameters.Add("DiskName", this.DiskName);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("DiskId", this.DiskId);
        }

        #endregion

        public void AddOtherParameter(string key, string value)
        {
            if (this.otherParameters == null)
            {
                this.otherParameters = new TopDictionary();
            }
            this.otherParameters.Add(key, value);
        }
        
    }
}
