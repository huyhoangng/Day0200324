using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class MedicineCategory
    {
        public string Name { get; set; }
        public List<Medicine> Medicines { get; set; }

        public MedicineCategory(string name)
        {
            Name = name;
            Medicines = new List<Medicine>();
        }
    }
}
