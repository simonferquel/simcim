using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataUGathererSearchGathererProjects : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataUGathererSearchGathererProjects()
        {
        }

        public Win32PerfFormattedDataUGathererSearchGathererProjects(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AccessedFileRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AccessedFileRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("AccessedFileRate", value);
            }
        }

        public System.UInt32? AccessedFiles
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AccessedFiles", out result);
                return result;
            }

            set
            {
                this.SetProperty("AccessedFiles", value);
            }
        }

        public System.UInt32? AdaptiveCrawlErrors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AdaptiveCrawlErrors", out result);
                return result;
            }

            set
            {
                this.SetProperty("AdaptiveCrawlErrors", value);
            }
        }

        public System.UInt32? ChangedDocuments
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ChangedDocuments", out result);
                return result;
            }

            set
            {
                this.SetProperty("ChangedDocuments", value);
            }
        }

        public System.UInt32? Crawlsinprogress
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Crawlsinprogress", out result);
                return result;
            }

            set
            {
                this.SetProperty("Crawlsinprogress", value);
            }
        }

        public System.UInt32? DelayedDocuments
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DelayedDocuments", out result);
                return result;
            }

            set
            {
                this.SetProperty("DelayedDocuments", value);
            }
        }

        public System.UInt32? DocumentAdditions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DocumentAdditions", out result);
                return result;
            }

            set
            {
                this.SetProperty("DocumentAdditions", value);
            }
        }

        public System.UInt32? DocumentAddRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DocumentAddRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("DocumentAddRate", value);
            }
        }

        public System.UInt32? DocumentDeleteRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DocumentDeleteRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("DocumentDeleteRate", value);
            }
        }

        public System.UInt32? DocumentDeletes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DocumentDeletes", out result);
                return result;
            }

            set
            {
                this.SetProperty("DocumentDeletes", value);
            }
        }

        public System.UInt32? DocumentModifies
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DocumentModifies", out result);
                return result;
            }

            set
            {
                this.SetProperty("DocumentModifies", value);
            }
        }

        public System.UInt32? DocumentModifiesRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DocumentModifiesRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("DocumentModifiesRate", value);
            }
        }

        public System.UInt32? DocumentMoveandRenameRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DocumentMoveandRenameRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("DocumentMoveandRenameRate", value);
            }
        }

        public System.UInt32? DocumentMovesPerRenames
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DocumentMovesPerRenames", out result);
                return result;
            }

            set
            {
                this.SetProperty("DocumentMovesPerRenames", value);
            }
        }

        public System.UInt32? DocumentsInProgress
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DocumentsInProgress", out result);
                return result;
            }

            set
            {
                this.SetProperty("DocumentsInProgress", value);
            }
        }

        public System.UInt32? DocumentsOnHold
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DocumentsOnHold", out result);
                return result;
            }

            set
            {
                this.SetProperty("DocumentsOnHold", value);
            }
        }

        public System.UInt32? ErrorRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ErrorRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorRate", value);
            }
        }

        public System.UInt32? FileErrors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FileErrors", out result);
                return result;
            }

            set
            {
                this.SetProperty("FileErrors", value);
            }
        }

        public System.UInt32? FileErrorsRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FileErrorsRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("FileErrorsRate", value);
            }
        }

        public System.UInt32? FilteredOffice
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FilteredOffice", out result);
                return result;
            }

            set
            {
                this.SetProperty("FilteredOffice", value);
            }
        }

        public System.UInt32? FilteredOfficeRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FilteredOfficeRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("FilteredOfficeRate", value);
            }
        }

        public System.UInt32? FilteredText
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FilteredText", out result);
                return result;
            }

            set
            {
                this.SetProperty("FilteredText", value);
            }
        }

        public System.UInt32? FilteredTextRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FilteredTextRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("FilteredTextRate", value);
            }
        }

        public System.UInt32? FilteringDocuments
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FilteringDocuments", out result);
                return result;
            }

            set
            {
                this.SetProperty("FilteringDocuments", value);
            }
        }

        public System.UInt32? GathererPausedFlag
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("GathererPausedFlag", out result);
                return result;
            }

            set
            {
                this.SetProperty("GathererPausedFlag", value);
            }
        }

        public System.UInt32? HistoryRecoveryProgress
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HistoryRecoveryProgress", out result);
                return result;
            }

            set
            {
                this.SetProperty("HistoryRecoveryProgress", value);
            }
        }

        public System.UInt32? IncrementalCrawls
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IncrementalCrawls", out result);
                return result;
            }

            set
            {
                this.SetProperty("IncrementalCrawls", value);
            }
        }

        public System.UInt32? IteratingHistoryInProgressFlag
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IteratingHistoryInProgressFlag", out result);
                return result;
            }

            set
            {
                this.SetProperty("IteratingHistoryInProgressFlag", value);
            }
        }

        public System.UInt32? NotModified
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NotModified", out result);
                return result;
            }

            set
            {
                this.SetProperty("NotModified", value);
            }
        }

        public System.UInt32? ProcessedDocuments
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ProcessedDocuments", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProcessedDocuments", value);
            }
        }

        public System.UInt32? ProcessedDocumentsRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ProcessedDocumentsRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProcessedDocumentsRate", value);
            }
        }

        public System.UInt32? RecoveryInProgressFlag
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RecoveryInProgressFlag", out result);
                return result;
            }

            set
            {
                this.SetProperty("RecoveryInProgressFlag", value);
            }
        }

        public System.UInt32? Retries
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Retries", out result);
                return result;
            }

            set
            {
                this.SetProperty("Retries", value);
            }
        }

        public System.UInt32? RetriesRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RetriesRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("RetriesRate", value);
            }
        }

        public System.UInt32? StartedDocuments
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StartedDocuments", out result);
                return result;
            }

            set
            {
                this.SetProperty("StartedDocuments", value);
            }
        }

        public System.UInt32? StatusError
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StatusError", out result);
                return result;
            }

            set
            {
                this.SetProperty("StatusError", value);
            }
        }

        public System.UInt32? StatusSuccess
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StatusSuccess", out result);
                return result;
            }

            set
            {
                this.SetProperty("StatusSuccess", value);
            }
        }

        public System.UInt32? SuccessRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SuccessRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("SuccessRate", value);
            }
        }

        public System.UInt32? UniqueDocuments
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UniqueDocuments", out result);
                return result;
            }

            set
            {
                this.SetProperty("UniqueDocuments", value);
            }
        }

        public System.UInt32? URLsinHistory
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("URLsinHistory", out result);
                return result;
            }

            set
            {
                this.SetProperty("URLsinHistory", value);
            }
        }

        public System.UInt32? WaitingDocuments
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WaitingDocuments", out result);
                return result;
            }

            set
            {
                this.SetProperty("WaitingDocuments", value);
            }
        }
    }
}