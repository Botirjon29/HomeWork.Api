﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace HomeWork.Api.Entities;

public class TaskEntity
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public int MaxScore { get; set; }
    public ETaskStatus Status { get; set; }

    public Guid CourseId { get; set; }
    [ForeignKey(nameof(CourseId))]
    public virtual Course? Course { get; set; }

    public virtual List<UserTask>? UserTasks { get; set; }
    public virtual List<TaskComment>? Comments { get; set; }
}
