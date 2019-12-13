using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SimCim.Core
{
    internal class HotObservable<T> : IObservable<T>, IObserver<T>, IDisposable
    {
        private readonly ReaderWriterLockSlim _rwLock = new ReaderWriterLockSlim();
        private readonly List<IObserver<T>> _observers = new List<IObserver<T>>();
        private readonly IDisposable _subscribtion;

        public HotObservable(IObservable<T> observable)
        {
            _subscribtion = observable.Subscribe(this);
        }
        public IDisposable Subscribe(IObserver<T> observer)
        {
            _rwLock.EnterWriteLock();
            try
            {
                _observers.Add(observer);
            }
            finally
            {
                _rwLock.ExitWriteLock();
            }
            return new SubscribtionToken
            {
                Observer = observer,
                Owner = this
            };
        }
        public void Dispose()
        {
            _subscribtion.Dispose();
            _rwLock.Dispose();
        }
        public void OnCompleted()
        {
            _rwLock.EnterReadLock();
            try
            {
                foreach(var o in _observers)
                {
                    o.OnCompleted();
                }
            }
            finally
            {
                _rwLock.ExitReadLock();
            }
        }
        public void OnError(Exception error)
        {
            _rwLock.EnterReadLock();
            try
            {
                foreach (var o in _observers)
                {
                    o.OnError(error);
                }
            }
            finally
            {
                _rwLock.ExitReadLock();
            }
        }
        public void OnNext(T value)
        {
            _rwLock.EnterReadLock();
            try
            {
                foreach (var o in _observers)
                {
                    o.OnNext(value);
                }
            }
            finally
            {
                _rwLock.ExitReadLock();
            }
        }

        private struct SubscribtionToken : IDisposable
        {
            public IObserver<T> Observer { get; set; }
            public HotObservable<T> Owner { get; set; }

            public void Dispose()
            {
                Owner._rwLock.EnterWriteLock();
                try
                {
                    Owner._observers.Remove(Observer);
                }
                finally
                {
                    Owner._rwLock.ExitWriteLock();
                }
            }
        }
    }
}
