//aluno Wilson Araujo

using System;

public class Pessoa_Fisica
{
    public string nome;
    public string endereco;
    public string cpf;
    public string rg;
    public float valor;
    public float valor_imposto;
    public float total;

    public void Pagar_Imposto(float valorCompra)
    {
        valor = valorCompra;
        valor_imposto = valor * 0.1f; // Imposto de 10% para pessoa física
        total = valor + valor_imposto;
    }
}

public class Pessoa_Juridica
{
    public string nome;
    public string endereco;
    public string cnpj;
    public string ie;
    public float valor;
    public float valor_imposto;
    public float total;

    public void Pagar_Imposto(float valorCompra)
    {
        valor = valorCompra;
        valor_imposto = valor * 0.05f; // Imposto de 5% para pessoa jurídica
        total = valor + valor_imposto;
    }
}

class Program
{
    static void Main(string[] args)
    {
        float val_pag;
        Console.WriteLine("Informe seu Nome");
        string var_nome = Console.ReadLine();
        Console.WriteLine("Informe seu Endereço");
        string var_endereco = Console.ReadLine();
        Console.WriteLine("Pessoa Física (f) ou Jurídica (j) ?");
        string var_tipo = Console.ReadLine();

        if (var_tipo == "f")
        {
            // --- Pessoa Física ----
            Pessoa_Fisica pf = new Pessoa_Fisica();
            pf.nome = var_nome;
            pf.endereco = var_endereco;
            Console.WriteLine("Informe seu CPF:");
            pf.cpf = Console.ReadLine();
            Console.WriteLine("Informe seu RG:");
            pf.rg = Console.ReadLine();
            Console.WriteLine("Informe o Valor da Compra:");
            val_pag = float.Parse(Console.ReadLine());
            pf.Pagar_Imposto(val_pag);
            Console.WriteLine("-------- Pessoa Física ---------");
            Console.WriteLine("Nome ..........: " + pf.nome);
            Console.WriteLine("Endereço ......: " + pf.endereco);
            Console.WriteLine("CPF ...........: " + pf.cpf);
            Console.WriteLine("RG ............: " + pf.rg);
            Console.WriteLine("Valor de Compra: " + pf.valor.ToString("C"));
            Console.WriteLine("Imposto .......: " + pf.valor_imposto.ToString("C"));
            Console.WriteLine("Total a Pagar : " + pf.total.ToString("C"));
        }
        else if (var_tipo == "j")
        {
            // Pessoa Jurídica
            Pessoa_Juridica pj = new Pessoa_Juridica();
            pj.nome = var_nome;
            pj.endereco = var_endereco;
            Console.WriteLine("Informe seu CNPJ:");
            pj.cnpj = Console.ReadLine();
            Console.WriteLine("Informe IE:");
            pj.ie = Console.ReadLine();
            Console.WriteLine("Informe o Valor de Compra:");
            val_pag = float.Parse(Console.ReadLine());
            pj.Pagar_Imposto(val_pag);
            Console.WriteLine("-------- Pessoa Jurídica ---------");
            Console.WriteLine("Nome ..........: " + pj.nome);
            Console.WriteLine("Endereço ......: " + pj.endereco);
            Console.WriteLine("CNPJ ..........: " + pj.cnpj);
            Console.WriteLine("IE ............: " + pj.ie);
            Console.WriteLine("Valor de Compra: " + pj.valor.ToString("C"));
            Console.WriteLine("Imposto .......: " + pj.valor_imposto.ToString("C"));
            Console.WriteLine("Total a Pagar : " + pj.total.ToString("C"));
        }
    }
}
