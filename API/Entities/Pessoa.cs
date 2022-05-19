using System;

namespace API.Entities
{
    public class Pessoa
    {
        public Pessoa(string cpf_Cnpj, string razao_Social, string nome_Fantasia, string tipo_empresa, DateTime data_Constituicao, string porte, string telefone, string telefone2, string telefone3, string site, string email, string caracterizacao_Capital, decimal quantidade_Quota, decimal valor_Quota, decimal capital_Social, string estado_Civil, string profissao, DateTime data_Nascimento, string genero, string nacionalidade, string tipo_Pessoa, string nacional)
        {
            Cpf_Cnpj = cpf_Cnpj;
            Razao_Social = razao_Social;
            Nome_Fantasia = nome_Fantasia;
            Tipo_empresa = tipo_empresa;
            Data_Constituicao = data_Constituicao;
            Porte = porte;
            Telefone = telefone;
            Telefone2 = telefone2;
            Telefone3 = telefone3;
            Site = site;
            Email = email;
            Caracterizacao_Capital = caracterizacao_Capital;
            Quantidade_Quota = quantidade_Quota;
            Valor_Quota = valor_Quota;
            Capital_Social = capital_Social;
            Estado_Civil = estado_Civil;
            Profissao = profissao;
            Data_Nascimento = data_Nascimento;
            Genero = genero;
            Nacionalidade = nacionalidade;
            CreatedAt = DateTime.Now;
            Tipo_Pessoa = tipo_Pessoa;
            Nacional = nacional;
            Situacao = (Situacoes)1;
            UpdatedAt = DateTime.Now;
        }

        public int Id { get; private set; }
        public string Tipo_Pessoa { get; private set; }
        public string Nacional { get; private set; }
        public string Cpf_Cnpj { get; private set; }
        public string Razao_Social { get; private set; }
        public string Nome_Fantasia { get; private set; }
        public string Tipo_empresa { get; private set; }
        public DateTime Data_Constituicao { get; private set; }
        public string Porte { get; private set; }
        public string Telefone { get; private set; }
        public string Telefone2 { get; private set; }
        public string Telefone3 { get; private set; }
        public string Site { get; private set; }
        public string Email { get; private set; }
        public string Caracterizacao_Capital { get; private set; }
        public decimal Quantidade_Quota { get; private set; }
        public decimal Valor_Quota { get; private set; }
        public decimal Capital_Social { get; private set; }
        public string Estado_Civil { get; private set; }
        public string Profissao { get; private set; }
        public DateTime Data_Nascimento { get; private set; }
        public string Genero { get; private set; }
        public string Nacionalidade { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public Situacoes Situacao { get; private set; }

        public void Update(string cpf_Cnpj, string razao_Social, string nome_Fantasia, string tipo_empresa, DateTime data_Constituicao, string porte, string telefone, string telefone2, string telefone3, string site, string email, string caracterizacao_Capital, decimal quantidade_Quota, decimal valor_Quota, decimal capital_Social, string estado_Civil, string profissao, DateTime data_Nascimento, string genero, string nacionalidade, string nacional)
        {
            Cpf_Cnpj = cpf_Cnpj;
            Razao_Social = razao_Social;
            Nome_Fantasia = nome_Fantasia;
            Tipo_empresa = tipo_empresa;
            Data_Constituicao = data_Constituicao;
            Porte = porte;
            Telefone = telefone;
            Telefone2 = telefone2;
            Telefone3 = telefone3;
            Site = site;
            Email = email;
            Caracterizacao_Capital = caracterizacao_Capital;
            Quantidade_Quota = quantidade_Quota;
            Valor_Quota = valor_Quota;
            Capital_Social = capital_Social;
            Estado_Civil = estado_Civil;
            Profissao = profissao;
            Data_Nascimento = data_Nascimento;
            Genero = genero;
            Nacionalidade = nacionalidade;
            Nacional = nacional;
            UpdatedAt = DateTime.Now;
        }

        public void Ativar()
        {
            Situacao = (Situacoes)2;
        }

        public void Desativar()
        {
            Situacao = (Situacoes)3;
        }

    }
}
