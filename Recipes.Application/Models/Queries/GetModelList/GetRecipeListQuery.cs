﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Recipes.Application.Models.Queries.GetModelList
{
    
    /// <summary>
    /// Choosing concrete user List of Recipes
    /// </summary>
    public class GetRecipeListQuery : IRequest<RecipeListVm>
    {
        public Guid UserId { get; set; }
    }
}
