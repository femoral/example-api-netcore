using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Filters;
using WebApplication.Domain.Model;

namespace WebApplication.Domain
{
    public interface IGetCharactersUseCase
    {
        IEnumerable<Character> Execute();
    }
}