using System;
using System.Threading.Tasks;

namespace CoreWindowsWrapper
{
    internal class TaskQueue
    {
        private Task previous = Task.FromResult(false);
        private object key = new object();

        public Task<T> Enqueue<T>(Func<Task<T>> taskGenerator)
        {
            lock (this.key)
            {
                var next = this.previous.ContinueWith(t => taskGenerator()).Unwrap();
                this.previous = next;
                return next;
            }
        }
        public Task Enqueue(Func<Task> taskGenerator)
        {
            lock (this.key)
            {
                var next = this.previous.ContinueWith(t => taskGenerator()).Unwrap();
                this.previous = next;
                return next;
            }
        }
    }
}