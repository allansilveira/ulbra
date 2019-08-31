using System;
using static aula_03_exercicios.Materiais;
using static aula_03_exercicios.Materiais.Revistas;
using static aula_03_exercicios.Usuarios;

namespace aula_03_exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuarios oAllan = new Usuarios("Allan", "Imbé", 51989898989, "123.senha");
            Usuarios oAmanda = new Usuarios("Amanda", "Tramandaí", 51999999999, "321.senha");

            w("");
            w("Usuários");
            w($"Nome: {oAllan.nome} - Local: {oAllan.local} - Fone: {oAllan.telefone} - Senha: {oAllan.senha}");
            w($"Nome: {oAmanda.nome} - Local: {oAmanda.local} - Fone: {oAmanda.telefone} - Senha: {oAmanda.senha}");

            Materiais oMateriaisA = new Materiais(123, "Meio Ambiente", "Fim das Matas");
            Materiais oMateriaisB = new Materiais(456, "Meio Ambiente", "O Fim da Amazônia");
            Materiais oMateriaisC = new Materiais(789, "Meio Ambiente", "Artigos");

            Livros oLivrosA = new Livros("Urubu", "1º Edição", "ISBN - 987-65-432-1012-3", "João Silva");
            Revistas oRevistaA = new Revistas("Desmatamento", "ABC");
            Artigos oArtigoA = new Artigos("João Silva", "Artigo Muito Louco");

            w("");
            w("Consulta");
            w($"#{oMateriaisA.codigo} - Assunto: {oMateriaisA.assunto} - Título: {oMateriaisA.titulo} - Editora: {oLivrosA.editora} - Edicao: {oLivrosA.edicao} - {oLivrosA.ISBN} - Autor: {oLivrosA.autor}");
            w($"#{oMateriaisB.codigo} - Assunto: {oMateriaisB.assunto} - Título: {oMateriaisB.titulo} - Coleção: {oRevistaA.colecao} - Edicao: {oRevistaA.editora}");
            w($"#{oMateriaisC.codigo} - Assunto: {oMateriaisC.assunto} - Título: {oMateriaisC.titulo} - Autor: {oArtigoA.autor} - Título: {oArtigoA.tituloArtigo}");

            Reservas oReserva1 = new Reservas(new DateTime(2019,01,01),new DateTime(2019,01,03));
            Reservas oReserva2 = new Reservas(new DateTime(2019,01,05),new DateTime(2019,01,08));

            w("");
            w("Reservas");
            oReserva1.Reservar(oMateriaisA, oReserva1);
            oReserva2.Reservar(oMateriaisB, oReserva2);

            Emprestimo oEmprestimo1 = new Emprestimo(new DateTime(2019,02,01),new DateTime(2019,02,10),0);
            Emprestimo oEmprestimo2 = new Emprestimo(new DateTime(2019,02,03),new DateTime(2019,02,13),0);

            w("");
            w("Empréstimos");
            oEmprestimo1.Emprestar(oAllan, oMateriaisA, oEmprestimo1);
            oEmprestimo2.Emprestar(oAmanda, oMateriaisB, oEmprestimo2);

            Devolucao oDevolucao1 = new Devolucao(new DateTime(2019,02,10));
            Devolucao oDevolucao2 = new Devolucao(new DateTime(2019,02,15));

            w("");
            w("Devolução");
            oDevolucao1.Devolver(oAllan, oMateriaisA, oDevolucao1, oEmprestimo1);
            oDevolucao2.Devolver(oAmanda, oMateriaisB, oDevolucao2, oEmprestimo2);



            w("");
        }
        static void w(string msg)
        {
            Console.WriteLine(msg);
        }
        static void r()
        {
            Console.ReadLine();
        }
    }
}
