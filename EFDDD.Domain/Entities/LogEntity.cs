using EFDDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDDD.Domain.Entities
{
    public sealed class LogEntity
    {
        private LogEntity()
        {

        }
        public LogEntity(DateTime logDate, string logText)
        {
            LogDate = logDate;
            LogText = logText;
        }

        public LogId LogId { get; }
        public DateTime LogDate { get;private set; }
        public string LogText { get;private set; }
    }
}
