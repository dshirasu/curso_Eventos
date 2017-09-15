using Eventos.IO.Domain.Core.Models;
using FluentValidation;
using System;

namespace Eventos.IO.Domain.Eventos
{
    public class Endereco : Entity<Endereco>
    {
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string CEP { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public Guid? EventoId { get; private set; }

        //EF propriedade de navegação
        public virtual Evento Evento { get; private set; }

        public Endereco(Guid id, string logradouro, string numero, string complemento, string bairro, string cep, string cidade, string estado, Guid? eventoId)
        {
            Id = id;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            CEP = cep;
            Cidade = cidade;
            Estado = estado;
            EventoId = eventoId;
        }

        protected Endereco() { }

        public override bool EhValido()
        {
            Validar();
            return ValidationResult.IsValid;
        }

        private void Validar()
        {
            ValidarLogradouro();
            ValidarBairro();
            ValidarCEP();
            ValidarCidade();
            ValidarEstado();
            ValidarNumero();
            ValidationResult = Validate(this); // Entidade ao validando ela propria
        }

        private void ValidarLogradouro()
        {
            RuleFor(c => c.Logradouro)
                .NotEmpty().WithMessage("O Logradouro prcisa ser fornecido.")
                .Length(2, 150).WithMessage("O Logradouro precisa ter entre 2 e 150 caracteres.");
        }

        private void ValidarBairro()
        {
            RuleFor(c => c.Bairro)
                .NotEmpty().WithMessage("O Bairro precisa ser fornecido.")
                .Length(2, 150).WithMessage("O Bairro precisa ter entre 2 e 150 caracteres.");
        }

        private void ValidarCEP()
        {
            RuleFor(c => c.CEP)
                .NotEmpty().WithMessage("O CEP precisa ser fornecido.")
                .Length(8).WithMessage("O CEP deve ter 8 dígitos.");
        }

        private void ValidarCidade()
        {
            RuleFor(c => c.Cidade)
                .NotEmpty().WithMessage("A Cidade deve ser fornecido.")
                .Length(2, 150).WithMessage("A Cidade precisa ter entre 2 e 150 caracteres.");
        }

        private void ValidarEstado()
        {
            RuleFor(c => c.Estado)
                .NotEmpty().WithMessage("O Estado precisa ser fornecido.")
                .Length(2, 150).WithMessage("O Estado precisa ter entre 2 e 150 caracteres.");
        }

        private void ValidarNumero()
        {
            RuleFor(c => c.Numero)
                .NotEmpty().WithMessage("O Número precisa ser fornecido.")
                .Length(1, 10).WithMessage("O Número precisa ter entre 1 e 10 caracteres.");
        }
    }
}