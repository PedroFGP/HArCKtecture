using HArCKtecture.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using VisualPlus.Toolkit.Dialogs;

namespace HArCKtecture.Forms
{
    public partial class FrmTutorial : VisualForm
    {
        #region Properties

        private Dictionary<Bitmap, string> Stages = new Dictionary<Bitmap, string>();
        private int currentStage = 0;

        #endregion

        #region Constructor

        public FrmTutorial()
        {
            InitializeComponent();

            PbxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            LoadTutorialStages();
        }

        #endregion

        #region Events

        private void BtnBack_Click(object sender, System.EventArgs e)
        {
            LoadStage(--currentStage);
        }

        private void BtnForward_Click(object sender, System.EventArgs e)
        {
            if (BtnForward.Text == "Fechar")
            {
                this.Close();

                return;
            }

            LoadStage(++currentStage);
        }

        #endregion

        #region Methods

        private void LoadTutorialStages()
        {
            #region Main Window Tutorial

            Stages.Add(Resources.Tutorial6, "O texto informa quantos desafios foram feitos de quantos disponíveis.");

            Stages.Add(Resources.Tutorial7, "O botão 'Resetar Desafios' apaga todas as informações relacionadas aos desafios carregados dando assim oportunidade de refazer o desafio em um tempo menor e de uma maneira diferente.");

            Stages.Add(Resources.Tutorial8, @"A janela de visualização de desafios mostra todos os desafios disponíveis agrupando os por cor e nível. É mostrado ainda a dificuldade de cada desafio junto de seu título. 

O botão 'Jogar' mais a direita é responsável por carregar o desafio, uma vez que o desafio foi feito seu texto muda para 'Jogar Novamente'.");

            Stages.Add(Resources.Tutorial9, "O botão '?' mostra esse tutorial novamente.");

            Stages.Add(Resources.Tutorial10, "O botão 'Sair' fecha o jogo HArCKtecture.");

            #endregion

            #region Challenge Window Tutorial

            Stages.Add(Resources.Tutorial1, @"A caixa de navegação pode ser usada para navegar pela memória do desafio. Nela são encontrados endereços pré definidos que irão servir de base para execução do desafio. 

Para visualizar qualquer endereço basta digitar um endereço válido (hexadecimal) na caixa e a janela de visualização de memória será ajustada para aquele endereço ou então selecionar um dos endereços pré definidos.");

            Stages.Add(Resources.Tutorial3, @"A janela de visualização de memória informa o endereço (hexadecimal) ao qual aquela sequência de bytes está além de uma representação em assembly x86 daqueles bytes (Opcodes, ou operation codes, também conhecidos como códigos de operação). 

Ao selecionar uma linha seus bytes e código de operação irão ser mostrados na janela de 'Assembly x86'.");

            Stages.Add(Resources.Tutorial4, @"A janela de 'Memória' é responsável por possibilitar a leitura e a escrita de valores em endereços de memória. 

Para ler um valor basta digitar um endereço válido (hexadecimal) no campo de entrada de texto abaixo do texto 'Endreço' e escolher como o dado deve ser interpretado na caixa de seleção abaixo do texto 'Tipo/Valor'. 

Para se escrever um valor basta ter digitado um endereço válido e digitar qualquer valor válido no campo de entrada de texto abaixo ao lado esquerdo do botão escrever e apertar o botão escrever.");

            Stages.Add(Resources.Tutorial5, @"A janela de 'Assembly x86' é responsável por possibilitar a injeção (modificação) de código assembly além de intepertrar bytes e assembly. No campo de entrada de texto 'Código' é possível escrever um código em assembly e ver sua correspondência em bytes no campo de entrada de texto 'Saída em bytes'.
                
A caixa de seleção 'Preencher com NOP's automaticamente' faz com que ao injetar um código assembly NOP's sejam adicionados automaticamente para substituir bytes que 'sobraram' evitando assim com que o programa execute uma instrução errada.

A caixa de seleção 'Interpretar endereços como relativos em JMP/CALL' faz com que o interpretador trate endereços em JUMP's e CALL's como valores relativos, permitindo assim uma interpretação mais correta.

Ao apertar o botão 'Injetar Assembly' o código escrito no campo 'Código' será interpretado e injetado na linha selecionada na janela de visualização de memória, o mesmo irá acontecer ao apertar o botão 'Injetar Bytes' porém dessa vez os bytes do campo 'Saída em bytes' serão injetados. 
                
Ao apertar o botão 'Preencher com NOP's' a linha selecionada será preenchida com NOP's (bytes 0x90) que representam ociosidade (No Operation) de acordo com o número de bytes.");

            Stages.Add(Resources.Tutorial2, @"O botão '?' mostra a tela de ajuda para o desafio atual.

O botão 'Voltar' fecha o desafio atual e retorna ao menu principal sem salvar nenhuma estatística.");

            #endregion

            LoadStage(currentStage);
        }

        private void LoadStage(int index)
        {
            if (index == Stages.Count - 1)
            {
                BtnForward.Text = "Fechar";
            }
            else if (index == 0)
            {
                BtnBack.Enabled = false;
            }
            else
            {
                BtnForward.Text = "Avançar";
                BtnBack.Enabled = true;
            }

            var element = Stages.ElementAt(index);

            PbxMain.Image = element.Key;
            RtbxDescription.Text = element.Value;
        }

        #endregion
    }
}
