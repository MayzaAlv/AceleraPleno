using Livraria;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;


int opcao = 0;
List<Livros> biblioteca = new List<Livros>();
List<Usuario> usuarios = new List<Usuario>();
List<Emprestimo> emprestimos = new List<Emprestimo>();

do
{
    Console.Clear();
    Console.WriteLine("\nO QUE VOCE DESEJA?");

    Console.WriteLine("\n========CADASTROS========");
    Console.WriteLine("1 - CADASTRAR LIVRO");
    Console.WriteLine("2 - CADASTRAR USUARIO");

    Console.WriteLine("\n========TRANSAÇÕES=======");
    Console.WriteLine("3 - NOVO EMPRÉSTIMO");
    //não é necessario
    Console.WriteLine("4 - DEVOLVER EMPRÉSTIMO");

    Console.WriteLine("\n========CONSULTAS========");
    Console.WriteLine("5 - CONSULTAR LIVROS");
    Console.WriteLine("6 - CONSULTAR USUARIO");

    Console.WriteLine("\n======CONFIGURAÇÕES======");
    Console.WriteLine("7 - SAIR");
    Console.WriteLine("");

    opcao = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Cadastro de Livro\n");
            CadastrarLivro();

            Console.WriteLine("\nClique uma tecla para continuar...");
            Console.ReadKey();
            break;
        case 2:
            Console.WriteLine("Cadastro de Usuário\n");
            CadastrarUsuario();

            Console.WriteLine("\nClique uma tecla para continuar...");
            Console.ReadKey();
            break;
        case 3:
            Console.WriteLine("Novo Empréstimo\n");
            NovoEmprestimo();

            Console.WriteLine("\nClique uma tecla para continuar...");
            Console.ReadKey();
            break;
        case 4:
            Console.WriteLine("Devolver Empréstimo\n");
            break;
        case 5:
            Console.WriteLine("Consultar Livros\n");
            ConsultarLivros();

            Console.WriteLine("\nClique uma tecla para continuar...");
            Console.ReadKey();
            break;
        case 6:
            Console.WriteLine("Consultar Usuários\n");
            ConsultarUsuarios();

            Console.WriteLine("\nClique uma tecla para continuar...");
            Console.ReadKey();
            break;
        case 7:
            Console.Write("Até mais!\n");
            break;
        default:
            Console.Write("Opção inválida!\n");
            break;

    }

} while (opcao != 7);

void NovoEmprestimo()
{
    Console.Write("Login: ");
    string login = Console.ReadLine();

    Usuario buscado = usuarios.Where(x => x.Login.Equals(login)).FirstOrDefault();

    if (buscado != null)
    {
        Console.WriteLine("Usuario Encontrado...");

        Console.Write("Senha: ");
        string senha = Console.ReadLine();

        if (buscado.Senha == senha)
        {
            Console.WriteLine("Usuario Logado!\n");

            Console.Write("Qual livro você deseja?, digite o nome: ");
            string nomeLivro = Console.ReadLine();

            List<Livros> buscalivro = biblioteca.Where(x => x.Livro.ToLower().StartsWith(nomeLivro.ToLower())).ToList();

            if (buscalivro.Count == 0) Console.WriteLine("\nLivro não encontrado");
            else if (buscalivro.Count == 1)
            {
                Console.WriteLine($"\n{buscalivro[0].Livro} encontrado!");

                Emprestimo novoEmprestimo = new Emprestimo(buscalivro[0], buscado);
                emprestimos.Add(novoEmprestimo);
            }
            else
            {
                Console.WriteLine($"\n{buscalivro.Count} encontrados");

                buscalivro.ForEach(livro => Console.WriteLine($"Livro: {livro.Livro} | Código: {livro.Codigo}"));
            }
        }
        else Console.WriteLine("Senha Incorreta");
    }
    else Console.WriteLine("Usuario não Encontrado...");
}

void CadastrarUsuario()
{
    Console.Write("Nome do Usuario: ");
    string usuario = Console.ReadLine();
    Console.Write("Login: ");
    string login = Console.ReadLine();
    Console.Write("Senha: ");
    string senha = Console.ReadLine();

    Usuario novoUser = new Usuario(usuario, login, senha);

    usuarios.Add(novoUser);

    Console.WriteLine(novoUser.Id);
}

void ConsultarUsuarios()
{
    for (int i = 0; i < usuarios.Count; i++)
    {
        Console.WriteLine($"ID: {usuarios[i].Id} | Nome: {usuarios[i].Nome} | Login: {usuarios[i].Login}");
    }
}

void CadastrarLivro()
{
    Console.Write("Nome do Livro: ");
    string livro = Console.ReadLine();
    Console.Write("Codigo: ");
    double cod = double.Parse(Console.ReadLine());
    Console.Write("Valor: ");
    decimal valor = decimal.Parse(Console.ReadLine());
    Console.Write("Nº Paginas: ");
    int pg = int.Parse(Console.ReadLine());

    Livros novo = new Livros(livro, pg, cod, valor);

    biblioteca.Add(novo);
}

void ConsultarLivros()
{
    for (int i = 0; i < biblioteca.Count; i++)
    {
        Console.WriteLine($"Item: {i} | Livro: {biblioteca[i].Livro} | Código: {biblioteca[i].Codigo} | Valor: {biblioteca[i].Valor}");
    }
}