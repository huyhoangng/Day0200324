using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Program
    {
        static void Main(string[] args)
        {
            PharmacyManagement pharmacyManagement = new PharmacyManagement();

            // Thêm danh mục thuốc
            pharmacyManagement.Categories.Add(new MedicineCategory("Painkillers"));
            pharmacyManagement.Categories.Add(new MedicineCategory("Antipyretics"));
            pharmacyManagement.Categories.Add(new MedicineCategory("Antibiotics"));

            // Thêm thuốc vào danh sách
            pharmacyManagement.AddMedicine("Painkillers", "Paracetamol", 100, 5.5);
            pharmacyManagement.AddMedicine("Painkillers", "Ibuprofen", 50, 7.8);
            pharmacyManagement.AddMedicine("Antipyretics", "Aspirin", 80, 4.2);
            pharmacyManagement.AddMedicine("Antibiotics", "Amoxicillin", 120, 8.6);

            // Hiển thị danh sách thuốc theo danh mục
            pharmacyManagement.DisplayMedicinesByCategory("Painkillers");
            pharmacyManagement.DisplayMedicinesByCategory("Antipyretics");
            pharmacyManagement.DisplayMedicinesByCategory("Antibiotics");

            // Hiển thị thông tin chi tiết về thuốc
            pharmacyManagement.DisplayMedicineDetails("Paracetamol");

            // Tìm kiếm thuốc
            pharmacyManagement.SearchMedicine("Ibu");

            // Cập nhật thông tin thuốc
            pharmacyManagement.UpdateMedicine("Paracetamol", 120, 6.0);

            // Xóa thuốc
            pharmacyManagement.DeleteMedicine("Aspirin");

            // Thêm thuốc mới từ người dùng
            Console.WriteLine("Enter new medicine details:");
            Console.Write("Category: ");
            string category = Console.ReadLine();
            Console.Write("Medicine Name: ");
            string name = Console.ReadLine();
            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());

            pharmacyManagement.AddMedicine(category, name, quantity, price);

            // Hiển thị lại danh sách thuốc sau khi thêm mới
            pharmacyManagement.DisplayMedicinesByCategory(category);
        }
    }
}
