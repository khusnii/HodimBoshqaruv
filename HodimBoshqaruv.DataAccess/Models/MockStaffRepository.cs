namespace HodimBoshqaruv.Models
{

    public class MockStaffRepository : IStaffRepository
    {

        private List<Staff> _staffs;
        private object x;

        public MockStaffRepository()
        {
            _staffs = new List<Staff>()
            {
                new Staff { Id = 1, FirstName = "Alisher", LastName = "Uzoqov", Email = "alisheruzoqov@gmail.com", Department = Departments.Admin},
                new Staff { Id= 2, FirstName = "Ulug'bek", LastName ="Rahmatov", Email="ulug'bekr@gmail.com", Department =Departments.Sales},
                new Staff { Id= 3, FirstName = "Sardor", LastName ="Rahimxon", Email="sardorrahimxon@gmail.com", Department =Departments.HR}
            };
        }

        public Staff Create(Staff staff)
        {
            staff.Id = _staffs.Max(s => s.Id) + 1;
            _staffs.Add(staff);
            return staff;

        }

        public Staff Get(int id)
        {
           return _staffs.FirstOrDefault(staff => staff.Id.Equals( id));
        }

        public IEnumerable<Staff> GetAll()
        {
            return _staffs;
        }
    }
}
