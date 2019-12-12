using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32Desktop : CIMSetting
    {
        public Win32Desktop()
        {
        }

        public Win32Desktop(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? BorderWidth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BorderWidth", out result);
                return result;
            }
        }

        public System.Boolean? CoolSwitch
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("CoolSwitch", out result);
                return result;
            }
        }

        public System.UInt32? CursorBlinkRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CursorBlinkRate", out result);
                return result;
            }
        }

        public System.Boolean? DragFullWindows
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DragFullWindows", out result);
                return result;
            }
        }

        public System.UInt32? GridGranularity
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("GridGranularity", out result);
                return result;
            }
        }

        public System.UInt32? IconSpacing
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IconSpacing", out result);
                return result;
            }
        }

        public System.String IconTitleFaceName
        {
            get
            {
                System.String result;
                this.GetProperty("IconTitleFaceName", out result);
                return result;
            }
        }

        public System.UInt32? IconTitleSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IconTitleSize", out result);
                return result;
            }
        }

        public System.Boolean? IconTitleWrap
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IconTitleWrap", out result);
                return result;
            }
        }

        public System.String Name
        {
            get
            {
                System.String result;
                this.GetProperty("Name", out result);
                return result;
            }
        }

        public System.String Pattern
        {
            get
            {
                System.String result;
                this.GetProperty("Pattern", out result);
                return result;
            }
        }

        public System.Boolean? ScreenSaverActive
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ScreenSaverActive", out result);
                return result;
            }
        }

        public System.String ScreenSaverExecutable
        {
            get
            {
                System.String result;
                this.GetProperty("ScreenSaverExecutable", out result);
                return result;
            }
        }

        public System.Boolean? ScreenSaverSecure
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ScreenSaverSecure", out result);
                return result;
            }
        }

        public System.UInt32? ScreenSaverTimeout
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ScreenSaverTimeout", out result);
                return result;
            }
        }

        public System.String Wallpaper
        {
            get
            {
                System.String result;
                this.GetProperty("Wallpaper", out result);
                return result;
            }
        }

        public System.Boolean? WallpaperStretched
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("WallpaperStretched", out result);
                return result;
            }
        }

        public System.Boolean? WallpaperTiled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("WallpaperTiled", out result);
                return result;
            }
        }

        public Win32UserAccount ResolveWin32UserDesktopElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_UserDesktop", "Win32_UserAccount", "Setting", "Element");
            return instances.Select(i => (Win32UserAccount)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32ComputerSystem ResolveWin32SystemDesktopElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemDesktop", "Win32_ComputerSystem", "Setting", "Element");
            return instances.Select(i => (Win32ComputerSystem)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}