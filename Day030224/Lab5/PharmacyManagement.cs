using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class PharmacyManagement
    {
        public List<MedicineCategory> Categories { get; set; }

        public PharmacyManagement()
        {
            Categories = new List<MedicineCategory>();
        }

        // Thêm thuốc mới
        public void AddMedicine(string categoryName, string medicineName, int quantity, double price)
        {
            MedicineCategory category = Categories.Find(c => c.Name == categoryName);
            if (category != null)
            {
                Medicine medicine = new Medicine(medicineName, quantity, price);
                category.Medicines.Add(medicine);
                Console.WriteLine($"Added {medicineName} to {categoryName} category.");
            }
            else
            {
                Console.WriteLine($"Category {categoryName} not found.");
            }
        }

        // Hiển thị danh sách thuốc theo danh mục
        public void DisplayMedicinesByCategory(string categoryName)
        {
            MedicineCategory category = Categories.Find(c => c.Name == categoryName);
            if (category != null)
            {
                Console.WriteLine($"Medicines in category {categoryName}:");
                foreach (Medicine medicine in category.Medicines)
                {
                    Console.WriteLine($"Name: {medicine.Name}, Quantity: {medicine.Quantity}, Price: {medicine.Price}");
                }
            }
            else
            {
                Console.WriteLine($"Category {categoryName} not found.");
            }
        }

        // Hiển thị thông tin chi tiết về thuốc
        public void DisplayMedicineDetails(string medicineName)
        {
            foreach (MedicineCategory category in Categories)
            {
                Medicine medicine = category.Medicines.Find(m => m.Name == medicineName);
                if (medicine != null)
                {
                    Console.WriteLine($"Medicine Name: {medicine.Name}, Quantity: {medicine.Quantity}, Price: {medicine.Price}");
                    return;
                }
            }
            Console.WriteLine($"Medicine {medicineName} not found.");
        }

        // Tìm kiếm thuốc theo tên
        public void SearchMedicine(string medicineName)
        {
            bool found = false;
            foreach (MedicineCategory category in Categories)
            {
                foreach (Medicine medicine in category.Medicines)
                {
                    if (medicine.Name.ToLower().Contains(medicineName.ToLower()))
                    {
                        Console.WriteLine($"Found medicine: {medicine.Name}, Category: {category.Name}");
                        found = true;
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine($"Medicine {medicineName} not found.");
            }
        }

        // Cập nhật thông tin thuốc
        public void UpdateMedicine(string medicineName, int newQuantity, double newPrice)
        {
            foreach (MedicineCategory category in Categories)
            {
                Medicine medicine = category.Medicines.Find(m => m.Name == medicineName);
                if (medicine != null)
                {
                    medicine.Quantity = newQuantity;
                    medicine.Price = newPrice;
                    Console.WriteLine($"Updated information for {medicineName}.");
                    return;
                }
            }
            Console.WriteLine($"Medicine {medicineName} not found.");
        }

        // Xóa thuốc
        public void DeleteMedicine(string medicineName)
        {
            foreach (MedicineCategory category in Categories)
            {
                Medicine medicine = category.Medicines.Find(m => m.Name == medicineName);
                if (medicine != null)
                {
                    category.Medicines.Remove(medicine);
                    Console.WriteLine($"Deleted medicine: {medicineName}.");
                    return;
                }
            }
            Console.WriteLine($"Medicine {medicineName} not found.");
        }
    }
}
