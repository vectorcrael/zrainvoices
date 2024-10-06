using System;
using System.Timers;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace VSDCAPI
{


    public class TimerService : IHostedService, IDisposable
    {
        private readonly ILogger<TimerService> _logger;
        private System.Timers.Timer _timer;

        public TimerService(ILogger<TimerService> logger)
        {
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timer Service is starting.");

            // Set up the timer to trigger every minute (60000 milliseconds)
            _timer = new System.Timers.Timer(60000);
            _timer.Elapsed += OnTimedEvent;
            _timer.AutoReset = true; // Allow the timer to run repeatedly
            _timer.Enabled = true;

            return Task.CompletedTask;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            // Logic to execute on timer event
            _logger.LogInformation("Timer event triggered at: {time}", e.SignalTime);
            // Add your code here to do something every minute
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timer Service is stopping.");
            _timer?.Stop();
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}

