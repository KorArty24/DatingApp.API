using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.DTOs
{
    public class PhotosForCreationDto
    {
        public string Url { get; set; }
        public IFormFile File { get; set; }
        public string Describtion { get; set; }
        public DateTime DateAdded { get; set; }
        public string PublicId { get; set; }
    }
}
