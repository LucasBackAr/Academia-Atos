using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace atividade12
{
    internal class Carro
    {
        private string _model;
        private int _ano;
        private double _vel;
        public string Model { get; set; }
        public int Ano { get; set; }
        public Carro() { }
        public Carro (string _model, int _ano)
        {
            Model = _model;
            Ano = _ano;
            _vel = 0;
        }

        public void Acelera()
        {
            _vel += 10;
        }

        public void Freio()
        {
            if(_vel >= 10) 
            {
                _vel -= 10;
            }
            else
            {
                _vel = 0;
            }
        }
        public double Vel 
        {
            get { return _vel; }
        }
    }
}
