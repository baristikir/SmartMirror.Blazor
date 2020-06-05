using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMirror.Blazor.Client.Models
{
    class ClockModel : BaseModel
    {
        private DateTime currentTime;

        public DateTime CurrentTime
        {
            get
            {
                return currentTime;
            }
            set
            {
                if (currentTime != value)
                {
                    currentTime = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public override TimeSpan Interval => TimeSpan.FromSeconds(1);

        public override async Task Update()
        {
            CurrentTime = DateTime.Now;
        }
    }
}
