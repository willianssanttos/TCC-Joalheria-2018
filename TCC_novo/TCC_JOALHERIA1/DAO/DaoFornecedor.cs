﻿using MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DaoFornecedor
    {
        private DaoConexao conexao;

        public DaoFornecedor(DaoConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloFornecedor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into Fornecedor(for_datacadastro, for_nome, for_cnpj, for_ie, "+
                                           "for_rsocial, for_cep, for_logradouro, for_bairro, for_fone, for_cel, for_email, for_endnumero,"+
                                           "for_cidade, for_estado) values (@for_datacadastro, @for_nome, @for_cnpj, @for_ie," +
                                           "@for_rsocial, @for_cep, @for_logradouro, @for_bairro, @for_fone, @for_cel, @for_email, @for_endnumero, @for_cidade, @for_estado); select @@IDENTITY;";

            cmd.Parameters.Add("@for_datacadastro", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@for_datacadastro"].Value = modelo.Fordatacadastro;
            cmd.Parameters.AddWithValue("@for_nome", modelo.ForNome);
            cmd.Parameters.AddWithValue("@for_cnpj", modelo.ForCnpj);
            cmd.Parameters.AddWithValue("@for_ie", modelo.ForIe);
            cmd.Parameters.AddWithValue("@for_rsocial", modelo.ForRsocial);
            cmd.Parameters.AddWithValue("@for_cep", modelo.ForCep);
            cmd.Parameters.AddWithValue("@for_logradouro", modelo.ForLogradouro);
            cmd.Parameters.AddWithValue("@for_bairro", modelo.ForBairro);
            cmd.Parameters.AddWithValue("@for_fone", modelo.ForFone);
            cmd.Parameters.AddWithValue("@for_cel", modelo.ForCelular);
            cmd.Parameters.AddWithValue("@for_email", modelo.ForEmail);
            cmd.Parameters.AddWithValue("@for_endnumero", modelo.ForEndNumero);
            cmd.Parameters.AddWithValue("@for_cidade", modelo.ForCidade);
            cmd.Parameters.AddWithValue("@for_estado", modelo.ForEstado);
            conexao.Conectar();
            modelo.ForCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloFornecedor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update Fornecedor set for_datacadastro = @for_datacadastro, for_nome = @for_nome, for_cnpj = @for_cnpj, for_ie = @for_ie," +
                                                 "for_rsocial = @for_rsocial, for_cep = @for_cep, for_logradouro = @for_logradouro, for_bairro = @for_bairro, for_fone = @for_fone, for_cel = @for_cel, for_email = @for_email, for_endnumero = @for_endnumero," +
                                                 "for_cidade = @for_cidade, for_estado = @for_estado where for_cod = @codigo;";

            cmd.Parameters.Add("@for_datacadastro", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@for_datacadastro"].Value = modelo.Fordatacadastro;
            cmd.Parameters.AddWithValue("@for_nome", modelo.ForNome);
            cmd.Parameters.AddWithValue("@for_cnpj", modelo.ForCnpj);
            cmd.Parameters.AddWithValue("@for_ie", modelo.ForIe);
            cmd.Parameters.AddWithValue("@for_rsocial", modelo.ForRsocial);
            cmd.Parameters.AddWithValue("@for_cep", modelo.ForCep);
            cmd.Parameters.AddWithValue("@for_logradouro", modelo.ForLogradouro);
            cmd.Parameters.AddWithValue("@for_bairro", modelo.ForBairro);
            cmd.Parameters.AddWithValue("@for_fone", modelo.ForFone);
            cmd.Parameters.AddWithValue("@for_cel", modelo.ForCelular);
            cmd.Parameters.AddWithValue("@for_email", modelo.ForEmail);
            cmd.Parameters.AddWithValue("@for_endnumero", modelo.ForEndNumero);
            cmd.Parameters.AddWithValue("@for_cidade", modelo.ForCidade);
            cmd.Parameters.AddWithValue("@for_estado", modelo.ForEstado);
            cmd.Parameters.AddWithValue("@codigo", modelo.ForCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from Fornecedor where for_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Fornecedor where for_nome like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorNome(String valor)
        {
            return Localizar(valor);
        }

        public DataTable LocalizarPorCNPJ(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Fornecedor where for_cnpj like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloFornecedor CarregaModeloFornecedor(int codigo)
        {
            ModeloFornecedor modelo = new ModeloFornecedor();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Fornecedor where for_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ForCod = Convert.ToInt32(registro["for_cod"]);
                modelo.Fordatacadastro = Convert.ToDateTime(registro["for_datacadastro"]);
                modelo.ForNome = Convert.ToString(registro["for_nome"]);
                modelo.ForCnpj = Convert.ToString(registro["for_cnpj"]);
                modelo.ForIe = Convert.ToString(registro["for_ie"]);
                modelo.ForRsocial = Convert.ToString(registro["for_rsocial"]);
                modelo.ForCep = Convert.ToString(registro["for_cep"]);
                modelo.ForLogradouro = Convert.ToString(registro["for_logradouro"]);
                modelo.ForBairro = Convert.ToString(registro["for_bairro"]);
                modelo.ForFone = Convert.ToString(registro["for_fone"]);
                modelo.ForCelular = Convert.ToString(registro["for_cel"]);
                modelo.ForEmail = Convert.ToString(registro["for_email"]);
                modelo.ForEndNumero = Convert.ToString(registro["for_endnumero"]);
                modelo.ForCidade = Convert.ToString(registro["for_cidade"]);
                modelo.ForEstado = Convert.ToString(registro["for_estado"]);
            }
            conexao.Desconectar();
            return modelo;
        }
        public ModeloFornecedor CarregaModeloFornecedor(string cnpj)
        {
            ModeloFornecedor modelo = new ModeloFornecedor();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Fornecedor where for_cnpj = @cnpj";
            cmd.Parameters.AddWithValue("@cnpj", cnpj);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ForCod = Convert.ToInt32(registro["for_cod"]);
                modelo.Fordatacadastro = Convert.ToDateTime(registro["for_datacadastro"]);
                modelo.ForNome = Convert.ToString(registro["for_nome"]);
                modelo.ForCnpj = Convert.ToString(registro["for_cnpj"]);
                modelo.ForIe = Convert.ToString(registro["for_ie"]);
                modelo.ForRsocial = Convert.ToString(registro["for_rsocial"]);
                modelo.ForCep = Convert.ToString(registro["for_cep"]);
                modelo.ForLogradouro = Convert.ToString(registro["for_logradouro"]);
                modelo.ForBairro = Convert.ToString(registro["for_bairro"]);
                modelo.ForFone = Convert.ToString(registro["for_fone"]);
                modelo.ForCelular = Convert.ToString(registro["for_celular"]);
                modelo.ForEmail = Convert.ToString(registro["for_email"]);
                modelo.ForEndNumero = Convert.ToString(registro["for_endnumero"]);
                modelo.ForCidade = Convert.ToString(registro["for_cidade"]);
                modelo.ForEstado = Convert.ToString(registro["for_estado"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}
