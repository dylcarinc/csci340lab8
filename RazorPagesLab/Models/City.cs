using System.ComponentModel.DataAnnotations;

namespace RazorPagesLab.Models;
using System.ComponentModel.DataAnnotations.Schema;

public class City
{
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [DataType(DataType.Date)]
    [Display(Name = "Date Visited")]
    [Required]
    public DateTime DateVisited { get; set; }
    [Display(Name = "State or Region")]
    [Required]
     public string? StateRegion  { get; set; }
    [Required] 
    public string? Country { get; set; }
    [Required]
    [DisplayFormat(DataFormatString = "{0:N0}")]
    public int Population { get; set; }
    [Required]
    [Display(Name = "Days Spent")]
    public int DaysSpent { get; set; }

}