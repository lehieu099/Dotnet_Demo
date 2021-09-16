using System;
using System.ComponentModel.DataAnnotations;

namespace Dotnet_Demo.Models{
    public class Lecture{
        public string ID { get; set; }
        public string LectureName { get; set; }
        public string LectureHour { get; set; }
    }
}
