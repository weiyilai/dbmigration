using System.ComponentModel.DataAnnotations.Schema;

namespace dbmigration.Models;

/// <summary>
/// 課程
/// </summary>
public class Course
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int CourseID { get; set; }
    public string Title { get; set; }
    public int Credits { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; }
}
