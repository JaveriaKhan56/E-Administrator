using System;
using System.Collections.Generic;

namespace E_Administration.Models;

public partial class Faculty
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int RoleId { get; set; }

    public int DepartmentId { get; set; }

    public int CourseId { get; set; }

    public int ScheduleId { get; set; }

    public DateOnly DateOfJoining { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual Department Department { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;

    public virtual Schedule Schedule { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
