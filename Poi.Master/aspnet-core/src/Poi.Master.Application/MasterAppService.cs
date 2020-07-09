using System;
using System.Collections.Generic;
using System.Text;
using Poi.Master.Localization;
using Volo.Abp.Application.Services;

namespace Poi.Master
{
    /* Inherit your application services from this class.
     */
    public abstract class MasterAppService : ApplicationService
    {
        protected MasterAppService()
        {
            LocalizationResource = typeof(MasterResource);
        }
    }
}
