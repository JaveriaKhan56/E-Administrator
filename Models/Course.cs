using System;
using System.Collections.Generic;

namespace E_Administration.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string CourseName { get; set; } = null!;

    public string CourseDuration { get; set; } = null!;

    public int UserId { get; set; }

    public virtual ICollection<Faculty> Faculties { get; set; } = new List<Faculty>();

    public virtual User User { get; set; } = null!;
}
