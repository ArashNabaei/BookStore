﻿using Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories.Query.Authors
{
    public record GetBooksOfAuthorByIdQuery : IRequest<IEnumerable<BookDTO>>
    {
        public int Id { get; set; }
    }
}
