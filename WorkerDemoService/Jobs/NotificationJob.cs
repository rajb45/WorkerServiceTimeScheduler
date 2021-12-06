using Microsoft.Extensions.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WorkerDemoService.Jobs
{
    class NotificationJob : IJob
    {
        private readonly ILogger<NotificationJob> _logger;
        public NotificationJob(ILogger<NotificationJob> logger)
        {
            this._logger = logger;
            
        }
        public Task Execute(IJobExecutionContext context)
        {

            var task = Task.Run(() => logfile(DateTime.Now)); ;
            return task;
        }
        public void logfile(DateTime time)
        {
            string path = "C:/Users/user/Desktop/Schedule.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(time);
                writer.Close();
            }
        }
    }
}
