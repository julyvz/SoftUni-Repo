﻿using AquaShop.Models.Decorations.Contracts;
using AquaShop.Repositories.Contracts;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Repositories
{
    public class DecorationRepository : IRepository<IDecoration>
    {
        private List<IDecoration> models;

        public DecorationRepository()
        {
            models = new List<IDecoration>();
        }
        
        public IReadOnlyCollection<IDecoration> Models
        {
            get => models.AsReadOnly();
        }

        public void Add(IDecoration model)
        {
            models.Add(model);
        }

        public IDecoration FindByType(string type)
        {
            return models.FirstOrDefault(d => d.GetType().Name == type);
        }

        public bool Remove(IDecoration model)
        {
            return models.Remove(model);
        }
    }
}
