using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudoClass
{
public class Personagem
{
    public string Nome { get; set; }
    public int Posicao { get; set; }
    public List<string> ItensColetados { get; set; }

    public Personagem()
    {
        ItensColetados = new List<string>();
    }

    public void Atacar(double dano)
    {
        Console.WriteLine($"O dano do ataque é: {dano}");
    }

    public void Movimentar(int direcao)
    {
        string direcaoMovimento = direcao switch
        {
            1 => "frente",
            2 => "trás",
            3 => "direita",
            4 => "esquerda",
            _ => "direção inválida",
        };
        Console.WriteLine($"O personagem vai se mover para: {direcaoMovimento}");
    }
}
}