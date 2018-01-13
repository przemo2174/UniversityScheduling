using System;
using System.Collections.Generic;
using System.Text;
using UniversityScheduling.Core.Enums;

namespace UniversityScheduling.Core.Helpers
{
    public class SlotsGenerator
    {
        private List<List<Slot>> _slots;
        private readonly int _numberOfSlotsInDay;
        public SlotsGenerator(TimeSpan slotDuration)
        {
            var duration = new TimeSpan(0, 13, 20, 0);

            _numberOfSlotsInDay = (int)(duration.Ticks / slotDuration.Ticks);
        }

        public List<List<Slot>> GetSlots()
        {
            int slotsCounter = 1;
            _slots = new List<List<Slot>>(5);
            for(int i = 0; i < _slots.Capacity; i++)
            {
                _slots.Add(new List<Slot>(_numberOfSlotsInDay));
                for (int j = 0; j < _numberOfSlotsInDay; j++)
                {
                    _slots[i].Add(new Slot
                    {
                        Id = slotsCounter,
                        Day = (Day)i,
                        Number = slotsCounter
                    });
                    slotsCounter++;
                }
            }

            return _slots;
        }


    }
}
