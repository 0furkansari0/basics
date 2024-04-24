namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses = new List<Course>()
            {
                new Course() {
                    Id = 1, 
                    Title="Aspnet core Kursu", 
                    Description="It's an Aspnet core course.", 
                    Image="1.jpg",
                    Tags=new string[] {"aspnet","web development"},
                    IsActive = true,
                    IsHome = true
                },
                new Course() {
                    Id = 2, 
                    Title="Php core Kursu", 
                    Description="It's a Php course.", 
                    Image="2.jpg",
                    Tags=new string[] {"php","web development"},
                    IsActive = true,
                    IsHome = true
                },
                new Course() {
                    Id = 3, 
                    Title="Django core Kursu",
                    Description="It's a Django course.", 
                    Image="3.jpg",
                    IsActive = true,
                    IsHome = true
                },
                new Course() {
                    Id = 4, 
                    Title="Javascript core Kursu", 
                    Description="It's a Javascript course.", 
                    Image="1.jpg",
                    IsActive = false,
                    IsHome = true
                }
            };
        }
        public static List<Course> Courses{
            get{
                return _courses;
            }
        }

        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(t => t.Id == id);
        }
    }
}