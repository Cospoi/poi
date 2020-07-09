using System;
using System.Collections.Generic;
using System.Text;
using Cospoi.Gopick.Localization;
using Volo.Abp.Application.Services;

namespace Cospoi.Gopick
{
    /* Inherit your application services from this class.
     */
    public abstract class GopickAppService : ApplicationService
    {
        protected GopickAppService()
        {
            LocalizationResource = typeof(GopickResource);
        }
    }
}
