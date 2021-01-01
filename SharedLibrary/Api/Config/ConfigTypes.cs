namespace SharedLibrary.Api.Config
{
    /// <summary>
    /// 定义了进行配置文件操作时需要使用的常量
    /// </summary>
    public static class ConfigTypes
    {
        /// <summary>
        /// 代表受控端
        /// </summary>
        public static readonly int CONFIG_CONTROLLED_END = 0;
        /// <summary>
        /// 代表控制台
        /// </summary>
        public static readonly int CONFIG_CONSOLE = 1;
        /// <summary>
        /// 代表服务端
        /// </summary>
        public static readonly int CONFIG_SERVER = 2;
    }
}
