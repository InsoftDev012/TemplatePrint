using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TemplatePrint.Models;

namespace TemplatePrint.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PrintOrderPage()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult PrintOrder(int numberOfOrders)
        {
            try
            {
                List<OrderDetail> orderDetails = GenerateRandomOrderDetails(numberOfOrders);


                // Pass the orderDetails list to the OrderTemplate
                OrderTemplate orderTemplate = new OrderTemplate(orderDetails);
                string printOrderPage = orderTemplate.TransformText(); // TransformText generates the HTML

                ViewBag.PrintPage = printOrderPage; // Pass generated HTML to view
                return View("PrintOrderPage");
            }
            catch
            {
                return View("Error");
            }
        }
        
        public ActionResult PrintSchoolReport(int numberOfOrders)
        {
            try
            {
                List<SchoolReportModel> reportDetails = GenerateRandomReports(numberOfOrders);


                // Pass the orderDetails list to the OrderTemplate
                SchoolReportTemplate schoolReportTemplate = new SchoolReportTemplate(reportDetails);
                string printReportPage = schoolReportTemplate.TransformText(); // TransformText generates the HTML

                ViewBag.PrintPage = printReportPage; // Pass generated HTML to view
                return View("PrintOrderPage");
            }
            catch
            {
                return View("Error");
            }
        }

        public List<OrderDetail> GenerateRandomOrderDetails(int n)
        {
            Random random = new Random();
            List<OrderDetail> orderDetails = new List<OrderDetail>();

            // Some sample data arrays to randomly pick from
            string[] companies = { "Company A", "Company B", "Company C", "Company D" };
            string[] branches = { "Branch A", "Branch B", "Branch C", "Branch D" };
            string[] addresses = { "123 Main St", "456 Elm St", "789 Oak St", "321 Park Ave" };
            string[] cities = { "City A", "City B", "City C", "City D" };
            string[] packageTypes = { "Type A", "Type B", "Type C", "Type D" };
            string[] descriptions = { "Electronics", "Books", "Clothing", "Toys" };
            string[] paymentModes = { "Credit Card", "Debit Card", "Cash" };
            string[] remarks = { "Handle with care", "Fragile", "Do not fold" };

            for (int i = 0; i < n; i++)
            {
                string company = companies[random.Next(companies.Length)];
                string originBranch = branches[random.Next(branches.Length)];
                string destinationBranch = branches[random.Next(branches.Length)];
                string deliveryAddress = addresses[random.Next(addresses.Length)] + ", " + cities[random.Next(cities.Length)];
                string pickupAddress = addresses[random.Next(addresses.Length)] + ", " + cities[random.Next(cities.Length)];
                string packageType = packageTypes[random.Next(packageTypes.Length)];
                string description = descriptions[random.Next(descriptions.Length)];
                string paymentMode = paymentModes[random.Next(paymentModes.Length)];
                string remark = remarks[random.Next(remarks.Length)];

                OrderDetail orderDetail = new OrderDetail
                {
                    S_Company = company,
                    OriginBranchName = originBranch,
                    DeliveryAddress = deliveryAddress,
                    S_TaxID_PANNO = "PAN" + random.Next(10000, 99999).ToString(),
                    PlannedPickupDateTime = DateTime.Now.AddDays(random.Next(1, 5)).ToString("yyyy-MM-dd"),
                    DestinationBranchName = destinationBranch,
                    PackagetypeName = packageType,
                    Package_Weight = random.Next(1, 20) + "kg",
                    Description = description,
                    PaymentMode = paymentMode,
                    Package_Pcs = random.Next(1, 5).ToString(),
                    S_name = "Shipper " + company.Substring(company.Length - 1),
                    S_PhoneNo = random.Next(100000000, 999999999).ToString(),  // Fixed phone number range
                    R_name = "Receiver " + company.Substring(company.Length - 1),
                    PickupAddress = pickupAddress,
                    R_PhoneNo = random.Next(100000000, 999999999).ToString(),  // Fixed phone number range
                    R_TaxID_PANNO = "PAN" + random.Next(10000, 99999).ToString(),
                    Remarks = remark,
                    OrderCreateDateADTimeOnly = DateTime.Now.ToString("yyyy-MM-dd HH:mm"),
                    BarCode = "<barcode-placeholder-" + i + ">"
                };

                orderDetails.Add(orderDetail);
            }

            return orderDetails;
        }

        public List<SchoolReportModel> GenerateRandomReports(int count)
        {
            Random random = new Random();
            var reports = new List<SchoolReportModel>();

            for (int i = 0; i < count; i++)
            {
                var students = new List<Student>
        {
            new Student { RegNo = random.Next(1000, 9999).ToString(), STDNAME = "Student " + i, Roll = random.Next(1, 50).ToString(), ClassName = "Class " + random.Next(1, 10), Semester = "1st", Sec = "A" }
        };

                var subjects = new List<Subject>
        {
            new Subject { SubCode = "CS101", SubjectName = "Computer Science" }
        };

                var testTypes = new List<TestType>
        {
            new TestType { Id = "1", Alias = "Term" }
        };

                var personnalDevs = new List<PersonnalDev>
        {
            new PersonnalDev { UkId = "1", Gname = "Handwriting" }
        };

                reports.Add(new SchoolReportModel
                {
                    SchoolName = "Random School " + i,
                    Address = "Address " + i,
                    ESTD = random.Next(1900, 2023).ToString(),
                    SchoolLogo = "logo" + i + ".jpg",
                    Students = students,
                    Subjects = subjects,
                    TestTypes = testTypes,
                    PersonnalDevs = personnalDevs,
                    Remarks = "Random Remark " + i
                });
            }

            return reports;
        }
    }


}
