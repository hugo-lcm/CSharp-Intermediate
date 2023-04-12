﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_generics
{
    public class RepositorioGenerico<TTipo>
    {
        private List<TTipo> list;

        public RepositorioGenerico()
        {
            list = new List<TTipo>();
        }

        public List<TTipo> Get()
        {
            return list;
        }

        public void Insert(TTipo item)
        {
            list.Add(item);
        }
    }
}
