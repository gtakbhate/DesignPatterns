using System.Web.Mvc;
using RepositoryUsingEFinMVC.DAL;
using RepositoryUsingEFinMVC.Repository;
using RepositoryUsingEFinMVC.GenericRepository;
namespace RepositoryUsingEFinMVC.Controllers
{
    /*  public class EmployeeController : Controller
      {
          private IEmployeeRepository _employeeRepository;

          public EmployeeController()
          {
              _employeeRepository = new EmployeeRepository(new EmployeeDBContext());
          }
          public EmployeeController(IEmployeeRepository employeeRepository)
          {
              _employeeRepository = employeeRepository;
          }

          [HttpGet]
          public ActionResult Index()
          {
              var model = _employeeRepository.GetAll();
              return View(model);
          }

          [HttpGet]
          public ActionResult AddEmployee()
          {
              return View();
          }

          [HttpPost]
          public ActionResult AddEmployee(Employee model)
          {
              if (ModelState.IsValid)
              {
                  _employeeRepository.Insert(model);
                  _employeeRepository.Save();
                  return RedirectToAction("Index", "Employee");
              }
              return View();
          }

          [HttpGet]
          public ActionResult EditEmployee(int EmployeeId)
          {
              Employee model = _employeeRepository.GetById(EmployeeId);
              return View(model);
          }

          [HttpPost]
          public ActionResult EditEmployee(Employee model)
          {
              if (ModelState.IsValid)
              {
                  _employeeRepository.Update(model);
                  _employeeRepository.Save();
                  return RedirectToAction("Index", "Employee");
              }
              else
              {
                  return View(model);
              }
          }

          [HttpGet]
          public ActionResult DeleteEmployee(int EmployeeId)
          {
              Employee model = _employeeRepository.GetById(EmployeeId);
              return View(model);
          }

          [HttpPost]
          public ActionResult Delete(int EmployeeID)
          {
              _employeeRepository.Delete(EmployeeID);
              _employeeRepository.Save();
              return RedirectToAction("Index", "Employee");
          }
      }*/

    //Generic controller

    public class EmployeeController : Controller
    {
        private IGenericRepository<Employee> repository = null;
        public EmployeeController()
        {
            this.repository = new GenericRepository<Employee>();
        }
        public EmployeeController(IGenericRepository<Employee> repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var model = repository.GetAll();
            return View(model);
        }
        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee model)
        {
            if (ModelState.IsValid)
            {
                repository.Insert(model);
                repository.Save();
                return RedirectToAction("Index", "Employee");
            }
            return View();
        }
        [HttpGet]
        public ActionResult EditEmployee(int EmployeeId)
        {
            Employee model = repository.GetById(EmployeeId);
            return View(model);
        }
        [HttpPost]
        public ActionResult EditEmployee(Employee model)
        {
            if (ModelState.IsValid)
            {
                repository.Update(model);
                repository.Save();
                return RedirectToAction("Index", "Employee");
            }
            else
            {
                return View(model);
            }
        }
        [HttpGet]
        public ActionResult DeleteEmployee(int EmployeeId)
        {
            Employee model = repository.GetById(EmployeeId);
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int EmployeeID)
        {
            repository.Delete(EmployeeID);
            repository.Save();
            return RedirectToAction("Index", "Employee");
        }
    }
}