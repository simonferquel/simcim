using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32WinSAT : GenericInfrastructureObject
    {
        public Win32WinSAT()
        {
        }

        public Win32WinSAT(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Single? CPUScore
        {
            get
            {
                System.Single? result;
                this.GetProperty("CPUScore", out result);
                return result;
            }
        }

        public System.Single? D3DScore
        {
            get
            {
                System.Single? result;
                this.GetProperty("D3DScore", out result);
                return result;
            }
        }

        public System.Single? DiskScore
        {
            get
            {
                System.Single? result;
                this.GetProperty("DiskScore", out result);
                return result;
            }
        }

        public System.Single? GraphicsScore
        {
            get
            {
                System.Single? result;
                this.GetProperty("GraphicsScore", out result);
                return result;
            }
        }

        public System.Single? MemoryScore
        {
            get
            {
                System.Single? result;
                this.GetProperty("MemoryScore", out result);
                return result;
            }
        }

        public System.String TimeTaken
        {
            get
            {
                System.String result;
                this.GetProperty("TimeTaken", out result);
                return result;
            }

            set
            {
                this.SetProperty("TimeTaken", value);
            }
        }

        public System.UInt32? WinSATAssessmentState
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WinSATAssessmentState", out result);
                return result;
            }
        }

        public System.Single? WinSPRLevel
        {
            get
            {
                System.Single? result;
                this.GetProperty("WinSPRLevel", out result);
                return result;
            }
        }
    }
}