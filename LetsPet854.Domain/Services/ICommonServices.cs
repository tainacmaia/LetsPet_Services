using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Domain.Services
{
    public interface ICommonServices
    {
        //public string Type { get; set; }
        public string Species { get; set; }
        public string Size { get; set; }
        public string Name { get; set; }
        public int ServiceTime { get; set; }
        public int Employees { get; set; }
        public double Price { get; set; }
    }

    public interface IBanho
    {
        public bool Special { get; set; }
        public bool Lotion { get; set; }
    }
    public interface ITosa
    {
        public string GroomingType { get; set; }
    }

    public class Banho : IBanho, ICommonServices
    {
        public string Species { get; set; }
        public string Size { get; set; }
        public string Name { get; set; }
        public bool Special { get; set; }
        public bool Lotion { get; set; }
        public int ServiceTime { get; set; }
        public int Employees { get; set; }
        public double Price { get; set; }
    }

    public class Tosa : ITosa, ICommonServices
    {
        public string Species { get; set; }
        public string Size { get; set; }
        public string Name { get; set; }
        public string GroomingType { get; set; }
        public int ServiceTime { get; set; }
        public int Employees { get; set; }
        public double Price { get; set; }
    }

    public class Servico
    {
        public ICommonServices GetService(object tipoServico)
        {
            ICommonServices servico;

            switch (tipoServico)
            {
                case Banho:
                    servico = new Banho();
                    break;
                case Tosa:
                    servico = new Tosa();
                    break;
                default:
                    servico = null;
                    break;
            }
            return servico;
        }

    }
    public interface IService
    {
        ICommonServices GetService(object tipoServico);
    }
}
