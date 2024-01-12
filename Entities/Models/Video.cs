using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    internal class Video
    {
        public Guid id { get; set; }
        [Required(ErrorMessage = "Video Title is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the title is 30 characters.")]
        public string Title { get; set; }
        public TimeSpan Duration { get; set; } 
        public bool IsPrivate { get; set; }
        [Required(ErrorMessage = "Video URL is a required field.")]
    
        public string Url { get; set; }
        [Required(ErrorMessage = "User is a required field.")]
      
        public User UploadedBy { get; set; }
    }
}
