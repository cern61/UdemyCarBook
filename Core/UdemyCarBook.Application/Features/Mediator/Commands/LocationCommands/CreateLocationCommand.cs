﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands.LocationCommands
{
    public class CreateLocationCommand:IRequest
    {
      
        public string Name { get; set; }
    }
}
