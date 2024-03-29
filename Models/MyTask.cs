using System;
using System.ComponentModel.DataAnnotations;

namespace EFCoreMyTask.Models
{
  public class MyTask
  {
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Deadline { get; set; }
  }
}