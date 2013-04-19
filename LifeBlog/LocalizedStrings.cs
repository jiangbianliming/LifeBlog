using LifeBlog.Resources;

namespace LifeBlog
{
    /// <summary>
    /// 提供对字符串资源的访问权。
    /// </summary>
    public class LocalizedStrings
    {
        private static AppResources _localizedResources = new AppResources();


        const int  d = 0;
        public AppResources LocalizedResources { get { return _localizedResources; } }
    }
}