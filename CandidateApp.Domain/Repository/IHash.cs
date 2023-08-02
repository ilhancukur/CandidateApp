﻿using CandidateApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateApp.Domain.Repository
{
    public interface IHash
    {
        string CreateHash(HasRequest hasRequest);

        HasRequest SetParam(PayzeeRequest payzeeRequest);
    }
}
