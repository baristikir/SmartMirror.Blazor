using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartMirror.Blazor.Client.Models;

namespace SmartMirror.Blazor.Client.ViewModels
{
    public class ClockViewModel : PropertyChangedBase
    {
        private ClockViewModel model;

        private string currentTime { get; set; }

        public string CurrentTime
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

        private string currentDate { get; set; }

        public string CurrentDate
        {
            get
            {
                return currentDate;
            }

            set
            {
                if (currentDate != value)
                {
                    currentDate = value;
                    NotifyPropertyChanged();
                }
            }
        }

        internal void Initialize(ClockModel model)
        {
            this.model = this.model;
        }

        private void ModelPropertyChange(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(model.CurrentTime))
            {
                updateTime();
            }
        }

        private void updateTime()
        {
           // CurrentTime = model.CurrentTime.ToString("h:mm");
           // CurrentDate = model.CurrentDate.ToString("MMMM d");
        }

    }
}
