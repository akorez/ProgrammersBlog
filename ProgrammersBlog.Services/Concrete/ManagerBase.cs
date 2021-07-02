using AutoMapper;
using ProgrammersBlog.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Services.Concrete
{
    public class ManagerBase
    {
        protected IUnitOfWork UnitOfWork { get; }
        protected IMapper IMapper { get; }
        public ManagerBase(IUnitOfWork unitOfWork, IMapper iMapper)
        {
            UnitOfWork = unitOfWork;
            IMapper = iMapper;
        }


    }
}
