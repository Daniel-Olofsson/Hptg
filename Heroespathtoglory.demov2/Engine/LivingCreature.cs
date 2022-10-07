using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace Engine
{
    public class LivingCreature : INotifyPropertyChanged
    {
        private int _currentHitPoints;
        public int CurrentHitPoints { 
            get { return _currentHitPoints; }
            set
            {
                _currentHitPoints = value;
                OnPropertyChanged("CurrentHitPoints");
            }
        }
        public int MaximumHitPoints { get; set;}


        // Player and monster base class
        public LivingCreature(int currenthitpoints, int maximumhitpoints)
        {
            CurrentHitPoints = currenthitpoints;
            MaximumHitPoints = maximumhitpoints;
;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
