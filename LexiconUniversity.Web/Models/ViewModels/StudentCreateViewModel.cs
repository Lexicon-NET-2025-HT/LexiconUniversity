using LexiconUniversity.Web.Validations;

namespace LexiconUniversity.Web.Models.ViewModels
{
    public class StudentCreateViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        [CheckStreetNr(10)]            
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }

        public IEnumerable<int> SelectedCourses { get; set; } = new List<int>(); 
    }
}
