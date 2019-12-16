using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersPowerShellWorkflow : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersPowerShellWorkflow()
        {
        }

        public Win32PerfFormattedDataCountersPowerShellWorkflow(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ActivityHostManagerhostprocessespoolsize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActivityHostManagerhostprocessespoolsize", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActivityHostManagerhostprocessespoolsize", value);
            }
        }

        public System.UInt32? ActivityHostManagerNumberofbusyhostprocesses
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActivityHostManagerNumberofbusyhostprocesses", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActivityHostManagerNumberofbusyhostprocesses", value);
            }
        }

        public System.UInt32? ActivityHostManagerNumberofcreatedhostprocesses
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActivityHostManagerNumberofcreatedhostprocesses", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActivityHostManagerNumberofcreatedhostprocesses", value);
            }
        }

        public System.UInt32? ActivityHostManagerNumberofdisposedhostprocesses
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActivityHostManagerNumberofdisposedhostprocesses", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActivityHostManagerNumberofdisposedhostprocesses", value);
            }
        }

        public System.UInt32? ActivityHostManagerNumberoffailedrequestsinqueue
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActivityHostManagerNumberoffailedrequestsinqueue", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActivityHostManagerNumberoffailedrequestsinqueue", value);
            }
        }

        public System.UInt32? ActivityHostManagerNumberoffailedrequestsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActivityHostManagerNumberoffailedrequestsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActivityHostManagerNumberoffailedrequestsPersec", value);
            }
        }

        public System.UInt32? ActivityHostManagerNumberofincomingrequestsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActivityHostManagerNumberofincomingrequestsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActivityHostManagerNumberofincomingrequestsPersec", value);
            }
        }

        public System.UInt32? ActivityHostManagerNumberofpendingrequestsinqueue
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActivityHostManagerNumberofpendingrequestsinqueue", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActivityHostManagerNumberofpendingrequestsinqueue", value);
            }
        }

        public System.UInt32? Numberoffailedworkflowjobs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Numberoffailedworkflowjobs", out result);
                return result;
            }

            set
            {
                this.SetProperty("Numberoffailedworkflowjobs", value);
            }
        }

        public System.UInt32? NumberoffailedworkflowjobsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberoffailedworkflowjobsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberoffailedworkflowjobsPersec", value);
            }
        }

        public System.UInt32? Numberofresumedworkflowjobs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Numberofresumedworkflowjobs", out result);
                return result;
            }

            set
            {
                this.SetProperty("Numberofresumedworkflowjobs", value);
            }
        }

        public System.UInt32? NumberofresumedworkflowjobsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofresumedworkflowjobsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofresumedworkflowjobsPersec", value);
            }
        }

        public System.UInt32? Numberofrunningworkflowjobs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Numberofrunningworkflowjobs", out result);
                return result;
            }

            set
            {
                this.SetProperty("Numberofrunningworkflowjobs", value);
            }
        }

        public System.UInt32? NumberofrunningworkflowjobsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofrunningworkflowjobsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofrunningworkflowjobsPersec", value);
            }
        }

        public System.UInt32? Numberofstoppedworkflowjobs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Numberofstoppedworkflowjobs", out result);
                return result;
            }

            set
            {
                this.SetProperty("Numberofstoppedworkflowjobs", value);
            }
        }

        public System.UInt32? NumberofstoppedworkflowjobsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofstoppedworkflowjobsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofstoppedworkflowjobsPersec", value);
            }
        }

        public System.UInt32? Numberofsucceededworkflowjobs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Numberofsucceededworkflowjobs", out result);
                return result;
            }

            set
            {
                this.SetProperty("Numberofsucceededworkflowjobs", value);
            }
        }

        public System.UInt32? NumberofsucceededworkflowjobsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofsucceededworkflowjobsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofsucceededworkflowjobsPersec", value);
            }
        }

        public System.UInt32? Numberofsuspendedworkflowjobs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Numberofsuspendedworkflowjobs", out result);
                return result;
            }

            set
            {
                this.SetProperty("Numberofsuspendedworkflowjobs", value);
            }
        }

        public System.UInt32? NumberofsuspendedworkflowjobsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofsuspendedworkflowjobsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofsuspendedworkflowjobsPersec", value);
            }
        }

        public System.UInt32? Numberofterminatedworkflowjobs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Numberofterminatedworkflowjobs", out result);
                return result;
            }

            set
            {
                this.SetProperty("Numberofterminatedworkflowjobs", value);
            }
        }

        public System.UInt32? NumberofterminatedworkflowjobsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberofterminatedworkflowjobsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofterminatedworkflowjobsPersec", value);
            }
        }

        public System.UInt32? Numberofwaitingworkflowjobs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Numberofwaitingworkflowjobs", out result);
                return result;
            }

            set
            {
                this.SetProperty("Numberofwaitingworkflowjobs", value);
            }
        }

        public System.UInt32? PowerShellRemotingNumberofconnectionsclosedreopened
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PowerShellRemotingNumberofconnectionsclosedreopened", out result);
                return result;
            }

            set
            {
                this.SetProperty("PowerShellRemotingNumberofconnectionsclosedreopened", value);
            }
        }

        public System.UInt32? PowerShellRemotingNumberofcreatedconnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PowerShellRemotingNumberofcreatedconnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("PowerShellRemotingNumberofcreatedconnections", value);
            }
        }

        public System.UInt32? PowerShellRemotingNumberofdisposedconnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PowerShellRemotingNumberofdisposedconnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("PowerShellRemotingNumberofdisposedconnections", value);
            }
        }

        public System.UInt32? PowerShellRemotingNumberofforcedtowaitrequestsinqueue
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PowerShellRemotingNumberofforcedtowaitrequestsinqueue", out result);
                return result;
            }

            set
            {
                this.SetProperty("PowerShellRemotingNumberofforcedtowaitrequestsinqueue", value);
            }
        }

        public System.UInt32? PowerShellRemotingNumberofpendingrequestsinqueue
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PowerShellRemotingNumberofpendingrequestsinqueue", out result);
                return result;
            }

            set
            {
                this.SetProperty("PowerShellRemotingNumberofpendingrequestsinqueue", value);
            }
        }

        public System.UInt32? PowerShellRemotingNumberofrequestsbeingserviced
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PowerShellRemotingNumberofrequestsbeingserviced", out result);
                return result;
            }

            set
            {
                this.SetProperty("PowerShellRemotingNumberofrequestsbeingserviced", value);
            }
        }
    }
}