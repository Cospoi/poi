using System;
using System.Collections.Generic;
using System.Text;
using Marieyr.Yuki.Localization;
using Volo.Abp.Application.Services;

namespace Marieyr.Yuki
{
    /* Inherit your application services from this class.
     */
    public abstract class YukiAppService : ApplicationService
    {
        protected YukiAppService()
        {
            LocalizationResource = typeof(YukiResource);
        }
    }
}
