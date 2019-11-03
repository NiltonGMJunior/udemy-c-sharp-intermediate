using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises01
{
    class Stopwatch
    {
        private bool _isRunning;
        private DateTime _startTime;
        private DateTime _stopTime;

        public Stopwatch()
        {
            this._isRunning = false;
            this._startTime = DateTime.Now;
            this._stopTime = this._startTime;
        }

        public TimeSpan Duration
        {
            get
            {
                if (!this._isRunning)
                {
                    return this._stopTime - this._startTime;
                }
                else
                {
                    throw new InvalidOperationException("The stopwatch is still running.");
                }
            }
        }

        public void Start()
        {
            if (!this._isRunning)
            {
                this._isRunning = true;
                this._startTime = DateTime.Now;
            }
            else
            {
                throw new InvalidOperationException("The stopwatch was already started.");
            }
        }

        public void Stop()
        {
            if (this._isRunning)
            {
                this._isRunning = false;
                this._stopTime = DateTime.Now;
            }
            else
            {
                throw new InvalidOperationException("The stopwatch was not yet running.");
            }
        }
    }
}
