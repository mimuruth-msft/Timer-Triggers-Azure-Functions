using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace LocalFunctionsProject
{
    public static class mimu_TimerTriggerFunc_docker
    {
        [FunctionName("mimu_TimerTriggerFunc_docker")]
        public static void Run([TimerTrigger("0 */2 * * * *")]TimerInfo myTimer, ILogger log)
        {
			if (myTimer.IsPastDue)
			{
				log.LogInformation("Timer is running late!");
			}
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
