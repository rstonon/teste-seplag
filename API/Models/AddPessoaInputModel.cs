using API.Entities;
using System;

namespace API.Models
{
    public record AddPessoaInputModel(string cpf_Cnpj, string razao_Social, string nome_Fantasia, string tipo_empresa, DateTime data_Constituicao, string porte, string telefone, string telefone2, string telefone3, string site, string email, string caracterizacao_Capital, decimal quantidade_Quota, decimal valor_Quota, decimal capital_Social, string estado_Civil, string profissao, DateTime data_Nascimento, string genero, string nacionalidade, string tipo_Pessoa, string nacional)
    {

    }
}
