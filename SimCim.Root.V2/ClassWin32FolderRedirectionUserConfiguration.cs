using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32FolderRedirectionUserConfiguration : GenericInfrastructureObject
    {
        public Win32FolderRedirectionUserConfiguration()
        {
        }

        public Win32FolderRedirectionUserConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32FolderRedirection AppDataRoaming
        {
            get
            {
                Win32FolderRedirection result;
                this.GetInfrastructureObjectProperty("AppDataRoaming", out result);
                return result;
            }

            set
            {
                this.SetProperty("AppDataRoaming", value);
            }
        }

        public Win32FolderRedirection Contacts
        {
            get
            {
                Win32FolderRedirection result;
                this.GetInfrastructureObjectProperty("Contacts", out result);
                return result;
            }

            set
            {
                this.SetProperty("Contacts", value);
            }
        }

        public Win32FolderRedirection Desktop
        {
            get
            {
                Win32FolderRedirection result;
                this.GetInfrastructureObjectProperty("Desktop", out result);
                return result;
            }

            set
            {
                this.SetProperty("Desktop", value);
            }
        }

        public Win32FolderRedirection Documents
        {
            get
            {
                Win32FolderRedirection result;
                this.GetInfrastructureObjectProperty("Documents", out result);
                return result;
            }

            set
            {
                this.SetProperty("Documents", value);
            }
        }

        public Win32FolderRedirection Downloads
        {
            get
            {
                Win32FolderRedirection result;
                this.GetInfrastructureObjectProperty("Downloads", out result);
                return result;
            }

            set
            {
                this.SetProperty("Downloads", value);
            }
        }

        public Win32FolderRedirection Favorites
        {
            get
            {
                Win32FolderRedirection result;
                this.GetInfrastructureObjectProperty("Favorites", out result);
                return result;
            }

            set
            {
                this.SetProperty("Favorites", value);
            }
        }

        public System.Boolean? IsConfiguredByWMI
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsConfiguredByWMI", out result);
                return result;
            }
        }

        public Win32FolderRedirection Links
        {
            get
            {
                Win32FolderRedirection result;
                this.GetInfrastructureObjectProperty("Links", out result);
                return result;
            }

            set
            {
                this.SetProperty("Links", value);
            }
        }

        public Win32FolderRedirection Music
        {
            get
            {
                Win32FolderRedirection result;
                this.GetInfrastructureObjectProperty("Music", out result);
                return result;
            }

            set
            {
                this.SetProperty("Music", value);
            }
        }

        public Win32FolderRedirection Pictures
        {
            get
            {
                Win32FolderRedirection result;
                this.GetInfrastructureObjectProperty("Pictures", out result);
                return result;
            }

            set
            {
                this.SetProperty("Pictures", value);
            }
        }

        public System.Boolean? PrimaryComputerEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PrimaryComputerEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("PrimaryComputerEnabled", value);
            }
        }

        public Win32FolderRedirection SavedGames
        {
            get
            {
                Win32FolderRedirection result;
                this.GetInfrastructureObjectProperty("SavedGames", out result);
                return result;
            }

            set
            {
                this.SetProperty("SavedGames", value);
            }
        }

        public Win32FolderRedirection Searches
        {
            get
            {
                Win32FolderRedirection result;
                this.GetInfrastructureObjectProperty("Searches", out result);
                return result;
            }

            set
            {
                this.SetProperty("Searches", value);
            }
        }

        public Win32FolderRedirection StartMenu
        {
            get
            {
                Win32FolderRedirection result;
                this.GetInfrastructureObjectProperty("StartMenu", out result);
                return result;
            }

            set
            {
                this.SetProperty("StartMenu", value);
            }
        }

        public Win32FolderRedirection Videos
        {
            get
            {
                Win32FolderRedirection result;
                this.GetInfrastructureObjectProperty("Videos", out result);
                return result;
            }

            set
            {
                this.SetProperty("Videos", value);
            }
        }
    }
}