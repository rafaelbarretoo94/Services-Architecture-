﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    public class ClienteDAO
    {
        private List<Cliente> clientes = new List<Cliente>();

        public void AdicionarCliente(Cliente c)
        {
            clientes.Add(c);
        }

        public Cliente Buscar (string nome)
        {
            var resultado = from c in clientes where c.Nome.Equals(nome) select c;
            return (Cliente) resultado; 
        }
    }
}
