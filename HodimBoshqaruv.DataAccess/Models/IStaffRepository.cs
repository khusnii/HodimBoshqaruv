﻿namespace HodimBoshqaruv.Models
{
    public interface IStaffRepository
    {
        Staff Get(int id);  

        IEnumerable<Staff> GetAll();

        Staff Create(Staff staff);
    }
}
