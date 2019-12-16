using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMPrinter : CIMLogicalDevice
    {
        protected CIMPrinter()
        {
        }

        protected CIMPrinter(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] AvailableJobSheets
        {
            get
            {
                System.String[] result;
                this.GetProperty("AvailableJobSheets", out result);
                return result;
            }
        }

        public System.UInt16[] Capabilities
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("Capabilities", out result);
                return result;
            }
        }

        public System.String[] CapabilityDescriptions
        {
            get
            {
                System.String[] result;
                this.GetProperty("CapabilityDescriptions", out result);
                return result;
            }
        }

        public System.String[] CharSetsSupported
        {
            get
            {
                System.String[] result;
                this.GetProperty("CharSetsSupported", out result);
                return result;
            }
        }

        public System.UInt16[] CurrentCapabilities
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("CurrentCapabilities", out result);
                return result;
            }
        }

        public System.String CurrentCharSet
        {
            get
            {
                System.String result;
                this.GetProperty("CurrentCharSet", out result);
                return result;
            }
        }

        public System.UInt16? CurrentLanguage
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("CurrentLanguage", out result);
                return result;
            }
        }

        public System.String CurrentMimeType
        {
            get
            {
                System.String result;
                this.GetProperty("CurrentMimeType", out result);
                return result;
            }
        }

        public System.String CurrentNaturalLanguage
        {
            get
            {
                System.String result;
                this.GetProperty("CurrentNaturalLanguage", out result);
                return result;
            }
        }

        public System.String CurrentPaperType
        {
            get
            {
                System.String result;
                this.GetProperty("CurrentPaperType", out result);
                return result;
            }
        }

        public System.UInt16[] DefaultCapabilities
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("DefaultCapabilities", out result);
                return result;
            }
        }

        public System.UInt32? DefaultCopies
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DefaultCopies", out result);
                return result;
            }
        }

        public System.UInt16? DefaultLanguage
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DefaultLanguage", out result);
                return result;
            }
        }

        public System.String DefaultMimeType
        {
            get
            {
                System.String result;
                this.GetProperty("DefaultMimeType", out result);
                return result;
            }
        }

        public System.UInt32? DefaultNumberUp
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DefaultNumberUp", out result);
                return result;
            }
        }

        public System.String DefaultPaperType
        {
            get
            {
                System.String result;
                this.GetProperty("DefaultPaperType", out result);
                return result;
            }
        }

        public System.UInt16? DetectedErrorState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DetectedErrorState", out result);
                return result;
            }
        }

        public System.String[] ErrorInformation
        {
            get
            {
                System.String[] result;
                this.GetProperty("ErrorInformation", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorInformation", value);
            }
        }

        public System.UInt32? HorizontalResolution
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HorizontalResolution", out result);
                return result;
            }
        }

        public System.UInt32? JobCountSinceLastReset
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("JobCountSinceLastReset", out result);
                return result;
            }
        }

        public System.UInt16[] LanguagesSupported
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("LanguagesSupported", out result);
                return result;
            }
        }

        public System.UInt16? MarkingTechnology
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("MarkingTechnology", out result);
                return result;
            }
        }

        public System.UInt32? MaxCopies
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxCopies", out result);
                return result;
            }
        }

        public System.UInt32? MaxNumberUp
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxNumberUp", out result);
                return result;
            }
        }

        public System.UInt32? MaxSizeSupported
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxSizeSupported", out result);
                return result;
            }
        }

        public System.String[] MimeTypesSupported
        {
            get
            {
                System.String[] result;
                this.GetProperty("MimeTypesSupported", out result);
                return result;
            }
        }

        public System.String[] NaturalLanguagesSupported
        {
            get
            {
                System.String[] result;
                this.GetProperty("NaturalLanguagesSupported", out result);
                return result;
            }
        }

        public System.UInt16[] PaperSizesSupported
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("PaperSizesSupported", out result);
                return result;
            }
        }

        public System.String[] PaperTypesAvailable
        {
            get
            {
                System.String[] result;
                this.GetProperty("PaperTypesAvailable", out result);
                return result;
            }
        }

        public System.UInt16? PrinterStatus
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PrinterStatus", out result);
                return result;
            }
        }

        public System.DateTime? TimeOfLastReset
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("TimeOfLastReset", out result);
                return result;
            }
        }

        public System.UInt32? VerticalResolution
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VerticalResolution", out result);
                return result;
            }
        }
    }
}