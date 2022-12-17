﻿using System.ComponentModel.DataAnnotations.Schema;

namespace HomeWork.Api.Entities;

public class TaskComment
{
    public Guid Id { get; set; }
    public string? Comment { get; set; }
    public DateTime? CreatedDate { get; set; } = DateTime.Now;

    public Guid? ParentId { get; set; }
    [ForeignKey(nameof(ParentId))]
    public virtual TaskComment? Parent { get; set; }

    public virtual List<TaskComment>? Children { get; set; }

    public Guid? TaskId { get; set; }
    [ForeignKey(nameof(TaskId))]
    public virtual TaskEntity? Task { get; set; }

    public Guid UserId { get; set; }
    [ForeignKey(nameof(UserId))]
    public virtual User? User { get; set; }
}
