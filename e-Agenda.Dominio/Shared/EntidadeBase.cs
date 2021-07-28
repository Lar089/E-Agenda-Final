using System;

namespace eAgenda.Dominio.Shared
{
    public abstract class EntidadeBase
    {
        private int id;

        public int Id { get => id; set => id = value; }

        public abstract string Validar();

        protected string QuebraDeLinha(string resultadoValidacao)
        {
            string quebraDeLinha = "";

            if (string.IsNullOrEmpty(resultadoValidacao) == false)
                quebraDeLinha = Environment.NewLine;

            return quebraDeLinha;
        }
    }
}