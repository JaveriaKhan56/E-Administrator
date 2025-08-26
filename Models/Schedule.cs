using System;
using System.Collections.Generic;

namespace E_Administration.Models;

public partial class Schedule
{
    public int ScheduleId { get; set; }

    public string DayOfWeek { get; set; } = null!;

    public string Shift { get; set; } = null!;

    public string Timing { get; set; } = null!;

    public virtual ICollection<Faculty> Faculties { get; set; } = new List<Faculty>();
}
