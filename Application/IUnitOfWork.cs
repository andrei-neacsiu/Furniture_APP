﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IUnitOfWork
    {
        public IProductRepository ProductRepository { get; }
        //public IPartRepository PartRepository { get; }

        Task Save();
    }
}