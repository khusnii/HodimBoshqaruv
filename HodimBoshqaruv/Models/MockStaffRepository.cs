namespace HodimBoshqaruv.Models
{
    public class MockStaffRepository : IStaffRepository
    {

        private List<Staff> _staffs;

        public MockStaffRepository()
        {
            _staffs = new List<Staff>()
            {
                new Staff { Id = 1, FirstName = "Alisher", LastName = "Uzoqov", Email = "alisheruzoqov@gmail.com", Department = "admin"},
                new Staff { Id= 2, FirstName = "Ulug'bek", LastName ="Rahmatullayev", Email="ulug'bekr@gmail.com", Department ="actor"},
                new Staff { Id= 3, FirstName = "Sardor", LastName ="Rahimxon", Email="sardorrahimxon@gmail.com", Department ="distributor"}
            };
        }
        public Staff Get(int id)
        {
           return _staffs.FirstOrDefault(staff => staff.Id == id);
        }

        public IEnumerable<Staff> GetAll()
        {
            return _staffs;
        }
    }
}
