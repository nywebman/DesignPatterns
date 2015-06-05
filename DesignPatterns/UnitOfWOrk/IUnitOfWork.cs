using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Repository;

namespace DesignPatterns.UnitOfWOrk
{
    /*
    public interface IUnitOfWork
    {
        IRepository<Employee> Employees { get; }
        IRepository<TimeCard> TimeCards { get; }
        void Commit();
    }

    public class SqlUnitOfWork : IUnitOfWork
    {
        public IRepository<Employee> Employees
        {
            get { throw new NotImplementedException(); }
        }

        public IRepository<TimeCard> TimeCards
        {
            get { throw new NotImplementedException(); }
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }
    }

    public class SomeController
    {
        private IUnitOfWork _unitOfWork;
        private IRepository<Employee> _repository;
        public SomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.Employees;
        }

        [HttpPost]
        public ActionResult Create([Bind(Exclude="Id")],Employee employee)
        {
            if (ModelState.IsValid)
            {
                _repository.add(employee);
                _unitOfWork.Commit();  //<------------------------when all work finished
                return RedirectToAction("Index");
            }
            return View(employee);
        }

    }
    */
}
