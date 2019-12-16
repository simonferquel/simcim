using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataMSDTCDistributedTransactionCoordinator : Win32PerfRawData
    {
        public Win32PerfRawDataMSDTCDistributedTransactionCoordinator()
        {
        }

        public Win32PerfRawDataMSDTCDistributedTransactionCoordinator(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AbortedTransactions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AbortedTransactions", out result);
                return result;
            }

            set
            {
                this.SetProperty("AbortedTransactions", value);
            }
        }

        public System.UInt32? AbortedTransactionsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AbortedTransactionsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("AbortedTransactionsPersec", value);
            }
        }

        public System.UInt32? ActiveTransactions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActiveTransactions", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActiveTransactions", value);
            }
        }

        public System.UInt32? ActiveTransactionsMaximum
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActiveTransactionsMaximum", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActiveTransactionsMaximum", value);
            }
        }

        public System.UInt32? CommittedTransactions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CommittedTransactions", out result);
                return result;
            }

            set
            {
                this.SetProperty("CommittedTransactions", value);
            }
        }

        public System.UInt32? CommittedTransactionsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CommittedTransactionsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("CommittedTransactionsPersec", value);
            }
        }

        public System.UInt32? ForceAbortedTransactions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ForceAbortedTransactions", out result);
                return result;
            }

            set
            {
                this.SetProperty("ForceAbortedTransactions", value);
            }
        }

        public System.UInt32? ForceCommittedTransactions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ForceCommittedTransactions", out result);
                return result;
            }

            set
            {
                this.SetProperty("ForceCommittedTransactions", value);
            }
        }

        public System.UInt32? InDoubtTransactions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InDoubtTransactions", out result);
                return result;
            }

            set
            {
                this.SetProperty("InDoubtTransactions", value);
            }
        }

        public System.UInt32? ResponseTimeAverage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ResponseTimeAverage", out result);
                return result;
            }

            set
            {
                this.SetProperty("ResponseTimeAverage", value);
            }
        }

        public System.UInt32? ResponseTimeMaximum
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ResponseTimeMaximum", out result);
                return result;
            }

            set
            {
                this.SetProperty("ResponseTimeMaximum", value);
            }
        }

        public System.UInt32? ResponseTimeMinimum
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ResponseTimeMinimum", out result);
                return result;
            }

            set
            {
                this.SetProperty("ResponseTimeMinimum", value);
            }
        }

        public System.UInt32? TransactionsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TransactionsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransactionsPersec", value);
            }
        }
    }
}