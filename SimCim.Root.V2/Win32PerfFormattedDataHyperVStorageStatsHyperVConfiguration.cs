using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataHyperVStorageStatsHyperVConfiguration : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataHyperVStorageStatsHyperVConfiguration()
        {
        }

        public Win32PerfFormattedDataHyperVStorageStatsHyperVConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Cacheupdateaveragemilliseconds
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Cacheupdateaveragemilliseconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("Cacheupdateaveragemilliseconds", value);
            }
        }

        public System.UInt32? Cacheupdatecount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Cacheupdatecount", out result);
                return result;
            }

            set
            {
                this.SetProperty("Cacheupdatecount", value);
            }
        }

        public System.UInt32? Commitaveragemilliseconds
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Commitaveragemilliseconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("Commitaveragemilliseconds", value);
            }
        }

        public System.UInt32? Commitbytespersecondaverage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Commitbytespersecondaverage", out result);
                return result;
            }

            set
            {
                this.SetProperty("Commitbytespersecondaverage", value);
            }
        }

        public System.UInt32? Commitcount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Commitcount", out result);
                return result;
            }

            set
            {
                this.SetProperty("Commitcount", value);
            }
        }

        public System.UInt32? Compactaveragemilliseconds
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Compactaveragemilliseconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("Compactaveragemilliseconds", value);
            }
        }

        public System.UInt32? Compactcount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Compactcount", out result);
                return result;
            }

            set
            {
                this.SetProperty("Compactcount", value);
            }
        }

        public System.UInt32? Configlockacquireaveragemilliseconds
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Configlockacquireaveragemilliseconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("Configlockacquireaveragemilliseconds", value);
            }
        }

        public System.UInt32? Configlockcount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Configlockcount", out result);
                return result;
            }

            set
            {
                this.SetProperty("Configlockcount", value);
            }
        }

        public System.UInt32? Filelockacquireaveragemilliseconds
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Filelockacquireaveragemilliseconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("Filelockacquireaveragemilliseconds", value);
            }
        }

        public System.UInt32? Filelockreleaseaveragemilliseconds
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Filelockreleaseaveragemilliseconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("Filelockreleaseaveragemilliseconds", value);
            }
        }

        public System.UInt32? Getaveragemilliseconds
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Getaveragemilliseconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("Getaveragemilliseconds", value);
            }
        }

        public System.UInt32? Getcount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Getcount", out result);
                return result;
            }

            set
            {
                this.SetProperty("Getcount", value);
            }
        }

        public System.UInt32? Loadfileaveragemilliseconds
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Loadfileaveragemilliseconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("Loadfileaveragemilliseconds", value);
            }
        }

        public System.UInt32? Lockacquireaveragemilliseconds
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Lockacquireaveragemilliseconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("Lockacquireaveragemilliseconds", value);
            }
        }

        public System.UInt32? Lockcount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Lockcount", out result);
                return result;
            }

            set
            {
                this.SetProperty("Lockcount", value);
            }
        }

        public System.UInt32? Lockreleaseaveragemilliseconds
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Lockreleaseaveragemilliseconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("Lockreleaseaveragemilliseconds", value);
            }
        }

        public System.UInt32? Querysizeaveragesizemilliseconds
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Querysizeaveragesizemilliseconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("Querysizeaveragesizemilliseconds", value);
            }
        }

        public System.UInt32? Querysizecount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Querysizecount", out result);
                return result;
            }

            set
            {
                this.SetProperty("Querysizecount", value);
            }
        }

        public System.UInt32? Readbytes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Readbytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("Readbytes", value);
            }
        }

        public System.UInt32? Readbytespersecondaverage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Readbytespersecondaverage", out result);
                return result;
            }

            set
            {
                this.SetProperty("Readbytespersecondaverage", value);
            }
        }

        public System.UInt32? Readfilebytes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Readfilebytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("Readfilebytes", value);
            }
        }

        public System.UInt32? Readfilebytespersecondaverage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Readfilebytespersecondaverage", out result);
                return result;
            }

            set
            {
                this.SetProperty("Readfilebytespersecondaverage", value);
            }
        }

        public System.UInt32? Readfilecount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Readfilecount", out result);
                return result;
            }

            set
            {
                this.SetProperty("Readfilecount", value);
            }
        }

        public System.UInt32? Removeaveragemilliseconds
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Removeaveragemilliseconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("Removeaveragemilliseconds", value);
            }
        }

        public System.UInt32? Removecount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Removecount", out result);
                return result;
            }

            set
            {
                this.SetProperty("Removecount", value);
            }
        }

        public System.UInt32? Setaveragemilliseconds
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Setaveragemilliseconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("Setaveragemilliseconds", value);
            }
        }

        public System.UInt32? Setcount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Setcount", out result);
                return result;
            }

            set
            {
                this.SetProperty("Setcount", value);
            }
        }

        public System.UInt32? Writebytes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Writebytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("Writebytes", value);
            }
        }

        public System.UInt32? Writebytespersecondaverage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Writebytespersecondaverage", out result);
                return result;
            }

            set
            {
                this.SetProperty("Writebytespersecondaverage", value);
            }
        }

        public System.UInt32? Writefilebytes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Writefilebytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("Writefilebytes", value);
            }
        }

        public System.UInt32? Writefilecount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Writefilecount", out result);
                return result;
            }

            set
            {
                this.SetProperty("Writefilecount", value);
            }
        }
    }
}