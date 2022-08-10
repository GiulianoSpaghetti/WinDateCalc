using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace WinDateCalc
{
    public class MyUserSettings : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValue("")]
        public DateTime data
        {            get
            {
                return ((DateTime)this["data"]);
            }
            set
            {
                this["data"] = value;
            }
        }
    }
}
