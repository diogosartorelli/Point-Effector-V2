# Point Effector 2D — Protótipo Espacial 

By Diogo Sartorelli - 1138670

Trabalho G1 da disciplina **Tecnologias Emergentes (Games)** — Prof. M.Sc. Fernando P. Pinheiro.


## Recurso demonstrado: Point Effector 2D

O **Point Effector 2D** é um componente da Unity que aplica uma força radial (de atração ou repulsão) a partir de um ponto central, afetando qualquer objeto com `Rigidbody2D` que entre na área do seu `Collider2D`.

Ele é configurado através de dois parâmetros principais:
- **Force Magnitude**: valores negativos atraem objetos para o centro; valores positivos os repelem.
- **Distance Scale**: controla como a força varia conforme a distância do centro.

## O protótipo

Para demonstrar o recurso, criei uma cena espacial com:

- **Nave (Player)**: controlada pelo jogador via WASD/setas, representando o objeto que sofre a influência dos campos de força.
- **Buraco Negro (zona de atração)**: um Point Effector 2D com força negativa, que atrai a nave e itens coletáveis (moedas) para perto de si, simulando um campo gravitacional.
- **Zona de Repulsão**: um segundo Point Effector 2D com força positiva, funcionando como um obstáculo que empurra a nave para longe ao ser tocado.
- **Moedas coletáveis**: objetos com `Rigidbody2D` que também são atraídos pelo buraco negro, demonstrando que o efeito age sobre qualquer corpo físico na cena, não apenas o jogador.

## Como rodar o protótipo

1. Clone este repositório.
2. Abra o projeto na Unity (versão utilizada: [preencher versão, ex: 2022.3 LTS]).
3. Abra a cena principal em `Assets/Scenes/MainScene`.
4. Aperte Play e use WASD ou as setas do teclado para mover a nave.
