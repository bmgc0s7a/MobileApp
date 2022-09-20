using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Essentials;

namespace Toponimia.Services
{
    public static class DataAccess
    {
        //Conexão para a base de dados
        private static SQLiteConnection conexao;

        private static void InicializarConexao()
        {
            //Forma "antiga" de aceder ao caminho para guardar ficheiros, como por exemplo, bases de dados
            //string caminho_completo_bd = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"database.db");

            //Forma "mais recente" de manusear ficheiros por cada aplicação
            string caminho_completo_bd = Path.Combine(FileSystem.AppDataDirectory, "database.db");

            conexao = new SQLiteConnection(caminho_completo_bd);
        }

        #region CREATE
        public static int InserirDistrito(Models.Distrito x)
        {
            int retorno = 0;

            //Inicializar a conexao
            InicializarConexao();

            //Garantir que a tabela existe
            conexao.CreateTable<Models.Distrito>();//CRIA A TABELA NA BD APENAS SE ESTA NÃO EXISTIR!!!

            //inserir o objeto
            retorno = conexao.Insert(x);

            //fechar a conexao
            conexao.Dispose();

            return retorno;

            //Em SQL Server
            //1-criar uma conexao
            //2-abrir a conexao
            //3-verificar se a conexao está efetivamente aberta
            //4-criar um SqlCommand
            //5-carregar o script para o SqlCommand
            //6-carregar os Values para o SqlCommand (através de SqlParameter por causa do Sql Injection)
            //7-executar o command
            //8-fechar a conexao

            //Em SqLite
            //1-inicializar a conexao
            //2-garantir que a tabela existe
            //3-inserir diretamente o objeto
            //4-fechar a conexao
        }

        public static int InserirConcelho(Models.Concelho x) 
        {
            int retorno = 0;

            InicializarConexao();
            conexao.CreateTable<Models.Concelho>();
            retorno = conexao.Insert(x);
            conexao.Dispose();

            return retorno;
        }

        public static int InserirFreguesia(Models.Freguesia x) 
        {
            int retorno = 0;

            InicializarConexao();
            conexao.CreateTable<Models.Freguesia>();
            retorno = conexao.Insert(x);
            conexao.Dispose();

            return retorno;
        }

        public static int InserirToponimo(Models.Toponimo x) 
        {
            int retorno = 0;

            InicializarConexao();
            conexao.CreateTable<Models.Toponimo>();
            retorno = conexao.Insert(x);
            conexao.Dispose();

            return retorno;
        }
        #endregion

        #region READ
        public static IEnumerable<Models.Distrito> ObterDistritos()
        {
            //Inicializar a conexao
            InicializarConexao();

            //Garantir que a tabela existe
            conexao.CreateTable<Models.Distrito>();//CRIA A TABELA NA BD APENAS SE ESTA NÃO EXISTIR!!!

            //Obter os dados
            IEnumerable<Models.Distrito> lista = conexao.Table<Models.Distrito>().ToList();
            
            //fechar a conexao
            conexao.Dispose();

            return lista;
        }
        #endregion

        #region UPDATE
        #endregion

        #region DELETE
        #endregion

    }
}
