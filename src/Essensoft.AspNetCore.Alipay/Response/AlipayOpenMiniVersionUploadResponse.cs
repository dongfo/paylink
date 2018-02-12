using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniVersionUploadResponse.
    /// </summary>
    public class AlipayOpenMiniVersionUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 构建的状态，0-构建排队中；1-正在构建；2-构建成功；3-构建失败；5-构建超时
        /// </summary>
        [JsonProperty("build_status")]
        public string BuildStatus { get; set; }

        /// <summary>
        /// 创建版本的状态，0-构建排队中；1-正在构建；2-构建成功；3-构建失败；5-构建超时；6-版本创建成功
        /// </summary>
        [JsonProperty("create_status")]
        public string CreateStatus { get; set; }

        /// <summary>
        /// 是否需要轮询
        /// </summary>
        [JsonProperty("need_rotation")]
        public string NeedRotation { get; set; }

        /// <summary>
        /// 是否创建了版本
        /// </summary>
        [JsonProperty("version_created")]
        public string VersionCreated { get; set; }
    }
}
